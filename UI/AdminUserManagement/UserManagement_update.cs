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
using System.Xml.Linq;

namespace SeaStory.UI.AdminFoodManagement
{
    public partial class UserManagement_update : Form
    {
        private string ID;
        public UserManagement_update(string ID_set, string NAME, string PW, string PHONE)
        {
            InitializeComponent();
            ID = ID_set;
            ID_Box.Text = ID_set;
            NAME_Box.Text = NAME;
            PW_Box.Text = PW;
            PHONE_Box.Text = PHONE;

        }


        //정보 수정 버튼 클릭 시
        private void button2_Click(object sender, EventArgs e)
        {
            bool trigger = true; // trigger를 true로 초기화
            do
            {

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

            } while (false); // 한 번 실행하고 루프를 탈출

            if (trigger)
            {
                // 모든 조건이 성립한 경우에만 특별한 함수를 실행하고 폼을 종료
                DatabaseAut.UpdateUser(ID, NAME_Box.Text, PW_Box.Text, PHONE_Box.Text);
                // 폼 종료
                this.Close();
            }

        }
        //닫기 버튼 클릭 시
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
