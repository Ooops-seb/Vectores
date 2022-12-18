using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Vectores.Classes
{
    internal class Operations
    {
        private Graphics Graph;
        public Operations()
        {
            //Constructor
        }

        public float Magnitude(Dots Punto)
        {
            float x = Punto.fX;
            float y = Punto.fY;

            double magnitud = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            return (float)magnitud;
        }

        public int Quadrant(Dots Punto)
        {
            float fX = Punto.fX;
            float fY = Punto.fY;
            if ((fX > 0) && (fY > 0))
            {
                return 1;
            }
            else if ((fX < 0) && (fY > 0))
            {
                return 2;
            }
            else if ((fX < 0) && (fY < 0))
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
        public int Quadrant(float fX, float fY)
        {
            if ((fX > 0) && (fY > 0))
            {
                return 1;
            }
            else if ((fX < 0) && (fY > 0))
            {
                return 2;
            }
            else if ((fX < 0) && (fY < 0))
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        public float Angle(Dots Punto)
        {
            float x = Punto.fX;
            float y = Punto.fY;
            float angle, rad;
            rad = (float)Math.Atan(y / x);
            angle = (float)((rad * 180) / (float)Math.PI);
            if (Quadrant(x, y) == 2)
                angle += 180;
            if (Quadrant(x, y) == 3)
                angle = 180 - (-angle);
            if (Quadrant(x, y) == 4)
                angle += 360;
            return angle;
        }

        public double Perimeter(Point PuntoA, Point PuntoB, String figura)
        {
            double Ax = (double)PuntoA.X;
            double Ay = (double)PuntoA.Y;
            double Bx = (double)PuntoB.X;
            double By = (double)PuntoB.Y;

            double perimetro = 0;
            double ancho = 0;
            double alto = 0;

            if (figura == "cuadrado")
            {
                ancho = Math.Abs(Bx - Ax);
                alto = Math.Abs(By - Ay);
                perimetro = 2 * (ancho + alto);
            }
            else if (figura == "triangulo")
            {
                double lado = ancho;
                perimetro = lado * 3;
            }
            return perimetro;
        }

        public double Area(Point PuntoA, Point PuntoB, String figura)
        {
            double Ax = (double)PuntoA.X;
            double Ay = (double)PuntoA.Y;
            double Bx = (double)PuntoB.X;
            double By = (double)PuntoB.Y;
            double area = 0;

            if (figura == "cuadrado")
            {
                double ancho = Math.Abs(Bx - Ax);
                double alto = Math.Abs(By - Ay);

                area = ancho * alto;
            }
            else if (figura == "triangulo")
            {
                double ancho = Math.Abs(Bx - Ax);
                double alto = Math.Abs(By - Ay);

                area = (ancho * alto) / 2;
            }
            return area;
        }

        public Dots Convert_Point(Point punto)
        {
            float x = punto.X;
            float y = -punto.Y;

            float pX = (x / 25) - 10;
            float pY = (y / 25) + 10;
            Dots Converted_Point = new Dots(pX, pY);
            return Converted_Point;
        }

        public void PrintPoint(PictureBox PicCanvas, Dots Punto)
        {
            Graph = PicCanvas.CreateGraphics();

            float x = Punto.fX;
            float y = Punto.fY;

            x = x / 25 - 11;
            y = -y / 25 + 11;

            float fX = Punto.fX;
            float fY = Punto.fY;

            SolidBrush FontBrush = new SolidBrush(Color.IndianRed);
            Font TextFont = new Font("Source Sans Pro Extraclara", 8);

            string txtPoint = "(" + Math.Round(x, 2) + "," + Math.Round(y, 2) + ")";
            if (x > 0 && y > 0)
                Graph.DrawString(txtPoint, TextFont, FontBrush, fX + 10, fY - 20);
            else if (x < 0 && y < 0)
                Graph.DrawString(txtPoint, TextFont, FontBrush, fX - 20, fY + 10);
            else if (x > 0 && y < 0)
                Graph.DrawString(txtPoint, TextFont, FontBrush, fX + 10, fY + 10);
            else
                Graph.DrawString(txtPoint, TextFont, FontBrush, fX - 20, fY - 20);
        }
    }
}
