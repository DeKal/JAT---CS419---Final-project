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
    public partial class ResultForm : Form
    {
        private string uploadPicLink;
        public ResultForm(string uploadPicLink = null)
        {
            InitializeComponent();
            this.UploadPicLink = uploadPicLink;
            if (uploadPicLink != null)
            {
                showPicture.SetImageUpload(uploadPicLink);
                // load image from result file
                ShowPicture.preview.loadResultImage();
            }
        }

        private void ResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }


        //hide the exit button
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public string UploadPicLink
        {
            get
            {
                return uploadPicLink;
            }

            set
            {
                uploadPicLink = value;
            }
        }
    }
}
