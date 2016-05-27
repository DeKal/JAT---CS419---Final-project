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
        public PreviewPicture()
        {
            InitializeComponent();
        }

        public void AddPicture(Image picture)
        {
            // create new picture box
            PictureBox temp = new PictureBox();
            temp.Image = picture;
            temp.Dock = DockStyle.Fill;
            temp.SizeMode = PictureBoxSizeMode.Zoom;

            if(!init)
            {
                // add control
                tb_layout_preview.Controls.Add(temp, 0, 0);
                init = true;
                return;
            }

            // add new column
            ++tb_layout_preview.ColumnCount;

            // add new column style
            tb_layout_preview.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));

            // add control
            tb_layout_preview.Controls.Add(temp, tb_layout_preview.ColumnCount - 1, 0);
        }

        private void previewImage(object sender, EventArgs e)
        {

        }
    }
}
