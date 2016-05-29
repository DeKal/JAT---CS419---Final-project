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

        public UploadSearchRedirect()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // check if has picture
            if (ShowPicture.selected.Image == global::JAT___Final_Project___Image_Retrieval.Properties.Resources.default_image)
            {
                MessageBox.Show("No image selected.", "Error");
                return;
            }

            // logic
            ShowPicture.self.saveSelectedImage();
            SearchForm.LoadPythonScript();

            ShowPicture.self.SetImageUpload(ShowPicture.selected.Image);

            // show result
            ShowPicture.preview.reset();
            ShowPicture.preview.loadResultImage();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            Program.SearchForm.Show();
            Program.CurrentResultForm.Close();
        }
    }
}
