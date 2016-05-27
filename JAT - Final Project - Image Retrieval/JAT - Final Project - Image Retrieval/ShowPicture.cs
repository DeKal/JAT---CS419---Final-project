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
            fileUploadPicture.Image = Image.FromFile(link);
        }
        
    }
}
