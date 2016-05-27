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
    public partial class UploadSearchRedirect : UserControl
    {
        public UploadSearchRedirect()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            Program.SearchForm.Show();
            Program.CurrentResultForm.Close();
        }
    }
}
