namespace WFcruzlara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.info = new System.Windows.Forms.TabPage();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.pdf = new System.Windows.Forms.TabPage();
            this.acrobatPDF = new AxAcroPDFLib.AxAcroPDF();
            this.labelDescription = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.video = new System.Windows.Forms.TabPage();
            this.youtube = new System.Windows.Forms.WebBrowser();
            this.tabControl1.SuspendLayout();
            this.info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            this.pdf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acrobatPDF)).BeginInit();
            this.video.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.info);
            this.tabControl1.Controls.Add(this.pdf);
            this.tabControl1.Controls.Add(this.video);
            this.tabControl1.Location = new System.Drawing.Point(311, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(442, 339);
            this.tabControl1.TabIndex = 0;
            // 
            // info
            // 
            this.info.Controls.Add(this.img2);
            this.info.Controls.Add(this.img1);
            this.info.Controls.Add(this.labelInfo);
            this.info.Location = new System.Drawing.Point(4, 22);
            this.info.Name = "info";
            this.info.Padding = new System.Windows.Forms.Padding(3);
            this.info.Size = new System.Drawing.Size(434, 313);
            this.info.TabIndex = 0;
            this.info.Text = "Información";
            this.info.UseVisualStyleBackColor = true;
            // 
            // img2
            // 
            this.img2.Image = ((System.Drawing.Image)(resources.GetObject("img2.Image")));
            this.img2.Location = new System.Drawing.Point(230, 174);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(161, 100);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img2.TabIndex = 2;
            this.img2.TabStop = false;
            // 
            // img1
            // 
            this.img1.Image = ((System.Drawing.Image)(resources.GetObject("img1.Image")));
            this.img1.Location = new System.Drawing.Point(50, 174);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(161, 100);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1.TabIndex = 1;
            this.img1.TabStop = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(25, 40);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(384, 104);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // pdf
            // 
            this.pdf.Controls.Add(this.acrobatPDF);
            this.pdf.Location = new System.Drawing.Point(4, 22);
            this.pdf.Name = "pdf";
            this.pdf.Padding = new System.Windows.Forms.Padding(3);
            this.pdf.Size = new System.Drawing.Size(434, 313);
            this.pdf.TabIndex = 1;
            this.pdf.Text = "Avance del trabajo";
            this.pdf.UseVisualStyleBackColor = true;
            // 
            // acrobatPDF
            // 
            this.acrobatPDF.Enabled = true;
            this.acrobatPDF.Location = new System.Drawing.Point(0, 0);
            this.acrobatPDF.Name = "acrobatPDF";
            this.acrobatPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("acrobatPDF.OcxState")));
            this.acrobatPDF.Size = new System.Drawing.Size(431, 310);
            this.acrobatPDF.TabIndex = 0;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(42, 84);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(194, 91);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = resources.GetString("labelDescription.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cargar información";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // video
            // 
            this.video.Controls.Add(this.youtube);
            this.video.Location = new System.Drawing.Point(4, 22);
            this.video.Name = "video";
            this.video.Padding = new System.Windows.Forms.Padding(3);
            this.video.Size = new System.Drawing.Size(434, 313);
            this.video.TabIndex = 2;
            this.video.Text = "Video de demostración de un sistema de riego";
            this.video.UseVisualStyleBackColor = true;
            // 
            // youtube
            // 
            this.youtube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.youtube.Location = new System.Drawing.Point(3, 3);
            this.youtube.MinimumSize = new System.Drawing.Size(20, 20);
            this.youtube.Name = "youtube";
            this.youtube.Size = new System.Drawing.Size(428, 307);
            this.youtube.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Proyecto 2 | Descriptor de tesis";
            this.tabControl1.ResumeLayout(false);
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            this.pdf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acrobatPDF)).EndInit();
            this.video.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage info;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TabPage pdf;
        private AxAcroPDFLib.AxAcroPDF acrobatPDF;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.TabPage video;
        private System.Windows.Forms.WebBrowser youtube;
    }
}

