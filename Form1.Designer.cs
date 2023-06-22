namespace DiCOM_Web_App_
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Viewer = new DicomObjects.DicomViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Viewer
            // 
            this.Viewer.AutoDisplay = false;
            this.Viewer.BackColor = System.Drawing.Color.Black;
            this.Viewer.BackColour = System.Drawing.Color.Black;
            this.Viewer.Border = ((short)(0));
            this.Viewer.CellSpacing = ((short)(0));
            this.Viewer.CineUpdateTime = 0;
            this.Viewer.CurrentIndex = 0;
            this.Viewer.HitMargin = 3;
            this.Viewer.Location = new System.Drawing.Point(13, 13);
            this.Viewer.MultiColumns = ((short)(1));
            this.Viewer.MultiRows = ((short)(1));
            this.Viewer.Name = "Viewer";
            this.Viewer.PixelSize = new System.Drawing.SizeF(0.3F, 0.3F);
            this.Viewer.ShowLabels = true;
            this.Viewer.Size = new System.Drawing.Size(370, 296);
            this.Viewer.TabIndex = 0;
            this.Viewer.Text = "dicomViewer1";
            this.Viewer.ViewerMode = DicomObjects.Enums.ViewerMode.DirectX;
            this.Viewer.VSync = false;
            this.Viewer.Click += new System.EventHandler(this.Viewer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Digest Dicom to DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Viewer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DicomObjects.DicomViewer Viewer;
        private System.Windows.Forms.Button button1;
    }
}