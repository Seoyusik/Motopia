using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sejong_projoect
{
    class LoginHandler
    {
        public bool LoginCheck(string id, string password)
        {
            
            MySqlDataReader r;
            MySqlCommand cmd=new MySqlCommand();

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

            string str = "select * from userinfo where id='"+id+"'"; //ID 검색
            r = new MySqlCommand(str, conn).ExecuteReader();

            if (!r.Read()) //ID가 없으면
            {
                r.Close();
                conn.Close();
                return false; 
            }
            
            if (id.Equals(r["id"].ToString()) && password.Equals(r["pw"].ToString()))//ID ,PW 체크
            {
                r.Close();
                conn.Close();
                return true;
            }
            

            //비밀번호 틀리면
            r.Close();
            conn.Close();
            return false;
        }
    }
}
