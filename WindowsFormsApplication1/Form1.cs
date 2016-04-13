using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int cc;

        List<Figura> figuras;
        public Form1()
        {
            figuras = new List<Figura>();
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           if( e.Button == MouseButtons.Left)
            {
                if (cc==1)
                {
                    Rectangulo r = new Rectangulo(e.X, e.Y);
                    r.Dibuja(this);
                    figuras.Add(r);

                }
                else if (cc == 2)
                {
                    Circulo c = new Circulo(e.X, e.Y);
                    c.Dibuja(this);
                    figuras.Add(c);
                }

      
            }else if(e.Button == MouseButtons.Right)
            {
                
                this.contextMenuStrip1.Show(this, new Point(e.X, e.Y));

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figura f in figuras)
            {
                f.Dibuja(this);
            }
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cc = 1;   
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cc = 2;
        }
    }
}
