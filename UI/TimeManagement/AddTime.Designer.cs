namespace SeaStory.UI.TimeManagement
{
    partial class AddTime
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
            textBoxName = new System.Windows.Forms.TextBox();
            labelTime = new System.Windows.Forms.Label();
            labelMemberPrice = new System.Windows.Forms.Label();
            labelName = new System.Windows.Forms.Label();
            buttonAddTime = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(178, 83);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(120, 23);
            textBoxName.TabIndex = 2;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new System.Drawing.Point(86, 39);
            labelTime.Name = "labelTime";
            labelTime.Size = new System.Drawing.Size(58, 15);
            labelTime.TabIndex = 3;
            labelTime.Text = "추가 시간";
            // 
            // labelMemberPrice
            // 
            labelMemberPrice.AutoSize = true;
            labelMemberPrice.Location = new System.Drawing.Point(86, 135);
            labelMemberPrice.Name = "labelMemberPrice";
            labelMemberPrice.Size = new System.Drawing.Size(58, 15);
            labelMemberPrice.TabIndex = 4;
            labelMemberPrice.Text = "회원 요금";
            labelMemberPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new System.Drawing.Point(86, 86);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(58, 15);
            labelName.TabIndex = 5;
            labelName.Text = "요금제 명";
            // 
            // buttonAddTime
            // 
            buttonAddTime.Location = new System.Drawing.Point(86, 203);
            buttonAddTime.Name = "buttonAddTime";
            buttonAddTime.Size = new System.Drawing.Size(75, 23);
            buttonAddTime.TabIndex = 6;
            buttonAddTime.Text = "등록";
            buttonAddTime.UseVisualStyleBackColor = true;
            buttonAddTime.Click += buttonAddTime_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(192, 203);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(75, 23);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "취소";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // numericUpDownTime
            // 
            numericUpDownTime.Location = new System.Drawing.Point(178, 31);
            numericUpDownTime.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownTime.Name = "numericUpDownTime";
            numericUpDownTime.Size = new System.Drawing.Size(120, 23);
            numericUpDownTime.TabIndex = 8;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new System.Drawing.Point(178, 133);
            numericUpDownPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new System.Drawing.Size(120, 23);
            numericUpDownPrice.TabIndex = 9;
            // 
            // AddTime
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(367, 281);
            Controls.Add(numericUpDownPrice);
            Controls.Add(numericUpDownTime);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAddTime);
            Controls.Add(labelName);
            Controls.Add(labelMemberPrice);
            Controls.Add(labelTime);
            Controls.Add(textBoxName);
            Name = "AddTime";
            Text = "AddTime";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelMemberPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAddTime;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
    }
}