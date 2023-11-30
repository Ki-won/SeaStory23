using SeaStory.Model;
using SeaStory.ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace SeaStory.UI.AdminFoodManagement
{
    public partial class ManageFoodChildUser : ManageFoodParent
    {
        private string SeatID;

        public ManageFoodChildUser(string seat)
        {
            DatabaseAut database = new DatabaseAut();
            SeatID = seat;
            InitializeComponent();
        }

        protected override async Task CreateMenuItemsAsync()
        {
            // Clear existing items
            flowLayoutPanelMenuItems.Controls.Clear();

            // get menu from database 
            var foodItemList = DatabaseNonAut.GetFoods();

            foreach (var foodItem in foodItemList)
            {
                Image foodImage = await ImageDownloader.LoadImageAsync(foodItem.ImageURL);
                var menuItemControl = new MenuItemWithCheckboxControl(foodImage, foodItem.FoodName, foodItem.FoodPrice, foodItem.FoodCode);

                flowLayoutPanelMenuItems.Controls.Add(menuItemControl);
            }

        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MakePayment_Click(object sender, EventArgs e)
        {
            var selectedItems = new List<MenuItemWithCheckboxControl>();
            decimal totalPrice = 0m;

            foreach (Control control in flowLayoutPanelMenuItems.Controls)
            {
                if (control is MenuItemWithCheckboxControl item && item.IsChecked())
                {
                    selectedItems.Add(item);

                    // 가격 누적
                    totalPrice += item.FoodPrice;
                }
            }

            if (selectedItems.Any())
            {
                UserInterFacePayment userInterFacePayment = new UserInterFacePayment(SeatID);
                userInterFacePayment.SetPrice((int)totalPrice);
                userInterFacePayment.ShowDialog();

                // 결제 폼에서의 결과 확인
                int paymentResult = userInterFacePayment.PaymentResult;
                if (paymentResult == 1)
                {
                    foreach (var item in selectedItems)
                    {
                        DatabaseAut.AddOrder(item.FoodName, SeatID);
                    }
                }
                this.Close();
            }

            else
            {
                MessageBox.Show("선택된 항목이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
