namespace Granblue_Raids
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addRaidDatabaseButton = new System.Windows.Forms.Button();
            this.raidInfoListBox = new System.Windows.Forms.ListBox();
            this.raidDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raidDataDataSet = new Granblue_Raids.RaidDataDataSet();
            this.raidDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raidDataTableAdapter = new Granblue_Raids.RaidDataDataSetTableAdapters.RaidDataTableAdapter();
            this.addButton = new System.Windows.Forms.Button();
            this.testtextbox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.addedRaidsListBox = new System.Windows.Forms.ListBox();
            this.deleteRaidButton = new System.Windows.Forms.Button();
            this.tweetsListView = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TweetTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.raidDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raidDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raidDataDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addRaidDatabaseButton
            // 
            this.addRaidDatabaseButton.Location = new System.Drawing.Point(549, 399);
            this.addRaidDatabaseButton.Name = "addRaidDatabaseButton";
            this.addRaidDatabaseButton.Size = new System.Drawing.Size(133, 23);
            this.addRaidDatabaseButton.TabIndex = 0;
            this.addRaidDatabaseButton.Text = "Add Raid to Database";
            this.addRaidDatabaseButton.UseVisualStyleBackColor = true;
            this.addRaidDatabaseButton.Click += new System.EventHandler(this.addRaidDatabaseButton_Click);
            // 
            // raidInfoListBox
            // 
            this.raidInfoListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.raidDataBindingSource, "Id", true));
            this.raidInfoListBox.DataSource = this.raidDataBindingSource;
            this.raidInfoListBox.DisplayMember = "Name";
            this.raidInfoListBox.FormattingEnabled = true;
            this.raidInfoListBox.Location = new System.Drawing.Point(12, 12);
            this.raidInfoListBox.Name = "raidInfoListBox";
            this.raidInfoListBox.Size = new System.Drawing.Size(130, 355);
            this.raidInfoListBox.Sorted = true;
            this.raidInfoListBox.TabIndex = 1;
            this.raidInfoListBox.TabStop = false;
            this.raidInfoListBox.ValueMember = "Id";
            // 
            // raidDataBindingSource
            // 
            this.raidDataBindingSource.DataMember = "RaidData";
            this.raidDataBindingSource.DataSource = this.raidDataDataSet;
            // 
            // raidDataDataSet
            // 
            this.raidDataDataSet.DataSetName = "RaidDataDataSet";
            this.raidDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raidDataDataSetBindingSource
            // 
            this.raidDataDataSetBindingSource.DataSource = this.raidDataDataSet;
            this.raidDataDataSetBindingSource.Position = 0;
            // 
            // raidDataTableAdapter
            // 
            this.raidDataTableAdapter.ClearBeforeFill = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(78, 376);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(60, 46);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // testtextbox
            // 
            this.testtextbox.Location = new System.Drawing.Point(433, 13);
            this.testtextbox.Multiline = true;
            this.testtextbox.Name = "testtextbox";
            this.testtextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.testtextbox.Size = new System.Drawing.Size(249, 354);
            this.testtextbox.TabIndex = 4;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(148, 376);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(130, 46);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addedRaidsListBox
            // 
            this.addedRaidsListBox.FormattingEnabled = true;
            this.addedRaidsListBox.Location = new System.Drawing.Point(148, 12);
            this.addedRaidsListBox.Name = "addedRaidsListBox";
            this.addedRaidsListBox.Size = new System.Drawing.Size(130, 355);
            this.addedRaidsListBox.TabIndex = 6;
            // 
            // deleteRaidButton
            // 
            this.deleteRaidButton.Location = new System.Drawing.Point(12, 376);
            this.deleteRaidButton.Name = "deleteRaidButton";
            this.deleteRaidButton.Size = new System.Drawing.Size(60, 46);
            this.deleteRaidButton.TabIndex = 7;
            this.deleteRaidButton.Text = "Del";
            this.deleteRaidButton.UseVisualStyleBackColor = true;
            this.deleteRaidButton.Click += new System.EventHandler(this.deleteRaidButton_Click);
            // 
            // tweetsListView
            // 
            this.tweetsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.ID,
            this.TweetTime});
            this.tweetsListView.Location = new System.Drawing.Point(285, 13);
            this.tweetsListView.Name = "tweetsListView";
            this.tweetsListView.Size = new System.Drawing.Size(142, 354);
            this.tweetsListView.TabIndex = 8;
            this.tweetsListView.UseCompatibleStateImageBehavior = false;
            this.tweetsListView.View = System.Windows.Forms.View.Tile;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 434);
            this.Controls.Add(this.tweetsListView);
            this.Controls.Add(this.deleteRaidButton);
            this.Controls.Add(this.addedRaidsListBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.testtextbox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.raidInfoListBox);
            this.Controls.Add(this.addRaidDatabaseButton);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.raidDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raidDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raidDataDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRaidDatabaseButton;
        private System.Windows.Forms.ListBox raidInfoListBox;
        private System.Windows.Forms.BindingSource raidDataDataSetBindingSource;
        private RaidDataDataSet raidDataDataSet;
        private System.Windows.Forms.BindingSource raidDataBindingSource;
        private RaidDataDataSetTableAdapters.RaidDataTableAdapter raidDataTableAdapter;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox testtextbox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox addedRaidsListBox;
        private System.Windows.Forms.Button deleteRaidButton;
        private System.Windows.Forms.ListView tweetsListView;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader TweetTime;
    }
}

