namespace SeaStory.UI
{
    partial class user_seat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            seat_opend = new System.Windows.Forms.Label();
            seat_used = new System.Windows.Forms.Label();
            labelAvailableSeatCount = new System.Windows.Forms.Label();
            labelUsedSeatCount = new System.Windows.Forms.Label();
            Back_Button = new System.Windows.Forms.Button();
            labelUserName = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            appCloseButton1 = new AppCloseButton();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            seatPanel1 = new Seats.SeatPanel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // seat_opend
            // 
            seat_opend.AutoSize = true;
            seat_opend.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            seat_opend.Location = new System.Drawing.Point(16, 16);
            seat_opend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            seat_opend.Name = "seat_opend";
            seat_opend.Size = new System.Drawing.Size(58, 21);
            seat_opend.TabIndex = 1;
            seat_opend.Text = "잔여석";
            // 
            // seat_used
            // 
            seat_used.AutoSize = true;
            seat_used.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            seat_used.ForeColor = System.Drawing.Color.Red;
            seat_used.Location = new System.Drawing.Point(165, 16);
            seat_used.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            seat_used.Name = "seat_used";
            seat_used.Size = new System.Drawing.Size(58, 21);
            seat_used.TabIndex = 2;
            seat_used.Text = "사용중";
            // 
            // labelAvailableSeatCount
            // 
            labelAvailableSeatCount.AutoSize = true;
            labelAvailableSeatCount.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelAvailableSeatCount.Location = new System.Drawing.Point(16, 84);
            labelAvailableSeatCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelAvailableSeatCount.Name = "labelAvailableSeatCount";
            labelAvailableSeatCount.Size = new System.Drawing.Size(19, 21);
            labelAvailableSeatCount.TabIndex = 3;
            labelAvailableSeatCount.Text = "0";
            // 
            // labelUsedSeatCount
            // 
            labelUsedSeatCount.AutoSize = true;
            labelUsedSeatCount.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelUsedSeatCount.Location = new System.Drawing.Point(165, 84);
            labelUsedSeatCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelUsedSeatCount.Name = "labelUsedSeatCount";
            labelUsedSeatCount.Size = new System.Drawing.Size(19, 21);
            labelUsedSeatCount.TabIndex = 4;
            labelUsedSeatCount.Text = "0";
            // 
            // Back_Button
            // 
            Back_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Back_Button.Location = new System.Drawing.Point(48, 214);
            Back_Button.Margin = new System.Windows.Forms.Padding(4);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new System.Drawing.Size(141, 48);
            Back_Button.TabIndex = 99;
            Back_Button.Text = "뒤로 가기";
            Back_Button.UseVisualStyleBackColor = true;
            Back_Button.Click += Back_Button_Click;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelUserName.Location = new System.Drawing.Point(51, 41);
            labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new System.Drawing.Size(58, 21);
            labelUserName.TabIndex = 6;
            labelUserName.Text = "UserID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(174, 41);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(112, 21);
            label4.TabIndex = 7;
            label4.Text = "님 환영합니다";
            // 
            // appCloseButton1
            // 
            appCloseButton1.BackColor = System.Drawing.Color.White;
            appCloseButton1.Location = new System.Drawing.Point(47, 531);
            appCloseButton1.Margin = new System.Windows.Forms.Padding(4);
            appCloseButton1.Name = "appCloseButton1";
            appCloseButton1.Size = new System.Drawing.Size(142, 43);
            appCloseButton1.TabIndex = 100;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(seat_opend);
            panel2.Controls.Add(seat_used);
            panel2.Controls.Add(labelAvailableSeatCount);
            panel2.Controls.Add(labelUsedSeatCount);
            panel2.Location = new System.Drawing.Point(47, 45);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(250, 125);
            panel2.TabIndex = 102;
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(labelUserName);
            panel3.Controls.Add(label4);
            panel3.Location = new System.Drawing.Point(315, 45);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(480, 125);
            panel3.TabIndex = 103;
            // 
            // seatPanel1
            // 
            seatPanel1.AutoSize = true;
            seatPanel1.Location = new System.Drawing.Point(213, 181);
            seatPanel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            seatPanel1.Name = "seatPanel1";
            seatPanel1.Size = new System.Drawing.Size(609, 432);
            seatPanel1.TabIndex = 104;
            // 
            // user_seat
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(845, 630);
            ControlBox = false;
            Controls.Add(seatPanel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(appCloseButton1);
            Controls.Add(Back_Button);
            Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "user_seat";
            Text = "user_seat";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label seat_opend;
        private System.Windows.Forms.Label seat_used;
        private System.Windows.Forms.Label labelAvailableSeatCount;
        private System.Windows.Forms.Label labelUsedSeatCount;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label4;
        private AppCloseButton appCloseButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Seats.SeatPanel seatPanel1;
    }
}