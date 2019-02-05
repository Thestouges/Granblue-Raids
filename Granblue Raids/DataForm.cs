using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Granblue_Raids
{
    public partial class DataForm : Form
    {
        private readonly Main mainform;
        Bitmap raidbitmap;
        public DataForm(Main mainref)
        {
            InitializeComponent();
            raidbitmap = null;
            mainform = mainref;
            this.FormClosing += DataForm_FormClosing;
            try
            {
                raidImage.Load(imageURL.Text);
                if (raidImage.Image.Height > 150 || raidImage.Image.Width > 150)
                {
                    Size defaultsize = new Size(150, 150);
                    raidbitmap = new Bitmap(raidImage.Image, defaultsize);
                    raidImage.Image = (Image)(raidbitmap);
                }
            }
            catch
            {

            }
        }

        private void dataFormSubmitButton_Click(object sender, EventArgs e)
        {
            saveToDatabase();
        }

        private void saveToDatabase()
        {
            if (raidbitmap == null)
            {
                raidbitmap = new Bitmap(raidImage.BackgroundImage);
            }
            if (raidbitmap != null && engName.Text != "" && japName.Text != "")
            {
                ImageConverter converter = new ImageConverter();
                byte[] raidimagebyte = (byte[])converter.ConvertTo(raidbitmap, typeof(byte[]));

                RaidDataDataSetTableAdapters.RaidDataTableAdapter raidTableAdapter = new RaidDataDataSetTableAdapters.RaidDataTableAdapter();
                RaidDataDataSet raidDataSet = new RaidDataDataSet();
                raidTableAdapter.Insert(engName.Text, japName.Text, raidimagebyte);
                raidTableAdapter.Update(raidDataSet.RaidData);

                engName.Text = "";
                japName.Text = "";
            }
            else
            {

            }
        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.InitialDirectory = @"C:\";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                raidImage.BackgroundImage = new Bitmap(dialog.FileName);
                if(raidImage.BackgroundImage.Height > 150 || raidImage.BackgroundImage.Width > 150)
                {
                    Size defaultsize = new Size(150, 150);
                    raidbitmap = new Bitmap(raidImage.BackgroundImage, defaultsize);
                    raidImage.BackgroundImage = raidbitmap;
                }
            }
        }

        private void imageURL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                raidImage.Load(imageURL.Text);
                if (raidImage.Image.Height > 150 || raidImage.Image.Width > 150)
                {
                    Size defaultsize = new Size(150, 150);
                    raidbitmap = new Bitmap(raidImage.Image, defaultsize);
                    raidImage.Image = (Image)(raidbitmap);
                }
            }
            catch
            {

            }
        }

        private void dataFormDoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveToDatabase();
        }
    }
}
