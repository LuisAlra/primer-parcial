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
            labelInfo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            youtube.Navigate("https://www.youtube.com/v/J3YatOrbEBM");

            OpenFileDialog pdf = new OpenFileDialog();
            pdf.FileName = "avance-sistema-de-riego.pdf";
            acrobatPDF.LoadFile(pdf.FileName);

            labelInfo.Text = @"Se denomina Sistema de riego o perímetro de riego, al conjunto de estructuras,
que hace posible que una determinada área pueda ser cultivada
con la aplicación del agua necesaria a las plantas.
El sistema de riego consta de una serie de componentes,
aunque no necesariamente el sistema de riego debe constar de todas ellas,
ya que el conjunto de componentes dependerá de si se trata de riego superficial
(principalmente en su variante de riego por inundación),
por aspersión, o por goteo.";
        }
    }
}
