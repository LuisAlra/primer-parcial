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
            info.Text = "";
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            example.Navigate("https://www.cs.us.es/~jalonso/cursos/pd-00/temas/tema-06.pdf");

            info.Text = @"En lógica y matemáticas, la lógica de segundo orden es una extensión de la lógica de primer orden,
que en sí misma es una extensión de la lógica proposicional.
La lógica de segundo orden se extiende a su vez por la lógica de orden superior y la teoría de tipos.

La lógica de segundo orden tiene un poder expresivo mayor que la lógica de primer orden.
Ese mayor poder expresivo permite axiomatizar sistemas matemáticos más complejos.
Es decir, hay proposiciones no formalizables exactamente utilitizando el formalismo
de la lógica de primer orden que sí pueden ser formalizadas correctamente
con la lógica de segundo orden. Sin duda ese último hecho constituye una ventaja,
sin embargo, el uso de lógicas de segundo orden comporta ciertas dificultades:

  -  El teorema de compacidad, que afirma que un conjunto de proposiciones lógicas
     de una lógica de primer orden es satisfactible si y solo si cualquier subconjunto finito
     de estas proposiciones es satisfactible, no es válido para una lógica de segundo orden.

  -  El teorema de Löwenheim-Skolem que afirma que una lógica de primer orden 
      con una cantidad finita de símbolos diferentes admite un modelo numerable 
      no es válido para una lógica de segundo orden.

El hecho de que estos dos teoremas, muy útiles en ciertas aplicaciones, no se pueden generalizar
a una lógica de segundo orden reducen la utilidad para esas aplicaciones de las lógicas de segundo orden.
Debido a esos problemas se han buscado sistemas lógicos intermedios que generalicen
la lógica de primer orden sin llegar a ser tan expresiva como una lógica de segundo orden.
Los teoremas de Lindström proporcionan información sobre lo que cabe esperar de algunos de dichos sistemas. 
";

            OpenFileDialog pdfAcrobat = new OpenFileDialog();
            pdfAcrobat.FileName = "ciclo-de-vida-examen.pdf";
            pdf.LoadFile(pdfAcrobat.FileName);
            
            pdfWeb.Navigate("https://lya.fciencias.unam.mx/favio/publ/esp/prop2.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            video.Navigate("https://www.youtube.com/v/XfRrBAfJZAI");

        }
    }
}
