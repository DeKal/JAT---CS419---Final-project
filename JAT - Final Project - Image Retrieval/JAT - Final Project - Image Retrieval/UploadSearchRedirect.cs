using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace JAT___Final_Project___Image_Retrieval
{
    public partial class UploadSearchRedirect : UserControl
    {
        static private PictureBox selectedImage = null;

        static public void setSeletectedImagePictureBox(PictureBox selectImage)
        {
            selectedImage = selectImage;
        }

        public UploadSearchRedirect()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // check if has picture
            if (selectedImage.Image == null)
            {
                MessageBox.Show("No image selected.", "Error");
                return;
            }

            String filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\retrieval engine\image.jpg";

            // logic
            selectedImage.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);

            //// show result
            //this.Hide();
            //Program.CurrentResultForm = new ResultForm(currentFileUploadLink);
            //Program.CurrentResultForm.Show();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            Program.SearchForm.Show();
            Program.CurrentResultForm.Close();
        }
    }
}
