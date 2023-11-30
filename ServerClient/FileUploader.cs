using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaStory.ServerClient
{
    public class FileUploader
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task UploadFileAsync(string filePath, Uri serverUri)
        {
            try
            {
                using (var content = new MultipartFormDataContent())
                {
                    // Load the file into a stream
                    var fileStream = new FileStream(filePath, FileMode.Open);
                    var streamContent = new StreamContent(fileStream);

                    // Add the file stream to the HTTP content
                    content.Add(streamContent, "file", Path.GetFileName(filePath));

                    // Post the data to the specified server URI
                    var response = await client.PostAsync(serverUri, content);

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("File uploaded successfully.");
                    }
                    else
                    {
                        Console.WriteLine("File upload failed: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in file upload: " + ex.Message);
            }
        }

        public static async Task TestRun()
        {
            var uploader = new FileUploader();
            //Uri serverUri = new Uri("http://webp.flykorea.kr:15000/upload");
            Uri serverUri = new Uri("http://15.165.43.43:15000/upload");
            await uploader.UploadFileAsync(@"C:\Users\fiasl\OneDrive - koreatech.ac.kr\Pictures\0e9e5b4a420173869c665c7b8ce1e449c2f0cc6218dbab3c3eb70d142d2dc0c9.jpeg", serverUri);
            //await uploader.UploadFileAsync(@"C:\Users\fiasl\OneDrive - koreatech.ac.kr\Pictures\18baf9cbed050e764.jpg", serverUri);
        }
    }
}
