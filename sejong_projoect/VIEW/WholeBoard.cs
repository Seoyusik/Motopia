using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Windows.Forms;

namespace sejong_projoect
{
    public partial class WholeBoard : Form
    {
        Login login; //로그인 객체 생성
        private string user; //유저ID저장
        private MySqlConnection conn; //db접속위한 변수
        private string selectedBoard; //선택된 목록정보 저장 
        private int sortColumn = -1; //sort 기본값

        public WholeBoard()
        {
            InitializeComponent();
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
                MessageBox.Show("MySQL Connection ERR.");
                Application.Exit();

            }
        }// void ConnectDataBase()

        private void WholeBoard_Load(object sender, EventArgs e)
        {
           
            login = new Login();
            login.loginEventHandler += new EventHandler(LoginSuccess);

            switch (login.ShowDialog())
            {
                case DialogResult.OK:
                    login.Close();
                    break;
                case DialogResult.Cancel:
                    Dispose();
                    break;
            }

            LoginCountCheck(); //로그인 카운터 체크 메소드 호출

            selectedBoardLbl.Text = "Hello! "+user; //라벨갱신

        }//void WholeBoard_Load(object sender, EventArgs e)

        private void LoginSuccess(string userName)
        {
            user = userName;

            MessageBox.Show("Hello, "+user); //로그인 성공 메세지
        }//void LoginSuccess

        private void LoginCountCheck()
        {
            //로그인 횟수 체크후 처음 로그인이면 영화 선호도 선택 뷰를 띄움
            ConnectDataBase();

            MySqlDataReader r;
            string str = "select * from userinfo where id='" + user + "'"; //id검색

            r = new MySqlCommand(str, conn).ExecuteReader(); //데이터를 읽기위한 커멘드 생성

            r.Read();

            if ((int)r["count"] == 0)            
            {
                //초기 로그인일 경우
                FirstVisitView firstVisitView = new FirstVisitView(user); //초기뷰 생성
                firstVisitView.ShowDialog();

                MySqlCommand cmd = new MySqlCommand();
                string sql = "update userinfo set count=1 where id='"+user+"'"; //count 1로 변경
   
                try
                {
                    r.Close();
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Login count update failed");
                }
               
            }

            r.Close();
            conn.Close();
            //커넥션을 닫고 메소드 종료
        } //void LoginCountCheck()

        //버튼별 뷰 갱신 및 테이블선택
        private void wholeMovieBtn_Click(object sender, EventArgs e)
        {
            string boardtype = "whole";
            searchLbl.Visible = true;
            searchOption.Visible = true;
            searchTbx.Visible = true;
            okBtn.Visible = true;
            userInfoLbl.Visible = false;
            selectedBoardLbl.Text = "Full movie list.";
            boardControl(boardtype); //리스트뷰 갱신 메소드 호출
            selectedBoard = "whole";
        }//wholeMovieBtn

        private void wishListBtn_Click(object sender, EventArgs e)
        {
            string boardtype = "wish";
            searchLbl.Visible = false;
            searchOption.Visible = false;
            searchTbx.Visible = false;
            okBtn.Visible = false;
            userInfoLbl.Visible = false;
            selectedBoardLbl.Text = "My favorites list.";
            boardControl(boardtype); //리스트뷰 갱신 메소드 호출
            selectedBoard = "wish";
        }//wishListBtn

        private void watchedMovieBtn_Click(object sender, EventArgs e)
        {
            string boardtype = "watched";
            searchLbl.Visible = false;
            searchOption.Visible = false;
            searchTbx.Visible = false;
            okBtn.Visible = false;
            userInfoLbl.Visible = false;
            selectedBoardLbl.Text = "Whated moive.";
            boardControl(boardtype); //리스트뷰 갱신 메소드 호출
            selectedBoard = "watched";
        }//watchedMovieBtn

        private void suggestedListBtn_Click(object sender, EventArgs e)
        {
            string boardtype = "suggested";
            searchLbl.Visible = false;
            searchOption.Visible = false;
            searchTbx.Visible = false;
            okBtn.Visible = false;
            userInfoLbl.Visible = false;
            selectedBoardLbl.Text = "Recommended list.";
            boardControl(boardtype); //리스트뷰 갱신 메소드 호출
            selectedBoard = "suggested";

        }//suggestedListBtn
        //Button 

