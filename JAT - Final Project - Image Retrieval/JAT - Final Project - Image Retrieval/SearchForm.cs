using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAT___Final_Project___Image_Retrieval
{
    public partial class SearchForm : Form
    {
        private String currentFileUploadLink = null;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.CurrentResultForm = new ResultForm(currentFileUploadLink);
            Program.CurrentResultForm.Show(); 
        }

        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            
            String input = string.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
 
            dialog.Filter =
               "Image Files(*.bmp, *.jpg) | *.bmp; *.jpg; *.JPG | All files (*.*)|*.*";
           

            dialog.InitialDirectory = "C:";
            dialog.Title = "Select a text file";

            
            if (dialog.ShowDialog() == DialogResult.OK)
                currentFileUploadLink =  dialog.FileName;
            if (currentFileUploadLink == null)
                return; //user didn't select a file to opena
            img_search.Image = Image.FromFile(currentFileUploadLink);


        }
    }
}
