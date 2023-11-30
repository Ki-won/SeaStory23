namespace SeaStory.UI.Seats
{
    partial class Seat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRemainingTime = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelSeatNum = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelRemainingTime);
            this.panel1.Controls.Add(this.labelUser);
            this.panel1.Controls.Add(this.labelSeatNum);
            this.panel1.Controls.Add(this.buttonSelect);
            this.panel1.Location = new System.Drawing.Point(18, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 169);
            this.panel1.TabIndex = 4;
            // 
            // labelRemainingTime
            // 
            this.labelRemainingTime.AutoSize = true;
            this.labelRemainingTime.Location = new System.Drawing.Point(56, 85);
            this.labelRemainingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRemainingTime.Name = "labelRemainingTime";
            this.labelRemainingTime.Size = new System.Drawing.Size(42, 20);
            this.labelRemainingTime.TabIndex = 7;
            this.labelRemainingTime.Text = "Time";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(56, 50);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(24, 20);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "ID";
            // 
            // labelSeatNum
            // 
            this.labelSeatNum.AutoSize = true;
            this.labelSeatNum.Location = new System.Drawing.Point(42, 16);
            this.labelSeatNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeatNum.Name = "labelSeatNum";
            this.labelSeatNum.Size = new System.Drawing.Size(69, 20);
            this.labelSeatNum.TabIndex = 5;
            this.labelSeatNum.Text = "자리번호";
            this.labelSeatNum.Click += new System.EventHandler(this.labelSeatNum_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(28, 127);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(96, 31);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "선택";
            this.buttonSelect.UseVisualStyleBackColor = true;
            // 
            // Seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Seat";
            this.Size = new System.Drawing.Size(193, 200);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRemainingTime;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelSeatNum;
        private System.Windows.Forms.Button buttonSelect;
    }
}
