using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Globalization;

namespace Vectores
{
    #region Vector desde origen
    internal class VectorOrigen
    {
        //ATRIBUTOS
        private float mX, mY;
        private float mcX, mcY;
        private float fX, fY;
        private float mWidth, mHeight;

        //CONSTANTES
        const float scale = 25;

        //CONTROL DE SET GET
        public float X { get => mX; set => mX = value; }
        public float Y { get => mY; set => mY = value; }

        public double datoAncho { get; set; }
        public double datoAlto { get; set; } 

        //CONTROL DE GRAFICOS
        private Graphics mGraph;
        Pen myPencil;
        Pen AxisPencil;
        Pen ArrowPencil;

        //CONSTRUCTOR
        public VectorOrigen(float mX, float mY)
        {
            this.mX = mX;
            this.mY = mY;
        }

        //METODOS
        #region Dibujar plano
        public void DrawAxis(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            picCanvas.Cursor = Cursors.Default;
            mGraph.Clear(Color.White);
            myPencil = new Pen(Color.DarkGray, 2);
            AxisPencil = new Pen(Color.Gray, 1);
            mWidth = picCanvas.Width;
            mHeight = picCanvas.Height;
            mcX = mWidth / 2;
            mcY = mHeight / 2;

            float oX = mcX;
            float oY = mcY;

            //DIBUJAR EJES
            Font txtMagnitud = new Font("Arial", 10);
            SolidBrush txtBrush = new SolidBrush(Color.Gray);
            mGraph.DrawLine(myPencil, mcX, 0, mcX, mHeight); //Axis Y
            int num = 11;
            for (float i = 0; i < mWidth; i += 25)
            {
                mGraph.DrawLine(AxisPencil, mcX-5, i, mcX+5, i); //Coordenadas en Y
                if (num != 0)
                {
                    mGraph.DrawString("" + num, txtMagnitud, txtBrush, mHeight - i, oY);
                    num--;
                }
                else
                    num--;
            }
            num = -11;
            mGraph.DrawLine(myPencil, 0, mcY, mWidth, mcY); //Axis X
            for (float i = 0; i < mHeight; i += 25)
            {
                mGraph.DrawLine(AxisPencil, i, mcY-5, i, mcY+5); //Coordenadas en Y
                if (num != 0)
                {
                    mGraph.DrawString("" + num, txtMagnitud, txtBrush, oX, mWidth - i);
                    num++;
                }
                else
                    num++;
            }
            
        }
        #endregion
        public void DrawVector(PictureBox picCanvas, float x, float y)
        {
            #region Dibujar vector
            mGraph = picCanvas.CreateGraphics();
            myPencil= new Pen(Color.Black, 2);
            ArrowPencil = new Pen(Color.Black, 5);
            myPencil.StartCap = LineCap.RoundAnchor;
            ArrowPencil.EndCap = LineCap.ArrowAnchor;

            mWidth = picCanvas.Width;
            mHeight = picCanvas.Height;
            mcX = mWidth / 2;
            mcY = mHeight / 2;

            float oX = mcX;
            float oY = mcY;
            fX = oX + (x*scale);
            fY = oY - (y*scale);

            mGraph.DrawLine(myPencil, oX, oY, fX, fY);
            #endregion

            #region Flechas de vectores
            if (x > 0 && y > 0)
                mGraph.DrawLine(ArrowPencil, fX - 3, fY + 3, fX, fY);
            else if (x < 0 && y < 0)
                mGraph.DrawLine(ArrowPencil, fX + 3, fY - 3, fX, fY);
            else if (x > 0 && y < 0)
                mGraph.DrawLine(ArrowPencil, fX - 3, fY - 3, fX, fY);
            else
                mGraph.DrawLine(ArrowPencil, fX + 3, fY + 3, fX, fY);
            #endregion

            #region Imprimir coordenadas vector vector
            Font txtMagnitud = new Font("Arial", 8);
            SolidBrush txtBrush = new SolidBrush(Color.IndianRed);
            string txtPoint = "("+ x + "," + y + ")";
            if (x > 0 && y > 0)
                mGraph.DrawString(txtPoint, txtMagnitud, txtBrush, fX + 10, fY - 20);
            else if (x < 0 && y < 0)
                mGraph.DrawString(txtPoint, txtMagnitud, txtBrush, fX - 20, fY + 10);
            else if (x > 0 && y < 0)
                mGraph.DrawString(txtPoint, txtMagnitud, txtBrush, fX + 10, fY + 10);
            else
                mGraph.DrawString(txtPoint, txtMagnitud, txtBrush, fX - 20, fY - 20);
            #endregion

            #region Imprimir magnitud vector
            Font txtFont = new Font("Arial", 8);
            float auxfX = oX + (x * scale)/2;
            float auxfY = oY - (y * scale)/2;
            if (x > 0 && y > 0)
                mGraph.DrawString(Calcular_magnitud(x, y).ToString(), txtFont, txtBrush, auxfX + 10, auxfY - 10);
            else if (x < 0 && y < 0)
                mGraph.DrawString(Calcular_magnitud(x, y).ToString(), txtFont, txtBrush, auxfX - 10, auxfY + 10);
            else if (x > 0 && y < 0)
                mGraph.DrawString(Calcular_magnitud(x, y).ToString(), txtFont, txtBrush, auxfX + 10, auxfY + 10);
            else
                mGraph.DrawString(Calcular_magnitud(x, y).ToString(), txtFont, txtBrush, auxfX - 10, auxfY - 10);
            #endregion
        }
        public void DrawColorVector(PictureBox picCanvas, float x, float y)
        {
            #region Dibujar vector
            var rand = new Random();
            Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            mGraph = picCanvas.CreateGraphics();
            myPencil = new Pen(color, 2);
            ArrowPencil = new Pen(color, 5);
            myPencil.StartCap = LineCap.RoundAnchor;
            ArrowPencil.EndCap = LineCap.ArrowAnchor;

            mWidth = picCanvas.Width;
            mHeight = picCanvas.Height;
            mcX = mWidth / 2;
            mcY = mHeight / 2;

            float oX = mcX;
            float oY = mcY;
            fX = oX + (x * scale);
            fY = oY - (y * scale);

            mGraph.DrawLine(myPencil, oX, oY, fX, fY);
            
            #endregion

            #region Flechas de vectores
            if (x > 0 && y > 0)
                mGraph.DrawLine(ArrowPencil, fX - 3, fY + 3, fX, fY);
            else if (x < 0 && y < 0)
                mGraph.DrawLine(ArrowPencil, fX + 3, fY - 3, fX, fY);
            else if (x > 0 && y < 0)
                mGraph.DrawLine(ArrowPencil, fX - 3, fY - 3, fX, fY);
            else
                mGraph.DrawLine(ArrowPencil, fX + 3, fY + 3, fX, fY);
            #endregion

            #region Imprimir coordenadas vector vector
            Font txtMagnitud = new Font("Arial", 8);
            SolidBrush txtBrush = new SolidBrush(Color.IndianRed);
            string txtPoint = "(" + x + "," + y + ")";
            if (x > 0 && y > 0)
                mGraph.DrawString(txtPoint, txtMagnitud, txtBrush, fX + 10, fY - 20);
            else if (x < 0 && y < 0)
                mGraph.DrawString(txtPoint, txtMagnitud, txtBrush, fX - 20, fY + 10);
            else if (x > 0 && y < 0)
                mGraph.DrawString(txtPoint, txtMagnitud, txtBrush, fX + 10, fY + 10);
            else
                mGraph.DrawString(txtPoint, txtMagnitud, txtBrush, fX - 20, fY - 20);
            #endregion

            #region Imprimir magnitud vector
            Font txtFont = new Font("Arial", 8);
            float auxfX = oX + (x * scale) / 2;
            float auxfY = oY - (y * scale) / 2;
            if (x > 0 && y > 0)
                mGraph.DrawString(Calcular_magnitud(x, y).ToString(), txtFont, txtBrush, auxfX + 10, auxfY - 10);
            else if (x < 0 && y < 0)
                mGraph.DrawString(Calcular_magnitud(x, y).ToString(), txtFont, txtBrush, auxfX - 10, auxfY + 10);
            else if (x > 0 && y < 0)
                mGraph.DrawString(Calcular_magnitud(x, y).ToString(), txtFont, txtBrush, auxfX + 10, auxfY + 10);
            else
                mGraph.DrawString(Calcular_magnitud(x, y).ToString(), txtFont, txtBrush, auxfX - 10, auxfY - 10);
            #endregion
        }

