using SeaStory.Model;
using SeaStory.ServerClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SeaStory.Model.DataCalss;


namespace SeaStory.UI.AdminFoodManagement
{
    public partial class AddFoodForm : Form
    {
        public Image FoodImage { get; private set; }
        public string FoodName { get; private set; }
        public decimal FoodPrice { get; private set; }
        public bool Confirm { get; private set; }
        private string selectedImagePath;

        public AddFoodForm()
        {
            InitializeComponent();
            Confirm = false;

        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;

                    // Load the image into a stream and then into the PictureBox, which doesn't lock the file
                    using (FileStream stream = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                    {
                        pictureBoxFoodImage.Image?.Dispose(); // Dispose the previous image if any
                        pictureBoxFoodImage.Image = Image.FromStream(stream);
                    }

                    FoodImage = pictureBoxFoodImage.Image;
                }
            }
        }

        private async void btnOK_Click_1(object sender, EventArgs e)
        {

            FoodName = txtBoxFoodName.Text;
            FoodPrice = numericUpDownFoodPrice.Value; // Assuming a NumericUpDown control for price input.
            Confirm = true;

            // Check if the selectedImagePath is null or empty
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("No image selected. Please select an image before proceeding.", "Image Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if no image is selected
            }


            FileUploader uploader = new FileUploader();
            Uri serverUri = new Uri("http://webp.flykorea.kr:55000/upload");
            await uploader.UploadFileAsync(selectedImagePath, serverUri);

            DatabaseAut.AddFood(FoodName, (int)FoodPrice, @"http://webp.flykorea.kr/~story/" + Path.GetFileName(selectedImagePath));
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
