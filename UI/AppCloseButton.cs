using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace SeaStory.UI
{
    public partial class AppCloseButton : UserControl
    {
        public AppCloseButton()
        {
            InitializeComponent();
        }
        //종료 버튼 눌러졋을 때
        private async void button1_Click(object sender, EventArgs e)
        {
            // SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Administrator\Desktop\깃허브\SeaStory23\UI\tts\종료.wav");
            
            var clientWrapper = await ClientWrapper.Instance;
            await clientWrapper.DeactivateUserAsync();
            await clientWrapper.CloseAsync();
            Application.Exit();
        }
    }
}
