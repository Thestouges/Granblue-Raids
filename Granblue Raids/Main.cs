using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using Tweetinvi;
using Tweetinvi.Parameters;
using Tweetinvi.Models;
using Granblue_Raids.Properties;

namespace Granblue_Raids
{
    public partial class Main : Form
    {
        class raidItem
        {
            public int id { get; set; }
            public string name { get; set; }
        };

        Dictionary<int, RaidData> raidInfoList;
        HashSet<int> raidUserList;
        string consumer_Key = "4ESs3qvZ7agufQ2msFvUFuIqG";
        string consumer_secret = "6nWLgImII8juULf21tTIYndBb9R1PjRdvRk9smixzwJPM2PMDX";
        string access_token = "781203896-MZ4JURARFMy9Fui49Fr4GhTdyHWG7yyym43PxKj9";
        string access_token_secret = "JsNk14d2ZAKrTCwTc6sUU1jDMWhW18QDsIDwbsQA3DHTU";
        string API_URL = "chrome-extension://fgpokpknehglcioijejfeebigdnbnokj/content/api.html";
        DateTime savedTime;
        long tweetID;
        Dictionary<string, RaidData> tweetraidID;
        Queue<string> tweetraidIDqueue;
        HttpClient client;
        int queueLimit = 10;

        public Main()
        {
            InitializeComponent();
            raidInfoListBox.DisplayMember = "name";
            raidInfoListBox.ValueMember = "id";
            addedRaidsListBox.DisplayMember = "name";
            addedRaidsListBox.ValueMember = "id";
            raidInfoList = new Dictionary<int, RaidData>();
            raidUserList = new HashSet<int>();
            raidUserList = (HashSet<int>)Settings.Default["UserRaid"];
            tweetraidID = new Dictionary<string, RaidData>();
            tweetraidIDqueue = new Queue<string>();
            //Auth.SetUserCredentials(consumer_Key, consumer_secret, access_token, access_token_secret);
            Auth.SetApplicationOnlyCredentials(consumer_Key, consumer_secret, true);
            client = new HttpClient();
            savedTime = DateTime.Now;
            tweetID = -1;

            refreshRaidInfoData();
            refreshRaidUserData();

            this.tweetsListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.tweetsListView.ItemActivate += new System.EventHandler(tweetsListView_DoubleClick);
            this.FormClosing += Main_FormClosing;
            this.Shown += Main_Shown;
        }

        private void addRaidDatabaseButton_Click(object sender, EventArgs e)
        {
            var dataform = new DataForm(this);
            dataform.ShowDialog();
            refreshRaidInfoData();
        }

        public void refreshRaidInfoData()
        {
            raidInfoList.Clear();

            var raidtable = raidDataTableAdapter.GetData();
            List<raidItem> raidItemList = new List<raidItem>();
            foreach (DataRow row in raidtable.Rows)
            {
                RaidData temp = new RaidData((int)row[0], (string)row[1], (string)row[2], (byte[])row[3]);
                raidInfoList.Add((int)row[0], temp);

                raidItemList.Add(new raidItem { id = (int)row[0], name = (string)row[1] });
            }

            this.raidInfoListBox.DataSource = raidItemList;
        }

        public void refreshRaidUserData()
        {
            List<raidItem> raidItemList = new List<raidItem>();
            foreach (int entry in raidUserList)
            {
                try
                {
                    raidItemList.Add(new raidItem { id = raidInfoList[entry].ID, name = raidInfoList[entry].Name });
                }
                catch
                {

                }
            }

            this.addedRaidsListBox.DataSource = raidItemList;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                raidItem raidI = (raidItem)raidInfoListBox.SelectedItem;

                raidUserList.Add(raidI.id);
                refreshRaidUserData();
            }
            catch
            {

            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                raidItem raidI = (raidItem)addedRaidsListBox.SelectedItem;
                raidUserList.Remove(raidI.id);
                refreshRaidUserData();
            }
            catch
            {

            }
        }

        private void deleteRaidButton_Click(object sender, EventArgs e)
        {
            try
            {
                raidItem raidI = (raidItem)raidInfoListBox.SelectedItem;
                RaidDataDataSetTableAdapters.RaidDataTableAdapter raidTableAdapter = new RaidDataDataSetTableAdapters.RaidDataTableAdapter();
                RaidDataDataSet raidDataSet = new RaidDataDataSet();
                raidTableAdapter.Delete(raidI.id);
                raidTableAdapter.Update(raidDataSet.RaidData);
                refreshRaidInfoData();

                raidUserList.Remove(raidI.id);
                refreshRaidUserData();
            }
            catch
            {

            }
        }

        private List<ITweet> SearchRaids(int index)
        {
            if (tweetID != -1)
            {
                var searchParameter = new SearchTweetsParameters(raidInfoList[index].Jname)
                {
                    MaximumNumberOfResults = 5,
                    SearchType = SearchResultType.Recent
                };
                var tweets = Search.SearchTweets(searchParameter);
                return (List<ITweet>)tweets;
            }
            else
            {
                var searchParameter = new SearchTweetsParameters(raidInfoList[index].Jname)
                {
                    MaximumNumberOfResults = 5,
                    SearchType = SearchResultType.Recent,
                    SinceId = tweetID
                };
                var tweets = Search.SearchTweets(searchParameter);
                return (List<ITweet>)tweets;
            }
        }

        private async Task refreshraids()
        {
            int counter = 1;
            while (true)
            {
                if (raidUserList.Count > 0)
                {
                    if (counter > raidUserList.Count)
                        counter = 1;
                    if ((DateTime.Now - savedTime).TotalSeconds > 2)
                    {
                        List<ITweet> tweets = await Task.Run(() => SearchRaids(counter));
                        foreach (var tweet in tweets)
                        {
                            int raidID = tweet.Text.LastIndexOf(" :参戦ID");
                            if (raidID != -1
                                && (savedTime - tweet.CreatedAt).TotalSeconds <= 30 + (2 * raidUserList.Count))
                            {
                                RaidData temp = new RaidData(raidInfoList[counter].ID, raidInfoList[counter].Name, raidInfoList[counter].Jname, raidInfoList[counter].Image);
                                addToTweetRaidQueue(tweet.Text.Substring(raidID - 8, 8), temp);
                                checkListViewLimit();
                                tweetID = tweet.Id;
                            }
                        }

                        savedTime = DateTime.Now;
                        counter++;
                    }
                }
            }
        }

        private void addToTweetRaidQueue(string raidID, RaidData raiditem)
        {
            if (!tweetraidID.ContainsKey(raidID))
            {
                if (tweetraidIDqueue.Count > queueLimit)
                {
                    tweetraidID.Remove(tweetraidIDqueue.Dequeue());
                }

                tweetraidIDqueue.Enqueue(raidID);
                tweetraidID.Add(raidID, raiditem);
                addToListView(raidID, raiditem.Name);
            }
        }

        private void addToListView(string raidID, string name)
        {
            string[] row = { raidID, name };
            var listViewItem = new ListViewItem(row);
            tweetsListView.Items.Insert(tweetsListView.Items.Count, listViewItem);
        }

        private void checkListViewLimit()
        {
            while (tweetsListView.Items.Count > queueLimit)
            {
                tweetsListView.Items.RemoveAt(tweetsListView.Items.Count);
            }
        }

        private void Main_Shown(Object sender, EventArgs e)
        {
            new Thread(() => refreshraids()).Start();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default["UserRaid"] = raidUserList;
            Settings.Default.Save();
            Environment.Exit(Environment.ExitCode);
        }

        private void tweetsListView_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
