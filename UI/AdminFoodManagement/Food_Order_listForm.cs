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

namespace SeaStory.UI.AdminFoodManagement
{
    public partial class Food_Order_listForm : Form
    {
        public Food_Order_listForm()
        {
            InitializeComponent();

            list_Update();
        }

        private void buttonRemoveOrder(object sender, EventArgs e)
        {
            //listview1에서 선택된 주문을 삭제하는 기능
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string foodCode = selectedItem.SubItems[0].Text;
                string orderSeat = selectedItem.SubItems[2].Text;

                // DelOrders 메소드 호출
                DatabaseNonAut.DelOrders(foodCode, orderSeat);

                list_Update();
            }

        }

        private void buttonRefresh(object sender, EventArgs e)
        {
            //주문 목록을 새로 받아오는 버튼
            list_Update();
        }

        private void list_Update()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("주문한 요리", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("주문한 시간", 250, HorizontalAlignment.Center);
            listView1.Columns.Add("주문한 자리", 150, HorizontalAlignment.Center);
            List<OrderTable> orders = DatabaseNonAut.GetOrders();

            // listView1에 주문 목록 추가
            foreach (OrderTable order in orders)
            {
                ListViewItem item = new ListViewItem(order.FoodCode);
                item.SubItems.Add(order.OrderTime.ToString());
                item.SubItems.Add(order.OrderSeat);

                listView1.Items.Add(item);
            }
        }
    }
}
