using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaStory.UI.Seats
{
    public partial class Seat : UserControl
    {
        // Properties to store seat data
        public int SeatNumber { get; private set; }
        public string UserID { get; private set; }
        public string UsageTime { get; private set; }

        private EventHandler seatClickEventHandler;

        public Seat()
        {
            InitializeComponent();
        }

        public Seat(int seatNumber, string userID, string usageTime, string buttonText="선택")
            : this() // Calls the default constructor to initialize components
        {
            // Store the parameters
            SeatNumber = seatNumber;
            UserID = userID;
            UsageTime = usageTime;

            buttonSelect.Text = buttonText;
            // Update UI elements with the stored data
            labelSeatNum.Text = seatNumber.ToString();
            labelUser.Text = userID;

            if (int.TryParse(usageTime, out int usageTimeSeconds))
            {
                // Format and update the labelRemainingTime
                labelRemainingTime.Text = FormatTime(usageTimeSeconds);
            }
            else
            {
                // Handle the case where usageTime is not a valid integer
                labelRemainingTime.Text = "";
            }
        }

        public void UpdateSeat(int seatNumber, string userID, string usageTime, bool disableEmtpySeatButton=true)
        {
            // Update properties
            SeatNumber = seatNumber;
            UserID = userID;
            UsageTime = usageTime;

            // Update UI elements
            labelSeatNum.Text = seatNumber.ToString();
            labelUser.Text = userID;

            if (int.TryParse(usageTime, out int usageTimeSeconds))
            {
                labelRemainingTime.Text = FormatTime(usageTimeSeconds);
                buttonSelect.Enabled = !disableEmtpySeatButton;
            }
            else
            {
                labelRemainingTime.Text = "";
                buttonSelect.Enabled = disableEmtpySeatButton;
            }
        }


        public static string FormatTime(int totalSeconds)
        {
            if (totalSeconds < 0)
                return "예약중";

            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            return string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
        }

        // fix later
        public void AttachEventHandler(SeatPanel.SeatClickHandler onSeatClick)
        {
            // Detach existing event handler to prevent duplicates
            DetachEventHandler();

            // Create a new delegate with the specified handler
            seatClickEventHandler = (sender, e) => onSeatClick(UserID, 0, SeatNumber.ToString());

            // Attach the new event handler
            buttonSelect.Click += seatClickEventHandler;
        }
        public void DetachEventHandler()
        {
            if (seatClickEventHandler != null)
            {
                // Remove the event handler
                buttonSelect.Click -= seatClickEventHandler;
                seatClickEventHandler = null;
            }
        }

        private void labelSeatNum_Click(object sender, EventArgs e)
        {

        }
    }
}