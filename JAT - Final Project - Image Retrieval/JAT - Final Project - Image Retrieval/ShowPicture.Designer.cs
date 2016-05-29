namespace JAT___Final_Project___Image_Retrieval
{
    partial class ShowPicture
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.fileSelectedPicture = new System.Windows.Forms.PictureBox();
            this.fileUploadPicture = new System.Windows.Forms.PictureBox();
            this.uploadDeleteView1 = new JAT___Final_Project___Image_Retrieval.UploadSearchRedirect();
            this.previewPicture = new JAT___Final_Project___Image_Retrieval.PreviewPicture();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSelectedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileUploadPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 522);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.uploadDeleteView1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.previewPicture, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 344);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.14612F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(738, 176);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.fileSelectedPicture, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.fileUploadPicture, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(736, 336);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // fileSelectedPicture
            // 
            this.fileSelectedPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileSelectedPicture.Image = global::JAT___Final_Project___Image_Retrieval.Properties.Resources.default_image;
            this.fileSelectedPicture.Location = new System.Drawing.Point(371, 3);
            this.fileSelectedPicture.Name = "fileSelectedPicture";
            this.fileSelectedPicture.Size = new System.Drawing.Size(362, 330);
            this.fileSelectedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fileSelectedPicture.TabIndex = 0;
            this.fileSelectedPicture.TabStop = false;
            // 
            // fileUploadPicture
            // 
            this.fileUploadPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileUploadPicture.Location = new System.Drawing.Point(3, 3);
            this.fileUploadPicture.Name = "fileUploadPicture";
            this.fileUploadPicture.Size = new System.Drawing.Size(362, 330);
            this.fileUploadPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fileUploadPicture.TabIndex = 1;
            this.fileUploadPicture.TabStop = false;
            // 
            // uploadDeleteView1
            // 
            this.uploadDeleteView1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uploadDeleteView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadDeleteView1.Location = new System.Drawing.Point(2, 137);
            this.uploadDeleteView1.Margin = new System.Windows.Forms.Padding(2);
            this.uploadDeleteView1.Name = "uploadDeleteView1";
            this.uploadDeleteView1.Size = new System.Drawing.Size(734, 37);
            this.uploadDeleteView1.TabIndex = 0;
            // 
            // previewPicture
            // 
            this.previewPicture.BackColor = System.Drawing.Color.Transparent;
            this.previewPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPicture.Location = new System.Drawing.Point(2, 2);
            this.previewPicture.Margin = new System.Windows.Forms.Padding(2);
            this.previewPicture.Name = "previewPicture";
            this.previewPicture.Size = new System.Drawing.Size(734, 131);
            this.previewPicture.TabIndex = 1;
            // 
            // ShowPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowPicture";
            this.Size = new System.Drawing.Size(742, 522);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSelectedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileUploadPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private UploadSearchRedirect uploadDeleteView1;
        private System.Windows.Forms.PictureBox fileSelectedPicture;
        private System.Windows.Forms.PictureBox fileUploadPicture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private PreviewPicture previewPicture;
    }
}
