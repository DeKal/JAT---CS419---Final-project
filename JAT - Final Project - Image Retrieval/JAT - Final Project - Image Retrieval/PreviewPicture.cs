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
    public partial class PreviewPicture : UserControl
    {
        bool init = false;
        Panel currentSelected = null;
        PictureBox selectedImage = null;
        public PreviewPicture(PictureBox selectedImage)
        {
            this.selectedImage = selectedImage;
            InitializeComponent();
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
                tb_layout_preview.Controls.Add(tempPanel, 0, 0);
                init = true;
                return;
            }

            // increase count
            ++tb_layout_preview.ColumnCount;

            // add new column style
            tb_layout_preview.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));

            // add control
            tb_layout_preview.Controls.Add(tempPanel, tb_layout_preview.ColumnCount - 1, 0);
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

            selectedImage.Image = ((PictureBox)sender).Image;

            // change current image
            currentSelected = tempPanel;
        }
    }
}
