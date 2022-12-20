using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vectores.Classes
{
    internal class Graphic
    {
        public float Width;
        public float Height;

        public int scale = 25;

        //Variable
        public float AxisX;
        public float AxisY;

        //Graphics
        private Graphics Graph;

        //Pens
        Pen AxisPen = new Pen(Color.Gray, 2);

        //brush
        SolidBrush FontBrush = new SolidBrush(Color.Gray);

        //Font
        Font TextFont = new Font("Source Sans Pro Extraclara", 10);

        public Graphic()
        {
            //Constructor
        }

        #region Control de plano dibujado en Picture Box

        public void DrawMap(PictureBox PicCanvas)
        {
            Graph = PicCanvas.CreateGraphics();
            PicCanvas.BackColor = Color.White;
            PicCanvas.Cursor = Cursors.Cross;

            this.Width= PicCanvas.Width;
            this.Height= PicCanvas.Height;

            this.AxisX= Width/2;
            this.AxisY= Height/2;

            float oX = this.AxisX;
            float oY = this.AxisY;

            //Eje X
            Graph.DrawLine(AxisPen, 0, oY, this.Width, oY);
            int topY = 11;
            for (int i=0; i < this.Width; i += scale)
            {
                Graph.DrawLine(AxisPen, oX - 5, i, oX + 5, i);
                if (topY != 0)
                {
                    Graph.DrawString(topY.ToString(), TextFont, FontBrush, Height - i, oY);
                    topY--;
                }
                else topY--;
            }

            //Eje Y
            int topX = -11;
            Graph.DrawLine(AxisPen, oX, 0, oX, this.Height);
            for (int i = 0; i < this.Height; i += scale)
            {
                Graph.DrawLine(AxisPen, i, oY - 5, i, oY + 5);
                if (topX != 0)
                {
                    Graph.DrawString(topX.ToString(), TextFont, FontBrush, oX, Width - i);
                    topX++;
                }
                else topX++;
            }
        }

        public void Clear(PictureBox PicCanvas)
        {
            //Graph.Dispose();
            Graph = PicCanvas.CreateGraphics();
            Graph.Clear(Color.White);
            DrawMap(PicCanvas);
        }
        #endregion
    }
}
