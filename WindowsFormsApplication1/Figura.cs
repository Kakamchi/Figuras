using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    abstract class Figura : IComparable
    {
        Random r = new Random();


        public int x;
        public int y;
        public Pen pluma;
        public int ancho;
        public int largo;
        public int area;
        public SolidBrush brocha;

        public Figura(int X, int Y)
        {
            x = X;
            y = Y;
             brocha = new SolidBrush(Color.BlueViolet);
            pluma = new Pen(Color.Green, 3);
            ancho = r.Next(10,50);
            largo = r.Next(10,50);
            
        }
        public abstract void Dibuja(Form f);

        public int CompareTo(object o)
        {
            return this.largo.CompareTo(((Figura)o).largo);
        }
        public Figura(SolidBrush sb, Pen p, int X, int Y, int largo, int ancho)
        {
            brocha = sb;
            pluma = p;
            x = X;
            y = Y;
            this.largo = largo;
            this.ancho = ancho;

        }
    }



   



     class Rectangulo : Figura
    {
        public Rectangulo(int x, int y) : base(x, y)
        {
        }
        public Rectangulo (SolidBrush sb, Pen p, int X, int Y, int largo, int ancho):base(sb, p,  X,  Y, largo, ancho)
        {

        }
        public override void Dibuja(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawRectangle(pluma, x, y, ancho, largo);
            g.FillRectangle(brocha,x,y, ancho,largo);
        }
    }



     class Circulo : Figura
    {
        public Circulo(int x, int y) : base(x, y)
        {
        }
        public Circulo(SolidBrush sb, Pen p, int X, int Y, int largo, int ancho):base(sb, p,  X,  Y, largo, ancho)
        {

        }
        public override void Dibuja(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawEllipse(pluma, x, y, ancho, largo);
            g.FillEllipse(brocha, x, y, ancho, largo);
        }

    }







  

}