using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sejong_projoect
{
    public delegate void EventHandler(string userName);

    public partial class Login : Form
    {
        public event EventHandler loginEventHandler;

        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginHandler loginHandler = new LoginHandler();

            if (ControlCheck())
            {
                if (loginHandler.LoginCheck(UserID.Text, UserPW.Text)) //loginHandler 객체를 통한 아이디 비밀번호 체크
                {
                    string userName = UserID.Text;
                    loginEventHandler(userName);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Login information is incorrect.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UserID.Clear();
                    UserPW.Clear();
                }
            }
        }

        //사용자로부터 입력받는 ID,PW칸이 비어있는지 확인
        private bool ControlCheck()
        {
            if (String.IsNullOrEmpty(UserID.Text))
            {
                MessageBox.Show("Please enter your ID and password.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserID.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(UserPW.Text))
            {
                MessageBox.Show("Please enter your username and password.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserPW.Focus();
                return false;
            }
            return true;
        }

        //회원가입 버튼 클릭
        private void signUpbtn_Click(object sender, EventArgs e)
        {
            SignUpPage signUpPage = new SignUpPage();
            signUpPage.ShowDialog();
            
        }
    }
   
}