        public void Limpiar(PictureBox picCanvas)
        {
            DrawAxis(picCanvas);
            mGraph.Clear(Color.White);
            DrawAxis(picCanvas);
        }

        public float Calcular_magnitud(float fX, float fY)
        {
            double magnitud = Math.Sqrt(Math.Pow(fX, 2) + Math.Pow(fY, 2));

            return (float)Math.Round(magnitud,2);
        }

        public int Calcular_cuadrante(float fX, float fY)
        {
            #region Calcular cuadrante
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
            #endregion
        }

        public float Calcular_angulo(float x, float y)
        {
            float angle, rad;
            rad = (float)Math.Atan(y / x);
            angle = (float)Math.Round(((rad * 180) / (float)Math.PI),2);
            if (Calcular_cuadrante(x, y) == 2)
                angle += 180;
            if (Calcular_cuadrante(x, y) == 3)
                angle = 180 - (-angle);
            if (Calcular_cuadrante(x, y) == 4)
                angle += 360;
            return angle;
        }
        public Point Convert_Point(Point point)
        {
            int pX = (point.X / 25) - 10;
            int pY = -(point.Y / 25) + 10;
            Point Convert_Point = new Point(pX, pY);

            return Convert_Point;
        }

        public void DrawRectangle(PictureBox picCanvas, Point PuntoA, Point PuntoB)
        {

            float auxBx = (float)PuntoB.X;
            float auxBy = (float)PuntoB.Y;
            float auxAx = (float)PuntoA.X;
            float auxAy = (float)PuntoA.Y;

            var rand = new Random();
            Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            mGraph = picCanvas.CreateGraphics();
            myPencil = new Pen(color, 2);

            mWidth = picCanvas.Width;
            mHeight = picCanvas.Height;
            mcX = mWidth / 2;
            mcY = mHeight / 2;

            float oX = mcX;
            float oY = mcY;

            auxAx = oX + (auxAx * scale);
            auxAy = oY - (auxAy * scale);
            auxBx = oX + (auxBx * scale);
            auxBy = oY - (auxBy * scale);

            //1
            mGraph.DrawLine(myPencil, auxAx, auxAy, auxAx, auxBy);
            //2
            mGraph.DrawLine(myPencil, auxAx, auxBy, auxBx, auxBy);
            //3
            mGraph.DrawLine(myPencil, auxBx, auxBy, auxBx, auxAy);
            //4
            mGraph.DrawLine(myPencil, auxBx, auxAy, auxAx, auxAy);
        }
        public void DrawRectangle(PictureBox picCanvas, Point PuntoA, Point PuntoB, float penWidth)
        {

            float auxBx = (float)PuntoB.X;
            float auxBy = (float)PuntoB.Y;
            float auxAx = (float)PuntoA.X;
            float auxAy = (float)PuntoA.Y;

            var rand = new Random();
            Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            mGraph = picCanvas.CreateGraphics();
            myPencil = new Pen(color, penWidth);

            mWidth = picCanvas.Width;
            mHeight = picCanvas.Height;
            mcX = mWidth / 2;
            mcY = mHeight / 2;

            float oX = mcX;
            float oY = mcY;

            auxAx = oX + (auxAx * scale);
            auxAy = oY - (auxAy * scale);
            auxBx = oX + (auxBx * scale);
            auxBy = oY - (auxBy * scale);

            //1
            mGraph.DrawLine(myPencil, auxAx, auxAy, auxAx, auxBy);
            //2
            mGraph.DrawLine(myPencil, auxAx, auxBy, auxBx, auxBy);
            //3
            mGraph.DrawLine(myPencil, auxBx, auxBy, auxBx, auxAy);
            //4
            mGraph.DrawLine(myPencil, auxBx, auxAy, auxAx, auxAy);
        }

