﻿using SeaStory.Model;
using System;
using System.Globalization;
using System.Windows.Forms;
using System.Media;
namespace SeaStory.ui
{
    public partial class UserInterFacePayment : Form
    {
        private string SeatID;
        public int PaymentResult { get; private set; }

        public UserInterFacePayment(string seat)
        {
            SeatID = seat;
            InitializeComponent();
        }

        public void SetPrice(int n)
        {
            labelPrice.Text = n.ToString("C", new CultureInfo("ko-KR"));
        }

        private void buttonCreditCard(object sender, EventArgs e)
        {
            // SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Administrator\Desktop\깃허브\SeaStory23\UI\tts\신용카드.wav");
            // simpleSound.Play();
            ProcessPayment();
        }

        private void buttonPayco(object sender, EventArgs e)
        {
            // SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Administrator\Desktop\깃허브\SeaStory23\UI\tts\페이코.wav");
            // simpleSound.Play();
            ProcessPayment();
        }

        private void buttonCash(object sender, EventArgs e)
        {
            // SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Administrator\Desktop\깃허브\SeaStory23\UI\tts\현금.wav");
            // simpleSound.Play();
            ProcessPayment();
        }

        private void ProcessPayment()
        {
            MessageBox.Show("결제되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PaymentResult = 1;
            this.Close();
        }

        //주문취소 버튼 클릭 시
        private void buttonCancelOrder(object sender, EventArgs e)
        {
            MessageBox.Show("주문이 취소되었습니다.", "주문 취소", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PaymentResult = 0;
            this.Close();

        }
    }
}
