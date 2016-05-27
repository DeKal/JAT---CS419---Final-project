namespace JAT___Final_Project___Image_Retrieval
{
    partial class PreviewPicture
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
            this.tb_layout_preview = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tb_layout_preview
            // 
            this.tb_layout_preview.AutoScroll = true;
            this.tb_layout_preview.ColumnCount = 1;
            this.tb_layout_preview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tb_layout_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_layout_preview.Location = new System.Drawing.Point(0, 0);
            this.tb_layout_preview.Margin = new System.Windows.Forms.Padding(2);
            this.tb_layout_preview.Name = "tb_layout_preview";
            this.tb_layout_preview.RowCount = 1;
            this.tb_layout_preview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb_layout_preview.Size = new System.Drawing.Size(470, 122);
            this.tb_layout_preview.TabIndex = 0;
            // 
            // PreviewPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tb_layout_preview);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PreviewPicture";
            this.Size = new System.Drawing.Size(470, 122);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tb_layout_preview;
    }
}