        public void DrawTriangle(PictureBox picCanvas, Point PuntoA, Point PuntoB)
        {
            double Bx = PuntoB.X;
            double By = PuntoB.Y;
            double Ax = PuntoA.X;
            double Ay = PuntoA.Y;

            var rand = new Random();
            Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            mGraph = picCanvas.CreateGraphics();
            myPencil = new Pen(color, 2);

            mWidth = picCanvas.Width;
            mHeight = picCanvas.Height;
            mcX = mWidth / 2;
            mcY = mHeight / 2;       

            double distanceAB = Math.Sqrt(Math.Pow((Bx - Ax), 2) + (Math.Pow((By - Ay), 2)));
            double puntoMedioX = (Ax + Bx)/2;
            double puntoMedioY = (Ay + By)/2;
            //double altura = Math.Sqrt(Math.Pow(distanceAB, 2) - Math.Pow(distanceAB / 2, 2));
            double altura = (Math.Sqrt(3) / 2) * distanceAB;

            double auxX = -puntoMedioY;
            double auxY = puntoMedioX;

            double distanceAux = Math.Sqrt(Math.Pow(auxX, 2) + Math.Pow(auxY, 2));

            double Cx = altura * auxX / distanceAux;
            double Cy = altura * auxY / distanceAux;

            float oX = mcX;
            float oY = mcY;

            float auxAx = oX + (float)(Ax * scale);
            float auxAy = oY - (float)(Ay * scale);
            float auxBx = oX + (float)(Bx * scale);
            float auxBy = oY - (float)(By * scale);
            float auxCx = oX + (float)(Cx * scale);
            float auxCy = oY - (float)(Cy * scale);

            mGraph.DrawLine(myPencil, auxAx, auxAy, auxBx, auxBy);
            mGraph.DrawLine(myPencil, auxCx, auxCy, auxAx, auxAy);
            mGraph.DrawLine(myPencil, auxBx, auxBy, auxCx, auxCy);

            /*
            #region Imprimir magnitud vector
            Font txtFont = new Font("Arial", 8);
            SolidBrush txtBrush = new SolidBrush(Color.Red);
            float auxfX = scale * ();
            float auxfY = oY - (y * scale) / 2;
            if (x > 0 && y > 0)
                mGraph.DrawString(distance.ToString(), txtFont, txtBrush, auxfX + 10, auxfY - 10);
            else if (x < 0 && y < 0)
                mGraph.DrawString(Calcular_magnitud(x, y).ToString(), txtFont, txtBrush, auxfX - 10, auxfY + 10);
            else if (x > 0 && y < 0)
                mGraph.DrawString(Calcular_magnitud(x, y).ToString(), txtFont, txtBrush, auxfX + 10, auxfY + 10);
            else
                mGraph.DrawString(Calcular_magnitud(x, y).ToString(), txtFont, txtBrush, auxfX - 10, auxfY - 10);
            #endregion
            */
        }

        public double Calcular_Perimetro(Point PuntoA, Point PuntoB, String figura)
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

            this.datoAlto = alto;
            this.datoAncho = ancho;

            return perimetro;
        }

        public double Calcular_Area(Point PuntoA, Point PuntoB, String figura)
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
            else if( figura == "triangulo")
            {
                double ancho = Math.Abs(Bx - Ax);
                double alto = Math.Abs(By - Ay);

                area = (ancho * alto) / 2;
            }

            return area;
        }

    }
    #endregion
}