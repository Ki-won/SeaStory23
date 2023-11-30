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
    public partial class User_Order_list_form : Form
    {
        private string SeatID;
        public User_Order_list_form(string seat)
        {
            SeatID = seat;
            InitializeComponent();
            label1.Text = SeatID;
            list_Update();
        }



        private void list_Update()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("주문한 요리", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("주문한 시간", 250, HorizontalAlignment.Center);
            listView1.Columns.Add("주문한 자리", 150, HorizontalAlignment.Center);
            List<OrderTable> orders = DatabaseAut.UserGetOrders(SeatID);

            // listView1에 주문 목록 추가
            foreach (OrderTable order in orders)
            {
                ListViewItem item = new ListViewItem(order.FoodCode);
                item.SubItems.Add(order.OrderTime.ToString());
                item.SubItems.Add(order.OrderSeat);

                listView1.Items.Add(item);
            }
        }

        //새로고침 버튼 클릭 시
        private void buttonRefreshClick(object sender, EventArgs e)
        {
            list_Update();
        }
        //닫기 버튼 클릭 시
        private void buttonCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
