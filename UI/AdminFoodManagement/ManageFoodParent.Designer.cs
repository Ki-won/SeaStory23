namespace SeaStory.UI.AdminFoodManagement
{
    partial class ManageFoodParent
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
            this.title = new System.Windows.Forms.Label();
            this.flowLayoutPanelMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(63, 44);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(74, 20);
            this.title.TabIndex = 0;
            this.title.Text = "음식 목록";
            // 
            // flowLayoutPanelMenuItems
            // 
            this.flowLayoutPanelMenuItems.AutoScroll = true;
            this.flowLayoutPanelMenuItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelMenuItems.Location = new System.Drawing.Point(63, 100);
            this.flowLayoutPanelMenuItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelMenuItems.Name = "flowLayoutPanelMenuItems";
            this.flowLayoutPanelMenuItems.Size = new System.Drawing.Size(773, 445);
            this.flowLayoutPanelMenuItems.TabIndex = 3;
            // 
            // ManageFoodParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 600);
            this.Controls.Add(this.flowLayoutPanelMenuItems);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageFoodParent";
            this.Text = "ManageFood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        protected System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuItems;
    }
}