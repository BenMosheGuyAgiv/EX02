namespace A18_Ex01_Guy_203507926_Ben_302823927
{
    public partial class FilteredPhotosDisplayForm
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxNumOfLikes = new System.Windows.Forms.TextBox();
            this.labelLikes = new System.Windows.Forms.Label();
            this.listBoxFriendsWhoLike = new System.Windows.Forms.ListBox();
            this.list = new System.Windows.Forms.Label();
            this.ribbonMenuButton1 = new RibbonStyle.RibbonMenuButton();
            this.buttonPostStatus = new RibbonStyle.RibbonMenuButton();
            this.pictureBoxCurrentPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 9;
            // 
            // textBoxNumOfLikes
            // 
            this.textBoxNumOfLikes.Location = new System.Drawing.Point(56, 101);
            this.textBoxNumOfLikes.Multiline = true;
            this.textBoxNumOfLikes.Name = "textBoxNumOfLikes";
            this.textBoxNumOfLikes.ReadOnly = true;
            this.textBoxNumOfLikes.Size = new System.Drawing.Size(42, 42);
            this.textBoxNumOfLikes.TabIndex = 7;
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.Location = new System.Drawing.Point(53, 66);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(45, 17);
            this.labelLikes.TabIndex = 8;
            this.labelLikes.Text = "Likes:";
            // 
            // listBoxFriendsWhoLike
            // 
            this.listBoxFriendsWhoLike.FormattingEnabled = true;
            this.listBoxFriendsWhoLike.ItemHeight = 16;
            this.listBoxFriendsWhoLike.Location = new System.Drawing.Point(1114, 121);
            this.listBoxFriendsWhoLike.Name = "listBoxFriendsWhoLike";
            this.listBoxFriendsWhoLike.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxFriendsWhoLike.Size = new System.Drawing.Size(177, 212);
            this.listBoxFriendsWhoLike.TabIndex = 9;
            // 
            // list
            // 
            this.list.AutoSize = true;
            this.list.Location = new System.Drawing.Point(1114, 65);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(187, 17);
            this.list.TabIndex = 10;
            this.list.Text = "Friends who liked this photo:";
            // 
            // ribbonMenuButton1
            // 
            this.ribbonMenuButton1.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.ribbonMenuButton1.BackColor = System.Drawing.Color.Transparent;
            this.ribbonMenuButton1.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.ribbonMenuButton1.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.ribbonMenuButton1.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.ribbonMenuButton1.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.ribbonMenuButton1.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ribbonMenuButton1.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ribbonMenuButton1.FadingSpeed = 0;
            this.ribbonMenuButton1.FlatAppearance.BorderSize = 0;
            this.ribbonMenuButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ribbonMenuButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonMenuButton1.ForeColor = System.Drawing.Color.DarkBlue;
            this.ribbonMenuButton1.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.ribbonMenuButton1.Image = global::A18_Ex01_Guy_203507926_Ben_302823927.Properties.Resources.previousIcon;
            this.ribbonMenuButton1.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Top;
            this.ribbonMenuButton1.ImageOffset = 5;
            this.ribbonMenuButton1.IsPressed = false;
            this.ribbonMenuButton1.KeepPress = false;
            this.ribbonMenuButton1.Location = new System.Drawing.Point(11, 376);
            this.ribbonMenuButton1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonMenuButton1.MaxImageSize = new System.Drawing.Point(38, 0);
            this.ribbonMenuButton1.MenuPos = new System.Drawing.Point(0, 0);
            this.ribbonMenuButton1.Name = "ribbonMenuButton1";
            this.ribbonMenuButton1.Radius = 8;
            this.ribbonMenuButton1.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.ribbonMenuButton1.Size = new System.Drawing.Size(211, 82);
            this.ribbonMenuButton1.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.ribbonMenuButton1.SplitDistance = 0;
            this.ribbonMenuButton1.TabIndex = 73;
            this.ribbonMenuButton1.TabStop = false;
            this.ribbonMenuButton1.Text = "Previous";
            this.ribbonMenuButton1.Title = "";
            this.ribbonMenuButton1.UseVisualStyleBackColor = true;
            this.ribbonMenuButton1.Click += new System.EventHandler(this.buttonPrevPic_Click);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.buttonPostStatus.BackColor = System.Drawing.Color.Transparent;
            this.buttonPostStatus.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.buttonPostStatus.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.buttonPostStatus.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.buttonPostStatus.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.buttonPostStatus.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPostStatus.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonPostStatus.FadingSpeed = 0;
            this.buttonPostStatus.FlatAppearance.BorderSize = 0;
            this.buttonPostStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPostStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostStatus.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonPostStatus.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.buttonPostStatus.Image = global::A18_Ex01_Guy_203507926_Ben_302823927.Properties.Resources.nextIcon;
            this.buttonPostStatus.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Top;
            this.buttonPostStatus.ImageOffset = 5;
            this.buttonPostStatus.IsPressed = false;
            this.buttonPostStatus.KeepPress = false;
            this.buttonPostStatus.Location = new System.Drawing.Point(1117, 376);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPostStatus.MaxImageSize = new System.Drawing.Point(38, 0);
            this.buttonPostStatus.MenuPos = new System.Drawing.Point(0, 0);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Radius = 8;
            this.buttonPostStatus.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.buttonPostStatus.Size = new System.Drawing.Size(211, 82);
            this.buttonPostStatus.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.buttonPostStatus.SplitDistance = 0;
            this.buttonPostStatus.TabIndex = 72;
            this.buttonPostStatus.TabStop = false;
            this.buttonPostStatus.Text = "Next";
            this.buttonPostStatus.Title = "";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonNextPic_Click);
            // 
            // pictureBoxCurrentPhoto
            // 
            this.pictureBoxCurrentPhoto.Location = new System.Drawing.Point(230, 66);
            this.pictureBoxCurrentPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCurrentPhoto.Name = "pictureBoxCurrentPhoto";
            this.pictureBoxCurrentPhoto.Size = new System.Drawing.Size(864, 635);
            this.pictureBoxCurrentPhoto.TabIndex = 6;
            this.pictureBoxCurrentPhoto.TabStop = false;
            // 
            // FilteredPhotosDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1376, 786);
            this.Controls.Add(this.ribbonMenuButton1);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.list);
            this.Controls.Add(this.listBoxFriendsWhoLike);
            this.Controls.Add(this.labelLikes);
            this.Controls.Add(this.textBoxNumOfLikes);
            this.Controls.Add(this.pictureBoxCurrentPhoto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FilteredPhotosDisplayForm";
            this.Text = "ShowFilteredPhotoForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxCurrentPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox textBoxNumOfLikes;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.ListBox listBoxFriendsWhoLike;
        private System.Windows.Forms.Label list;
        public RibbonStyle.RibbonMenuButton buttonPostStatus;
        public RibbonStyle.RibbonMenuButton ribbonMenuButton1;
    }
}