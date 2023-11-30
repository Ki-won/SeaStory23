namespace SeaStory.ui
{
    partial class UserInterFacePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterFacePayment));
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            labelPrice = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.Location = new System.Drawing.Point(2, 2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(212, 194);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonCreditCard;
            // 
            // button2
            // 
            button2.BackgroundImage = (System.Drawing.Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button2.Location = new System.Drawing.Point(0, -1);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(213, 198);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonPayco;
            // 
            // button3
            // 
            button3.BackgroundImage = (System.Drawing.Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button3.Location = new System.Drawing.Point(-1, 1);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(225, 198);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonCash;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelPrice.Location = new System.Drawing.Point(37, 8);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new System.Drawing.Size(55, 28);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Price";
            // 
            // button4
            // 
            button4.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button4.ForeColor = System.Drawing.Color.Red;
            button4.Location = new System.Drawing.Point(633, 334);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(112, 46);
            button4.TabIndex = 4;
            button4.Text = "주문 취소";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonCancelOrder;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new System.Drawing.Point(49, 88);
            panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(697, 232);
            panel1.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel4.Controls.Add(button3);
            panel4.Location = new System.Drawing.Point(459, 14);
            panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(226, 202);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel3.Controls.Add(button2);
            panel3.Location = new System.Drawing.Point(235, 14);
            panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(220, 202);
            panel3.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.Controls.Add(button1);
            panel2.Location = new System.Drawing.Point(11, 14);
            panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(220, 202);
            panel2.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(labelPrice);
            panel5.Location = new System.Drawing.Point(49, 41);
            panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(131, 42);
            panel5.TabIndex = 6;
            // 
            // UserInterFacePayment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(button4);
            Name = "UserInterFacePayment";
            Text = "user_interface_pay";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
    }
}