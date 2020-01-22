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
    public partial class ToWishOrWatched : Form
    {
        private string number;
        private string title;
        private string table;

        //값을 전달하기 위한 속성
        public string Passvalue
        {
            get { return this.table; } // WholeBoard에서 얻은(get) 값을 다른폼(Form1)으로 전달 목적
            set { this.table = value; }  // 다른폼(Wholboard)에서 전달받은 값을 쓰기
        }
        
        public ToWishOrWatched(string number,string title)
        {
            InitializeComponent();
            this.number = number;
            //영화제목 set
            if (title.IndexOf('(') != -1)
            {
                this.title = title.Substring(0, title.IndexOf('('));
            }
            else
                this.title = title;
            Passvalue = "";
            titleTbx.Text = this.title;
        }

        private void wishBtn_Click(object sender, EventArgs e)
        {
            Passvalue = "wishlist";
            this.Close();
        }

        private void wathedBtn_Click(object sender, EventArgs e)
        {
            Passvalue = "watchlist";
            this.Close();
        }
    }
}
