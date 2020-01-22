namespace sejong_projoect
{
    partial class WholeBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WholeBoard));
            this.boardListView = new System.Windows.Forms.ListView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userInfoLbl = new iTalk.iTalk_HeaderLabel();
            this.okBtn = new iTalk.iTalk_Button_1();
            this.searchTbx = new iTalk.iTalk_TextBox_Small();
            this.searchOption = new iTalk.iTalk_ComboBox();
            this.searchLbl = new iTalk.iTalk_Label();
            this.selectedBoardLbl = new iTalk.iTalk_HeaderLabel();
            this.suggestedListBtn = new iTalk.iTalk_Button_1();
            this.watchedMovieBtn = new iTalk.iTalk_Button_1();
            this.wishListBtn = new iTalk.iTalk_Button_1();
            this.wholeMovieBtn = new iTalk.iTalk_Button_1();
            this.titleHeaderLbl = new iTalk.iTalk_HeaderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // boardListView
            // 
            this.boardListView.HideSelection = false;
            this.boardListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boardListView.Location = new System.Drawing.Point(48, 154);
            this.boardListView.Name = "boardListView";
            this.boardListView.Size = new System.Drawing.Size(682, 359);
            this.boardListView.TabIndex = 0;
            this.boardListView.TabStop = false;
            this.boardListView.UseCompatibleStateImageBehavior = false;
            this.boardListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.boardListView_ColumnClick_1);
            this.boardListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.boardListView_ColumnWidthChanging);
            this.boardListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.boardListView_MouseDoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // userInfoLbl
            // 
            this.userInfoLbl.AutoSize = true;
            this.userInfoLbl.BackColor = System.Drawing.Color.Transparent;
            this.userInfoLbl.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.userInfoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.userInfoLbl.Location = new System.Drawing.Point(44, 527);
            this.userInfoLbl.Name = "userInfoLbl";
            this.userInfoLbl.Size = new System.Drawing.Size(217, 20);
            this.userInfoLbl.TabIndex = 26;
            this.userInfoLbl.Text = "Our Recommended List For You";
            this.userInfoLbl.Visible = false;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.Transparent;
            this.okBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.okBtn.Image = null;
            this.okBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okBtn.Location = new System.Drawing.Point(677, 521);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(53, 28);
            this.okBtn.TabIndex = 24;
            this.okBtn.Text = "OK";
            this.okBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.okBtn.Visible = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // searchTbx
            // 
            this.searchTbx.BackColor = System.Drawing.Color.Transparent;
            this.searchTbx.Font = new System.Drawing.Font("Tahoma", 11F);
            this.searchTbx.ForeColor = System.Drawing.Color.DimGray;
            this.searchTbx.Location = new System.Drawing.Point(453, 521);
            this.searchTbx.MaxLength = 32767;
            this.searchTbx.Multiline = false;
            this.searchTbx.Name = "searchTbx";
            this.searchTbx.ReadOnly = false;
            this.searchTbx.Size = new System.Drawing.Size(218, 28);
            this.searchTbx.TabIndex = 23;
            this.searchTbx.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTbx.UseSystemPasswordChar = false;
            this.searchTbx.Visible = false;
            // 
            // searchOption
            // 
            this.searchOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.searchOption.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.searchOption.DropDownHeight = 100;
            this.searchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchOption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.searchOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.searchOption.FormattingEnabled = true;
            this.searchOption.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.searchOption.IntegralHeight = false;
            this.searchOption.ItemHeight = 20;
            this.searchOption.Items.AddRange(new object[] {
            "TITLE",
            "GENRE"});
            this.searchOption.Location = new System.Drawing.Point(345, 523);
            this.searchOption.Name = "searchOption";
            this.searchOption.Size = new System.Drawing.Size(102, 26);
            this.searchOption.StartIndex = 0;
            this.searchOption.TabIndex = 22;
            this.searchOption.Visible = false;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.BackColor = System.Drawing.Color.Transparent;
            this.searchLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.searchLbl.Location = new System.Drawing.Point(275, 525);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(68, 21);
            this.searchLbl.TabIndex = 21;
            this.searchLbl.Text = "SEARCH";
            this.searchLbl.Visible = false;
            // 
            // selectedBoardLbl
            // 
            this.selectedBoardLbl.AutoSize = true;
            this.selectedBoardLbl.BackColor = System.Drawing.Color.Transparent;
            this.selectedBoardLbl.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedBoardLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.selectedBoardLbl.Location = new System.Drawing.Point(106, 57);
            this.selectedBoardLbl.Name = "selectedBoardLbl";
            this.selectedBoardLbl.Size = new System.Drawing.Size(115, 23);
            this.selectedBoardLbl.TabIndex = 20;
            this.selectedBoardLbl.Text = "Seleted menu";
            // 
            // suggestedListBtn
            // 
            this.suggestedListBtn.BackColor = System.Drawing.Color.Transparent;
            this.suggestedListBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.suggestedListBtn.Image = null;
            this.suggestedListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suggestedListBtn.Location = new System.Drawing.Point(564, 108);
            this.suggestedListBtn.Name = "suggestedListBtn";
            this.suggestedListBtn.Size = new System.Drawing.Size(166, 40);
            this.suggestedListBtn.TabIndex = 17;
            this.suggestedListBtn.Text = "Recommend List";
            this.suggestedListBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.suggestedListBtn.Click += new System.EventHandler(this.suggestedListBtn_Click);
            // 
            // watchedMovieBtn
            // 
            this.watchedMovieBtn.BackColor = System.Drawing.Color.Transparent;
            this.watchedMovieBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.watchedMovieBtn.Image = null;
            this.watchedMovieBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.watchedMovieBtn.Location = new System.Drawing.Point(392, 108);
            this.watchedMovieBtn.Name = "watchedMovieBtn";
            this.watchedMovieBtn.Size = new System.Drawing.Size(166, 40);
            this.watchedMovieBtn.TabIndex = 16;
            this.watchedMovieBtn.Text = "Watched List";
            this.watchedMovieBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.watchedMovieBtn.Click += new System.EventHandler(this.watchedMovieBtn_Click);
            // 
            // wishListBtn
            // 
            this.wishListBtn.BackColor = System.Drawing.Color.Transparent;
            this.wishListBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.wishListBtn.Image = null;
            this.wishListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wishListBtn.Location = new System.Drawing.Point(220, 108);
            this.wishListBtn.Name = "wishListBtn";
            this.wishListBtn.Size = new System.Drawing.Size(166, 40);
            this.wishListBtn.TabIndex = 15;
            this.wishListBtn.Text = "Favorite List";
            this.wishListBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.wishListBtn.Click += new System.EventHandler(this.wishListBtn_Click);
            // 
            // wholeMovieBtn
            // 
            this.wholeMovieBtn.BackColor = System.Drawing.Color.Transparent;
            this.wholeMovieBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.wholeMovieBtn.Image = null;
            this.wholeMovieBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wholeMovieBtn.Location = new System.Drawing.Point(48, 108);
            this.wholeMovieBtn.Name = "wholeMovieBtn";
            this.wholeMovieBtn.Size = new System.Drawing.Size(166, 40);
            this.wholeMovieBtn.TabIndex = 14;
            this.wholeMovieBtn.Text = "Whole Movie List";
            this.wholeMovieBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.wholeMovieBtn.Click += new System.EventHandler(this.wholeMovieBtn_Click);
            // 
            // titleHeaderLbl
            // 
            this.titleHeaderLbl.AutoSize = true;
            this.titleHeaderLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleHeaderLbl.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.titleHeaderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.titleHeaderLbl.Location = new System.Drawing.Point(102, 11);
            this.titleHeaderLbl.Name = "titleHeaderLbl";
            this.titleHeaderLbl.Size = new System.Drawing.Size(148, 46);
            this.titleHeaderLbl.TabIndex = 13;
            this.titleHeaderLbl.Text = "Motopia";
            // 
            // WholeBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.userInfoLbl);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.searchTbx);
            this.Controls.Add(this.searchOption);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.selectedBoardLbl);
            this.Controls.Add(this.suggestedListBtn);
            this.Controls.Add(this.watchedMovieBtn);
            this.Controls.Add(this.wishListBtn);
            this.Controls.Add(this.wholeMovieBtn);
            this.Controls.Add(this.titleHeaderLbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.boardListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WholeBoard";
            this.Text = "WholeBoard";
            this.Load += new System.EventHandler(this.WholeBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView boardListView;
        private System.Windows.Forms.PictureBox pictureBox2;
        private iTalk.iTalk_HeaderLabel titleHeaderLbl;
        private iTalk.iTalk_Button_1 wholeMovieBtn;
        private iTalk.iTalk_Button_1 wishListBtn;
        private iTalk.iTalk_Button_1 watchedMovieBtn;
        private iTalk.iTalk_Button_1 suggestedListBtn;
        private iTalk.iTalk_HeaderLabel selectedBoardLbl;
        private iTalk.iTalk_Label searchLbl;
        private iTalk.iTalk_ComboBox searchOption;
        private iTalk.iTalk_TextBox_Small searchTbx;
        private iTalk.iTalk_Button_1 okBtn;
        private iTalk.iTalk_HeaderLabel userInfoLbl;
    }
}