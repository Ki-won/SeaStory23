using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static SeaStory.Model.DataCalss;
using User = SeaStory.Model.DataCalss.User;
using SeaStory.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Media;
namespace SeaStory.UI
{
    public partial class user_seat : Form
    {
        //user_type = 0 회원 유저


        private string userID;
        private int userType;
        private string selectedSeat;

        public user_seat(string ID, int user_type)
        {
            InitializeComponent();
            SoundPlayer simpleSound = new SoundPlayer(@"..\..\..\UI\tts\login.wav");
            simpleSound.Play();
            userID = ID;
            userType = user_type;

            InitializeUser();
            InitializeSeats();

            //버튼에 대한 정보 초기화 부분
            //DB에서 리스트 형태로 좌석 정보 받음
            //1. 빈자리인 경우 - 버튼 텍스트에 좌석 이름만 받음
            //2. 사용중 좌석이면서 사용 시간이 null인 경우 - 버튼 텍스트에 좌석 이름 \r\n 사용자명 , 버튼 상태 enable -false
            //3. 사용중 좌석이면서 사용 시간이 있는 경우 - 버튼 텍스트에 좌석 이름  \r\n 사용자명  \r\n 잔여 시간 , 버튼 상태 enable -false
        }
        private void InitializeUser()
        {
            //회원 로그인
            if (userType == 0)
            {
                //로그인 폼에서 받아온 ID 기반 유저 정보 넣기
                User user = Model.DatabaseAut.UserData(userID);

                //유저 정보 기반 유저명 호출 및 표시
                labelUserName.Text = user.Name;
            }

        }
        private void InitializeSeats()
        {
            //리스트 형태로 좌석 정보 받아오기
            List<Seat> seats = DatabaseNonAut.GetSeats();

            //잔여석 사용중 좌석 표시
            //사용석 갯수 구하는 함수
            int usedSeatsCount = seats.Count(seat => !string.IsNullOrEmpty(seat.UserID));
            int availableSeatsCount = seats.Count - usedSeatsCount;

            labelAvailableSeatCount.Text = availableSeatsCount.ToString();
            labelUsedSeatCount.Text = usedSeatsCount.ToString();

            seatPanel1.SetSeatClickHandler(button1_Click);


        }
        /*private void InitializeSeats()
        {
            List<Seat> seats = DatabaseNonAut.GetSeats();

            int usedSeatsCount = seats.Count(seat => !string.IsNullOrEmpty(seat.UserID));
            int availableSeatsCount = seats.Count - usedSeatsCount;

            label1.Text = availableSeatsCount.ToString(); // "잔여석" 레이블 업데이트
            label2.Text = usedSeatsCount.ToString(); // "사용중" 레이블 업데이트

            // FlowLayoutPanel 설정
            FlowLayoutPanel seatPanel1 = new FlowLayoutPanel
            {
                AutoScroll = true,
                Dock = DockStyle.Fill, // 패널을 부모 컨테이너 크기에 맞게 조정
                FlowDirection = FlowDirection.LeftToRight, // 흐름 방향 설정
                WrapContents = true, // 내용이 많을 경우 다음 줄로 넘김
                Location = new Point(10, 10), // 시작 위치 설정
                Size = new Size(780, 500) // 패널 크기 설정
            };

            this.Controls.Add(seatPanel1); // Form에 seatPanel1 추가

            foreach (var seat in seats)
            {
                Panel seatContainerPanel = new Panel
                {
                    Size = new Size(100, 100),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    Padding = new Padding(3)
                };

                System.Windows.Forms.Button seatButton = new System.Windows.Forms.Button
                {
                    Text = $"Seat {seat.SeatNumber}",
                    Dock = DockStyle.Fill,
                    Enabled = string.IsNullOrEmpty(seat.UserID)
                };

                seatButton.Click += (sender, e) => button1_Click(seat.UserID, userType, seat.SeatNumber.ToString());
                seatContainerPanel.Controls.Add(seatButton);

                seatPanel1.Controls.Add(seatContainerPanel); // FlowLayoutPanel에 패널 추가
            }
        }*/


        private void Back_Button_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }


        private void button1_Click(string userId, int userType, string seat)
        {
            user_interface_main user_Interface_main = new user_interface_main(userID, userType, seat);
            user_Interface_main.Show();
            this.Close();
        }

    }
}
