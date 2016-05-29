using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAT___Final_Project___Image_Retrieval
{
    public partial class ShowPicture : UserControl
    {
        static public PreviewPicture preview = null;
        static public PictureBox selected = null;
        static public ShowPicture self = null;
        public ShowPicture()
        {
            InitializeComponent();
            // static stuff
            preview = previewPicture;
            selected = fileSelectedPicture;
            self = this;
        }
        public void SetImageUpload(string link)
        {
            Image temp = Image.FromFile(link);
            fileUploadPicture.Image = temp;
            previewPicture.AddPicture(temp);
        }
        public void SetImageUpload(Image image)
        {
            fileUploadPicture.Image = image;
        }

        public void SetSelectedImage(Image image)
        {
            fileSelectedPicture.Image = image;
        }
        public void saveSelectedImage()
        {
            fileSelectedPicture.Image.Save(SearchForm.path + @"\image.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

    }
}
