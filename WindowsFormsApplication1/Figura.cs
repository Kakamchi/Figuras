using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    abstract class Figura
    {
        Random r = new Random();


        public int x;
        public int y;
        public Pen pluma;
        public Brush brocha;
        public int ancho;
        public int largo;
        public int area;

        public Figura(int X, int Y)
        {
            x = X;
            y = Y;
            pluma = new Pen(Color.Green, 3);
            ancho = r.Next(10,50);
            largo = r.Next(10,50);
            
        }
        public abstract void Dibuja(Form f);

        
    }

    

     class Rectangulo : Figura
    {
        public Rectangulo(int x, int y) : base(x, y)
        {
        }

        public override void Dibuja(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawRectangle(pluma, x, y, ancho, largo);
        }
    }



     class Circulo : Figura
    {
        public Circulo(int x, int y) : base(x, y)
        {
        }

        public override void Dibuja(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawEllipse(pluma, x, y, ancho, largo);
        }

    }







  

}