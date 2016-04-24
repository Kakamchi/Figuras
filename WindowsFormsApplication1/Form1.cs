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
        public Color cbrocha,cpincel;
        static List<Figura> figuras;
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
                    Rectangulo r = new Rectangulo(new SolidBrush(cbrocha),new Pen(cpincel,1), e.X, e.Y,20,20);
                    r.Dibuja(this);
                    figuras.Add(r);

                }
                else if (cc == 2)
                {
                    Circulo c = new Circulo(new SolidBrush(cbrocha), new Pen(cpincel, 1), e.X, e.Y, 20, 20);
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
            this.cuadradoToolStripMenuItem.Checked = true;
            this.circuloToolStripMenuItem.Checked = false;
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cc = 2;
            this.circuloToolStripMenuItem.Checked = true;
            this.cuadradoToolStripMenuItem.Checked = false;
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figuras.Sort();
            figuras.Reverse();
            this.Invalidate();
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbrocha = Color.Black;
            this.negroToolStripMenuItem.Checked = true;
            this.azulToolStripMenuItem.Checked = false;
            this.blancoToolStripMenuItem.Checked = false;
            this.verdeToolStripMenuItem.Checked = false;
        }

        private void blancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbrocha = Color.White;
            this.blancoToolStripMenuItem.Checked = true;
            this.negroToolStripMenuItem.Checked = false;
            this.azulToolStripMenuItem.Checked = false;
            this.verdeToolStripMenuItem.Checked = false;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbrocha = Color.Green;
            this.verdeToolStripMenuItem.Checked = true;
            this.negroToolStripMenuItem.Checked = false;
            this.azulToolStripMenuItem.Checked = false;
            this.blancoToolStripMenuItem.Checked = false;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbrocha = Color.Blue;
            this.azulToolStripMenuItem.Checked = true;
            this.negroToolStripMenuItem.Checked = false;
            this.blancoToolStripMenuItem.Checked = false;
            this.verdeToolStripMenuItem.Checked = false;
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cpincel = Color.Red;
            this.rojoToolStripMenuItem.Checked = true;
            this.moradoToolStripMenuItem.Checked = false;
            this.blancoToolStripMenuItem.Checked = false;
        }

        private void moradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cpincel = Color.Purple;
            this.moradoToolStripMenuItem.Checked = true;
            this.rojoToolStripMenuItem.Checked = false;
            this.blancoToolStripMenuItem.Checked = false;
        }

        private void blancoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cpincel = Color.White;
            this.blancoToolStripMenuItem.Checked = true;
            this.moradoToolStripMenuItem.Checked = false;
            this.rojoToolStripMenuItem.Checked = false;
        }
    }
}
