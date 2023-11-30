namespace SeaStory.UI
{
    partial class User_Order_list_form
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
            button2 = new System.Windows.Forms.Button();
            listView1 = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(11, 18);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(101, 39);
            button2.TabIndex = 6;
            button2.Text = "새로고침";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonRefreshClick;
            // 
            // listView1
            // 
            listView1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new System.Drawing.Point(30, 89);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(606, 313);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(17, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 28);
            label1.TabIndex = 4;
            label1.Text = "좌석";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(75, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(166, 28);
            label2.TabIndex = 7;
            label2.Text = "번 좌석 주문목록";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(11, 70);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(101, 39);
            button1.TabIndex = 8;
            button1.Text = "닫기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonCloseClick;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(30, 26);
            panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(279, 59);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new System.Drawing.Point(641, 89);
            panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(124, 312);
            panel2.TabIndex = 10;
            // 
            // User_Order_list_form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Name = "User_Order_list_form";
            Text = "User_Order_list_form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}