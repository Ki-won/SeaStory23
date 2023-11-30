using SeaStory.UI;
using SeaStory.UI.AdminFoodManagement;
using SeaStory.UI.TimeManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaStory.ui
{
    public partial class admin_inter_main : Form
    {
        public admin_inter_main()
        {
            InitializeComponent();
            seatPanelAdmin1.SetSeatClickHandler(ForceClose);
        }

        //요금제 관리 버튼 클릭 시
        private void button24_Click(object sender, EventArgs e)
        {
            ManageTimeAdmin manageTimeAdmin = new ManageTimeAdmin();
            manageTimeAdmin.ShowDialog();
        }

        //음식 관리 버튼 클릭 시
        private void button25_Click(object sender, EventArgs e)
        {

            ManageFoodChildAdmin manageFoodChildAdmin = new ManageFoodChildAdmin();
            manageFoodChildAdmin.ShowDialog();
        }

        //요리 주문 목록 버튼 클릭 시
        private void button2_Click(object sender, EventArgs e)
        {
            Food_Order_listForm food_Order_listForm = new Food_Order_listForm();
            food_Order_listForm.ShowDialog();
        }

        //회원 관리 버튼 클릭 시
        private void button3_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement();
            userManagement.ShowDialog();
        }

        private async void ForceClose(string userId, int userType, string seat)
        {
            var clientWrapper = await ClientWrapper.Instance;
            await clientWrapper.ForceDeactivateUserAsync(userId, int.Parse(seat));
            // await clientWrapper.CloseAsync();

            MessageBox.Show("강제 종료되었습니다");
        }



    }
}
