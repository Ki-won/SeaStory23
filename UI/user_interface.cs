using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Media;
namespace SeaStory
{
    public partial class user_interface : Form
    {
        //중복 확인 체크 토클
        bool duplication_checker = false;
        public user_interface()
        {
            InitializeComponent();
        }

        //닫기 버튼 클릭 시 이벤트
        private void buttonClose(object sender, EventArgs e)
        {
            this.Close();
        }

        //등록 버튼 클릭 시 이벤트
        private void buttonRegister(object sender, EventArgs e)
        {
            bool trigger = true; // trigger를 true로 초기화

            do
            {
                // 1. ID_Box.text = null 체크
                if (string.IsNullOrWhiteSpace(ID_Box.Text))
                {
                    MessageBox.Show("ID가 입력되지 않았습니다!", "ID 입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    trigger = false; // trigger를 false로 변경
                    break;
                }

                // 2. 중복 확인 체크 여부 체크
                if (duplication_checker == false)
                {
                    MessageBox.Show("ID 중복체크가 이루어 지지 않았습니다!", "ID 중복 체크 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    trigger = false; // trigger를 false로 변경
                    break;
                }

                // 3. PW_Box.text = null 체크
                if (string.IsNullOrWhiteSpace(PW_Box.Text))
                {
                    MessageBox.Show("비밀번호가 입력되지 않았습니다!", "비밀번호 입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    trigger = false; // trigger를 false로 변경
                    break;
                }

                // 4. PW_Box2.text == PW_Box.text 체크
                if (PW_Box.Text != PW_Box2.Text)
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다!", "비밀번호 일치 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    trigger = false; // trigger를 false로 변경
                    break;
                }

                // 5. NAME_Box = null 체크
                if (string.IsNullOrWhiteSpace(NAME_Box.Text))
                {
                    MessageBox.Show("이름이 입력되지 않았습니다!", "이름 입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    trigger = false; // trigger를 false로 변경
                    break;
                }

                // 6. PHONE_Box = null 체크
                if (string.IsNullOrWhiteSpace(PHONE_Box.Text))
                {
                    MessageBox.Show("연락처가 입력되지 않았습니다!", "연락처 입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    trigger = false; // trigger를 false로 변경
                    break;
                }

                // 7. 본인 인증 체크 여부 체크 (생략)
            } while (false); // 한 번 실행하고 루프를 탈출

            if (trigger)
            {
                // 모든 조건이 성립한 경우에만 특별한 함수를 실행하고 폼을 종료
                // 회원 가입 함수 실행
                Model.DatabaseAut.RegisterUser(ID_Box.Text, NAME_Box.Text, PW_Box.Text, PHONE_Box.Text);
                SoundPlayer addsound = new SoundPlayer(@"..\..\..\UI\tts\좌석tts\addplayer.wav");
                addsound.Play();
                // 폼 종료
                this.Close();
            }
        }

        //중복 확인 버튼 클릭 시 이벤트
        private void buttonCheckDuplicate(object sender, EventArgs e)
        {
            //ID_Box.text 값을 통해 유저 검색후
            //유저가 null이 아니면 이미 등록된 아이디입니다! 메세지 박스 출력
            //유저가 null인 경우 사용가능한 아이디입니다! 메세지 박스 출력후 중복 확인 체크 토글
            if (Model.DatabaseAut.IDCheck(ID_Box.Text) == -1)
            {

                duplication_checker = true;
                MessageBox.Show("사용 가능한 아이디입니다!", "ID 사용 가능", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("이미 등록된 아이디입니다!", "ID 정보 중복", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        //ID_Box 내용 수정되었을 때
        private void ID_Box_TextChanged(object sender, EventArgs e)
        {
            //중복 확인 체크 토글
            duplication_checker = false;
        }
    }
}
