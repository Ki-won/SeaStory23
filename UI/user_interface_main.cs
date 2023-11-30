using Microsoft.VisualBasic.ApplicationServices;
using SeaStory.Model;
using SeaStory.UI;
using SeaStory.UI.AdminFoodManagement;
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
using User = SeaStory.Model.DataCalss.User;

// 시간이 변경되는 동작이 있는 경우 좌석 테이블의 좌석코드와 업데이트 이후의 시간을 넣어 업데이트 해주는 함수 필요

namespace SeaStory
{
    public partial class user_interface_main : Form
    {
        private Timer timer;
        private string userID; // userID 추가
        private int userType; // userType 추가
        private string seatNumber; // seat_number 추가

        private int seatNumberInt;

        public user_interface_main(string ID, int user_type, string seat_number)
        {
            InitializeComponent();
            //타이머 작동 함수
            InitializeTimer();
            userID = ID;
            userType = user_type;
            seatNumber = seat_number;
            //회원 로그인
            if (user_type == 0)
            {
                //로그인 폼에서 받아온 ID 기반 유저 정보 넣기
                User user = Model.DatabaseAut.UserData(ID);
                label1.Text = "회원 요금제";
                //유저 정보 기반 유저명 호출 및 표시
                label3.Text = user.Name;

            }
            //자리 번호
            label8.Text = seat_number;

            timeTable1.SetRowClickEventHandler(dataGridViewTimeTable_CellDoubleClick);
            InitialConnection(ID);

        }

        private async void InitialConnection(string ID)
        {
            User user = Model.DatabaseAut.UserData(ID);
            var clientWrapper = await ClientWrapper.Instance;

            int timeAsInt;
            bool isTimeValid = int.TryParse(user.Time, out timeAsInt);

            bool isSeatNumberValid = int.TryParse(seatNumber, out seatNumberInt);

            if (!isTimeValid || timeAsInt <= 0)
            {
                // Time is either not a number, empty, or a negative/zero number
                await clientWrapper.ReserveUserAsync(ID, seatNumberInt);
            }
            else
            {
                await clientWrapper.ActivateUserAsync(ID, seatNumberInt);
            }
            clientWrapper.ClearLogoutCommandReceived();
            clientWrapper.LogoutCommandReceived += LogoutCommandHandler;
        }

        private async void dataGridViewTimeTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Check if the click is on a row, not the column header
            if (e.RowIndex != -1) // Header row has RowIndex -1
            {
                // Cast sender to DataGridView and get the current row
                var dataGridView = sender as DataGridView;
                if (dataGridView != null)
                {
                    DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                    // Perform the action you need on row click
                    // For example, you can retrieve the data using the row index and show it
                    // var subscriptionTime = row.Cells["time"].Value.ToString();
                    // var subscriptionName = row.Cells["name"].Value.ToString();
                    // var memberPrice = row.Cells["member_price"].Value.ToString();

                    int subscriptionTime = 0; // Initialize with a default value

                    if (row.Cells["time"].Value != null)
                    {
                        // Use int.TryParse for a safe conversion
                        bool isConverted = int.TryParse(row.Cells["time"].Value.ToString(), out subscriptionTime);

                        if (!isConverted)
                        {
                            // Handle the case where the conversion fails
                            MessageBox.Show("The value in 'time' cell is not a valid integer.");
                        }
                    }

                    var clientWrapper = await ClientWrapper.Instance;
                    // await clientWrapper.DeactivateUserAsync();
                    // DatabaseAut.SetUserTime(userID, subscriptionTime);
                    await clientWrapper.AddTimeAync(userID, seatNumberInt, subscriptionTime);
                    // await Task.Delay(50); 
                    // await clientWrapper.ActivateUserAsync(userID, seatNumberInt);
                    MessageBox.Show("결제 완료, 시간 추가 완료");

                }
            }

            return;
        }

        //타이머 함수
        private void InitializeTimer()
        {
            // 타이머 생성
            timer = new Timer();

            // 타이머 간격 설정 (1초 = 1000밀리초)
            timer.Interval = 1000;

            // 타이머 이벤트 핸들러 등록
            timer.Tick += Timer_Tick;

            // 타이머 시작
            timer.Start();
        }

        //타이머 이벤트 핸들러
        private void Timer_Tick(object sender, EventArgs e)
        {
            // 시간 업데이트 메서드 호출
            UpdateTime(userID, userType, seatNumber);
        }
        //시간 업데이트 함수
        private void UpdateTime(string userID, int userType, string seatNumber)
        {
            // GetUesrTime을 통해 남은 시간을 초 단위로 받아옴
            int remainingTimeInSeconds = Model.DatabaseAut.GetUesrTime(userID);

            if (remainingTimeInSeconds <= 0)
            {
                label6.Text = "예약중";
            }
            else
            {
                // 남은 시간을 시, 분, 초로 변환
                int hours = remainingTimeInSeconds / 3600;
                int minutes = (remainingTimeInSeconds % 3600) / 60;
                int seconds = remainingTimeInSeconds % 60;

                // 시간을 00:00:00 형태의 문자열로 변환
                string formattedTime = $"{hours:D2}:{minutes:D2}:{seconds:D2}";

                // label6에 남은 시간 표시
                label6.Text = formattedTime;
            }
        }

        //요리 주문 버튼 클릭 시
        private void buttonOrderFood(object sender, EventArgs e)
        {
            ManageFoodChildUser manageFoodChildUser = new ManageFoodChildUser(seatNumber);
            manageFoodChildUser.ShowDialog();
        }
        //사용 종료 버튼 클릭 시
        private async void buttonLogOut(object sender, EventArgs e)
        {
            DatabaseAut.DeleteOrder(seatNumber);
            login login = new login();
            login.Show();

            var clientWrapper = await ClientWrapper.Instance;
            await clientWrapper.DeactivateUserAsync();
            this.Close();
        }
        private void LogoutCommandHandler()
        {
            // Call buttonLogOut or directly the logic inside it
            buttonLogOut(this, EventArgs.Empty);
        }


        // 폼이 닫힐 때 타이머 정리
        protected async override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
        }

        //프로그램 종료 추가 기능
        private void appCloseButton1_Load(object sender, EventArgs e)
        {
            //프로그램 종료시 필요한 기능이 있다면 여기 추가
            DatabaseAut.DeleteOrder(seatNumber);
        }

        //랭킹 보기 버튼 클릭 시
        private void buttonViewRankings(object sender, EventArgs e)
        {
            user_interface_rank user_Interface_Rank = new user_interface_rank();
            user_Interface_Rank.ShowDialog();
        }

        //주문 목록 버튼 클릭 시
        private void buttonViewOrderList(object sender, EventArgs e)
        {
            User_Order_list_form user_Order_list_Form = new User_Order_list_form(seatNumber);
            user_Order_list_Form.ShowDialog();
        }
    }
}
