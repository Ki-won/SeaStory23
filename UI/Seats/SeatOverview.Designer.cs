namespace SeaStory.UI.Seats
{
    partial class SeatOverview
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
            seatPanel1 = new SeatPanel();
            SuspendLayout();
            // 
            // seatPanel1
            // 
            seatPanel1.Location = new System.Drawing.Point(97, 39);
            seatPanel1.Name = "seatPanel1";
            seatPanel1.Size = new System.Drawing.Size(620, 383);
            seatPanel1.TabIndex = 0;
            seatPanel1.Load += seatPanel1_Load;
            // 
            // SeatOverview
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(seatPanel1);
            DoubleBuffered = true;
            Name = "SeatOverview";
            Text = "SeatOverview";
            ResumeLayout(false);
        }

        #endregion

        private SeatPanel seatPanel1;
    }
}