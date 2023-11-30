namespace SeaStory.UI.AdminFoodManagement
{
    partial class ManageFoodChildAdmin
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
            System.Windows.Forms.Button buttonAddFood;
            buttonDeleteFood = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            buttonAddFood = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddFood
            // 
            buttonAddFood.Location = new System.Drawing.Point(26, 60);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new System.Drawing.Size(85, 37);
            buttonAddFood.TabIndex = 4;
            buttonAddFood.Text = "음식 추가";
            buttonAddFood.UseVisualStyleBackColor = true;
            buttonAddFood.Click += buttonAddFood_Click;
            // 
            // buttonDeleteFood
            // 
            buttonDeleteFood.Location = new System.Drawing.Point(26, 117);
            buttonDeleteFood.Name = "buttonDeleteFood";
            buttonDeleteFood.Size = new System.Drawing.Size(85, 37);
            buttonDeleteFood.TabIndex = 5;
            buttonDeleteFood.Text = "음식 삭제";
            buttonDeleteFood.UseVisualStyleBackColor = true;
            buttonDeleteFood.Click += buttonDeleteFood_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonAddFood);
            panel1.Controls.Add(buttonDeleteFood);
            panel1.Location = new System.Drawing.Point(656, 75);
            panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(136, 334);
            panel1.TabIndex = 6;
            // 
            // ManageFoodChildAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "ManageFoodChildAdmin";
            Text = "ManageFoodChildAdmin";
            Controls.SetChildIndex(flowLayoutPanelMenuItems, 0);
            Controls.SetChildIndex(panel1, 0);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonAddFood;
        private System.Windows.Forms.Button buttonDeleteFood;
        private System.Windows.Forms.Panel panel1;
    }
}