using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores.Classes
{
    internal class VectorOrigin
    {
        Graphics graph;

        private float originX;
        private float originY;
        const float scale = 25;

        public VectorOrigin(PictureBox PicCanvas)
        {
            this.originX = PicCanvas.Width / 2;
            this.originY = PicCanvas.Height / 2;
        }

        public void Draw_Origin(PictureBox PicCanvas, Dots Punto)
        {
            graph = PicCanvas.CreateGraphics();
            Random rand = new Random();
            Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

            Pen LinePen = new Pen(color, 2);
            Pen ArrowPen = new Pen(color, 5);
            LinePen.StartCap = LineCap.RoundAnchor;
            ArrowPen.EndCap = LineCap.ArrowAnchor;

            float x = Punto.fX;
            float y = Punto.fY;

            float fX = originX + (x * scale);
            float fY = originY - (y * scale);

            graph.DrawLine(LinePen, originX, originY, fX, fY);

            //Flecha de vector
            if (x > 0 && y > 0)
                graph.DrawLine(LinePen, fX - 3, fY + 3, fX, fY);
            else if (x < 0 && y < 0)
                graph.DrawLine(LinePen, fX + 3, fY - 3, fX, fY);
            else if (x > 0 && y < 0)
                graph.DrawLine(LinePen, fX - 3, fY - 3, fX, fY);
            else
                graph.DrawLine(LinePen, fX + 3, fY + 3, fX, fY);

            Operations operation = new Operations();
            //Imprimir punto de vector
            Dots AuxPoint = new Dots(fX, fY);
            operation.PrintPoint(PicCanvas, AuxPoint);
            
            //Imprimir magnitud vector
            float auxfX = originX + (x * scale) / 2;
            float auxfY = originY - (y * scale) / 2;
            Dots Aux = new Dots(auxfX, auxfY);
            operation.PrintPoint(PicCanvas, Aux);
        }

        public void Draw_Everywhere(PictureBox PicCanvas, Dots FloatPointA, Dots FloatPointB)
        {
            graph = PicCanvas.CreateGraphics();
            Random rand = new Random();
            Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

            Pen LinePen = new Pen(color, 2);
            Pen ArrowPen = new Pen(color, 5);
            ArrowPen.StartCap = LineCap.ArrowAnchor;
            ArrowPen.EndCap = LineCap.RoundAnchor;
            
            float auxAx = FloatPointA.fX;
            float auxAy = FloatPointA.fY;
            float auxBx = FloatPointB.fX;
            float auxBy = FloatPointB.fY;

            float Ax = originX + (auxAx * scale);
            float Ay = originY - (auxAy * scale);
            float Bx = originX + (auxBx * scale);
            float By = originY - (auxBy * scale);

            graph.DrawLine(LinePen, Ax, Ay, Bx, By);
            graph.DrawLine(ArrowPen, Ax, Ay, Ax, Ay);
            graph.DrawLine(ArrowPen, Bx, By, Bx, By);

            //Imprimir coordenadas
            Dots PuntoA = new Dots(Ax, Ay);
            Dots PuntoB = new Dots(Bx, By);
            Operations op = new Operations();
            op.PrintPoint(PicCanvas, PuntoA);
            op.PrintPoint(PicCanvas, PuntoB);
        }
    }
}
