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
        public ShowPicture()
        {
            InitializeComponent();
        }
        public void SetImageUpload(string link)
        {
            Image temp = Image.FromFile(link);
            fileUploadPicture.Image = temp;
            previewPicture.AddPicture(temp);
            /*
            previewPicture.AddPicture(temp);
            previewPicture.AddPicture(temp);
            previewPicture.AddPicture(temp);
            previewPicture.AddPicture(temp);
            previewPicture.AddPicture(temp);
            previewPicture.AddPicture(temp);
            previewPicture.AddPicture(temp);
            previewPicture.AddPicture(temp);
            previewPicture.AddPicture(temp);
            */
        }
        public void SetImageUpload(Image image)
        {
            fileUploadPicture.Image = image;
        }

        public void SetSelectedImage(Image image)
        {
            fileSelectedPicture.Image = image;
        }

    }
}
