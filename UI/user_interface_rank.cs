using SeaStory.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SeaStory.Model.DataCalss;

namespace SeaStory.UI
{
    public partial class user_interface_rank : Form
    {
        public user_interface_rank()
        {
            InitializeComponent();
            list_Update();
        }

        private void buttonRefresh(object sender, EventArgs e)
        {
            //유저 랭킹 리스트 형태로 받아오는 함수 필요
            list_Update();
        }

        private void list_Update()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("아이디", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("유저명", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("사용시간", 250, HorizontalAlignment.Center);
            List<User2> users = DatabaseAut.GetRanking();

            // listView1에 랭킹 목록 추가
            foreach (User2 userss in users)
            {
                if (!(userss.ID == "admin"))
                {
                    ListViewItem item = new ListViewItem(userss.ID);
                    item.SubItems.Add(userss.Name);
                    item.SubItems.Add(userss.UsedTime.ToString());
                    listView1.Items.Add(item);
                }
            }
        }
    }
}
