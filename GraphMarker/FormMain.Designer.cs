namespace GraphMarker
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			this.pbReadImage = new System.Windows.Forms.Panel();
			this.lbImageList = new System.Windows.Forms.ListBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.tbFolderName = new System.Windows.Forms.TextBox();
			this.btnFolder = new System.Windows.Forms.Button();
			this.btnInit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// pbReadImage
			// 
			this.pbReadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbReadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbReadImage.Location = new System.Drawing.Point(237, 48);
			this.pbReadImage.Name = "pbReadImage";
			this.pbReadImage.Size = new System.Drawing.Size(416, 416);
			this.pbReadImage.TabIndex = 0;
			this.pbReadImage.Click += new System.EventHandler(this.pbReadImage_Click);
			// 
			// lbImageList
			// 
			this.lbImageList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lbImageList.FormattingEnabled = true;
			this.lbImageList.ItemHeight = 12;
			this.lbImageList.Location = new System.Drawing.Point(12, 48);
			this.lbImageList.Name = "lbImageList";
			this.lbImageList.Size = new System.Drawing.Size(219, 412);
			this.lbImageList.TabIndex = 1;
			this.lbImageList.SelectedIndexChanged += new System.EventHandler(this.lbImageList_SelectedIndexChanged);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(578, 470);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save!";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tbFolderName
			// 
			this.tbFolderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbFolderName.Enabled = false;
			this.tbFolderName.Location = new System.Drawing.Point(12, 12);
			this.tbFolderName.Name = "tbFolderName";
			this.tbFolderName.Size = new System.Drawing.Size(559, 21);
			this.tbFolderName.TabIndex = 4;
			// 
			// btnFolder
			// 
			this.btnFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFolder.Location = new System.Drawing.Point(577, 12);
			this.btnFolder.Name = "btnFolder";
			this.btnFolder.Size = new System.Drawing.Size(75, 23);
			this.btnFolder.TabIndex = 5;
			this.btnFolder.Text = "Folder..";
			this.btnFolder.UseVisualStyleBackColor = true;
			this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
			// 
			// btnInit
			// 
			this.btnInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInit.Location = new System.Drawing.Point(496, 470);
			this.btnInit.Name = "btnInit";
			this.btnInit.Size = new System.Drawing.Size(75, 23);
			this.btnInit.TabIndex = 6;
			this.btnInit.Text = "Init!";
			this.btnInit.UseVisualStyleBackColor = true;
			this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 505);
			this.Controls.Add(this.btnInit);
			this.Controls.Add(this.btnFolder);
			this.Controls.Add(this.tbFolderName);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lbImageList);
			this.Controls.Add(this.pbReadImage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pbReadImage;
        private System.Windows.Forms.ListBox lbImageList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbFolderName;
        private System.Windows.Forms.Button btnFolder;
		private System.Windows.Forms.Button btnInit;
	}
}

