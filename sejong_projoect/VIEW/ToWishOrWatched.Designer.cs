namespace sejong_projoect
{
    partial class ToWishOrWatched
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
            this.iTalk_Panel1 = new iTalk.iTalk_Panel();
            this.titleLabel = new iTalk.iTalk_Label();
            this.titleTbx = new iTalk.iTalk_TextBox_Small();
            this.titleLbl = new iTalk.iTalk_HeaderLabel();
            this.wathedBtn = new iTalk.iTalk_Button_1();
            this.wishBtn = new iTalk.iTalk_Button_1();
            this.iTalk_Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iTalk_Panel1
            // 
            this.iTalk_Panel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Panel1.Controls.Add(this.titleLabel);
            this.iTalk_Panel1.Controls.Add(this.titleTbx);
            this.iTalk_Panel1.Controls.Add(this.titleLbl);
            this.iTalk_Panel1.Controls.Add(this.wathedBtn);
            this.iTalk_Panel1.Controls.Add(this.wishBtn);
            this.iTalk_Panel1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_Panel1.Name = "iTalk_Panel1";
            this.iTalk_Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.iTalk_Panel1.Size = new System.Drawing.Size(294, 295);
            this.iTalk_Panel1.TabIndex = 4;
            this.iTalk_Panel1.Text = "iTalk_Panel1";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.titleLabel.Location = new System.Drawing.Point(41, 105);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(29, 13);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Title";
            // 
            // titleTbx
            // 
            this.titleTbx.BackColor = System.Drawing.Color.Transparent;
            this.titleTbx.Font = new System.Drawing.Font("Tahoma", 11F);
            this.titleTbx.ForeColor = System.Drawing.Color.DimGray;
            this.titleTbx.Location = new System.Drawing.Point(41, 124);
            this.titleTbx.MaxLength = 32767;
            this.titleTbx.Multiline = false;
            this.titleTbx.Name = "titleTbx";
            this.titleTbx.ReadOnly = false;
            this.titleTbx.Size = new System.Drawing.Size(193, 28);
            this.titleTbx.TabIndex = 3;
            this.titleTbx.TabStop = false;
            this.titleTbx.Text = "Movie Title";
            this.titleTbx.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.titleTbx.UseSystemPasswordChar = false;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.White;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.Black;
            this.titleLbl.Location = new System.Drawing.Point(92, 29);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(113, 30);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Add movie";
            // 
            // wathedBtn
            // 
            this.wathedBtn.BackColor = System.Drawing.Color.White;
            this.wathedBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.wathedBtn.Image = null;
            this.wathedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wathedBtn.Location = new System.Drawing.Point(41, 237);
            this.wathedBtn.Name = "wathedBtn";
            this.wathedBtn.Size = new System.Drawing.Size(193, 43);
            this.wathedBtn.TabIndex = 2;
            this.wathedBtn.Text = "To Watched List";
            this.wathedBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.wathedBtn.Click += new System.EventHandler(this.wathedBtn_Click);
            // 
            // wishBtn
            // 
            this.wishBtn.BackColor = System.Drawing.Color.White;
            this.wishBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.wishBtn.Image = null;
            this.wishBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wishBtn.Location = new System.Drawing.Point(41, 180);
            this.wishBtn.Name = "wishBtn";
            this.wishBtn.Size = new System.Drawing.Size(193, 41);
            this.wishBtn.TabIndex = 1;
            this.wishBtn.Text = "To Favorite List";
            this.wishBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.wishBtn.Click += new System.EventHandler(this.wishBtn_Click);
            // 
            // ToWishOrWatched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 292);
            this.Controls.Add(this.iTalk_Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ToWishOrWatched";
            this.Text = "ToWishOrWatched";
            this.iTalk_Panel1.ResumeLayout(false);
            this.iTalk_Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_HeaderLabel titleLbl;
        private iTalk.iTalk_Button_1 wishBtn;
        private iTalk.iTalk_Button_1 wathedBtn;
        private iTalk.iTalk_Panel iTalk_Panel1;
        private iTalk.iTalk_Label titleLabel;
        private iTalk.iTalk_TextBox_Small titleTbx;
    }
}