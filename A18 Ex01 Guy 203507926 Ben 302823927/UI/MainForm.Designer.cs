namespace A18_Ex01_Guy_203507926_Ben_302823927
{
    public partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxFriendsList = new System.Windows.Forms.ListBox();
            this.listBoxEventsList = new System.Windows.Forms.ListBox();
            this.richTextBoxPostStatus = new System.Windows.Forms.RichTextBox();
            this.richTextBoxWeatheStats = new System.Windows.Forms.RichTextBox();
            this.richTextBoxEventDescription = new System.Windows.Forms.RichTextBox();
            this.panelEventDetails = new System.Windows.Forms.Panel();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.labelEventDetails = new System.Windows.Forms.Label();
            this.pictureBoxWeatherIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelFriendsList = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPicFilter = new RibbonStyle.RibbonMenuButton();
            this.buttonPostStatus = new RibbonStyle.RibbonMenuButton();
            this.labelUpcomingEvents = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new RibbonStyle.RibbonMenuButton();
            this.panelEventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.ItemHeight = 16;
            this.listBoxFriendsList.Location = new System.Drawing.Point(3, 25);
            this.listBoxFriendsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(133, 276);
            this.listBoxFriendsList.TabIndex = 0;
            // 
            // listBoxEventsList
            // 
            this.listBoxEventsList.FormattingEnabled = true;
            this.listBoxEventsList.ItemHeight = 16;
            this.listBoxEventsList.Location = new System.Drawing.Point(0, 411);
            this.listBoxEventsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEventsList.Name = "listBoxEventsList";
            this.listBoxEventsList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxEventsList.Size = new System.Drawing.Size(864, 132);
            this.listBoxEventsList.TabIndex = 1;
            this.listBoxEventsList.SelectedIndexChanged += new System.EventHandler(this.listBoxEventsList_SelectedIndexChanged);
            // 
            // richTextBoxPostStatus
            // 
            this.richTextBoxPostStatus.Location = new System.Drawing.Point(105, 14);
            this.richTextBoxPostStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxPostStatus.Name = "richTextBoxPostStatus";
            this.richTextBoxPostStatus.Size = new System.Drawing.Size(433, 101);
            this.richTextBoxPostStatus.TabIndex = 4;
            this.richTextBoxPostStatus.Text = "";
            // 
            // richTextBoxWeatheStats
            // 
            this.richTextBoxWeatheStats.Enabled = false;
            this.richTextBoxWeatheStats.Location = new System.Drawing.Point(103, 46);
            this.richTextBoxWeatheStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxWeatheStats.Name = "richTextBoxWeatheStats";
            this.richTextBoxWeatheStats.ReadOnly = true;
            this.richTextBoxWeatheStats.Size = new System.Drawing.Size(357, 80);
            this.richTextBoxWeatheStats.TabIndex = 11;
            this.richTextBoxWeatheStats.Text = "";
            // 
            // richTextBoxEventDescription
            // 
            this.richTextBoxEventDescription.Location = new System.Drawing.Point(4, 300);
            this.richTextBoxEventDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxEventDescription.Name = "richTextBoxEventDescription";
            this.richTextBoxEventDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBoxEventDescription.Size = new System.Drawing.Size(457, 141);
            this.richTextBoxEventDescription.TabIndex = 13;
            this.richTextBoxEventDescription.Text = "";
            // 
            // panelEventDetails
            // 
            this.panelEventDetails.BackColor = System.Drawing.Color.Linen;
            this.panelEventDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEventDetails.Controls.Add(this.pictureBoxEvent);
            this.panelEventDetails.Controls.Add(this.labelEventDetails);
            this.panelEventDetails.Controls.Add(this.richTextBoxEventDescription);
            this.panelEventDetails.Controls.Add(this.richTextBoxWeatheStats);
            this.panelEventDetails.Controls.Add(this.pictureBoxWeatherIcon);
            this.panelEventDetails.Location = new System.Drawing.Point(895, 105);
            this.panelEventDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEventDetails.Name = "panelEventDetails";
            this.panelEventDetails.Size = new System.Drawing.Size(481, 454);
            this.panelEventDetails.TabIndex = 69;
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEvent.Location = new System.Drawing.Point(3, 139);
            this.pictureBoxEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(457, 143);
            this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEvent.TabIndex = 15;
            this.pictureBoxEvent.TabStop = false;
            // 
            // labelEventDetails
            // 
            this.labelEventDetails.AutoSize = true;
            this.labelEventDetails.BackColor = System.Drawing.Color.Khaki;
            this.labelEventDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelEventDetails.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelEventDetails.Location = new System.Drawing.Point(195, 10);
            this.labelEventDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEventDetails.Name = "labelEventDetails";
            this.labelEventDetails.Size = new System.Drawing.Size(100, 20);
            this.labelEventDetails.TabIndex = 14;
            this.labelEventDetails.Text = "Event Details";
            // 
            // pictureBoxWeatherIcon
            // 
            this.pictureBoxWeatherIcon.Location = new System.Drawing.Point(3, 57);
            this.pictureBoxWeatherIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxWeatherIcon.Name = "pictureBoxWeatherIcon";
            this.pictureBoxWeatherIcon.Size = new System.Drawing.Size(95, 53);
            this.pictureBoxWeatherIcon.TabIndex = 10;
            this.pictureBoxWeatherIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelUpcomingEvents);
            this.panel1.Controls.Add(this.pictureBoxProfile);
            this.panel1.Controls.Add(this.listBoxEventsList);
            this.panel1.Controls.Add(this.pictureBoxCover);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 542);
            this.panel1.TabIndex = 70;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.listBoxFriendsList);
            this.panel3.Controls.Add(this.labelFriendsList);
            this.panel3.Location = new System.Drawing.Point(7, 106);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 308);
            this.panel3.TabIndex = 74;
            // 
            // labelFriendsList
            // 
            this.labelFriendsList.AutoSize = true;
            this.labelFriendsList.BackColor = System.Drawing.Color.Gold;
            this.labelFriendsList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelFriendsList.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelFriendsList.Location = new System.Drawing.Point(4, 4);
            this.labelFriendsList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriendsList.Name = "labelFriendsList";
            this.labelFriendsList.Size = new System.Drawing.Size(89, 20);
            this.labelFriendsList.TabIndex = 16;
            this.labelFriendsList.Text = "Friends List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonPicFilter);
            this.panel2.Controls.Add(this.buttonPostStatus);
            this.panel2.Controls.Add(this.richTextBoxPostStatus);
            this.panel2.Location = new System.Drawing.Point(156, 134);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 238);
            this.panel2.TabIndex = 73;
            // 
            // buttonPicFilter
            // 
            this.buttonPicFilter.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.buttonPicFilter.BackColor = System.Drawing.Color.Transparent;
            this.buttonPicFilter.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.buttonPicFilter.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.buttonPicFilter.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.buttonPicFilter.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.buttonPicFilter.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPicFilter.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonPicFilter.FadingSpeed = 0;
            this.buttonPicFilter.FlatAppearance.BorderSize = 0;
            this.buttonPicFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPicFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPicFilter.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonPicFilter.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.buttonPicFilter.Image = global::A18_Ex01_Guy_203507926_Ben_302823927.Properties.Resources.if_Presentation_27867;
            this.buttonPicFilter.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Top;
            this.buttonPicFilter.ImageOffset = 5;
            this.buttonPicFilter.IsPressed = false;
            this.buttonPicFilter.KeepPress = false;
            this.buttonPicFilter.Location = new System.Drawing.Point(324, 143);
            this.buttonPicFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPicFilter.MaxImageSize = new System.Drawing.Point(38, 0);
            this.buttonPicFilter.MenuPos = new System.Drawing.Point(0, 0);
            this.buttonPicFilter.Name = "buttonPicFilter";
            this.buttonPicFilter.Radius = 8;
            this.buttonPicFilter.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.buttonPicFilter.Size = new System.Drawing.Size(216, 82);
            this.buttonPicFilter.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.buttonPicFilter.SplitDistance = 0;
            this.buttonPicFilter.TabIndex = 72;
            this.buttonPicFilter.TabStop = false;
            this.buttonPicFilter.Text = "Get Filtered Pics";
            this.buttonPicFilter.Title = "";
            this.buttonPicFilter.UseVisualStyleBackColor = true;
            this.buttonPicFilter.Click += new System.EventHandler(this.buttonPicFilter_Click);
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
            this.buttonPostStatus.Image = global::A18_Ex01_Guy_203507926_Ben_302823927.Properties.Resources.if_Text_Document_27884;
            this.buttonPostStatus.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Top;
            this.buttonPostStatus.ImageOffset = 5;
            this.buttonPostStatus.IsPressed = false;
            this.buttonPostStatus.KeepPress = false;
            this.buttonPostStatus.Location = new System.Drawing.Point(105, 143);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPostStatus.MaxImageSize = new System.Drawing.Point(38, 0);
            this.buttonPostStatus.MenuPos = new System.Drawing.Point(0, 0);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Radius = 8;
            this.buttonPostStatus.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.buttonPostStatus.Size = new System.Drawing.Size(211, 82);
            this.buttonPostStatus.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.buttonPostStatus.SplitDistance = 0;
            this.buttonPostStatus.TabIndex = 71;
            this.buttonPostStatus.TabStop = false;
            this.buttonPostStatus.Text = "Post Status";
            this.buttonPostStatus.Title = "";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // labelUpcomingEvents
            // 
            this.labelUpcomingEvents.AutoSize = true;
            this.labelUpcomingEvents.BackColor = System.Drawing.Color.SpringGreen;
            this.labelUpcomingEvents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelUpcomingEvents.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelUpcomingEvents.Location = new System.Drawing.Point(361, 388);
            this.labelUpcomingEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUpcomingEvents.Name = "labelUpcomingEvents";
            this.labelUpcomingEvents.Size = new System.Drawing.Size(182, 20);
            this.labelUpcomingEvents.TabIndex = 17;
            this.labelUpcomingEvents.Text = "Upcoming Evens(5 days)";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(7, 12);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(135, 87);
            this.pictureBoxProfile.TabIndex = 7;
            this.pictureBoxProfile.TabStop = false;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(156, 12);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(709, 118);
            this.pictureBoxCover.TabIndex = 2;
            this.pictureBoxCover.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.buttonLogout.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogout.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.buttonLogout.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.buttonLogout.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.buttonLogout.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.buttonLogout.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonLogout.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonLogout.FadingSpeed = 0;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonLogout.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Top;
            this.buttonLogout.ImageOffset = 5;
            this.buttonLogout.IsPressed = false;
            this.buttonLogout.KeepPress = false;
            this.buttonLogout.Location = new System.Drawing.Point(895, 15);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogout.MaxImageSize = new System.Drawing.Point(38, 0);
            this.buttonLogout.MenuPos = new System.Drawing.Point(0, 0);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Radius = 8;
            this.buttonLogout.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.buttonLogout.Size = new System.Drawing.Size(481, 82);
            this.buttonLogout.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.buttonLogout.SplitDistance = 0;
            this.buttonLogout.TabIndex = 68;
            this.buttonLogout.TabStop = false;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.Title = "";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1387, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelEventDetails);
            this.Controls.Add(this.buttonLogout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelEventDetails.ResumeLayout(false);
            this.panelEventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriendsList;
        private System.Windows.Forms.ListBox listBoxEventsList;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.RichTextBox richTextBoxPostStatus;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxWeatherIcon;
        private System.Windows.Forms.RichTextBox richTextBoxWeatheStats;
        private System.Windows.Forms.RichTextBox richTextBoxEventDescription;
        public RibbonStyle.RibbonMenuButton buttonLogout;
        private System.Windows.Forms.Panel panelEventDetails;
        private System.Windows.Forms.Label labelEventDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUpcomingEvents;
        private System.Windows.Forms.Label labelFriendsList;
        public RibbonStyle.RibbonMenuButton buttonPostStatus;
        public RibbonStyle.RibbonMenuButton buttonPicFilter;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}