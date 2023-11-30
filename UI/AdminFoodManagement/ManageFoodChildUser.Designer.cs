namespace SeaStory.UI.AdminFoodManagement
{
    partial class ManageFoodChildUser
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
            buttonPay = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPay
            // 
            buttonPay.Location = new System.Drawing.Point(28, 64);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new System.Drawing.Size(86, 40);
            buttonPay.TabIndex = 4;
            buttonPay.Text = "결제";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += MakePayment_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(28, 145);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(86, 40);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "취소";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += CloseButton_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonPay);
            panel1.Controls.Add(buttonCancel);
            panel1.Location = new System.Drawing.Point(656, 75);
            panel1.Margin = new System.Windows.Forms.Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(140, 334);
            panel1.TabIndex = 6;
            // 
            // ManageFoodChildUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "ManageFoodChildUser";
            Text = "ManageFoodChildUser";
            Controls.SetChildIndex(flowLayoutPanelMenuItems, 0);
            Controls.SetChildIndex(panel1, 0);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
    }
}