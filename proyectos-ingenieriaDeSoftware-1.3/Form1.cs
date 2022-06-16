using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFcruzlara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
        }

        private void notes_Click(object sender, EventArgs e)
        {
            notes notes_form = new notes();
            notes_form.Show();
        }

        private void practices_Click(object sender, EventArgs e)
        {
            practices practices_form = new practices();
            practices_form.Show();
        }

        private void projects_Click(object sender, EventArgs e)
        {
            projects projects_form = new projects();
            projects_form.Show();
        }

        private void exam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Exam.exe");
        }
    }
}
