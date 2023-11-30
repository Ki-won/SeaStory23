using SeaStory.ui;
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

namespace SeaStory
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            Panel loginPanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle, // 테두리 스타일 설정
                Size = new Size(500, 300), // Panel의 크기 설정
                Location = new Point(10, 150) // 폼 내에서 Panel의 위치 설정
            };

            // 기존 컨트롤들을 Panel에 추가
            loginPanel.Controls.Add(label1); // 아이디 라벨
            loginPanel.Controls.Add(textBox1); // 아이디 입력 필드
            loginPanel.Controls.Add(label2); // 비밀번호 라벨
            loginPanel.Controls.Add(textBox2); // 비밀번호 입력 필드
            loginPanel.Controls.Add(button1); // 로그인 버튼

            // 컨트롤들의 위치를 Panel 내에서 조정해야 할 수 있습니다.
            // 예를 들어, 다음과 같이 조정할 수 있습니다.
            label1.Location = new Point(10, 20); // Panel 기준 새로운 위치
            textBox1.Location = new Point(10, 45);
            label2.Location = new Point(10, 100);
            textBox2.Location = new Point(10, 125);
            button1.Location = new Point(10, 160);

            // Panel을 Form의 Controls 컬렉션에 추가
            this.Controls.Add(loginPanel);

            // Panel 내부의 컨트롤들이 Panel에 맞춰서 움직이도록 설정
            label1.Parent = loginPanel;
            textBox1.Parent = loginPanel;
            label2.Parent = loginPanel;
            textBox2.Parent = loginPanel;
            button1.Parent = loginPanel;

            // Panel을 가장 앞으로 가져옵니다.
            loginPanel.BringToFront();

            //초기값
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox2.BorderStyle = BorderStyle.FixedSingle; 

            // KeyDown 이벤트 등록
            this.AcceptButton = button1;
        }

        //회원가입 버튼 클릭
        private void register_Click(object sender, EventArgs e)
        {
            //회원 가입 폼 열기
            user_interface user_Interface = new user_interface();
            user_Interface.ShowDialog();
        }

        // 로그인 버튼 클릭 또는 Enter 키 누를 때 실행되는 이벤트
        private void button1_Click(object sender, EventArgs e)
        {

            //회원 로그인
            if (radioButton1.Checked)
            {
                //로그인 부분
                int login_check = Model.DatabaseAut.UserCheck(textBox1.Text, textBox2.Text);

                if (login_check == 1)
                {
                    //관리자 체크를 받아야 하기 때문에 유저 정보 받기
                    User user = Model.DatabaseAut.UserData(textBox1.Text);

                    //관리자 체크
                    if (user.UserType == true)
                    {
                        //관리자 폼 열기
                        admin_inter_main admin_Inter_Main = new admin_inter_main();
                        admin_Inter_Main.Show();
                        this.Close();
                    }
                    else
                    {
                        //자리 선택 폼으로 이동
                        user_seat user_Seat = new user_seat(textBox1.Text, 0);
                        user_Seat.Show();
                        this.Close();
                    }
                }
                //로그인 실패
                else
                {
                    MessageBox.Show("로그인 정보가 잘못되었습니다!", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

    }
}