        public void setRecList()
        {
            MySqlDataReader r;
            string str = "";
            MySqlCommand cmd = new MySqlCommand();

            //장르와 국가 초기값, 시청목록이 비어있을 경우 공백이 들어감
            string genre="";

            ConnectDataBase(); //DB연결
            str = "select count(*),movielist.genre from movielist,watchlist " +
                "where watchlist.ID='" + user + "' AND watchlist.number = movielist.number " +
                "group by movielist.genre order by count(*) desc";
            r = new MySqlCommand(str, conn).ExecuteReader();

            try
            {
                r.Read(); //가장위의 튜플을 한줄 읽어옴

                genre = r["genre"].ToString();

            }
            catch
            {
                //읽어올 데이터가 없을때 아무것도 하지않음
                
            }

            r.Close(); //redaer close

            string sql=" delete from reclist where ID = '"+user+"'"; // 추천정보 갱신을 위한 기존정보 삭제.
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                //기존 reclist삭제 실패
                MessageBox.Show("Data deletion failed.");
            }

       
            sql= "insert into reclist values('"+user+"','"+genre+"')";
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                //reclist 갱신 실패
                MessageBox.Show("Data insertion failed");
            }

            conn.Close();
        }// void setRecList()

        //선택 메뉴별 리스트뷰 갱신
        private void boardControl(string boardType)
        {

            MySqlDataReader r;
            string str = "";
            string genre = "";
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
            
            ConnectDataBase(); //DB연결

            if (boardType == "whole")
            {
                str = "select * from movielist"; // 전체영화
            }
            else if (boardType == "wish")
            {
                str = "select * from movielist LEFT JOIN wishlist on movielist.number = wishlist.number AND wishlist.ID = '"+user+"' where wishlist.ID is not NULL";

            }
            else if (boardType == "watched")
            {
                str = "select * from movielist LEFT JOIN watchlist on movielist.number = watchlist.number AND watchlist.ID = '" + user + "' where watchlist.ID is not NULL";
            }
            else //추천목록 리스트뷰
            {
                str = "select * from reclist where ID = '" + user + "'";
                r = new MySqlCommand(str, conn).ExecuteReader();
                try
                {
                    r.Read();
                    genre = r["rec_genre"].ToString();
                    userInfoLbl.Visible = true; //추천목록의 라벨정보 갱신
                    userInfoLbl.Text = "Our Recommended List For "+user;
                    str = "select movielist.* from movielist LEFT JOIN watchlist on movielist.number = watchlist.number AND watchlist.ID = '"+user+"' " +
                                "where watchlist.ID is NULL and movielist.genre = '"+genre+"'";
                }
                catch
                {
                    //한번도 시청목록이 갱신되지않아 reclist가 초기화되지않아 발생하는 오류처리
                    MessageBox.Show("There is no watch history information.");
                }

                r.Close();
            }//else

            try
            {
                r = new MySqlCommand(str, conn).ExecuteReader();

                while (r.Read()) //읽어올 튜플이없을때까지 읽어오고 리스트뷰에 추가
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

                if (boardListView.Items.Count == 0)
                {
                    userInfoLbl.Visible = false;
                    MessageBox.Show("No saved list.");
                }

                r.Close();
                conn.Close();
            }
            catch
            {
                //쿼리로유로 인한 오류발생처리
                MessageBox.Show("Error reading data.");
            }

        }// void boardControl(string boardType)


        private void boardListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            //컬럼사이즈를 이전사이즈로고정 =>변경 제한
            e.NewWidth = this.boardListView.Columns[e.ColumnIndex].Width;
            //이벤트를 취소한다.
            e.Cancel = true;
        }// void boardListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)

        //리스트뷰 항목 더블클릭
        private void boardListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string number;
            string title;
            string table;

            //1. 전체목록에서의 항목 더블클릭 : 추천목록이나 시청기록으로 이동.
            if (selectedBoard == "whole")
            {
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
                        MessageBox.Show("Cancel movie add");
                    }
                   
                    conn.Close();
                }
            } //if whole board
            else if (selectedBoard == "wish") //2. 즐겨찾기에서의 항목 더블클릭 : 삭제
            {
                number = boardListView.FocusedItem.SubItems[0].Text;
                title = boardListView.FocusedItem.SubItems[1].Text;

                DialogResult dr = MessageBox.Show("Are you sure you want to delete the selected movie from your favorites? ", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.OK)
                {
                    ConnectDataBase();//db연결

                    MySqlCommand cmd = new MySqlCommand();

                    string sql = "delete from wishlist where ID='" + user + "' and number=" + number + "; ";

                    try
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deletion complete.");
                        boardControl(selectedBoard);
                    }
                    catch
                    {
                        conn.Close();
                        MessageBox.Show("Error deleting data.");
                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Cancel");
                }
            }
            else if (selectedBoard == "watched") //3. 시청기록에서의 더블클릭 : 삭제
            {
                number = boardListView.FocusedItem.SubItems[0].Text;
                title = boardListView.FocusedItem.SubItems[1].Text;

                DialogResult dr = MessageBox.Show("Are you sure you want to delete the selected movie from your watch history?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
           
                if (dr == DialogResult.OK)
                {
                    ConnectDataBase();//db연결

                    MySqlCommand cmd = new MySqlCommand();

                    string sql = "delete from watchlist where ID='"+user+"' and number="+number+"; ";

                    try
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deletion complete");
                        boardControl(selectedBoard);
                    }
                    catch
                    {
                        MessageBox.Show("Error deleting data.");
                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Cancel");
                }
            }//if watchlist
            else if(selectedBoard=="suggested") //4. 추천에서의 항목 더블클릭 : 추천목록이나 시청기록으로 이동
            {
                number = boardListView.FocusedItem.SubItems[0].Text;
                title = boardListView.FocusedItem.SubItems[1].Text;


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
                        boardControl(selectedBoard);
                    }
                    catch
                    {
                        //사용자가 table을 선택하지 않을경우(취소할경우) 오류 발생
                        MessageBox.Show("Cancel movie add");
                    }

                    conn.Close();
                }
            }
            setRecList(); //항목변경후 항상 추천테이블 갱신

        }//void boardListView_MouseDoubleClick(object sender, MouseEventArgs e)

        private void okBtn_Click(object sender, EventArgs e) //검색버튼
        {
            ConnectDataBase();
            string option = searchOption.Text;
            string content = searchTbx.Text;

            MySqlDataReader r;
            string str = "";

            boardListView.Clear();

            boardListView.BeginUpdate(); //업데이트시작
            //컬럼생성
            boardListView.Columns.Add("Num", 0, HorizontalAlignment.Center); //인덱스숨김
            boardListView.Columns.Add("Title", 245, HorizontalAlignment.Center);
            boardListView.Columns.Add("Genre", 115, HorizontalAlignment.Center);
            boardListView.Columns.Add("Restriction", 110, HorizontalAlignment.Center);
            boardListView.Columns.Add("Release", 85, HorizontalAlignment.Center);

            boardListView.View = View.Details;

            boardListView.FullRowSelect = true;
            boardListView.GridLines = true;

            str = "select * from movielist where " + option + " like '%" + content + "%'";
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
                    boardListView.Items.Add(lvt);//리스트뷰에 추가
                }

                boardListView.EndUpdate(); //업데이트 끝

                if (boardListView.Items.Count == 0)
                {
                    MessageBox.Show("There are no movies found.");
                }
                r.Close();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error reading data.");
            }
        }
        

        //정렬을 위한 클래스
        class MyListViewComparer : IComparer //정렬을 위해 IComparer 상속받아 구현
        {
            private int col;
            private SortOrder order;

            public MyListViewComparer()
            {
                col = 0;
                order = SortOrder.Ascending;
            }

            public MyListViewComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }
            public int Compare(object x, object y)
            {
                int returnVal = -1;
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text); 

                if (order == SortOrder.Descending)
                {
                    returnVal *= -1; 
                }
                return returnVal;

            }

        }//void okBtn_Click(object sender, EventArgs e)

        //클릭시마다 내림차순-오름차순 변환
        private void boardListView_ColumnClick_1(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;

                boardListView.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (boardListView.Sorting == SortOrder.Ascending)
                {
                    boardListView.Sorting = SortOrder.Descending;

                }
                else
                {
                    boardListView.Sorting = SortOrder.Ascending;

                }
            }

            boardListView.Sort();
            this.boardListView.ListViewItemSorter = new MyListViewComparer(e.Column, boardListView.Sorting);
        }//void boardListView_ColumnClick_1(object sender, ColumnClickEventArgs e)
    }
}
