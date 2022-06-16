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
    public partial class projects : Form
    {
        public projects()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://github.com/AngelCruzL/proyectos-ingenieriaDeSoftware#proyectos-ingenier%C3%ADa-de-software");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("PR1_WFcruzlara.exe");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("PR2_WFcruzlara.exe");

        }
    }
}
