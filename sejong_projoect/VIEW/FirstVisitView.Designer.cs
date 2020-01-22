namespace sejong_projoect
{
    partial class FirstVisitView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstVisitView));
            this.boardListView = new System.Windows.Forms.ListView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.selectedBoardLbl = new iTalk.iTalk_HeaderLabel();
            this.titleHeaderLbl = new iTalk.iTalk_HeaderLabel();
            this.okBtn = new iTalk.iTalk_Button_1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // boardListView
            // 
            this.boardListView.HideSelection = false;
            this.boardListView.Location = new System.Drawing.Point(49, 112);
            this.boardListView.Name = "boardListView";
            this.boardListView.Size = new System.Drawing.Size(682, 391);
            this.boardListView.TabIndex = 21;
            this.boardListView.TabStop = false;
            this.boardListView.UseCompatibleStateImageBehavior = false;
            this.boardListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.boardListView_ColumnWidthChanging);
            this.boardListView.DoubleClick += new System.EventHandler(this.boardListView_DoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // selectedBoardLbl
            // 
            this.selectedBoardLbl.AutoSize = true;
            this.selectedBoardLbl.BackColor = System.Drawing.Color.Transparent;
            this.selectedBoardLbl.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedBoardLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.selectedBoardLbl.Location = new System.Drawing.Point(107, 64);
            this.selectedBoardLbl.Name = "selectedBoardLbl";
            this.selectedBoardLbl.Size = new System.Drawing.Size(379, 23);
            this.selectedBoardLbl.TabIndex = 24;
            this.selectedBoardLbl.Text = "Pick your favorite movie to recommend a movie.";
            // 
            // titleHeaderLbl
            // 
            this.titleHeaderLbl.AutoSize = true;
            this.titleHeaderLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleHeaderLbl.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.titleHeaderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.titleHeaderLbl.Location = new System.Drawing.Point(103, 18);
            this.titleHeaderLbl.Name = "titleHeaderLbl";
            this.titleHeaderLbl.Size = new System.Drawing.Size(148, 46);
            this.titleHeaderLbl.TabIndex = 23;
            this.titleHeaderLbl.Text = "Motopia";
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.Transparent;
            this.okBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.okBtn.Image = null;
            this.okBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okBtn.Location = new System.Drawing.Point(643, 509);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(88, 40);
            this.okBtn.TabIndex = 27;
            this.okBtn.Text = "Complete";
            this.okBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // FirstVisitView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.selectedBoardLbl);
            this.Controls.Add(this.titleHeaderLbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.boardListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FirstVisitView";
            this.Text = "FristVisitView";
            this.Load += new System.EventHandler(this.FristVisitView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_HeaderLabel selectedBoardLbl;
        private iTalk.iTalk_HeaderLabel titleHeaderLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView boardListView;
        private iTalk.iTalk_Button_1 okBtn;
    }
}