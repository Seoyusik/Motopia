using MySql.Data.MySqlClient;
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
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        private void SignUpPage_Load(object sender, EventArgs e)
        {
            this.Text = "Sign Up";
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string id = userIdTbx.Text;
            string password = userPasswordTbx.Text;
            string name = userNameTbx.Text;
            MySqlDataReader r;


            //Todo, db연결후 아이디 중복체크& 회원생성
            string connStr = string.Format(@"server=;
                                              port=;
                                              user=;
                                              password=;
                                              database=");

            MySqlConnection conn = new MySqlConnection(connStr); //DB 연결
            try
            {
                conn.Open();
            }
            catch
            {
                conn.Close();
                MessageBox.Show("MySQL Connection ERR.");
                Application.Exit();
            }
            if (ControlCheck())
            {
                string str = "select * from userinfo where id='" + id + "'"; //ID 검색
                r = new MySqlCommand(str, conn).ExecuteReader();

                if (r.Read()) //이미 등록된 아이디가 있으면
                {
                    MessageBox.Show("ID is already registered. Please use a different ID");
                    idLbl.ForeColor = Color.Red;
                    userIdTbx.ForeColor = Color.Red;
                    return;
                }
                else
                {

                    r.Close();

                    MySqlCommand cmd = new MySqlCommand();
                    string sql = "insert into userinfo(id,pw,name) values(\"" + id + "\",\"" + password + "\",\"" + name + "\")";

                    try
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sign Up Success. Please try logging in again.");
                        conn.Close();
                        this.Close();

                    }
                    catch
                    {
                        MessageBox.Show("Membership failed. 20 characters for ID, 20 characters for password, and 10 characters for name.");
                        conn.Close();
                    }
                }
            }

        }

        //입력받아야 하는 값들이 입력되었는지 판별
        private bool ControlCheck()
        {
            if (String.IsNullOrEmpty(userNameTbx.Text))
            {
                MessageBox.Show("이름을 입력해 주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userNameTbx.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(userIdTbx.Text))
            {
                MessageBox.Show("ID를 입력해 주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userIdTbx.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(userPasswordTbx.Text))
            {
                MessageBox.Show("비밀번호를 입력해 주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userPasswordTbx.Focus();
                return false;
            }

            return true;
        }

    }
}
