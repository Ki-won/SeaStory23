﻿namespace SeaStory.UI.AdminFoodManagement
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
            title = new System.Windows.Forms.Label();
            flowLayoutPanelMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new System.Drawing.Point(49, 33);
            title.Name = "title";
            title.Size = new System.Drawing.Size(58, 15);
            title.TabIndex = 0;
            title.Text = "음식 목록";
            // 
            // flowLayoutPanelMenuItems
            // 
            flowLayoutPanelMenuItems.AutoScroll = true;
            flowLayoutPanelMenuItems.Location = new System.Drawing.Point(49, 75);
            flowLayoutPanelMenuItems.Name = "flowLayoutPanelMenuItems";
            flowLayoutPanelMenuItems.Size = new System.Drawing.Size(601, 334);
            flowLayoutPanelMenuItems.TabIndex = 3;
            // 
            // ManageFoodParent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(flowLayoutPanelMenuItems);
            Controls.Add(title);
            Name = "ManageFoodParent";
            Text = "ManageFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label title;
        protected System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuItems;
    }
}