
using JAT___Final_Project___Image_Retrieval.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace JAT___Final_Project___Image_Retrieval
{
    public partial class SearchForm : Form
    {
        private String currentFileUploadLink = null;
        private Image currentImage = null;


        public SearchForm()
        {
            InitializeComponent();
            
        }
        private void LoadPythonScript(string imgLink)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var process = new System.Diagnostics.Process();
            
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WorkingDirectory = path+"\\code";
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c python retriever.py " + imgLink;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            // check if has picture
            if(currentFileUploadLink == null)
            {
                MessageBox.Show("Please add picture.", "Error");
                return;
            }

            String filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\code\image.jpg";

            // logic
            currentImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);

            // show result
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
               "Image Files(*.bmp, *.jpg) | *.bmp; *.jpg; *.JPG";
           

            dialog.InitialDirectory = "C:";
            dialog.Title = "Select a text file";

            
            if (dialog.ShowDialog() == DialogResult.OK)
                currentFileUploadLink =  dialog.FileName;
            if (currentFileUploadLink == null)
                return; //user didn't select a file to opena
            currentImage = Image.FromFile(currentFileUploadLink);
            img_search.Image = currentImage;
            

        }
    }
}
