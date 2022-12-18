using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    public class Dots
    {
        private int IntX;
        private int IntY;

        private float FloatX;
        private float FloatY;

        private double DoubleX;
        private double DoubleY;

        public static readonly Dots Empty;

        [Browsable(false)]
        public bool IsEmptyInt
        {
            get
            {
                if (IntX == 0)
                {
                    return IntY == 0;
                }

                return false;
            }
        }

        [Browsable(false)]
        public bool IsEmptyFloat
        {
            get
            {
                if (FloatX == 0)
                {
                    return FloatY == 0;
                }

                return false;
            }
        }

        [Browsable(false)]
        public bool IsEmptyDouble
        {
            get
            {
                if (DoubleX == 0)
                {
                    return DoubleY == 0;
                }

                return false;
            }
        }

        public int iX
        {
            get
            {
                return IntX;
            }
            set
            {
                IntX = value;
            }
        }

        public int iY
        {
            get
            {
                return IntY;
            }
            set
            {
                IntY = value;
            }
        }

        public double dX
        {
            get
            {
                return DoubleX;
            }
            set
            {
                DoubleX = value;
            }
        }

        public double dY
        {
            get
            {
                return DoubleY;
            }
            set
            {
                DoubleY = value;
            }
        }

        public float fX
        {
            get
            {
                return FloatX;
            }
            set
            {
                FloatX = value;
            }
        }

        public float fY
        {
            get { 
                return FloatY;
            }
            set
            {
                FloatY = value;
            }
        }
        
        public Dots(int IntX, int IntY)
        {
            this.IntX = IntX;
            this.IntY = IntY;
        }

        public Dots(float FloatX, float FloatY)
        {
            this.FloatX= FloatX;
            this.FloatY= FloatY;
        }

        public Dots(double DoubleX, double DoubleY)
        {
            this.DoubleX = DoubleX;
            this.DoubleY = DoubleY;
        }

        public Dots(Point Point)
        {
            this.IntX = Point.X;
            this.IntY = Point.Y;
        }

        public Dots(Dots Point)
        {
            this.FloatX = Point.fX;
            this.FloatY = Point.fY;
        }
    }
}