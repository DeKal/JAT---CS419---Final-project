using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JAT___Final_Project___Image_Retrieval
{
    public partial class PreviewPicture : UserControl
    {
        private bool init = false;
        private Panel currentSelected = null;
        public PreviewPicture()
        {
            InitializeComponent();
        }
        public void reset()
        {
            tb_layout_preview.Controls.Clear();
            tb_layout_preview.ColumnCount = 1;
            init = false;
        }
        public void loadResultImage()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(SearchForm.path + @"\retrieve.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    string result = sr.ReadToEnd();
                    string []lines = result.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                    Image temp = null;
                    foreach(string line in lines)
                    {
                        if(line != "")
                        {
                            temp = Image.FromFile(SearchForm.path + @"\dataset\" + line);
                            AddPicture(temp);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        public void AddPicture(Image picture)
        {
            // create new picture box
            PictureBox temp = new PictureBox();
            temp.Image = picture;
            temp.Dock = DockStyle.Fill;
            temp.SizeMode = PictureBoxSizeMode.Zoom;
            temp.Click += previewImage;

            // panel
            Panel tempPanel = new Panel();
            tempPanel.Dock = DockStyle.Fill;
            tempPanel.BackColor = Color.Transparent;
            tempPanel.Controls.Add(temp);

            if (!init)
            {
                // add control
                tb_layout_preview.ColumnStyles.Clear();
                tb_layout_preview.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
                ++tb_layout_preview.ColumnCount;
                tb_layout_preview.Controls.Add(tempPanel, 0, 0);
                init = true;
                return;
            }

            // increase count
            ++tb_layout_preview.ColumnCount;

            // add new column style
            tb_layout_preview.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));

            // add control
            tb_layout_preview.Controls.Add(tempPanel, tb_layout_preview.ColumnCount - 2, 0);
        }

        private void previewImage(object sender, EventArgs e)
        {
            // unselect image
            if(currentSelected!=null)
            {
                currentSelected.BackColor = Color.Transparent;
            }

            // select image
            PictureBox temp = (PictureBox)sender;
            Panel tempPanel = (Panel) temp.Parent;
            tempPanel.BackColor = Color.BlueViolet;

            ShowPicture.self.SetSelectedImage(((PictureBox)sender).Image);

            // change current image
            currentSelected = tempPanel;
        }
    }
}
