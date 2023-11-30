namespace SeaStory.UI.AdminFoodManagement
{
    partial class Food_Order_listForm
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
            label1 = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(37, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 28);
            label1.TabIndex = 0;
            label1.Text = "주문목록";
            // 
            // listView1
            // 
            listView1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new System.Drawing.Point(37, 63);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(606, 313);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(24, 197);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(101, 38);
            button1.TabIndex = 2;
            button1.Text = "주문 삭제";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonRemoveOrder;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(24, 64);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(101, 39);
            button2.TabIndex = 3;
            button2.Text = "새로고침";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonRefresh;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new System.Drawing.Point(648, 63);
            panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(152, 312);
            panel1.TabIndex = 4;
            // 
            // Food_Order_listForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "Food_Order_listForm";
            Text = "Food_Order_listForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}