namespace SeaStory.UI
{
    partial class user_interface_rank
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
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(37, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 28);
            label1.TabIndex = 0;
            label1.Text = "사용량 랭킹";
            // 
            // listView1
            // 
            listView1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new System.Drawing.Point(37, 78);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(606, 313);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(671, 78);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(101, 39);
            button2.TabIndex = 4;
            button2.Text = "새로고침";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonRefresh;
            // 
            // user_interface_rank
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "user_interface_rank";
            Text = "user_interface_rank";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
    }
}