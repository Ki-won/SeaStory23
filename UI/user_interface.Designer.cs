﻿
namespace SeaStory
{
    partial class user_interface
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
            ID_Box = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            PW_Box = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            PHONE_Box = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            NAME_Box = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            PW_Box2 = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            CloseButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ID_Box
            // 
            ID_Box.Location = new System.Drawing.Point(155, 77);
            ID_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ID_Box.Name = "ID_Box";
            ID_Box.Size = new System.Drawing.Size(100, 23);
            ID_Box.TabIndex = 0;
            ID_Box.TextChanged += ID_Box_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.White;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(31, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 30);
            label1.TabIndex = 1;
            label1.Text = "아이디";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label2.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(31, 155);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 30);
            label2.TabIndex = 3;
            label2.Text = "비밀번호";
            // 
            // PW_Box
            // 
            PW_Box.Location = new System.Drawing.Point(155, 163);
            PW_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PW_Box.Name = "PW_Box";
            PW_Box.Size = new System.Drawing.Size(100, 23);
            PW_Box.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label3.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(31, 311);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 30);
            label3.TabIndex = 5;
            label3.Text = "연락처";
            // 
            // PHONE_Box
            // 
            PHONE_Box.Location = new System.Drawing.Point(155, 318);
            PHONE_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PHONE_Box.Name = "PHONE_Box";
            PHONE_Box.Size = new System.Drawing.Size(100, 23);
            PHONE_Box.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.White;
            label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label4.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(31, 231);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 30);
            label4.TabIndex = 7;
            label4.Text = "이름";
            // 
            // NAME_Box
            // 
            NAME_Box.Location = new System.Drawing.Point(155, 238);
            NAME_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            NAME_Box.Name = "NAME_Box";
            NAME_Box.Size = new System.Drawing.Size(100, 23);
            NAME_Box.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.Location = new System.Drawing.Point(261, 73);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 29);
            button1.TabIndex = 8;
            button1.Text = "중복확인";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label5.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(327, 156);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(141, 30);
            label5.TabIndex = 10;
            label5.Text = "비밀번호 확인";
            // 
            // PW_Box2
            // 
            PW_Box2.Location = new System.Drawing.Point(479, 163);
            PW_Box2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PW_Box2.Name = "PW_Box2";
            PW_Box2.Size = new System.Drawing.Size(100, 23);
            PW_Box2.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.White;
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button3.ForeColor = System.Drawing.Color.Red;
            button3.Location = new System.Drawing.Point(213, 426);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(84, 80);
            button3.TabIndex = 12;
            button3.Text = "등록";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = System.Drawing.Color.White;
            CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            CloseButton.ForeColor = System.Drawing.Color.Red;
            CloseButton.Location = new System.Drawing.Point(410, 426);
            CloseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new System.Drawing.Size(87, 80);
            CloseButton.TabIndex = 13;
            CloseButton.Text = "취소";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += button4_Click;
            // 
            // user_interface
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(CloseButton);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(PW_Box2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(NAME_Box);
            Controls.Add(label3);
            Controls.Add(PHONE_Box);
            Controls.Add(label2);
            Controls.Add(PW_Box);
            Controls.Add(label1);
            Controls.Add(ID_Box);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "user_interface";
            Text = "user_interface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PW_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PHONE_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NAME_Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PW_Box2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button CloseButton;
    }
}