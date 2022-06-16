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
    public partial class notes : Form
    {
        public notes()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdf = new OpenFileDialog();
            pdf.FileName = "02-01-22.pdf";
            axAcroPDF1.LoadFile(pdf.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdf = new OpenFileDialog();
            pdf.FileName = "02-03-22.pdf";
            axAcroPDF1.LoadFile(pdf.FileName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdf = new OpenFileDialog();
            pdf.FileName = "02-04-22.pdf";
            axAcroPDF1.LoadFile(pdf.FileName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdf = new OpenFileDialog();
            pdf.FileName = "02-08-22.pdf";
            axAcroPDF1.LoadFile(pdf.FileName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdf = new OpenFileDialog();
            pdf.FileName = "02-10-22.pdf";
            axAcroPDF1.LoadFile(pdf.FileName);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdf = new OpenFileDialog();
            pdf.FileName = "02-11-22.pdf";
            axAcroPDF1.LoadFile(pdf.FileName);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdf = new OpenFileDialog();
            pdf.FileName = "02-15-22.pdf";
            axAcroPDF1.LoadFile(pdf.FileName);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdf = new OpenFileDialog();
            pdf.FileName = "02-17-22.pdf";
            axAcroPDF1.LoadFile(pdf.FileName);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdf = new OpenFileDialog();
            pdf.FileName = "02-18-22.pdf";
            axAcroPDF1.LoadFile(pdf.FileName);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdf = new OpenFileDialog();
            pdf.FileName = "02-22-22.pdf";
            axAcroPDF1.LoadFile(pdf.FileName);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdf = new OpenFileDialog();
            pdf.FileName = "02-24-22.pdf";
            axAcroPDF1.LoadFile(pdf.FileName);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdf = new OpenFileDialog();
            pdf.FileName = "02-25-22.pdf";
            axAcroPDF1.LoadFile(pdf.FileName);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdf = new OpenFileDialog();
            pdf.FileName = "03-01-22.pdf";
            axAcroPDF1.LoadFile(pdf.FileName);
        }
    }
}
