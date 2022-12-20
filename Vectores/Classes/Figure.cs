using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores.Classes
{
    internal class Figure
    {
        Graphics graph;

        private float OriginX;
        private float OriginY;

        const float scale = 25;

        static Random rand = new Random();

        Pen LinePen = new Pen(Color.LightGray, 2);

        public Figure(PictureBox PicCanvas)
        {
            this.OriginX = PicCanvas.Width / 2;
            this.OriginY = PicCanvas.Height / 2;
        }

        //No dibuja ***CORREGIR***
        public void DrawPoint(PictureBox PicCanvas, Dots Punto)
        {
            graph = PicCanvas.CreateGraphics();

            float x = Punto.fX;
            float y = Punto.fY;

            graph.DrawLine(LinePen, x-5, y, x+5, y);
            graph.DrawLine(LinePen, x, y-5, x, y+5);
        }

        public void Triangle(PictureBox PicCanvas, Dots PuntoA, Dots PuntoB)
        {
            graph = PicCanvas.CreateGraphics();
            Operations op = new Operations();

            float x1 = PuntoA.fX;
            float y1 = PuntoA.fY;
            float x2 = PuntoB.fX;
            float y2 = PuntoB.fY;

            double lado = op.Distance(x1, y1, x2, y2);
            double mx = (x1 + x2) / 2;
            double my = (y1 + y2) / 2;
            double auxAlturaX = Math.Cos((60 * Math.PI) / 180) * lado;
            double auxAlturaY = Math.Sin((60 * Math.PI) / 180) * lado;

            double x3 = (mx + auxAlturaX);
            double y3 = (my + auxAlturaY);

            float X1 = OriginX + (x1 * scale);
            float Y1 = OriginY - (y1 * scale);
            float X2 = OriginX + (x2 * scale);
            float Y2 = OriginY - (y2 * scale);
            float X3 = OriginX + (float)(x3 * scale);
            float Y3 = OriginY - (float)(y3 * scale);

            graph.DrawLine(LinePen, X1, Y1, X2, Y2);
            graph.DrawLine(LinePen, X2, Y2, X3, Y3);
            graph.DrawLine(LinePen, X3, Y3, X1, Y1);

            //Imprimir posiciones de vector
            Dots AuxPuntoA = new Dots(X1, Y1);
            Dots AuxPuntoB = new Dots(X2, Y2);
            Dots AuxPuntoC = new Dots(X3, Y3);
            
            op.PrintPoint(PicCanvas, AuxPuntoA);
            op.PrintPoint(PicCanvas, AuxPuntoB);
            op.PrintPoint(PicCanvas, AuxPuntoC);
        }

        public void Rectangle(PictureBox PicCanvas, Dots PuntoA, Dots PuntoB)
        {
            graph = PicCanvas.CreateGraphics();

            float Ax = PuntoA.fX;
            float Ay = PuntoA.fY;
            float Bx = PuntoB.fX;
            float By = PuntoB.fY;

            Ax = OriginX + (Ax * scale);
            Ay = OriginY - (Ay * scale);
            Bx = OriginX + (Bx * scale);
            By = OriginY - (By * scale);

            graph.DrawLine(LinePen, Ax, Ay, Ax, By);
            graph.DrawLine(LinePen, Ax, By, Bx, By);
            graph.DrawLine(LinePen, Bx, By, Bx, Ay);
            graph.DrawLine(LinePen, By, Ay, Ax, Ay);
        }
    }
}
