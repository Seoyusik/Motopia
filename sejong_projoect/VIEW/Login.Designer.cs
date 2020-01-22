namespace sejong_projoect
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UserID = new System.Windows.Forms.TextBox();
            this.UserPW = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.labelPW = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.squarePictureBox = new System.Windows.Forms.PictureBox();
            this.backGroundPictureBox = new System.Windows.Forms.PictureBox();
            this.signUpbtn = new iTalk.iTalk_Button_1();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squarePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserID
            // 
            this.UserID.Location = new System.Drawing.Point(96, 299);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(173, 21);
            this.UserID.TabIndex = 0;
            // 
            // UserPW
            // 
            this.UserPW.Location = new System.Drawing.Point(96, 345);
            this.UserPW.Name = "UserPW";
            this.UserPW.PasswordChar = '*';
            this.UserPW.Size = new System.Drawing.Size(173, 21);
            this.UserPW.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginButton.Location = new System.Drawing.Point(96, 384);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(173, 29);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.BackColor = System.Drawing.Color.White;
            this.labelPW.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPW.Location = new System.Drawing.Point(93, 327);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(25, 15);
            this.labelPW.TabIndex = 6;
            this.labelPW.Text = "PW";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.White;
            this.labelID.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelID.Location = new System.Drawing.Point(93, 281);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(19, 15);
            this.labelID.TabIndex = 5;
            this.labelID.Text = "ID";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.White;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(108, 123);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(150, 154);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // squarePictureBox
            // 
            this.squarePictureBox.BackColor = System.Drawing.Color.White;
            this.squarePictureBox.Location = new System.Drawing.Point(49, 100);
            this.squarePictureBox.Name = "squarePictureBox";
            this.squarePictureBox.Size = new System.Drawing.Size(268, 348);
            this.squarePictureBox.TabIndex = 11;
            this.squarePictureBox.TabStop = false;
            // 
            // backGroundPictureBox
            // 
            this.backGroundPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("backGroundPictureBox.Image")));
            this.backGroundPictureBox.Location = new System.Drawing.Point(-1, -2);
            this.backGroundPictureBox.Name = "backGroundPictureBox";
            this.backGroundPictureBox.Size = new System.Drawing.Size(367, 645);
            this.backGroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backGroundPictureBox.TabIndex = 10;
            this.backGroundPictureBox.TabStop = false;
            // 
            // signUpbtn
            // 
            this.signUpbtn.BackColor = System.Drawing.Color.Transparent;
            this.signUpbtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpbtn.Image = null;
            this.signUpbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signUpbtn.Location = new System.Drawing.Point(143, 422);
            this.signUpbtn.Name = "signUpbtn";
            this.signUpbtn.Size = new System.Drawing.Size(83, 21);
            this.signUpbtn.TabIndex = 13;
            this.signUpbtn.Text = "Sign Up";
            this.signUpbtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.signUpbtn.Click += new System.EventHandler(this.signUpbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 641);
            this.Controls.Add(this.signUpbtn);
            this.Controls.Add(this.labelPW);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.UserPW);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.squarePictureBox);
            this.Controls.Add(this.backGroundPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Motopia";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squarePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGroundPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.TextBox UserPW;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.PictureBox squarePictureBox;
        private System.Windows.Forms.PictureBox backGroundPictureBox;
        private iTalk.iTalk_Button_1 signUpbtn;
    }
}

