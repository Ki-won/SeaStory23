namespace SeaStory.UI.AdminFoodManagement
{
    partial class MenuItemControl
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
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            this.labelFoodName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxFood);
            this.panel1.Controls.Add(this.labelFoodName);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 205);
            this.panel1.TabIndex = 3;
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.Location = new System.Drawing.Point(26, 4);
            this.pictureBoxFood.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(131, 121);
            this.pictureBoxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFood.TabIndex = 5;
            this.pictureBoxFood.TabStop = false;
            // 
            // labelFoodName
            // 
            this.labelFoodName.AutoSize = true;
            this.labelFoodName.Location = new System.Drawing.Point(49, 129);
            this.labelFoodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFoodName.Name = "labelFoodName";
            this.labelFoodName.Size = new System.Drawing.Size(74, 20);
            this.labelFoodName.TabIndex = 4;
            this.labelFoodName.Text = "음식 이름";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(59, 163);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(64, 20);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "10000원";
            // 
            // MenuItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuItemControl";
            this.Size = new System.Drawing.Size(186, 211);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.Label labelFoodName;
        private System.Windows.Forms.Label labelPrice;
    }
}
