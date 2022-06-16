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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notes = new System.Windows.Forms.Button();
            this.practices = new System.Windows.Forms.Button();
            this.projects = new System.Windows.Forms.Button();
            this.exam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
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
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(227, 138);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(75, 38);
            this.notes.TabIndex = 1;
            this.notes.Text = "Notas";
            this.notes.UseVisualStyleBackColor = true;
            this.notes.Click += new System.EventHandler(this.notes_Click);
            // 
            // practices
            // 
            this.practices.Location = new System.Drawing.Point(476, 138);
            this.practices.Name = "practices";
            this.practices.Size = new System.Drawing.Size(75, 38);
            this.practices.TabIndex = 2;
            this.practices.Text = "Prácticas";
            this.practices.UseVisualStyleBackColor = true;
            this.practices.Click += new System.EventHandler(this.practices_Click);
            // 
            // projects
            // 
            this.projects.Location = new System.Drawing.Point(227, 267);
            this.projects.Name = "projects";
            this.projects.Size = new System.Drawing.Size(75, 38);
            this.projects.TabIndex = 3;
            this.projects.Text = "Proyectos";
            this.projects.UseVisualStyleBackColor = true;
            this.projects.Click += new System.EventHandler(this.projects_Click);
            // 
            // exam
            // 
            this.exam.Location = new System.Drawing.Point(476, 267);
            this.exam.Name = "exam";
            this.exam.Size = new System.Drawing.Size(75, 38);
            this.exam.TabIndex = 4;
            this.exam.Text = "Proyecto examen";
            this.exam.UseVisualStyleBackColor = true;
            this.exam.Click += new System.EventHandler(this.exam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione una opción";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exam);
            this.Controls.Add(this.projects);
            this.Controls.Add(this.practices);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Proyecto 3 | Lanzador general";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.Button notes;
        private System.Windows.Forms.Button practices;
        private System.Windows.Forms.Button projects;
        private System.Windows.Forms.Button exam;
        private System.Windows.Forms.Label label1;
    }
}

