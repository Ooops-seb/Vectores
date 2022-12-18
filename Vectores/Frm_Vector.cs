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
using Vectores.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Vectores
{
    public partial class Frm_Vector : Form
    {
        Operations operation = new Operations();
        private float generalX;
        private float generalY;

        public Frm_Vector()
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
            Panel_SubMenuDibujarTriangulo.Visible = false;
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
            if (PanelSubMenuOperations.Visible == true)
                PanelSubMenuOperations.Visible = false;
            if (Panel_SubMenuDibujarCuadrado.Visible == true)
                Panel_SubMenuDibujarCuadrado.Visible = false;
            if (Panel_SubMenuDibujarTriangulo.Visible == true)
                Panel_SubMenuDibujarTriangulo.Visible = false;
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
            
            Graphic Graph = new Graphic();
            Graph.DrawMap(pctBox_Graph);
            
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
            Graphic map = new Graphic();
            pictureBox_FreeDraw.Visible = false;
            map.Clear(pctBox_Graph);
            map.DrawMap(pctBox_Graph);
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
                    Graphic map = new Graphic();
                    map.Clear(pctBox_Graph);
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
                float x = float.Parse(txtAxisX.Text);
                float y = float.Parse(txtAxisY.Text);
                Dots Punto = new Dots(x, y);
                VectorOrigin vector = new VectorOrigin(pctBox_Graph);
                vector.Draw_Origin(pctBox_Graph, Punto);
                lblMagnitud.Visible = true;
                lblCuadrante.Visible = true;
                lblMagnitud.Text = "" + operation.Magnitude(Punto);
                lblCuadrante.Text = "" + operation.Quadrant(Punto);
                lblAngulo.Visible = true;
                lblAngulo.Text = "" + operation.Angle(Punto) + " °";
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
                VectorOrigin vector = new VectorOrigin(pctBox_Graph);
                float escalar = float.Parse(txtEscalar.Text);
                float x = float.Parse(txtAxisX.Text);
                float y = float.Parse(txtAxisY.Text);
                Dots Punto = new Dots(escalar * x, escalar * y);
                vector.Draw_Origin(pctBox_Graph, Punto);               
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
                float x = float.Parse(txtAxisX.Text);
                float y = float.Parse(txtAxisY.Text);
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
                float x = float.Parse(txtAxisX.Text);
                float y = float.Parse(txtAxisY.Text);
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
            float x = float.Parse(txtAxisX.Text);
            float y = float.Parse(txtAxisY.Text);
            float auxX = float.Parse(lblVectorActualX_PnlCambiarSentido.Text);
            float auxY = float.Parse(lblVectorActualY_PnlCambiarSentido.Text);
            VectorOrigin vector = new VectorOrigin(pctBox_Graph);
            Dots Punto = new Dots(auxX, auxY);
            if (auxX == x && auxY == y)
                MessageBox.Show("El vector no ha cambiado de sentido");
            else
                vector.Draw_Origin(pctBox_Graph, Punto);
        }

        private void checkBoxX_Click(object sender, EventArgs e)
        {
            float x = float.Parse(txtAxisX.Text);
            float auxX = x;

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
            float y = float.Parse(txtAxisY.Text);
            float auxY = y;
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
                float x = float.Parse(txtAxisX.Text);
                float y = float.Parse(txtAxisY.Text);
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
                float X1 = float.Parse(txtSumaVectorX1.Text);
                float Y1 = float.Parse(txtSumaVectorY1.Text);
                float X2 = float.Parse(txtSumaVectorX2.Text);
                float Y2 = float.Parse(txtSumaVectorY2.Text);
                float auxX = X1 + X2;
                float auxY = Y1 + Y2;
                lblSumaX.Visible = true;
                lblSumaY.Visible = true;
                lblSumaX.Text = auxX.ToString();
                lblSumaY.Text = auxY.ToString();
                showOperationsMenu(PanelSumaVector);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese valores a sumar.");
            }
        }
        private void Btn_CalcularSuma_Click(object sender, EventArgs e)
        {
            float x1 = float.Parse(lblSumaX.Text);
            float y1 = float.Parse(lblSumaY.Text);
            VectorOrigin vector = new VectorOrigin(pctBox_Graph);
            Dots PuntoA = new Dots(x1, y1);
            vector.Draw_Origin(pctBox_Graph, PuntoA);
            float x2 = float.Parse(txtSumaVectorX2.Text);
            float y2 = float.Parse(txtSumaVectorY2.Text);
            Dots PuntoB = new Dots(x2, y2);
            vector.Draw_Origin(pctBox_Graph, PuntoB);
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
                float x1 = float.Parse(txtVectorRestaX1.Text);
                float y1 = float.Parse(txtVectorRestaY1.Text);
                float x2 = float.Parse(txtVectorRestaX2.Text);
                float y2 = float.Parse(txtVectorRestaY2.Text);

                float auxX = x1 - x2;
                float auxY = y1 - y2;
                lblRestaX.Visible = true;
                lblRestaY.Visible = true;
                lblRestaX.Text = auxX.ToString();
                lblRestaY.Text = auxY.ToString();
                showOperationsMenu(PanelRestaVector);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese valores a restar.");
            }
        }
        private void Btn_CalcularResta_Click(object sender, EventArgs e)
        {
            VectorOrigin vector = new VectorOrigin(pctBox_Graph);
            float x1 = float.Parse(lblRestaX.Text);
            float y1 = float.Parse(lblRestaY.Text);
            Dots PuntoA = new Dots(x1, y1);
            vector.Draw_Origin(pctBox_Graph, PuntoA);

            float x2 = float.Parse(txtVectorRestaX2.Text);
            float y2 = float.Parse(txtVectorRestaY2.Text);
            Dots PuntoB = new Dots(x2, y2);
            vector.Draw_Origin(pctBox_Graph, PuntoB);
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
                float x1 = float.Parse(txtVectorProductoX1.Text);
                float y1 = float.Parse(txtVectorProductoY1.Text);
                float x2 = float.Parse(txtVectorProductoX2.Text);
                float y2 = float.Parse(txtVectorProductoY2.Text);

                lblProductoX1.Visible = true;
                lblProductoX2.Visible = true;
                lblProductoY1.Visible = true;
                lblProductoY2.Visible = true;
                lblResultadoProducto.Visible = true;

                lblProductoX1.Text = x1.ToString();
                lblProductoX2.Text = x2.ToString();
                lblProductoY1.Text = y1.ToString();
                lblProductoY2.Text = y2.ToString();

                float resultado = (x1 * x2) + (y1 * y2);

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
                if ((e.Button == MouseButtons.Left) && (e.X < pctBox_Graph.Width && e.Y < pctBox_Graph.Height && e.Y >= 0 && e.X >= 0))
                {
                    Dots PuntoA = new Dots(operation.Convert_Point(e.Location));

                    txtCuadradoPuntoAx.Text = Math.Round(PuntoA.fX,2).ToString();
                    txtCuadradoPuntoAy.Text = Math.Round(PuntoA.fY,2).ToString();
                    Figure punto = new Figure(pctBox_Graph);
                    punto.DrawPoint(pctBox_Graph, PuntoA);
                }
                else if ((e.Button == MouseButtons.Right) && (e.X < pctBox_Graph.Width && e.Y < pctBox_Graph.Height && e.Y >= 0 && e.X >= 0))
                {   
                    Dots PuntoB = new Dots(operation.Convert_Point(e.Location));

                    txtCuadradoPuntoBx.Text = Math.Round(PuntoB.fX,2).ToString();
                    txtCuadradoPuntoBy.Text = Math.Round(PuntoB.fY,2).ToString();
                    Figure punto = new Figure(pctBox_Graph);
                    punto.DrawPoint(pctBox_Graph, PuntoB);
                }
            }
            else if (Panel_SubMenuDibujarTriangulo.Visible == true)
            {
                if ((e.Button == MouseButtons.Left) && (e.X < pctBox_Graph.Width && e.Y < pctBox_Graph.Height && e.Y >= 0 && e.X >= 0))
                {
                    Dots PuntoA = new Dots(operation.Convert_Point(e.Location));
                    
                    txtTrianguloAx.Text = Math.Round(PuntoA.fX,2).ToString();
                    txtTrianguloAy.Text = Math.Round(PuntoA.fY,2).ToString();
                    Figure punto = new Figure(pctBox_Graph);
                    punto.DrawPoint(pctBox_Graph, PuntoA);
                }
                else if ((e.Button == MouseButtons.Right) && (e.X < pctBox_Graph.Width && e.Y < pctBox_Graph.Height && e.Y >= 0 && e.X >= 0))
                {
                    Dots PuntoB = new Dots(operation.Convert_Point(e.Location));
                    
                    txtTrianguloBx.Text = Math.Round(PuntoB.fX,2).ToString();
                    txtTrianguloBy.Text = Math.Round(PuntoB.fY,2).ToString();
                    Figure punto = new Figure(pctBox_Graph);
                    punto.DrawPoint(pctBox_Graph, PuntoB);
                }
            }
            else if (Panel_SubMenuDibujar.Visible == true)
            {
                Dots Punto = new Dots(operation.Convert_Point(e.Location));
                VectorOrigin vector = new VectorOrigin(pctBox_Graph);

                txtAxisX.Text = Math.Round(Punto.fX,2).ToString();
                txtAxisY.Text = Math.Round(Punto.fY,2).ToString();
                generalX = Punto.fX;
                generalY = Punto.fY;

                vector.Draw_Origin(pctBox_Graph, Punto);
            }
            else if (Panel_SubMenuRecta.Visible == true)
            {
                if ((e.Button == MouseButtons.Left) && (e.X < pctBox_Graph.Width && e.Y < pctBox_Graph.Height && e.Y >= 0 && e.X >= 0))
                {
                    Dots PuntoA = operation.Convert_Point(e.Location);
                    txtPuntoAx.Text = PuntoA.fX.ToString();
                    txtPuntoAy.Text = PuntoA.fY.ToString();
                }
                else if ((e.Button == MouseButtons.Right) && (e.X < pctBox_Graph.Width && e.Y < pctBox_Graph.Height && e.Y >= 0 && e.X >= 0))
                {
                    Dots PuntoB = operation.Convert_Point(e.Location);

                    txtPuntoBx.Text = PuntoB.fX.ToString();
                    txtPuntoBy.Text = PuntoB.fY.ToString();
                }
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
                VectorOrigin vector = new VectorOrigin(pctBox_Graph);
                Dots Punto = new Dots((float)generalX, (float)generalY);
                float angle = operation.Angle(Punto);
                float mag = operation.Magnitude(Punto);
                float cuad = operation.Quadrant(Punto);
                double auxX;
                double auxY;
                float auxAngle = angle;
                for (int i = 0; i < 100; i += 1)
                {
                    pctBox_Graph.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                    auxAngle += angle;
                    auxX = Math.Round(mag * Math.Cos(auxAngle));
                    auxY = Math.Round(mag * Math.Sin(auxAngle));
                    Dots PuntoAux = new Dots((float)auxX, (float)auxY);
                    vector.Draw_Origin(pctBox_Graph, PuntoAux);
                    Thread.Sleep(100);
                }
                pctBox_Graph.Cursor = System.Windows.Forms.Cursors.Cross;
            }
            catch(Exception msg)
            {
                MessageBox.Show("¡Ingrese valores a dibujar!"+msg);
            }
        }

        private void Btn_SubMenuRecta_Click(object sender, EventArgs e)
        {
            showSubMenu(Panel_SubMenuRecta);
        }

        private void Btn_SubMenuCuadrado_Click(object sender, EventArgs e)
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
                catch(Exception msg)
                {
                    MessageBox.Show("¡Ingrese valores a dibujar!" + msg);
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
                float Ax = float.Parse(txtCuadradoPuntoAx.Text);
                float Ay = float.Parse(txtCuadradoPuntoAy.Text);
                float Bx = float.Parse(txtCuadradoPuntoBx.Text);
                float By = float.Parse(txtCuadradoPuntoBy.Text);

                Dots PuntoA = new Dots(Ax, Ay);
                Dots PuntoB = new Dots(Bx, By);

                Figure figura = new Figure(pctBox_Graph);
                figura.Rectangle(pctBox_Graph, PuntoA, PuntoB);
            }
            catch(Exception msg)
            {
                MessageBox.Show("¡Ingrese valores a dibujar!"+msg);
            }
        }

        private void Btn_SubMenuTriangulo_Click(object sender, EventArgs e)
        {
            showSubMenu(Panel_SubMenuDibujarTriangulo);
        }

        private void Btn_DibujarFigurasTriangulo_Click(object sender, EventArgs e)
        {
            try
            {
                Panel_TrianguloDibujar.Visible = true;
                lblBaseTriangulo.Visible = true;
                lblAlturaTriangulo.Visible = true;
                lblAreaTriangulo.Visible = true;
                lblPerimetroTriangulo.Visible = true;

                float Ax = float.Parse(txtTrianguloAx.Text);
                float Ay = float.Parse(txtTrianguloAy.Text);
                float Bx = float.Parse(txtTrianguloBx.Text);
                float By = float.Parse(txtTrianguloBy.Text);

                Dots PuntoA = new Dots(Ax, Ay);
                Dots PuntoB = new Dots(Bx, By);

                Figure figura = new Figure(pctBox_Graph);
                figura.Triangle(pctBox_Graph, PuntoA, PuntoB);
            }
            catch (Exception msg)
            {
                MessageBox.Show("¡Ingrese valores a dibujar!"+msg);
            }
        }

        private void btn_CalcularEcuacionRecta_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception msg)
            {
                MessageBox.Show("¡Ingrese valores a dibujar!"+msg);
            }
        }
    }
}