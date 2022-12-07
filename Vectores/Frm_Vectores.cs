using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Vectores
{
    public partial class Frm_Vectores : Form
    {
        VectorOrigen vect = new VectorOrigen(0, 0);
        private float generalX;
        private float generalY;

        public Frm_Vectores()
        {
            InitializeComponent();
            customizeDesing();
        }

        #region Menu Personalizado
        private void customizeDesing()
        {
            Panel_SubMenuDibujar .Visible = false;
            PanelSubMenuOperations.Visible = false;
            PanelSubMenuOperationsEscalar.Visible = false;
            PanelSubMenuOperationsSuma.Visible = false;
            PanelSubMenuOperationsProducto.Visible = false;
            PanelSubMenuOperationsResta.Visible = false;
            PanelSubMenuOperationsSentido.Visible = false;
            PanelSubMenuOperationsSuma.Visible = false;
            Panel_MenuDibujarOrigen.Visible = false;
            Panel_DibujarFiguras.Visible = false;
            Panel_SubMenuDibujarCuadrado.Visible = false;
            Panel_SubMenuRecta.Visible = false;
            Panel_SubMenuDibujoLibre.Visible = false;
            Panel_CuadradoDibujar.Visible = false;
        }

        private void hideMenu()
        {
            if (Panel_MenuDibujarOrigen.Visible == true)
                Panel_MenuDibujarOrigen.Visible = false;
            if (Panel_DibujarFiguras.Visible == true)
                Panel_DibujarFiguras.Visible = false;
            if (Panel_SubMenuDibujoLibre.Visible == true)
                Panel_SubMenuDibujoLibre.Visible = false;
        }
        private void hideSubMenu()
        {
            //if (Panel_SubMenuDibujar )
            if (PanelSubMenuOperations.Visible == true)
                PanelSubMenuOperations.Visible = false;
            if (Panel_SubMenuDibujarCuadrado.Visible == true)
                Panel_SubMenuDibujarCuadrado.Visible = false;
            if (Panel_SubMenuRecta.Visible == true)
                Panel_SubMenuRecta.Visible = false;
            if (Panel_CuadradoDibujar.Visible == true)
                Panel_CuadradoDibujar.Visible = false;
        }

        private void hideSubSubMenu()
        {
            if (PanelSubMenuOperationsEscalar.Visible == true)
                PanelSubMenuOperationsEscalar.Visible = false;
            if (PanelSubMenuOperationsSuma.Visible == true)
                PanelSubMenuOperationsSuma.Visible = false;
            if (PanelSubMenuOperationsProducto.Visible == true)
                PanelSubMenuOperationsProducto.Visible = false;
            if (PanelSubMenuOperationsResta.Visible == true)
                PanelSubMenuOperationsResta.Visible = false;
            if (PanelSubMenuOperationsSentido.Visible == true)
                PanelSubMenuOperationsSentido.Visible = false;
        }

        private void hideSubOperationsMenu()
        {
            if (PanelSumaVector.Visible == true)
                PanelSumaVector.Visible = false;
            if (PanelRestaVector.Visible == true)
                PanelRestaVector.Visible = false;
            if (PanelProductoVector.Visible == true)
                PanelProductoVector.Visible = false;
        }

        private void showMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                hideMenu();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void showSubSubMenu(Panel subSubMenu)
        {
            if (subSubMenu.Visible == false)
            {
                hideSubSubMenu();
                subSubMenu.Visible = true;
            }
            else
                subSubMenu.Visible = false;
        }
        
        private void showOperationsMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubOperationsMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void Btn_MenuDibujarOrigen_Click(object sender, EventArgs e)
        {
            pictureBox_FreeDraw.Visible = false;
            Btn_ReDraw.Visible = true;
            vect.DrawAxis(pctBox_Graph);
            BtnMenuOperations.Visible = true;
            showSubMenu(Panel_SubMenuDibujar );
            showMenu(Panel_MenuDibujarOrigen);
        }

        private void BtnMenuOperations_Click(object sender, EventArgs e)
        {
            pictureBox_FreeDraw.Visible=false;
            showSubMenu(PanelSubMenuOperations);
            hideSubSubMenu();
        }

        private void Btn_MenuEcuaciones_Click(object sender, EventArgs e)
        {
            pictureBox_FreeDraw.Visible = false;
            vect.Limpiar(pctBox_Graph);
            vect.DrawAxis(pctBox_Graph);
            showMenu(Panel_DibujarFiguras);
        }
        #endregion

        #region Funcionalidades de menus Vector desde Origen

        #region Manejo de planos
        private void Btn_ReDraw_Click(object sender, EventArgs e)
        {
            try
            {
                if(pictureBox_FreeDraw.Visible == true)
                {
                    mig = new Bitmap(pictureBox_FreeDraw.Width, pictureBox_FreeDraw.Height);
                    pictureBox_FreeDraw.Image = mig;
                    imEditor = Graphics.FromImage(mig);
                }
                else
                {
                    vect.Limpiar(pctBox_Graph);
                    if (PanelDetallesGrafico.Visible == false)
                        PanelDetallesGrafico.Visible = true;
                    lblMagnitud.Visible = true;
                    lblCuadrante.Visible = true;
                    lblAngulo.Visible = true;
                    lblMagnitud.Text = "Ingresa";
                    lblCuadrante.Text = "un";
                    lblAngulo.Text = "vector.";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No se ha graficado ningún plano.");
            }
        }
        private void Btn_DrawVector_Click(object sender, EventArgs e)
        {
            try
            {
                if (PanelDetallesGrafico.Visible == false)
                    PanelDetallesGrafico.Visible = true;
                int x = int.Parse(txtAxisX.Text);
                int y = int.Parse(txtAxisY.Text);
                vect.DrawVector(pctBox_Graph, x, y);
                lblMagnitud.Visible = true;
                lblCuadrante.Visible = true;
                lblMagnitud.Text = "" + vect.Calcular_magnitud(x, y);
                lblCuadrante.Text = "" + vect.Calcular_cuadrante(x, y);
                lblAngulo.Visible = true;
                lblAngulo.Text = "" + vect.Calcular_angulo(x, y) + " °";
            }
            catch(Exception)
            {
                MessageBox.Show("Ingrese valores para graficar.");
            }
        }
        #endregion

        #region Dibujar Escalar
        private void BtnAplicarEscalar_Click(object sender, EventArgs e)
        {
            try
            {
                int escalar = int.Parse(txtEscalar.Text);
                int x = int.Parse(txtAxisX.Text);
                int y = int.Parse(txtAxisY.Text);
                vect.DrawColorVector(pctBox_Graph, escalar * x, escalar * y);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese valores para graficar.");
            }
        }

        private void Btn_SubMenuOperationsEscalar_Click(object sender, EventArgs e)
        {
            try
            {
                PanelSubMenuOperationsEscalar.Enabled = true;
                int x = int.Parse(txtAxisX.Text);
                int y = int.Parse(txtAxisY.Text);
                lblVectorActual_PnlEscalar.Visible = true;
                lblVectorActual_PnlEscalar.Text = "(" + x + " , " + y + ")";
            }
            catch (Exception)
            {
                PanelSubMenuOperationsEscalar.Enabled = false;
                MessageBox.Show("Ingrese valores para graficar.");
            }

            showSubSubMenu(PanelSubMenuOperationsEscalar);
        }
        #endregion

        #region Dibujar Sentido
        private void Btn_SubMenuOperationsSentido_Click(object sender, EventArgs e)
        {
            try
            {
                PanelSubMenuOperationsSentido.Enabled = true;
                int x = int.Parse(txtAxisX.Text);
                int y = int.Parse(txtAxisY.Text);
                lblVectorActualX_PnlCambiarSentido.Visible = true;
                lblVectorActualY_PnlCambiarSentido.Visible = true;
                lblVectorActualX_PnlCambiarSentido.Text = x.ToString();
                lblVectorActualY_PnlCambiarSentido.Text = y.ToString();
            }
            catch (Exception)
            {
                PanelSubMenuOperationsSentido.Enabled = false;
                MessageBox.Show("Ingrese valores para graficar.");
            }
            showSubSubMenu(PanelSubMenuOperationsSentido);
        }

        private void BtnCambiarSentido_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtAxisX.Text);
            int y = int.Parse(txtAxisY.Text);
            int auxX = int.Parse(lblVectorActualX_PnlCambiarSentido.Text);
            int auxY = int.Parse(lblVectorActualY_PnlCambiarSentido.Text);
            if (auxX == x && auxY == y)
                MessageBox.Show("El vector no ha cambiado de sentido");
            else
                vect.DrawColorVector(pctBox_Graph, auxX, auxY);
        }

        private void checkBoxX_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtAxisX.Text);
            int auxX = x;

            if (checkBoxX.Checked == true)
            {
                auxX = (-1) * x;
                lblVectorActualX_PnlCambiarSentido.Text = auxX.ToString();
            }
            else
            {
                lblVectorActualX_PnlCambiarSentido.Text = auxX.ToString();
            }
        }

        private void checkBoxY_Click(object sender, EventArgs e)
        {
            int y = int.Parse(txtAxisY.Text);
            int auxY = y;
            if (checkBoxY.Checked == true)
            {
                auxY = (-1) * y;
                lblVectorActualY_PnlCambiarSentido.Text = auxY.ToString();
            }
            else
            {
                lblVectorActualY_PnlCambiarSentido.Text = auxY.ToString();
            }
        }
        #endregion

        #region Calcular Suma
        private void Btn_SubMenuOperationsSuma_Click(object sender, EventArgs e)
        {
            try
            {
                PanelSuma.Enabled = true;
                PanelSubMenuOperationsSuma.Enabled = true;
                int x = int.Parse(txtAxisX.Text);
                int y = int.Parse(txtAxisY.Text);
                txtSumaVectorX1.Text = x.ToString();
                txtSumaVectorY1.Text = y.ToString();
            }
            catch (Exception)
            {
                PanelSuma.Enabled = false;
                MessageBox.Show("Ingrese valores para graficar.");
            }

            showSubSubMenu(PanelSubMenuOperationsSuma);
        }
        private void BtnCalcularSuma_Click(object sender, EventArgs e)
        {
            try
            {
                int vectX1 = int.Parse(txtSumaVectorX1.Text);
                int vectY1 = int.Parse(txtSumaVectorY1.Text);
                int vectX2 = int.Parse(txtSumaVectorX2.Text);
                int vectY2 = int.Parse(txtSumaVectorY2.Text);
                int auxSumaX = vectX1 + vectX2;
                int auxSumaY = vectY1 + vectY2;
                lblSumaX.Visible = true;
                lblSumaY.Visible = true;
                lblSumaX.Text = auxSumaX.ToString();
                lblSumaY.Text = auxSumaY.ToString();
                showOperationsMenu(PanelSumaVector);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese valores a sumar.");
            }
        }
        private void Btn_CalcularSuma_Click(object sender, EventArgs e)
        {
            int x = int.Parse(lblSumaX.Text);
            int y = int.Parse(lblSumaY.Text);
            vect.DrawColorVector(pctBox_Graph, x, y);
            int vectX2 = int.Parse(txtSumaVectorX2.Text);
            int vectY2 = int.Parse(txtSumaVectorY2.Text);
            vect.DrawColorVector(pctBox_Graph, vectX2, vectY2);
        }
        #endregion

        #region Calcular Resta
        private void Btn_SubMenuOperationsResta_Click(object sender, EventArgs e)
        {
            try
            {
                PanelResta.Enabled = true;
                PanelSubMenuOperationsResta.Enabled = true;

                txtVectorRestaX1.Text = txtAxisX.Text;
                txtVectorRestaY1.Text = txtAxisY.Text;

                showSubSubMenu(PanelSubMenuOperationsResta);
            }
            catch (Exception)
            {
                PanelSuma.Enabled = false;
                MessageBox.Show("Ingrese valores para graficar.");
            }
        }

        private void BtnCalcularResta_Click(object sender, EventArgs e)
        {
            try
            {
                int vectX1 = int.Parse(txtVectorRestaX1.Text);
                int vectY1 = int.Parse(txtVectorRestaY1.Text);
                int vectX2 = int.Parse(txtVectorRestaX2.Text);
                int vectY2 = int.Parse(txtVectorRestaY2.Text);

                int auxRestaX = vectX1 - vectX2;
                int auxRestaY = vectY1 - vectY2;
                lblRestaX.Visible = true;
                lblRestaY.Visible = true;
                lblRestaX.Text = auxRestaX.ToString();
                lblRestaY.Text = auxRestaY.ToString();
                showOperationsMenu(PanelRestaVector);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese valores a restar.");
            }
        }
        private void Btn_CalcularResta_Click(object sender, EventArgs e)
        {
            int x = int.Parse(lblRestaX.Text);
            int y = int.Parse(lblRestaY.Text);
            vect.DrawColorVector(pctBox_Graph, x, y);

            int x2 = int.Parse(txtVectorRestaX2.Text);
            int y2 = int.Parse(txtVectorRestaY2.Text);
            vect.DrawColorVector(pctBox_Graph, x2, y2);
        }
        #endregion

        #region Calcular Producto
        private void Btn_SubMenuOperationsProducto_Click(object sender, EventArgs e)
        {
            try
            {
                PanelProducto.Enabled = true;
                PanelSubMenuOperationsProducto.Enabled = true;

                txtVectorProductoX1.Text = txtAxisX.Text;
                txtVectorProductoY1.Text = txtAxisY.Text;

                showSubSubMenu(PanelSubMenuOperationsProducto);
            }
            catch (Exception)
            {
                PanelProducto.Enabled = false;
                PanelSubMenuOperationsProducto.Enabled = false;
                MessageBox.Show("Ingrese valores para graficar.");
            }
        }
        private void BtnCalcularProducto_Click(object sender, EventArgs e)
        {
            try
            {
                int vectX1 = int.Parse(txtVectorProductoX1.Text);
                int vectY1 = int.Parse(txtVectorProductoY1.Text);
                int vectX2 = int.Parse(txtVectorProductoX2.Text);
                int vectY2 = int.Parse(txtVectorProductoY2.Text);

                lblProductoX1.Visible = true;
                lblProductoX2.Visible = true;
                lblProductoY1.Visible = true;
                lblProductoY2.Visible = true;
                lblResultadoProducto.Visible = true;

                lblProductoX1.Text = vectX1.ToString();
                lblProductoX2.Text = vectX2.ToString();
                lblProductoY1.Text = vectY1.ToString();
                lblProductoY2.Text = vectY2.ToString();

                int resultado = (vectX1 * vectX2) + (vectY1 * vectY2);

                lblResultadoProducto.Text = resultado.ToString();

                showOperationsMenu(PanelProductoVector);
            }
            catch(Exception)
            {
                MessageBox.Show("Ingrese valores a calcular.");
            }
        }
        #endregion

        #endregion

        private void pctBox_Graph_MouseDown(object sender, MouseEventArgs e)
        {
            if (Panel_SubMenuDibujarCuadrado.Visible == true)
            {
                Point AuxPuntoB = new Point();
                Point AuxPuntoA = new Point();
                
                if ((e.Button == MouseButtons.Left) && (e.X < pctBox_Graph.Width && e.Y < pctBox_Graph.Height && e.Y >= 0 && e.X >= 0))
                {
                    
                    AuxPuntoA = vect.Convert_Point(e.Location);

                    txtCuadradoPuntoAx.Text = AuxPuntoA.X.ToString();
                    txtCuadradoPuntoAy.Text = AuxPuntoA.Y.ToString(); 
                }
                else if ((e.Button == MouseButtons.Right) && (e.X < pctBox_Graph.Width && e.Y < pctBox_Graph.Height && e.Y >= 0 && e.X >= 0))
                {
                    
                    AuxPuntoB = vect.Convert_Point(e.Location);

                    txtCuadradoPuntoBx.Text = AuxPuntoB.X.ToString();
                    txtCuadradoPuntoBy.Text = AuxPuntoB.Y.ToString();
                }

                vect.DrawRectangle(pctBox_Graph, AuxPuntoA, AuxPuntoB);
            }
            else if (Panel_SubMenuDibujar .Visible == true){
                //txtAxisX.Text = e.X.ToString();
                //txtAxisY.Text = e.Y.ToString();

                Point AuxPoint = new Point();
                AuxPoint = vect.Convert_Point(e.Location);

                vect.Convert_Point(AuxPoint);

                txtAxisX.Text = AuxPoint.X.ToString();
                txtAxisY.Text = AuxPoint.Y.ToString();
                generalX = AuxPoint.X;
                generalY = AuxPoint.Y;
                vect.DrawColorVector(pctBox_Graph, generalX, generalY);
            }
            else
            {

            }
        }

        private void linkLabel_DibujarMouse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pctBox_Graph.Cursor = System.Windows.Forms.Cursors.Cross;
        }

        private void linkLabel_Animar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                float angle = vect.Calcular_angulo(generalX, generalY);
                float mag = vect.Calcular_magnitud(generalX, generalY);
                float cuad = vect.Calcular_cuadrante(generalX, generalY);
                double auxX;
                double auxY;
                float auxAngle = angle;
                for (int i = 0; i < 100; i += 1)
                {
                    pctBox_Graph.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                    auxAngle += angle;
                    auxX = Math.Round(mag * Math.Cos(auxAngle));
                    auxY = Math.Round(mag * Math.Sin(auxAngle));
                    vect.DrawColorVector(pctBox_Graph, (float)auxX, (float)auxY);
                    Thread.Sleep(100);
                }
                pctBox_Graph.Cursor = System.Windows.Forms.Cursors.Cross;
            }
            catch(Exception Msg)
            {
                MessageBox.Show("" + Msg);
            }
        }

        private void Btn_SubMenuRecta_Click(object sender, EventArgs e)
        {
            //showSubMenu(Panel_SubMenuRecta);
        }

        private void Btn_SubMenuCuadratica_Click(object sender, EventArgs e)
        {
            showSubMenu(Panel_SubMenuDibujarCuadrado);
        }

        private void Frm_Vectores_Load(object sender, EventArgs e)
        {
            mig = new Bitmap(pctBox_Graph.Width, pctBox_Graph.Height);
            imEditor = Graphics.FromImage(mig);
            penGrosor = new Pen(Color.Black, 10);
            brushRelleno = new SolidBrush(Color.FromArgb(255, 255, 255));
        }

        //DIBUJO ARCOIRIS
        private void pictureBox_FreeDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (Panel_SubMenuDibujar .Visible == false)
            {
                var rand = new Random();
                pictureBox_FreeDraw.Visible = true;
                pictureBox_FreeDraw.Image = (Image)mig;
                try
                {
                    if ((e.Button == MouseButtons.Left) && (e.X < pictureBox_FreeDraw.Width && e.Y < pictureBox_FreeDraw.Height && e.Y >= 0 && e.X >= 0))
                    {
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X, e.Y, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X + 1, e.Y + 1, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X - 1, e.Y - 1, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X + 1, e.Y - 1, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X - 1, e.Y + 1, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X + 2, e.Y + 2, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X - 2, e.Y - 2, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X + 2, e.Y - 2, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X - 2, e.Y + 2, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X + 2, e.Y + 1, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X - 2, e.Y - 1, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X + 2, e.Y - 1, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X - 2, e.Y + 1, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X + 1, e.Y + 2, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X - 1, e.Y - 2, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X + 1, e.Y - 2, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X - 1, e.Y + 2, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X, e.Y + 1, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X, e.Y - 1, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X + 1, e.Y, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                        ((Bitmap)pictureBox_FreeDraw.Image).SetPixel(e.X - 1, e.Y, Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                    }
                }
                catch(Exception)
                {
                }
            }
            else
            {
                pictureBox_FreeDraw.Visible = false;
            }
        }

        private void Btn_MenuDibujoLibre_Click(object sender, EventArgs e)
        {
            Btn_ReDraw.Visible = true;
            showMenu(Panel_SubMenuDibujoLibre);
            pictureBox_FreeDraw.Visible = true;
        }

        private void Btn_DibujarFigurasCuadrado_Click(object sender, EventArgs e)
        {
            try
            {
                int aX = Convert.ToInt32(txtCuadradoPuntoAx.Text);
                int aY = Convert.ToInt32(txtCuadradoPuntoAy.Text);

                int bX = Convert.ToInt32(txtCuadradoPuntoBx.Text);
                int bY = Convert.ToInt32(txtCuadradoPuntoBy.Text);

                Point PuntoA = new Point(aX, aY);
                Point PuntoB = new Point(bX, bY);
                vect.DrawRectangle(pctBox_Graph, PuntoA, PuntoB);

                #region Calcular Perimetro y Área
                double perimetro = vect.Calcular_Perimetro(pctBox_Graph, PuntoA, PuntoB);
                lblPerimetroCuadrado.Visible = true;
                lblPerimetroCuadrado.Text = Math.Round(perimetro,2).ToString();
                double area = vect.Calcular_Area(pctBox_Graph, PuntoA, PuntoB);
                lblAreaCuadrado.Visible = true;
                lblAreaCuadrado.Text = Math.Round(area,2).ToString();

                lblBaseCuadrado.Visible = true;
                lblBaseCuadrado.Text = vect.datoAncho.ToString();
                lblAlturaCuadrado.Visible = true;
                lblAlturaCuadrado.Text = vect.datoAlto.ToString();

                Panel_CuadradoDibujar.Visible = true;
                //showSubMenu(Panel_CuadradoDibujar);
                #endregion
            }
            catch(Exception)
            {
                MessageBox.Show("¡Ingrese valores a dibujar!");
            }
        }

    }
}