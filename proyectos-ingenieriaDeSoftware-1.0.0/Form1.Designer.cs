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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.about = new System.Windows.Forms.TabPage();
            this.Examples = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lifeCicle = new System.Windows.Forms.TabPage();
            this.info = new System.Windows.Forms.Label();
            this.pdf = new AxAcroPDFLib.AxAcroPDF();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.video = new System.Windows.Forms.WebBrowser();
            this.pdfWeb = new System.Windows.Forms.WebBrowser();
            this.button2 = new System.Windows.Forms.Button();
            this.example = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.about.SuspendLayout();
            this.Examples.SuspendLayout();
            this.lifeCicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdf)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.about);
            this.tabControl1.Controls.Add(this.Examples);
            this.tabControl1.Controls.Add(this.lifeCicle);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(195, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 391);
            this.tabControl1.TabIndex = 1;
            // 
            // about
            // 
            this.about.Controls.Add(this.info);
            this.about.Location = new System.Drawing.Point(4, 22);
            this.about.Name = "about";
            this.about.Padding = new System.Windows.Forms.Padding(3);
            this.about.Size = new System.Drawing.Size(567, 365);
            this.about.TabIndex = 0;
            this.about.Text = "¿Qué es la lógica de segundo orden?";
            this.about.UseVisualStyleBackColor = true;
            // 
            // Examples
            // 
            this.Examples.Controls.Add(this.example);
            this.Examples.Location = new System.Drawing.Point(4, 22);
            this.Examples.Name = "Examples";
            this.Examples.Padding = new System.Windows.Forms.Padding(3);
            this.Examples.Size = new System.Drawing.Size(567, 365);
            this.Examples.TabIndex = 1;
            this.Examples.Text = "Ejemplos";
            this.Examples.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cargar información";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lifeCicle
            // 
            this.lifeCicle.Controls.Add(this.pdf);
            this.lifeCicle.Location = new System.Drawing.Point(4, 22);
            this.lifeCicle.Name = "lifeCicle";
            this.lifeCicle.Padding = new System.Windows.Forms.Padding(3);
            this.lifeCicle.Size = new System.Drawing.Size(567, 365);
            this.lifeCicle.TabIndex = 2;
            this.lifeCicle.Text = "Ciclo de vida";
            this.lifeCicle.UseVisualStyleBackColor = true;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(18, 23);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(534, 312);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // pdf
            // 
            this.pdf.Enabled = true;
            this.pdf.Location = new System.Drawing.Point(0, 0);
            this.pdf.Name = "pdf";
            this.pdf.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdf.OcxState")));
            this.pdf.Size = new System.Drawing.Size(567, 365);
            this.pdf.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pdfWeb);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 365);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Más información";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.video);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 365);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Video ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // video
            // 
            this.video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.video.Location = new System.Drawing.Point(3, 3);
            this.video.MinimumSize = new System.Drawing.Size(20, 20);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(561, 359);
            this.video.TabIndex = 0;
            // 
            // pdfWeb
            // 
            this.pdfWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfWeb.Location = new System.Drawing.Point(3, 3);
            this.pdfWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.pdfWeb.Name = "pdfWeb";
            this.pdfWeb.Size = new System.Drawing.Size(561, 359);
            this.pdfWeb.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cargar video";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // example
            // 
            this.example.Dock = System.Windows.Forms.DockStyle.Fill;
            this.example.Location = new System.Drawing.Point(3, 3);
            this.example.MinimumSize = new System.Drawing.Size(20, 20);
            this.example.Name = "example";
            this.example.Size = new System.Drawing.Size(561, 359);
            this.example.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Proyecto Examen | Lógica de segundo orden";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.about.ResumeLayout(false);
            this.about.PerformLayout();
            this.Examples.ResumeLayout(false);
            this.lifeCicle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdf)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage about;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.TabPage Examples;
        private System.Windows.Forms.TabPage lifeCicle;
        private System.Windows.Forms.Button button1;
        private AxAcroPDFLib.AxAcroPDF pdf;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser pdfWeb;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser video;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.WebBrowser example;
    }
}

