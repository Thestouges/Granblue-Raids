namespace Granblue_Raids
{
    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.dataFormSubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.engName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.japName = new System.Windows.Forms.TextBox();
            this.uploadImageButton = new System.Windows.Forms.Button();
            this.raidImage = new System.Windows.Forms.PictureBox();
            this.imageURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataFormDoneButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.raidImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataFormSubmitButton
            // 
            this.dataFormSubmitButton.Location = new System.Drawing.Point(168, 215);
            this.dataFormSubmitButton.Name = "dataFormSubmitButton";
            this.dataFormSubmitButton.Size = new System.Drawing.Size(104, 23);
            this.dataFormSubmitButton.TabIndex = 0;
            this.dataFormSubmitButton.Text = "Submit";
            this.dataFormSubmitButton.UseVisualStyleBackColor = true;
            this.dataFormSubmitButton.Click += new System.EventHandler(this.dataFormSubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Raid Name";
            // 
            // engName
            // 
            this.engName.Location = new System.Drawing.Point(129, 6);
            this.engName.Name = "engName";
            this.engName.Size = new System.Drawing.Size(143, 20);
            this.engName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Raid Japanese Name";
            // 
            // japName
            // 
            this.japName.Location = new System.Drawing.Point(129, 32);
            this.japName.Name = "japName";
            this.japName.Size = new System.Drawing.Size(143, 20);
            this.japName.TabIndex = 4;
            // 
            // uploadImageButton
            // 
            this.uploadImageButton.Location = new System.Drawing.Point(15, 87);
            this.uploadImageButton.Name = "uploadImageButton";
            this.uploadImageButton.Size = new System.Drawing.Size(94, 23);
            this.uploadImageButton.TabIndex = 6;
            this.uploadImageButton.Text = "Upload Image";
            this.uploadImageButton.UseVisualStyleBackColor = true;
            this.uploadImageButton.Click += new System.EventHandler(this.uploadImageButton_Click);
            // 
            // raidImage
            // 
            this.raidImage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.raidImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("raidImage.BackgroundImage")));
            this.raidImage.Location = new System.Drawing.Point(12, 118);
            this.raidImage.Name = "raidImage";
            this.raidImage.Size = new System.Drawing.Size(150, 150);
            this.raidImage.TabIndex = 7;
            this.raidImage.TabStop = false;
            // 
            // imageURL
            // 
            this.imageURL.Location = new System.Drawing.Point(129, 58);
            this.imageURL.Name = "imageURL";
            this.imageURL.Size = new System.Drawing.Size(143, 20);
            this.imageURL.TabIndex = 8;
            this.imageURL.TextChanged += new System.EventHandler(this.imageURL_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Image URL";
            // 
            // dataFormDoneButton
            // 
            this.dataFormDoneButton.Location = new System.Drawing.Point(168, 244);
            this.dataFormDoneButton.Name = "dataFormDoneButton";
            this.dataFormDoneButton.Size = new System.Drawing.Size(104, 23);
            this.dataFormDoneButton.TabIndex = 10;
            this.dataFormDoneButton.Text = "Done";
            this.dataFormDoneButton.UseVisualStyleBackColor = true;
            this.dataFormDoneButton.Click += new System.EventHandler(this.dataFormDoneButton_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.dataFormDoneButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imageURL);
            this.Controls.Add(this.raidImage);
            this.Controls.Add(this.uploadImageButton);
            this.Controls.Add(this.japName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.engName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataFormSubmitButton);
            this.Name = "DataForm";
            this.Text = "DataForm";
            ((System.ComponentModel.ISupportInitialize)(this.raidImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dataFormSubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox engName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox japName;
        private System.Windows.Forms.Button uploadImageButton;
        private System.Windows.Forms.PictureBox raidImage;
        private System.Windows.Forms.TextBox imageURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dataFormDoneButton;
    }
}