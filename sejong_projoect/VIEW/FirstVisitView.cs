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
    public partial class FirstVisitView : Form
    {
        private string user;
        private MySqlConnection conn;

        public FirstVisitView(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ConnectDataBase()
        {
            string connStr = string.Format(@"server=;
                                              port=;
                                              user=;
                                              password=;
                                              database=");

            conn = new MySqlConnection(connStr); //DB 연결

            try
            {
                conn.Open();
            }
            catch
            {
                conn.Close();
                MessageBox.Show("MySQL 연결 실패 프로그램을 종료합니다.");
                Application.Exit(); //커넥션 오류시 프로그램종료
            }
        }

        private void FristVisitView_Load(object sender, EventArgs e)
        {
            ConnectDataBase();
            boardListView.Clear();

            boardListView.BeginUpdate(); //업데이트시작
                                         //컬럼생성
            boardListView.Columns.Add("Num", 0, HorizontalAlignment.Center); //인덱스는 숨김
            boardListView.Columns.Add("Title", 260, HorizontalAlignment.Center);
            boardListView.Columns.Add("Genre", 130, HorizontalAlignment.Center);
            boardListView.Columns.Add("Restriction", 135, HorizontalAlignment.Center);
            boardListView.Columns.Add("Release", 130, HorizontalAlignment.Center);

            boardListView.View = View.Details;

            boardListView.FullRowSelect = true;
            boardListView.GridLines = true;
            

            MySqlDataReader r;
            string str = "select * from movielist"; //전체 영화 목록 검색

            try
            {
                r = new MySqlCommand(str, conn).ExecuteReader();

                while (r.Read())
                {
                    String[] arr = new String[6];
                    arr[0] = r["number"].ToString();
                    arr[1] = r["title"].ToString();
                    arr[2] = r["genre"].ToString();
                    arr[3] = r["age"].ToString();
                    arr[4] = r["date"].ToString();
                    ListViewItem lvt = new ListViewItem(arr);
                    boardListView.Items.Add(lvt);

                }
                boardListView.EndUpdate(); //업데이트 끝

                r.Close();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error reading data.Quit the program.");
                Application.Exit();
            }
            
         }
        

        private void boardListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            //컬럼사이즈를 이전사이즈로고정 =>변경 제한
            e.NewWidth = this.boardListView.Columns[e.ColumnIndex].Width;
            //이벤트를 취소한다.
            e.Cancel = true;
        }

        private void okBtn_Click(object sender, EventArgs e) //완료버튼
        {
            this.Close(); 
        }

        private void boardListView_DoubleClick(object sender, EventArgs e)
        {
            string number;
            string title;
            string table;
            if (boardListView.SelectedItems.Count == 1)
            {
                number = boardListView.FocusedItem.SubItems[0].Text;
                title = boardListView.FocusedItem.SubItems[1].Text;

                ToWishOrWatched toWishOrWatched = new ToWishOrWatched(number, title);
                toWishOrWatched.ShowDialog();
                table = toWishOrWatched.Passvalue; //선택된 값 가져오기

                ConnectDataBase();//db연결

                MySqlCommand cmd = new MySqlCommand();

                string sql = "insert into " + table + "(id,number) values(\"" + user + "\"," + number + ")";

                try
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    //사용자가 table을 선택하지 않을경우(취소할경우) 오류 발생
                    MessageBox.Show("Cancel Movie add");
                }

                conn.Close();
                setRecList();
            }

        }

        public void setRecList()
        {
            MySqlDataReader r;
            string str = "";
            MySqlCommand cmd = new MySqlCommand();

            string genre = "";


            ConnectDataBase();
            str = "select count(*),movielist.genre from movielist,watchlist where watchlist.ID='" + user + "' AND watchlist.number = movielist.number group by movielist.genre order by count(*) desc"; //ID 검색
            r = new MySqlCommand(str, conn).ExecuteReader();

            try
            {
                r.Read();

                genre = r["genre"].ToString();

            }
            catch
            {
                MessageBox.Show("1Error reading data");
            }

            r.Close(); //reader close

            string sql = " delete from reclist where ID = '" + user + "'"; // 기존에 있던 값 삭제.
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                //기존 reclist삭제 실패
                MessageBox.Show("Error deletion data.");
            }


            sql = "insert into reclist values('" + user + "','" + genre + "')";
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                //reclist 갱신 실패
                MessageBox.Show("Error insertion data.");
            }

            conn.Close();
        }


    }
}
