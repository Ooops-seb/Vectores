using System.Drawing;

namespace Vectores
{
    partial class Frm_Vectores
    {
        Bitmap mig;
        Graphics imEditor;
        Pen penGrosor;
        SolidBrush brushRelleno;
        int rojo, verde, azul = 0;
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_FreeDraw = new System.Windows.Forms.PictureBox();
            this.pctBox_Graph = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_ReDraw = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.Panel_SubMenuDibujoLibre = new System.Windows.Forms.Panel();
            this.label52 = new System.Windows.Forms.Label();
            this.Btn_MenuDibujoLibre = new System.Windows.Forms.Button();
            this.Panel_Ecuaciones = new System.Windows.Forms.Panel();
            this.Panel_SubMenuCuadratica = new System.Windows.Forms.Panel();
            this.label73 = new System.Windows.Forms.Label();
            this.Btn_SubMenuCuadratica = new System.Windows.Forms.Button();
            this.Panel_SubMenuRecta = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtPendiente = new System.Windows.Forms.TextBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txtPuntoY = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.txtPuntoX = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtPuntoBY = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txtPuntoBX = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtPuntoAY = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtPuntoAX = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.boxEcuacion = new System.Windows.Forms.GroupBox();
            this.txtEcuacionB = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.txtEcuacionY = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.txtEcuacionX = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.btn_CalcularEcuacionRecta = new System.Windows.Forms.Button();
            this.Btn_SubMenuRecta = new System.Windows.Forms.Button();
            this.Btn_DibujarFiguras = new System.Windows.Forms.Button();
            this.Panel_MenuDibujarOrigen = new System.Windows.Forms.Panel();
            this.PanelSubMenuOperations = new System.Windows.Forms.Panel();
            this.PanelSubMenuOperationsProducto = new System.Windows.Forms.Panel();
            this.PanelProductoVector = new System.Windows.Forms.Panel();
            this.lblResultadoProducto = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblProductoX2 = new System.Windows.Forms.Label();
            this.lblProductoX1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.lblProductoY2 = new System.Windows.Forms.Label();
            this.lblProductoY1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.PanelProducto = new System.Windows.Forms.Panel();
            this.BtnCalcularProducto = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtVectorProductoY2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtVectorProductoX2 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtVectorProductoY1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtVectorProductoX1 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.Btn_SubMenuOperationsProducto = new System.Windows.Forms.Button();
            this.PanelSubMenuOperationsResta = new System.Windows.Forms.Panel();
            this.PanelRestaVector = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lblRestaY = new System.Windows.Forms.Label();
            this.lblRestaX = new System.Windows.Forms.Label();
            this.Btn_CalcularResta = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.PanelResta = new System.Windows.Forms.Panel();
            this.BtnCalcularResta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVectorRestaY2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtVectorRestaX2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtVectorRestaY1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtVectorRestaX1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Btn_SubMenuOperationsResta = new System.Windows.Forms.Button();
            this.PanelSubMenuOperationsSuma = new System.Windows.Forms.Panel();
            this.PanelSumaVector = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblSumaY = new System.Windows.Forms.Label();
            this.lblSumaX = new System.Windows.Forms.Label();
            this.Btn_CalcularSuma = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.PanelSuma = new System.Windows.Forms.Panel();
            this.BtnCalcularSuma = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtSumaVectorY2 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtSumaVectorX2 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtSumaVectorY1 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSumaVectorX1 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.Btn_SubMenuOperationsSuma = new System.Windows.Forms.Button();
            this.PanelSubMenuOperationsSentido = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVectorActualY_PnlCambiarSentido = new System.Windows.Forms.Label();
            this.BtnCambiarSentido = new System.Windows.Forms.Button();
            this.lblVectorActualX_PnlCambiarSentido = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxY = new System.Windows.Forms.CheckBox();
            this.checkBoxX = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_SubMenuOperationsSentido = new System.Windows.Forms.Button();
            this.PanelSubMenuOperationsEscalar = new System.Windows.Forms.Panel();
            this.lblVectorActual_PnlEscalar = new System.Windows.Forms.Label();
            this.BtnAplicarEscalar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEscalar = new System.Windows.Forms.TextBox();
            this.Btn_SubMenuOperationsEscalar = new System.Windows.Forms.Button();
            this.BtnMenuOperations = new System.Windows.Forms.Button();
            this.PanelSubMenuDraw = new System.Windows.Forms.Panel();
            this.linkLabel_Animar = new System.Windows.Forms.LinkLabel();
            this.linkLabel_DibujarMouse = new System.Windows.Forms.LinkLabel();
            this.Btn_DrawVector = new System.Windows.Forms.Button();
            this.txtAxisY = new System.Windows.Forms.TextBox();
            this.txtAxisX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_MenuDibujarOrigen = new System.Windows.Forms.Button();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.PanelDetallesGrafico = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.lblAngulo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCuadrante = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMagnitud = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txtCuadradoPuntoBy = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.txtCuadradoPuntoBx = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.txtCuadradoPuntoAy = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.txtCuadradoPuntoAx = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.Btn_DibujarFigurasCuadrado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FreeDraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Graph)).BeginInit();
            this.PanelPrincipal.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.Panel_SubMenuDibujoLibre.SuspendLayout();
            this.Panel_Ecuaciones.SuspendLayout();
            this.Panel_SubMenuCuadratica.SuspendLayout();
            this.Panel_SubMenuRecta.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.boxEcuacion.SuspendLayout();
            this.Panel_MenuDibujarOrigen.SuspendLayout();
            this.PanelSubMenuOperations.SuspendLayout();
            this.PanelSubMenuOperationsProducto.SuspendLayout();
            this.PanelProductoVector.SuspendLayout();
            this.PanelProducto.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.PanelSubMenuOperationsResta.SuspendLayout();
            this.PanelRestaVector.SuspendLayout();
            this.PanelResta.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.PanelSubMenuOperationsSuma.SuspendLayout();
            this.PanelSumaVector.SuspendLayout();
            this.PanelSuma.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.PanelSubMenuOperationsSentido.SuspendLayout();
            this.PanelSubMenuOperationsEscalar.SuspendLayout();
            this.PanelSubMenuDraw.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.PanelDetallesGrafico.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_FreeDraw);
            this.groupBox1.Controls.Add(this.pctBox_Graph);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(306, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 593);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLANO 2D";
            // 
            // pictureBox_FreeDraw
            // 
            this.pictureBox_FreeDraw.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox_FreeDraw.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox_FreeDraw.Location = new System.Drawing.Point(9, 28);
            this.pictureBox_FreeDraw.Name = "pictureBox_FreeDraw";
            this.pictureBox_FreeDraw.Size = new System.Drawing.Size(550, 550);
            this.pictureBox_FreeDraw.TabIndex = 1;
            this.pictureBox_FreeDraw.TabStop = false;
            this.pictureBox_FreeDraw.Visible = false;
            this.pictureBox_FreeDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_FreeDraw_MouseMove);
            // 
            // pctBox_Graph
            // 
            this.pctBox_Graph.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pctBox_Graph.Cursor = System.Windows.Forms.Cursors.Default;
            this.pctBox_Graph.Location = new System.Drawing.Point(9, 28);
            this.pctBox_Graph.Name = "pctBox_Graph";
            this.pctBox_Graph.Size = new System.Drawing.Size(550, 550);
            this.pctBox_Graph.TabIndex = 0;
            this.pctBox_Graph.TabStop = false;
            this.pctBox_Graph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctBox_Graph_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "VECTORES";
            // 
            // Btn_ReDraw
            // 
            this.Btn_ReDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ReDraw.Location = new System.Drawing.Point(306, 21);
            this.Btn_ReDraw.Name = "Btn_ReDraw";
            this.Btn_ReDraw.Size = new System.Drawing.Size(96, 29);
            this.Btn_ReDraw.TabIndex = 3;
            this.Btn_ReDraw.Text = "Limpiar";
            this.Btn_ReDraw.UseVisualStyleBackColor = true;
            this.Btn_ReDraw.Visible = false;
            this.Btn_ReDraw.Click += new System.EventHandler(this.Btn_ReDraw_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.PanelPrincipal.Controls.Add(this.PanelMenu);
            this.PanelPrincipal.Controls.Add(this.PanelTitle);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(300, 661);
            this.PanelPrincipal.TabIndex = 6;
            // 
            // PanelMenu
            // 
            this.PanelMenu.AutoScroll = true;
            this.PanelMenu.Controls.Add(this.Panel_SubMenuDibujoLibre);
            this.PanelMenu.Controls.Add(this.Btn_MenuDibujoLibre);
            this.PanelMenu.Controls.Add(this.Panel_Ecuaciones);
            this.PanelMenu.Controls.Add(this.Btn_DibujarFiguras);
            this.PanelMenu.Controls.Add(this.Panel_MenuDibujarOrigen);
            this.PanelMenu.Controls.Add(this.Btn_MenuDibujarOrigen);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 100);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(300, 561);
            this.PanelMenu.TabIndex = 8;
            // 
            // Panel_SubMenuDibujoLibre
            // 
            this.Panel_SubMenuDibujoLibre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.Panel_SubMenuDibujoLibre.Controls.Add(this.label52);
            this.Panel_SubMenuDibujoLibre.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SubMenuDibujoLibre.Location = new System.Drawing.Point(0, 1865);
            this.Panel_SubMenuDibujoLibre.Name = "Panel_SubMenuDibujoLibre";
            this.Panel_SubMenuDibujoLibre.Size = new System.Drawing.Size(283, 63);
            this.Panel_SubMenuDibujoLibre.TabIndex = 12;
            this.Panel_SubMenuDibujoLibre.Visible = false;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(57, 20);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(186, 16);
            this.label52.TabIndex = 18;
            this.label52.Text = "¡DIBUJE CON CREATIVIDAD!";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_MenuDibujoLibre
            // 
            this.Btn_MenuDibujoLibre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(31)))));
            this.Btn_MenuDibujoLibre.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_MenuDibujoLibre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Btn_MenuDibujoLibre.FlatAppearance.BorderSize = 0;
            this.Btn_MenuDibujoLibre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MenuDibujoLibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MenuDibujoLibre.ForeColor = System.Drawing.Color.White;
            this.Btn_MenuDibujoLibre.Location = new System.Drawing.Point(0, 1825);
            this.Btn_MenuDibujoLibre.Name = "Btn_MenuDibujoLibre";
            this.Btn_MenuDibujoLibre.Size = new System.Drawing.Size(283, 40);
            this.Btn_MenuDibujoLibre.TabIndex = 11;
            this.Btn_MenuDibujoLibre.Text = "DibujoLibre";
            this.Btn_MenuDibujoLibre.UseVisualStyleBackColor = false;
            this.Btn_MenuDibujoLibre.Click += new System.EventHandler(this.Btn_MenuDibujoLibre_Click);
            // 
            // Panel_Ecuaciones
            // 
            this.Panel_Ecuaciones.AutoSize = true;
            this.Panel_Ecuaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.Panel_Ecuaciones.Controls.Add(this.Panel_SubMenuCuadratica);
            this.Panel_Ecuaciones.Controls.Add(this.Btn_SubMenuCuadratica);
            this.Panel_Ecuaciones.Controls.Add(this.Panel_SubMenuRecta);
            this.Panel_Ecuaciones.Controls.Add(this.Btn_SubMenuRecta);
            this.Panel_Ecuaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Ecuaciones.Location = new System.Drawing.Point(0, 1195);
            this.Panel_Ecuaciones.Name = "Panel_Ecuaciones";
            this.Panel_Ecuaciones.Size = new System.Drawing.Size(283, 630);
            this.Panel_Ecuaciones.TabIndex = 10;
            this.Panel_Ecuaciones.Visible = false;
            // 
            // Panel_SubMenuCuadratica
            // 
            this.Panel_SubMenuCuadratica.Controls.Add(this.Btn_DibujarFigurasCuadrado);
            this.Panel_SubMenuCuadratica.Controls.Add(this.groupBox13);
            this.Panel_SubMenuCuadratica.Controls.Add(this.groupBox14);
            this.Panel_SubMenuCuadratica.Controls.Add(this.label73);
            this.Panel_SubMenuCuadratica.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SubMenuCuadratica.Location = new System.Drawing.Point(0, 440);
            this.Panel_SubMenuCuadratica.Name = "Panel_SubMenuCuadratica";
            this.Panel_SubMenuCuadratica.Size = new System.Drawing.Size(283, 190);
            this.Panel_SubMenuCuadratica.TabIndex = 13;
            this.Panel_SubMenuCuadratica.Visible = false;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.Location = new System.Drawing.Point(82, 17);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(121, 16);
            this.label73.TabIndex = 17;
            this.label73.Text = "Seleccione puntos:";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_SubMenuCuadratica
            // 
            this.Btn_SubMenuCuadratica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(118)))), ((int)(((byte)(37)))));
            this.Btn_SubMenuCuadratica.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SubMenuCuadratica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Btn_SubMenuCuadratica.FlatAppearance.BorderSize = 0;
            this.Btn_SubMenuCuadratica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubMenuCuadratica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SubMenuCuadratica.ForeColor = System.Drawing.Color.White;
            this.Btn_SubMenuCuadratica.Location = new System.Drawing.Point(0, 410);
            this.Btn_SubMenuCuadratica.Name = "Btn_SubMenuCuadratica";
            this.Btn_SubMenuCuadratica.Size = new System.Drawing.Size(283, 30);
            this.Btn_SubMenuCuadratica.TabIndex = 5;
            this.Btn_SubMenuCuadratica.Text = "Cuadrado";
            this.Btn_SubMenuCuadratica.UseVisualStyleBackColor = false;
            this.Btn_SubMenuCuadratica.Click += new System.EventHandler(this.Btn_SubMenuCuadratica_Click);
            // 
            // Panel_SubMenuRecta
            // 
            this.Panel_SubMenuRecta.Controls.Add(this.groupBox11);
            this.Panel_SubMenuRecta.Controls.Add(this.groupBox10);
            this.Panel_SubMenuRecta.Controls.Add(this.btn_CalcularEcuacionRecta);
            this.Panel_SubMenuRecta.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SubMenuRecta.Location = new System.Drawing.Point(0, 30);
            this.Panel_SubMenuRecta.Name = "Panel_SubMenuRecta";
            this.Panel_SubMenuRecta.Size = new System.Drawing.Size(283, 380);
            this.Panel_SubMenuRecta.TabIndex = 12;
            this.Panel_SubMenuRecta.Visible = false;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txtPendiente);
            this.groupBox11.Controls.Add(this.txtAngle);
            this.groupBox11.Controls.Add(this.label51);
            this.groupBox11.Controls.Add(this.groupBox12);
            this.groupBox11.Controls.Add(this.label48);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.ForeColor = System.Drawing.Color.White;
            this.groupBox11.Location = new System.Drawing.Point(3, 219);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(272, 155);
            this.groupBox11.TabIndex = 37;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Punto - Recta";
            // 
            // txtPendiente
            // 
            this.txtPendiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtPendiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPendiente.Location = new System.Drawing.Point(103, 25);
            this.txtPendiente.Name = "txtPendiente";
            this.txtPendiente.Size = new System.Drawing.Size(35, 19);
            this.txtPendiente.TabIndex = 41;
            this.txtPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAngle
            // 
            this.txtAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtAngle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngle.Location = new System.Drawing.Point(163, 124);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(35, 19);
            this.txtAngle.TabIndex = 14;
            this.txtAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.Black;
            this.label51.Location = new System.Drawing.Point(24, 127);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(133, 16);
            this.label51.TabIndex = 40;
            this.label51.Text = "Ángulo respecto a X: ";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txtPuntoY);
            this.groupBox12.Controls.Add(this.label49);
            this.groupBox12.Controls.Add(this.txtPuntoX);
            this.groupBox12.Controls.Add(this.label50);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(24, 52);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(205, 62);
            this.groupBox12.TabIndex = 39;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Punto A";
            // 
            // txtPuntoY
            // 
            this.txtPuntoY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtPuntoY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuntoY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntoY.Location = new System.Drawing.Point(149, 34);
            this.txtPuntoY.Name = "txtPuntoY";
            this.txtPuntoY.Size = new System.Drawing.Size(35, 19);
            this.txtPuntoY.TabIndex = 13;
            this.txtPuntoY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(22, 31);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(18, 16);
            this.label49.TabIndex = 10;
            this.label49.Text = "X:";
            // 
            // txtPuntoX
            // 
            this.txtPuntoX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtPuntoX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuntoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntoX.Location = new System.Drawing.Point(57, 31);
            this.txtPuntoX.Name = "txtPuntoX";
            this.txtPuntoX.Size = new System.Drawing.Size(35, 19);
            this.txtPuntoX.TabIndex = 12;
            this.txtPuntoX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(114, 34);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(19, 16);
            this.label50.TabIndex = 11;
            this.label50.Text = "Y:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.Black;
            this.label48.Location = new System.Drawing.Point(25, 25);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(74, 16);
            this.label48.TabIndex = 33;
            this.label48.Text = "Pendiente: ";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox8);
            this.groupBox10.Controls.Add(this.groupBox9);
            this.groupBox10.Controls.Add(this.boxEcuacion);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.Color.White;
            this.groupBox10.Location = new System.Drawing.Point(3, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(272, 181);
            this.groupBox10.TabIndex = 36;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Punto - Recta";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtPuntoBY);
            this.groupBox8.Controls.Add(this.label39);
            this.groupBox8.Controls.Add(this.label42);
            this.groupBox8.Controls.Add(this.txtPuntoBX);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(146, 88);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(123, 88);
            this.groupBox8.TabIndex = 39;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Punto B";
            // 
            // txtPuntoBY
            // 
            this.txtPuntoBY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtPuntoBY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuntoBY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntoBY.Location = new System.Drawing.Point(48, 59);
            this.txtPuntoBY.Name = "txtPuntoBY";
            this.txtPuntoBY.Size = new System.Drawing.Size(35, 19);
            this.txtPuntoBY.TabIndex = 17;
            this.txtPuntoBY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(13, 31);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(18, 16);
            this.label39.TabIndex = 14;
            this.label39.Text = "X:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(13, 59);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(19, 16);
            this.label42.TabIndex = 15;
            this.label42.Text = "Y:";
            // 
            // txtPuntoBX
            // 
            this.txtPuntoBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtPuntoBX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuntoBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntoBX.Location = new System.Drawing.Point(48, 31);
            this.txtPuntoBX.Name = "txtPuntoBX";
            this.txtPuntoBX.Size = new System.Drawing.Size(35, 19);
            this.txtPuntoBX.TabIndex = 16;
            this.txtPuntoBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtPuntoAY);
            this.groupBox9.Controls.Add(this.label46);
            this.groupBox9.Controls.Add(this.txtPuntoAX);
            this.groupBox9.Controls.Add(this.label47);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(3, 88);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(123, 88);
            this.groupBox9.TabIndex = 38;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Punto A";
            // 
            // txtPuntoAY
            // 
            this.txtPuntoAY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtPuntoAY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuntoAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntoAY.Location = new System.Drawing.Point(57, 59);
            this.txtPuntoAY.Name = "txtPuntoAY";
            this.txtPuntoAY.Size = new System.Drawing.Size(35, 19);
            this.txtPuntoAY.TabIndex = 13;
            this.txtPuntoAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(22, 31);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(18, 16);
            this.label46.TabIndex = 10;
            this.label46.Text = "X:";
            // 
            // txtPuntoAX
            // 
            this.txtPuntoAX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtPuntoAX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuntoAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntoAX.Location = new System.Drawing.Point(57, 31);
            this.txtPuntoAX.Name = "txtPuntoAX";
            this.txtPuntoAX.Size = new System.Drawing.Size(35, 19);
            this.txtPuntoAX.TabIndex = 12;
            this.txtPuntoAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.White;
            this.label47.Location = new System.Drawing.Point(22, 59);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(19, 16);
            this.label47.TabIndex = 11;
            this.label47.Text = "Y:";
            // 
            // boxEcuacion
            // 
            this.boxEcuacion.Controls.Add(this.txtEcuacionB);
            this.boxEcuacion.Controls.Add(this.label76);
            this.boxEcuacion.Controls.Add(this.txtEcuacionY);
            this.boxEcuacion.Controls.Add(this.label74);
            this.boxEcuacion.Controls.Add(this.txtEcuacionX);
            this.boxEcuacion.Controls.Add(this.label75);
            this.boxEcuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxEcuacion.Location = new System.Drawing.Point(15, 21);
            this.boxEcuacion.Name = "boxEcuacion";
            this.boxEcuacion.Size = new System.Drawing.Size(243, 61);
            this.boxEcuacion.TabIndex = 35;
            this.boxEcuacion.TabStop = false;
            this.boxEcuacion.Text = "Ecuación";
            // 
            // txtEcuacionB
            // 
            this.txtEcuacionB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtEcuacionB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEcuacionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEcuacionB.Location = new System.Drawing.Point(146, 30);
            this.txtEcuacionB.Name = "txtEcuacionB";
            this.txtEcuacionB.Size = new System.Drawing.Size(30, 15);
            this.txtEcuacionB.TabIndex = 15;
            this.txtEcuacionB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.ForeColor = System.Drawing.Color.White;
            this.label76.Location = new System.Drawing.Point(187, 29);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(27, 16);
            this.label76.TabIndex = 14;
            this.label76.Text = "=  0";
            // 
            // txtEcuacionY
            // 
            this.txtEcuacionY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtEcuacionY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEcuacionY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEcuacionY.Location = new System.Drawing.Point(81, 30);
            this.txtEcuacionY.Name = "txtEcuacionY";
            this.txtEcuacionY.Size = new System.Drawing.Size(30, 15);
            this.txtEcuacionY.TabIndex = 13;
            this.txtEcuacionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.ForeColor = System.Drawing.Color.White;
            this.label74.Location = new System.Drawing.Point(50, 29);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(26, 16);
            this.label74.TabIndex = 10;
            this.label74.Text = "x  +";
            // 
            // txtEcuacionX
            // 
            this.txtEcuacionX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtEcuacionX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEcuacionX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEcuacionX.Location = new System.Drawing.Point(14, 30);
            this.txtEcuacionX.Name = "txtEcuacionX";
            this.txtEcuacionX.Size = new System.Drawing.Size(30, 15);
            this.txtEcuacionX.TabIndex = 12;
            this.txtEcuacionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.ForeColor = System.Drawing.Color.White;
            this.label75.Location = new System.Drawing.Point(117, 29);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(27, 16);
            this.label75.TabIndex = 11;
            this.label75.Text = "y  +";
            // 
            // btn_CalcularEcuacionRecta
            // 
            this.btn_CalcularEcuacionRecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalcularEcuacionRecta.Location = new System.Drawing.Point(105, 193);
            this.btn_CalcularEcuacionRecta.Name = "btn_CalcularEcuacionRecta";
            this.btn_CalcularEcuacionRecta.Size = new System.Drawing.Size(68, 26);
            this.btn_CalcularEcuacionRecta.TabIndex = 25;
            this.btn_CalcularEcuacionRecta.Text = "Calcular";
            this.btn_CalcularEcuacionRecta.UseVisualStyleBackColor = true;
            // 
            // Btn_SubMenuRecta
            // 
            this.Btn_SubMenuRecta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(118)))), ((int)(((byte)(37)))));
            this.Btn_SubMenuRecta.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SubMenuRecta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Btn_SubMenuRecta.FlatAppearance.BorderSize = 0;
            this.Btn_SubMenuRecta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubMenuRecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SubMenuRecta.ForeColor = System.Drawing.Color.White;
            this.Btn_SubMenuRecta.Location = new System.Drawing.Point(0, 0);
            this.Btn_SubMenuRecta.Name = "Btn_SubMenuRecta";
            this.Btn_SubMenuRecta.Size = new System.Drawing.Size(283, 30);
            this.Btn_SubMenuRecta.TabIndex = 4;
            this.Btn_SubMenuRecta.Text = "Recta";
            this.Btn_SubMenuRecta.UseVisualStyleBackColor = false;
            this.Btn_SubMenuRecta.Click += new System.EventHandler(this.Btn_SubMenuRecta_Click);
            // 
            // Btn_DibujarFiguras
            // 
            this.Btn_DibujarFiguras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Btn_DibujarFiguras.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_DibujarFiguras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Btn_DibujarFiguras.FlatAppearance.BorderSize = 0;
            this.Btn_DibujarFiguras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DibujarFiguras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DibujarFiguras.ForeColor = System.Drawing.Color.White;
            this.Btn_DibujarFiguras.Location = new System.Drawing.Point(0, 1155);
            this.Btn_DibujarFiguras.Name = "Btn_DibujarFiguras";
            this.Btn_DibujarFiguras.Size = new System.Drawing.Size(283, 40);
            this.Btn_DibujarFiguras.TabIndex = 10;
            this.Btn_DibujarFiguras.Text = "Dibujar Figuras";
            this.Btn_DibujarFiguras.UseVisualStyleBackColor = false;
            this.Btn_DibujarFiguras.Click += new System.EventHandler(this.Btn_MenuEcuaciones_Click);
            // 
            // Panel_MenuDibujarOrigen
            // 
            this.Panel_MenuDibujarOrigen.AutoSize = true;
            this.Panel_MenuDibujarOrigen.Controls.Add(this.PanelSubMenuOperations);
            this.Panel_MenuDibujarOrigen.Controls.Add(this.BtnMenuOperations);
            this.Panel_MenuDibujarOrigen.Controls.Add(this.PanelSubMenuDraw);
            this.Panel_MenuDibujarOrigen.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_MenuDibujarOrigen.Location = new System.Drawing.Point(0, 40);
            this.Panel_MenuDibujarOrigen.Name = "Panel_MenuDibujarOrigen";
            this.Panel_MenuDibujarOrigen.Size = new System.Drawing.Size(283, 1115);
            this.Panel_MenuDibujarOrigen.TabIndex = 1;
            this.Panel_MenuDibujarOrigen.Visible = false;
            // 
            // PanelSubMenuOperations
            // 
            this.PanelSubMenuOperations.AutoSize = true;
            this.PanelSubMenuOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.PanelSubMenuOperations.Controls.Add(this.PanelSubMenuOperationsProducto);
            this.PanelSubMenuOperations.Controls.Add(this.Btn_SubMenuOperationsProducto);
            this.PanelSubMenuOperations.Controls.Add(this.PanelSubMenuOperationsResta);
            this.PanelSubMenuOperations.Controls.Add(this.Btn_SubMenuOperationsResta);
            this.PanelSubMenuOperations.Controls.Add(this.PanelSubMenuOperationsSuma);
            this.PanelSubMenuOperations.Controls.Add(this.Btn_SubMenuOperationsSuma);
            this.PanelSubMenuOperations.Controls.Add(this.PanelSubMenuOperationsSentido);
            this.PanelSubMenuOperations.Controls.Add(this.Btn_SubMenuOperationsSentido);
            this.PanelSubMenuOperations.Controls.Add(this.PanelSubMenuOperationsEscalar);
            this.PanelSubMenuOperations.Controls.Add(this.Btn_SubMenuOperationsEscalar);
            this.PanelSubMenuOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuOperations.Location = new System.Drawing.Point(0, 130);
            this.PanelSubMenuOperations.Name = "PanelSubMenuOperations";
            this.PanelSubMenuOperations.Size = new System.Drawing.Size(283, 985);
            this.PanelSubMenuOperations.TabIndex = 6;
            // 
            // PanelSubMenuOperationsProducto
            // 
            this.PanelSubMenuOperationsProducto.AutoSize = true;
            this.PanelSubMenuOperationsProducto.Controls.Add(this.PanelProductoVector);
            this.PanelSubMenuOperationsProducto.Controls.Add(this.PanelProducto);
            this.PanelSubMenuOperationsProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuOperationsProducto.Enabled = false;
            this.PanelSubMenuOperationsProducto.Location = new System.Drawing.Point(0, 755);
            this.PanelSubMenuOperationsProducto.Name = "PanelSubMenuOperationsProducto";
            this.PanelSubMenuOperationsProducto.Size = new System.Drawing.Size(283, 230);
            this.PanelSubMenuOperationsProducto.TabIndex = 19;
            // 
            // PanelProductoVector
            // 
            this.PanelProductoVector.Controls.Add(this.lblResultadoProducto);
            this.PanelProductoVector.Controls.Add(this.label45);
            this.PanelProductoVector.Controls.Add(this.label44);
            this.PanelProductoVector.Controls.Add(this.label43);
            this.PanelProductoVector.Controls.Add(this.label34);
            this.PanelProductoVector.Controls.Add(this.label35);
            this.PanelProductoVector.Controls.Add(this.label38);
            this.PanelProductoVector.Controls.Add(this.lblProductoX2);
            this.PanelProductoVector.Controls.Add(this.lblProductoX1);
            this.PanelProductoVector.Controls.Add(this.label20);
            this.PanelProductoVector.Controls.Add(this.label40);
            this.PanelProductoVector.Controls.Add(this.label41);
            this.PanelProductoVector.Controls.Add(this.lblProductoY2);
            this.PanelProductoVector.Controls.Add(this.lblProductoY1);
            this.PanelProductoVector.Controls.Add(this.label21);
            this.PanelProductoVector.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProductoVector.Location = new System.Drawing.Point(0, 140);
            this.PanelProductoVector.Name = "PanelProductoVector";
            this.PanelProductoVector.Size = new System.Drawing.Size(283, 90);
            this.PanelProductoVector.TabIndex = 11;
            this.PanelProductoVector.Visible = false;
            // 
            // lblResultadoProducto
            // 
            this.lblResultadoProducto.AutoSize = true;
            this.lblResultadoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoProducto.Location = new System.Drawing.Point(155, 65);
            this.lblResultadoProducto.Name = "lblResultadoProducto";
            this.lblResultadoProducto.Size = new System.Drawing.Size(13, 16);
            this.lblResultadoProducto.TabIndex = 34;
            this.lblResultadoProducto.Text = "x";
            this.lblResultadoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultadoProducto.Visible = false;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(77, 65);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(63, 16);
            this.label45.TabIndex = 33;
            this.label45.Text = "V1 * V2  =";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(44, 37);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(63, 16);
            this.label44.TabIndex = 32;
            this.label44.Text = "V1 * V2  =";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(175, 37);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(14, 16);
            this.label43.TabIndex = 31;
            this.label43.Text = "+";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(162, 37);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(11, 16);
            this.label34.TabIndex = 30;
            this.label34.Text = ")";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(113, 37);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(11, 16);
            this.label35.TabIndex = 29;
            this.label35.Text = "(";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(138, 37);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(12, 16);
            this.label38.TabIndex = 28;
            this.label38.Text = "*";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductoX2
            // 
            this.lblProductoX2.AutoSize = true;
            this.lblProductoX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoX2.Location = new System.Drawing.Point(149, 37);
            this.lblProductoX2.Name = "lblProductoX2";
            this.lblProductoX2.Size = new System.Drawing.Size(20, 16);
            this.lblProductoX2.TabIndex = 27;
            this.lblProductoX2.Text = "x2";
            this.lblProductoX2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductoX2.Visible = false;
            // 
            // lblProductoX1
            // 
            this.lblProductoX1.AutoSize = true;
            this.lblProductoX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoX1.Location = new System.Drawing.Point(122, 37);
            this.lblProductoX1.Name = "lblProductoX1";
            this.lblProductoX1.Size = new System.Drawing.Size(20, 16);
            this.lblProductoX1.TabIndex = 26;
            this.lblProductoX1.Text = "x1";
            this.lblProductoX1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductoX1.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(236, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 16);
            this.label20.TabIndex = 25;
            this.label20.Text = ")";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(187, 37);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(11, 16);
            this.label40.TabIndex = 24;
            this.label40.Text = "(";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(212, 37);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(12, 16);
            this.label41.TabIndex = 23;
            this.label41.Text = "*";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductoY2
            // 
            this.lblProductoY2.AutoSize = true;
            this.lblProductoY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoY2.Location = new System.Drawing.Point(223, 37);
            this.lblProductoY2.Name = "lblProductoY2";
            this.lblProductoY2.Size = new System.Drawing.Size(21, 16);
            this.lblProductoY2.TabIndex = 22;
            this.lblProductoY2.Text = "y2";
            this.lblProductoY2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductoY2.Visible = false;
            // 
            // lblProductoY1
            // 
            this.lblProductoY1.AutoSize = true;
            this.lblProductoY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoY1.Location = new System.Drawing.Point(196, 37);
            this.lblProductoY1.Name = "lblProductoY1";
            this.lblProductoY1.Size = new System.Drawing.Size(21, 16);
            this.lblProductoY1.TabIndex = 21;
            this.lblProductoY1.Text = "y1";
            this.lblProductoY1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductoY1.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(50, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(191, 16);
            this.label21.TabIndex = 17;
            this.label21.Text = "El producto de los vectores es:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelProducto
            // 
            this.PanelProducto.Controls.Add(this.BtnCalcularProducto);
            this.PanelProducto.Controls.Add(this.groupBox4);
            this.PanelProducto.Controls.Add(this.groupBox5);
            this.PanelProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProducto.Enabled = false;
            this.PanelProducto.Location = new System.Drawing.Point(0, 0);
            this.PanelProducto.Name = "PanelProducto";
            this.PanelProducto.Size = new System.Drawing.Size(283, 140);
            this.PanelProducto.TabIndex = 10;
            // 
            // BtnCalcularProducto
            // 
            this.BtnCalcularProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcularProducto.Location = new System.Drawing.Point(111, 103);
            this.BtnCalcularProducto.Name = "BtnCalcularProducto";
            this.BtnCalcularProducto.Size = new System.Drawing.Size(68, 26);
            this.BtnCalcularProducto.TabIndex = 24;
            this.BtnCalcularProducto.Text = "Calcular";
            this.BtnCalcularProducto.UseVisualStyleBackColor = true;
            this.BtnCalcularProducto.Click += new System.EventHandler(this.BtnCalcularProducto_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtVectorProductoY2);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.txtVectorProductoX2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(157, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(123, 88);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vector 2:";
            // 
            // txtVectorProductoY2
            // 
            this.txtVectorProductoY2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtVectorProductoY2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVectorProductoY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVectorProductoY2.Location = new System.Drawing.Point(48, 59);
            this.txtVectorProductoY2.Name = "txtVectorProductoY2";
            this.txtVectorProductoY2.Size = new System.Drawing.Size(35, 19);
            this.txtVectorProductoY2.TabIndex = 17;
            this.txtVectorProductoY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(13, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(18, 16);
            this.label22.TabIndex = 14;
            this.label22.Text = "X:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(13, 59);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(19, 16);
            this.label23.TabIndex = 15;
            this.label23.Text = "Y:";
            // 
            // txtVectorProductoX2
            // 
            this.txtVectorProductoX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtVectorProductoX2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVectorProductoX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVectorProductoX2.Location = new System.Drawing.Point(48, 31);
            this.txtVectorProductoX2.Name = "txtVectorProductoX2";
            this.txtVectorProductoX2.Size = new System.Drawing.Size(35, 19);
            this.txtVectorProductoX2.TabIndex = 16;
            this.txtVectorProductoX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtVectorProductoY1);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.txtVectorProductoX1);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(123, 88);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vector 1:";
            // 
            // txtVectorProductoY1
            // 
            this.txtVectorProductoY1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtVectorProductoY1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVectorProductoY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVectorProductoY1.Location = new System.Drawing.Point(57, 59);
            this.txtVectorProductoY1.Name = "txtVectorProductoY1";
            this.txtVectorProductoY1.Size = new System.Drawing.Size(35, 19);
            this.txtVectorProductoY1.TabIndex = 13;
            this.txtVectorProductoY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(22, 31);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(18, 16);
            this.label24.TabIndex = 10;
            this.label24.Text = "X:";
            // 
            // txtVectorProductoX1
            // 
            this.txtVectorProductoX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtVectorProductoX1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVectorProductoX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVectorProductoX1.Location = new System.Drawing.Point(57, 31);
            this.txtVectorProductoX1.Name = "txtVectorProductoX1";
            this.txtVectorProductoX1.Size = new System.Drawing.Size(35, 19);
            this.txtVectorProductoX1.TabIndex = 12;
            this.txtVectorProductoX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(22, 59);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(19, 16);
            this.label25.TabIndex = 11;
            this.label25.Text = "Y:";
            // 
            // Btn_SubMenuOperationsProducto
            // 
            this.Btn_SubMenuOperationsProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.Btn_SubMenuOperationsProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SubMenuOperationsProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Btn_SubMenuOperationsProducto.FlatAppearance.BorderSize = 0;
            this.Btn_SubMenuOperationsProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubMenuOperationsProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SubMenuOperationsProducto.ForeColor = System.Drawing.Color.White;
            this.Btn_SubMenuOperationsProducto.Location = new System.Drawing.Point(0, 725);
            this.Btn_SubMenuOperationsProducto.Name = "Btn_SubMenuOperationsProducto";
            this.Btn_SubMenuOperationsProducto.Size = new System.Drawing.Size(283, 30);
            this.Btn_SubMenuOperationsProducto.TabIndex = 3;
            this.Btn_SubMenuOperationsProducto.Text = "Producto Punto";
            this.Btn_SubMenuOperationsProducto.UseVisualStyleBackColor = false;
            this.Btn_SubMenuOperationsProducto.Click += new System.EventHandler(this.Btn_SubMenuOperationsProducto_Click);
            // 
            // PanelSubMenuOperationsResta
            // 
            this.PanelSubMenuOperationsResta.AutoSize = true;
            this.PanelSubMenuOperationsResta.Controls.Add(this.PanelRestaVector);
            this.PanelSubMenuOperationsResta.Controls.Add(this.PanelResta);
            this.PanelSubMenuOperationsResta.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuOperationsResta.Enabled = false;
            this.PanelSubMenuOperationsResta.Location = new System.Drawing.Point(0, 505);
            this.PanelSubMenuOperationsResta.Name = "PanelSubMenuOperationsResta";
            this.PanelSubMenuOperationsResta.Size = new System.Drawing.Size(283, 220);
            this.PanelSubMenuOperationsResta.TabIndex = 18;
            // 
            // PanelRestaVector
            // 
            this.PanelRestaVector.Controls.Add(this.label14);
            this.PanelRestaVector.Controls.Add(this.label36);
            this.PanelRestaVector.Controls.Add(this.label37);
            this.PanelRestaVector.Controls.Add(this.lblRestaY);
            this.PanelRestaVector.Controls.Add(this.lblRestaX);
            this.PanelRestaVector.Controls.Add(this.Btn_CalcularResta);
            this.PanelRestaVector.Controls.Add(this.label15);
            this.PanelRestaVector.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelRestaVector.Location = new System.Drawing.Point(0, 140);
            this.PanelRestaVector.Name = "PanelRestaVector";
            this.PanelRestaVector.Size = new System.Drawing.Size(283, 80);
            this.PanelRestaVector.TabIndex = 11;
            this.PanelRestaVector.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(106, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = ")";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(57, 44);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(11, 16);
            this.label36.TabIndex = 24;
            this.label36.Text = "(";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(82, 44);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(10, 16);
            this.label37.TabIndex = 23;
            this.label37.Text = ",";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRestaY
            // 
            this.lblRestaY.AutoSize = true;
            this.lblRestaY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaY.Location = new System.Drawing.Point(93, 44);
            this.lblRestaY.Name = "lblRestaY";
            this.lblRestaY.Size = new System.Drawing.Size(14, 16);
            this.lblRestaY.TabIndex = 22;
            this.lblRestaY.Text = "y";
            this.lblRestaY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRestaY.Visible = false;
            // 
            // lblRestaX
            // 
            this.lblRestaX.AutoSize = true;
            this.lblRestaX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaX.Location = new System.Drawing.Point(66, 44);
            this.lblRestaX.Name = "lblRestaX";
            this.lblRestaX.Size = new System.Drawing.Size(13, 16);
            this.lblRestaX.TabIndex = 21;
            this.lblRestaX.Text = "x";
            this.lblRestaX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRestaX.Visible = false;
            // 
            // Btn_CalcularResta
            // 
            this.Btn_CalcularResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CalcularResta.Location = new System.Drawing.Point(176, 39);
            this.Btn_CalcularResta.Name = "Btn_CalcularResta";
            this.Btn_CalcularResta.Size = new System.Drawing.Size(64, 26);
            this.Btn_CalcularResta.TabIndex = 18;
            this.Btn_CalcularResta.Text = "Dibujar";
            this.Btn_CalcularResta.UseVisualStyleBackColor = true;
            this.Btn_CalcularResta.Click += new System.EventHandler(this.Btn_CalcularResta_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(60, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 16);
            this.label15.TabIndex = 17;
            this.label15.Text = "La resta de los vectores es:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelResta
            // 
            this.PanelResta.Controls.Add(this.BtnCalcularResta);
            this.PanelResta.Controls.Add(this.groupBox2);
            this.PanelResta.Controls.Add(this.groupBox3);
            this.PanelResta.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelResta.Enabled = false;
            this.PanelResta.Location = new System.Drawing.Point(0, 0);
            this.PanelResta.Name = "PanelResta";
            this.PanelResta.Size = new System.Drawing.Size(283, 140);
            this.PanelResta.TabIndex = 10;
            // 
            // BtnCalcularResta
            // 
            this.BtnCalcularResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcularResta.Location = new System.Drawing.Point(111, 103);
            this.BtnCalcularResta.Name = "BtnCalcularResta";
            this.BtnCalcularResta.Size = new System.Drawing.Size(68, 26);
            this.BtnCalcularResta.TabIndex = 24;
            this.BtnCalcularResta.Text = "Calcular";
            this.BtnCalcularResta.UseVisualStyleBackColor = true;
            this.BtnCalcularResta.Click += new System.EventHandler(this.BtnCalcularResta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVectorRestaY2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtVectorRestaX2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(157, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 88);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vector 2:";
            // 
            // txtVectorRestaY2
            // 
            this.txtVectorRestaY2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtVectorRestaY2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVectorRestaY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVectorRestaY2.Location = new System.Drawing.Point(48, 59);
            this.txtVectorRestaY2.Name = "txtVectorRestaY2";
            this.txtVectorRestaY2.Size = new System.Drawing.Size(35, 19);
            this.txtVectorRestaY2.TabIndex = 17;
            this.txtVectorRestaY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(13, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "X:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(13, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 16);
            this.label17.TabIndex = 15;
            this.label17.Text = "Y:";
            // 
            // txtVectorRestaX2
            // 
            this.txtVectorRestaX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtVectorRestaX2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVectorRestaX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVectorRestaX2.Location = new System.Drawing.Point(48, 31);
            this.txtVectorRestaX2.Name = "txtVectorRestaX2";
            this.txtVectorRestaX2.Size = new System.Drawing.Size(35, 19);
            this.txtVectorRestaX2.TabIndex = 16;
            this.txtVectorRestaX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtVectorRestaY1);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtVectorRestaX1);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 88);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vector 1:";
            // 
            // txtVectorRestaY1
            // 
            this.txtVectorRestaY1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtVectorRestaY1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVectorRestaY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVectorRestaY1.Location = new System.Drawing.Point(57, 59);
            this.txtVectorRestaY1.Name = "txtVectorRestaY1";
            this.txtVectorRestaY1.Size = new System.Drawing.Size(35, 19);
            this.txtVectorRestaY1.TabIndex = 13;
            this.txtVectorRestaY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(22, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 16);
            this.label18.TabIndex = 10;
            this.label18.Text = "X:";
            // 
            // txtVectorRestaX1
            // 
            this.txtVectorRestaX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtVectorRestaX1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVectorRestaX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVectorRestaX1.Location = new System.Drawing.Point(57, 31);
            this.txtVectorRestaX1.Name = "txtVectorRestaX1";
            this.txtVectorRestaX1.Size = new System.Drawing.Size(35, 19);
            this.txtVectorRestaX1.TabIndex = 12;
            this.txtVectorRestaX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(22, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 16);
            this.label19.TabIndex = 11;
            this.label19.Text = "Y:";
            // 
            // Btn_SubMenuOperationsResta
            // 
            this.Btn_SubMenuOperationsResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.Btn_SubMenuOperationsResta.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SubMenuOperationsResta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Btn_SubMenuOperationsResta.FlatAppearance.BorderSize = 0;
            this.Btn_SubMenuOperationsResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubMenuOperationsResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SubMenuOperationsResta.ForeColor = System.Drawing.Color.White;
            this.Btn_SubMenuOperationsResta.Location = new System.Drawing.Point(0, 475);
            this.Btn_SubMenuOperationsResta.Name = "Btn_SubMenuOperationsResta";
            this.Btn_SubMenuOperationsResta.Size = new System.Drawing.Size(283, 30);
            this.Btn_SubMenuOperationsResta.TabIndex = 2;
            this.Btn_SubMenuOperationsResta.Text = "Restar vectores";
            this.Btn_SubMenuOperationsResta.UseVisualStyleBackColor = false;
            this.Btn_SubMenuOperationsResta.Click += new System.EventHandler(this.Btn_SubMenuOperationsResta_Click);
            // 
            // PanelSubMenuOperationsSuma
            // 
            this.PanelSubMenuOperationsSuma.AutoSize = true;
            this.PanelSubMenuOperationsSuma.Controls.Add(this.PanelSumaVector);
            this.PanelSubMenuOperationsSuma.Controls.Add(this.PanelSuma);
            this.PanelSubMenuOperationsSuma.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuOperationsSuma.Enabled = false;
            this.PanelSubMenuOperationsSuma.Location = new System.Drawing.Point(0, 255);
            this.PanelSubMenuOperationsSuma.Name = "PanelSubMenuOperationsSuma";
            this.PanelSubMenuOperationsSuma.Size = new System.Drawing.Size(283, 220);
            this.PanelSubMenuOperationsSuma.TabIndex = 17;
            // 
            // PanelSumaVector
            // 
            this.PanelSumaVector.Controls.Add(this.label12);
            this.PanelSumaVector.Controls.Add(this.label32);
            this.PanelSumaVector.Controls.Add(this.label33);
            this.PanelSumaVector.Controls.Add(this.lblSumaY);
            this.PanelSumaVector.Controls.Add(this.lblSumaX);
            this.PanelSumaVector.Controls.Add(this.Btn_CalcularSuma);
            this.PanelSumaVector.Controls.Add(this.label13);
            this.PanelSumaVector.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSumaVector.Location = new System.Drawing.Point(0, 140);
            this.PanelSumaVector.Name = "PanelSumaVector";
            this.PanelSumaVector.Size = new System.Drawing.Size(283, 80);
            this.PanelSumaVector.TabIndex = 11;
            this.PanelSumaVector.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(106, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = ")";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(57, 44);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(11, 16);
            this.label32.TabIndex = 24;
            this.label32.Text = "(";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(82, 44);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(10, 16);
            this.label33.TabIndex = 23;
            this.label33.Text = ",";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSumaY
            // 
            this.lblSumaY.AutoSize = true;
            this.lblSumaY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaY.Location = new System.Drawing.Point(93, 44);
            this.lblSumaY.Name = "lblSumaY";
            this.lblSumaY.Size = new System.Drawing.Size(14, 16);
            this.lblSumaY.TabIndex = 22;
            this.lblSumaY.Text = "y";
            this.lblSumaY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSumaY.Visible = false;
            // 
            // lblSumaX
            // 
            this.lblSumaX.AutoSize = true;
            this.lblSumaX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaX.Location = new System.Drawing.Point(66, 44);
            this.lblSumaX.Name = "lblSumaX";
            this.lblSumaX.Size = new System.Drawing.Size(13, 16);
            this.lblSumaX.TabIndex = 21;
            this.lblSumaX.Text = "x";
            this.lblSumaX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSumaX.Visible = false;
            // 
            // Btn_CalcularSuma
            // 
            this.Btn_CalcularSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CalcularSuma.Location = new System.Drawing.Point(176, 39);
            this.Btn_CalcularSuma.Name = "Btn_CalcularSuma";
            this.Btn_CalcularSuma.Size = new System.Drawing.Size(64, 26);
            this.Btn_CalcularSuma.TabIndex = 18;
            this.Btn_CalcularSuma.Text = "Dibujar";
            this.Btn_CalcularSuma.UseVisualStyleBackColor = true;
            this.Btn_CalcularSuma.Click += new System.EventHandler(this.Btn_CalcularSuma_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(58, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "La suma de los vectores es:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelSuma
            // 
            this.PanelSuma.Controls.Add(this.BtnCalcularSuma);
            this.PanelSuma.Controls.Add(this.groupBox6);
            this.PanelSuma.Controls.Add(this.groupBox7);
            this.PanelSuma.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuma.Enabled = false;
            this.PanelSuma.Location = new System.Drawing.Point(0, 0);
            this.PanelSuma.Name = "PanelSuma";
            this.PanelSuma.Size = new System.Drawing.Size(283, 140);
            this.PanelSuma.TabIndex = 10;
            // 
            // BtnCalcularSuma
            // 
            this.BtnCalcularSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcularSuma.Location = new System.Drawing.Point(111, 103);
            this.BtnCalcularSuma.Name = "BtnCalcularSuma";
            this.BtnCalcularSuma.Size = new System.Drawing.Size(68, 26);
            this.BtnCalcularSuma.TabIndex = 24;
            this.BtnCalcularSuma.Text = "Calcular";
            this.BtnCalcularSuma.UseVisualStyleBackColor = true;
            this.BtnCalcularSuma.Click += new System.EventHandler(this.BtnCalcularSuma_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtSumaVectorY2);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.txtSumaVectorX2);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(157, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(123, 88);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Vector 2:";
            // 
            // txtSumaVectorY2
            // 
            this.txtSumaVectorY2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtSumaVectorY2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSumaVectorY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaVectorY2.Location = new System.Drawing.Point(48, 59);
            this.txtSumaVectorY2.Name = "txtSumaVectorY2";
            this.txtSumaVectorY2.Size = new System.Drawing.Size(35, 19);
            this.txtSumaVectorY2.TabIndex = 17;
            this.txtSumaVectorY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(13, 31);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(18, 16);
            this.label26.TabIndex = 14;
            this.label26.Text = "X:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(13, 59);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(19, 16);
            this.label27.TabIndex = 15;
            this.label27.Text = "Y:";
            // 
            // txtSumaVectorX2
            // 
            this.txtSumaVectorX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtSumaVectorX2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSumaVectorX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaVectorX2.Location = new System.Drawing.Point(48, 31);
            this.txtSumaVectorX2.Name = "txtSumaVectorX2";
            this.txtSumaVectorX2.Size = new System.Drawing.Size(35, 19);
            this.txtSumaVectorX2.TabIndex = 16;
            this.txtSumaVectorX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtSumaVectorY1);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.txtSumaVectorX1);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(12, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(123, 88);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Vector 1:";
            // 
            // txtSumaVectorY1
            // 
            this.txtSumaVectorY1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtSumaVectorY1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSumaVectorY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaVectorY1.Location = new System.Drawing.Point(57, 59);
            this.txtSumaVectorY1.Name = "txtSumaVectorY1";
            this.txtSumaVectorY1.Size = new System.Drawing.Size(35, 19);
            this.txtSumaVectorY1.TabIndex = 13;
            this.txtSumaVectorY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(22, 31);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(18, 16);
            this.label28.TabIndex = 10;
            this.label28.Text = "X:";
            // 
            // txtSumaVectorX1
            // 
            this.txtSumaVectorX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtSumaVectorX1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSumaVectorX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaVectorX1.Location = new System.Drawing.Point(57, 31);
            this.txtSumaVectorX1.Name = "txtSumaVectorX1";
            this.txtSumaVectorX1.Size = new System.Drawing.Size(35, 19);
            this.txtSumaVectorX1.TabIndex = 12;
            this.txtSumaVectorX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(22, 59);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(19, 16);
            this.label29.TabIndex = 11;
            this.label29.Text = "Y:";
            // 
            // Btn_SubMenuOperationsSuma
            // 
            this.Btn_SubMenuOperationsSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.Btn_SubMenuOperationsSuma.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SubMenuOperationsSuma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Btn_SubMenuOperationsSuma.FlatAppearance.BorderSize = 0;
            this.Btn_SubMenuOperationsSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubMenuOperationsSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SubMenuOperationsSuma.ForeColor = System.Drawing.Color.White;
            this.Btn_SubMenuOperationsSuma.Location = new System.Drawing.Point(0, 225);
            this.Btn_SubMenuOperationsSuma.Name = "Btn_SubMenuOperationsSuma";
            this.Btn_SubMenuOperationsSuma.Size = new System.Drawing.Size(283, 30);
            this.Btn_SubMenuOperationsSuma.TabIndex = 1;
            this.Btn_SubMenuOperationsSuma.Text = "Sumar vectores";
            this.Btn_SubMenuOperationsSuma.UseVisualStyleBackColor = false;
            this.Btn_SubMenuOperationsSuma.Click += new System.EventHandler(this.Btn_SubMenuOperationsSuma_Click);
            // 
            // PanelSubMenuOperationsSentido
            // 
            this.PanelSubMenuOperationsSentido.Controls.Add(this.label31);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.label11);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.label5);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.lblVectorActualY_PnlCambiarSentido);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.BtnCambiarSentido);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.lblVectorActualX_PnlCambiarSentido);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.label10);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.checkBoxY);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.checkBoxX);
            this.PanelSubMenuOperationsSentido.Controls.Add(this.label8);
            this.PanelSubMenuOperationsSentido.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuOperationsSentido.Location = new System.Drawing.Point(0, 125);
            this.PanelSubMenuOperationsSentido.Name = "PanelSubMenuOperationsSentido";
            this.PanelSubMenuOperationsSentido.Size = new System.Drawing.Size(283, 100);
            this.PanelSubMenuOperationsSentido.TabIndex = 6;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(154, 71);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(11, 16);
            this.label31.TabIndex = 20;
            this.label31.Text = ")";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(105, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "(";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = ",";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // lblVectorActualY_PnlCambiarSentido
            // 
            this.lblVectorActualY_PnlCambiarSentido.AutoSize = true;
            this.lblVectorActualY_PnlCambiarSentido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVectorActualY_PnlCambiarSentido.Location = new System.Drawing.Point(141, 71);
            this.lblVectorActualY_PnlCambiarSentido.Name = "lblVectorActualY_PnlCambiarSentido";
            this.lblVectorActualY_PnlCambiarSentido.Size = new System.Drawing.Size(14, 16);
            this.lblVectorActualY_PnlCambiarSentido.TabIndex = 17;
            this.lblVectorActualY_PnlCambiarSentido.Text = "y";
            this.lblVectorActualY_PnlCambiarSentido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVectorActualY_PnlCambiarSentido.Visible = false;
            // 
            // BtnCambiarSentido
            // 
            this.BtnCambiarSentido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiarSentido.Location = new System.Drawing.Point(198, 66);
            this.BtnCambiarSentido.Name = "BtnCambiarSentido";
            this.BtnCambiarSentido.Size = new System.Drawing.Size(64, 26);
            this.BtnCambiarSentido.TabIndex = 15;
            this.BtnCambiarSentido.Text = "Dibujar";
            this.BtnCambiarSentido.UseVisualStyleBackColor = true;
            this.BtnCambiarSentido.Click += new System.EventHandler(this.BtnCambiarSentido_Click);
            // 
            // lblVectorActualX_PnlCambiarSentido
            // 
            this.lblVectorActualX_PnlCambiarSentido.AutoSize = true;
            this.lblVectorActualX_PnlCambiarSentido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVectorActualX_PnlCambiarSentido.Location = new System.Drawing.Point(114, 71);
            this.lblVectorActualX_PnlCambiarSentido.Name = "lblVectorActualX_PnlCambiarSentido";
            this.lblVectorActualX_PnlCambiarSentido.Size = new System.Drawing.Size(13, 16);
            this.lblVectorActualX_PnlCambiarSentido.TabIndex = 16;
            this.lblVectorActualX_PnlCambiarSentido.Text = "x";
            this.lblVectorActualX_PnlCambiarSentido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVectorActualX_PnlCambiarSentido.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Vector:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxY
            // 
            this.checkBoxY.AutoSize = true;
            this.checkBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxY.Location = new System.Drawing.Point(173, 42);
            this.checkBoxY.Name = "checkBoxY";
            this.checkBoxY.Size = new System.Drawing.Size(35, 20);
            this.checkBoxY.TabIndex = 14;
            this.checkBoxY.Text = "Y";
            this.checkBoxY.UseVisualStyleBackColor = true;
            this.checkBoxY.Click += new System.EventHandler(this.checkBoxY_Click);
            // 
            // checkBoxX
            // 
            this.checkBoxX.AutoSize = true;
            this.checkBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxX.Location = new System.Drawing.Point(91, 42);
            this.checkBoxX.Name = "checkBoxX";
            this.checkBoxX.Size = new System.Drawing.Size(34, 20);
            this.checkBoxX.TabIndex = 13;
            this.checkBoxX.Text = "X";
            this.checkBoxX.UseVisualStyleBackColor = true;
            this.checkBoxX.Click += new System.EventHandler(this.checkBoxX_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Seleccionar eje a cambiar de sentido:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_SubMenuOperationsSentido
            // 
            this.Btn_SubMenuOperationsSentido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.Btn_SubMenuOperationsSentido.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SubMenuOperationsSentido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Btn_SubMenuOperationsSentido.FlatAppearance.BorderSize = 0;
            this.Btn_SubMenuOperationsSentido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubMenuOperationsSentido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SubMenuOperationsSentido.ForeColor = System.Drawing.Color.White;
            this.Btn_SubMenuOperationsSentido.Location = new System.Drawing.Point(0, 95);
            this.Btn_SubMenuOperationsSentido.Name = "Btn_SubMenuOperationsSentido";
            this.Btn_SubMenuOperationsSentido.Size = new System.Drawing.Size(283, 30);
            this.Btn_SubMenuOperationsSentido.TabIndex = 4;
            this.Btn_SubMenuOperationsSentido.Text = "Cambiar sentido";
            this.Btn_SubMenuOperationsSentido.UseVisualStyleBackColor = false;
            this.Btn_SubMenuOperationsSentido.Click += new System.EventHandler(this.Btn_SubMenuOperationsSentido_Click);
            // 
            // PanelSubMenuOperationsEscalar
            // 
            this.PanelSubMenuOperationsEscalar.Controls.Add(this.lblVectorActual_PnlEscalar);
            this.PanelSubMenuOperationsEscalar.Controls.Add(this.BtnAplicarEscalar);
            this.PanelSubMenuOperationsEscalar.Controls.Add(this.label9);
            this.PanelSubMenuOperationsEscalar.Controls.Add(this.txtEscalar);
            this.PanelSubMenuOperationsEscalar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuOperationsEscalar.Location = new System.Drawing.Point(0, 30);
            this.PanelSubMenuOperationsEscalar.Name = "PanelSubMenuOperationsEscalar";
            this.PanelSubMenuOperationsEscalar.Size = new System.Drawing.Size(283, 65);
            this.PanelSubMenuOperationsEscalar.TabIndex = 5;
            this.PanelSubMenuOperationsEscalar.Visible = false;
            // 
            // lblVectorActual_PnlEscalar
            // 
            this.lblVectorActual_PnlEscalar.AutoSize = true;
            this.lblVectorActual_PnlEscalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVectorActual_PnlEscalar.Location = new System.Drawing.Point(143, 26);
            this.lblVectorActual_PnlEscalar.Name = "lblVectorActual_PnlEscalar";
            this.lblVectorActual_PnlEscalar.Size = new System.Drawing.Size(34, 16);
            this.lblVectorActual_PnlEscalar.TabIndex = 14;
            this.lblVectorActual_PnlEscalar.Text = "(x, y)";
            this.lblVectorActual_PnlEscalar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVectorActual_PnlEscalar.Visible = false;
            // 
            // BtnAplicarEscalar
            // 
            this.BtnAplicarEscalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAplicarEscalar.Location = new System.Drawing.Point(197, 18);
            this.BtnAplicarEscalar.Name = "BtnAplicarEscalar";
            this.BtnAplicarEscalar.Size = new System.Drawing.Size(64, 33);
            this.BtnAplicarEscalar.TabIndex = 13;
            this.BtnAplicarEscalar.Text = "Aplicar";
            this.BtnAplicarEscalar.UseVisualStyleBackColor = true;
            this.BtnAplicarEscalar.Click += new System.EventHandler(this.BtnAplicarEscalar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Escalar:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEscalar
            // 
            this.txtEscalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtEscalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEscalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscalar.Location = new System.Drawing.Point(88, 25);
            this.txtEscalar.Name = "txtEscalar";
            this.txtEscalar.Size = new System.Drawing.Size(35, 19);
            this.txtEscalar.TabIndex = 12;
            this.txtEscalar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_SubMenuOperationsEscalar
            // 
            this.Btn_SubMenuOperationsEscalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.Btn_SubMenuOperationsEscalar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SubMenuOperationsEscalar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Btn_SubMenuOperationsEscalar.FlatAppearance.BorderSize = 0;
            this.Btn_SubMenuOperationsEscalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubMenuOperationsEscalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SubMenuOperationsEscalar.ForeColor = System.Drawing.Color.White;
            this.Btn_SubMenuOperationsEscalar.Location = new System.Drawing.Point(0, 0);
            this.Btn_SubMenuOperationsEscalar.Name = "Btn_SubMenuOperationsEscalar";
            this.Btn_SubMenuOperationsEscalar.Size = new System.Drawing.Size(283, 30);
            this.Btn_SubMenuOperationsEscalar.TabIndex = 0;
            this.Btn_SubMenuOperationsEscalar.Text = "Escalar vector";
            this.Btn_SubMenuOperationsEscalar.UseVisualStyleBackColor = false;
            this.Btn_SubMenuOperationsEscalar.Click += new System.EventHandler(this.Btn_SubMenuOperationsEscalar_Click);
            // 
            // BtnMenuOperations
            // 
            this.BtnMenuOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(33)))), ((int)(((byte)(17)))));
            this.BtnMenuOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMenuOperations.FlatAppearance.BorderSize = 0;
            this.BtnMenuOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenuOperations.ForeColor = System.Drawing.Color.White;
            this.BtnMenuOperations.Location = new System.Drawing.Point(0, 90);
            this.BtnMenuOperations.Name = "BtnMenuOperations";
            this.BtnMenuOperations.Size = new System.Drawing.Size(283, 40);
            this.BtnMenuOperations.TabIndex = 5;
            this.BtnMenuOperations.Text = "Operaciones";
            this.BtnMenuOperations.UseVisualStyleBackColor = false;
            this.BtnMenuOperations.Visible = false;
            this.BtnMenuOperations.Click += new System.EventHandler(this.BtnMenuOperations_Click);
            // 
            // PanelSubMenuDraw
            // 
            this.PanelSubMenuDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.PanelSubMenuDraw.Controls.Add(this.linkLabel_Animar);
            this.PanelSubMenuDraw.Controls.Add(this.linkLabel_DibujarMouse);
            this.PanelSubMenuDraw.Controls.Add(this.Btn_DrawVector);
            this.PanelSubMenuDraw.Controls.Add(this.txtAxisY);
            this.PanelSubMenuDraw.Controls.Add(this.txtAxisX);
            this.PanelSubMenuDraw.Controls.Add(this.label2);
            this.PanelSubMenuDraw.Controls.Add(this.label1);
            this.PanelSubMenuDraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuDraw.Location = new System.Drawing.Point(0, 0);
            this.PanelSubMenuDraw.Name = "PanelSubMenuDraw";
            this.PanelSubMenuDraw.Size = new System.Drawing.Size(283, 90);
            this.PanelSubMenuDraw.TabIndex = 4;
            // 
            // linkLabel_Animar
            // 
            this.linkLabel_Animar.AutoSize = true;
            this.linkLabel_Animar.LinkColor = System.Drawing.Color.White;
            this.linkLabel_Animar.Location = new System.Drawing.Point(201, 70);
            this.linkLabel_Animar.Name = "linkLabel_Animar";
            this.linkLabel_Animar.Size = new System.Drawing.Size(39, 13);
            this.linkLabel_Animar.TabIndex = 11;
            this.linkLabel_Animar.TabStop = true;
            this.linkLabel_Animar.Text = "Animar";
            this.linkLabel_Animar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Animar_LinkClicked);
            // 
            // linkLabel_DibujarMouse
            // 
            this.linkLabel_DibujarMouse.AutoSize = true;
            this.linkLabel_DibujarMouse.LinkColor = System.Drawing.Color.White;
            this.linkLabel_DibujarMouse.Location = new System.Drawing.Point(173, 49);
            this.linkLabel_DibujarMouse.Name = "linkLabel_DibujarMouse";
            this.linkLabel_DibujarMouse.Size = new System.Drawing.Size(95, 13);
            this.linkLabel_DibujarMouse.TabIndex = 10;
            this.linkLabel_DibujarMouse.TabStop = true;
            this.linkLabel_DibujarMouse.Text = "Dibujar con mouse";
            this.linkLabel_DibujarMouse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DibujarMouse_LinkClicked);
            // 
            // Btn_DrawVector
            // 
            this.Btn_DrawVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DrawVector.Location = new System.Drawing.Point(173, 13);
            this.Btn_DrawVector.Name = "Btn_DrawVector";
            this.Btn_DrawVector.Size = new System.Drawing.Size(95, 33);
            this.Btn_DrawVector.TabIndex = 9;
            this.Btn_DrawVector.Text = "DIBUJAR";
            this.Btn_DrawVector.UseVisualStyleBackColor = true;
            this.Btn_DrawVector.Click += new System.EventHandler(this.Btn_DrawVector_Click);
            // 
            // txtAxisY
            // 
            this.txtAxisY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtAxisY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAxisY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAxisY.Location = new System.Drawing.Point(92, 55);
            this.txtAxisY.Name = "txtAxisY";
            this.txtAxisY.Size = new System.Drawing.Size(35, 19);
            this.txtAxisY.TabIndex = 8;
            this.txtAxisY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAxisX
            // 
            this.txtAxisX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtAxisX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAxisX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAxisX.Location = new System.Drawing.Point(92, 18);
            this.txtAxisX.Name = "txtAxisX";
            this.txtAxisX.Size = new System.Drawing.Size(35, 19);
            this.txtAxisX.TabIndex = 7;
            this.txtAxisX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "X:";
            // 
            // Btn_MenuDibujarOrigen
            // 
            this.Btn_MenuDibujarOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Btn_MenuDibujarOrigen.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_MenuDibujarOrigen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Btn_MenuDibujarOrigen.FlatAppearance.BorderSize = 0;
            this.Btn_MenuDibujarOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MenuDibujarOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MenuDibujarOrigen.ForeColor = System.Drawing.Color.White;
            this.Btn_MenuDibujarOrigen.Location = new System.Drawing.Point(0, 0);
            this.Btn_MenuDibujarOrigen.Name = "Btn_MenuDibujarOrigen";
            this.Btn_MenuDibujarOrigen.Size = new System.Drawing.Size(283, 40);
            this.Btn_MenuDibujarOrigen.TabIndex = 0;
            this.Btn_MenuDibujarOrigen.Text = "Dibujar Desde Origen";
            this.Btn_MenuDibujarOrigen.UseVisualStyleBackColor = false;
            this.Btn_MenuDibujarOrigen.Click += new System.EventHandler(this.Btn_MenuDibujarOrigen_Click);
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(5)))), ((int)(((byte)(9)))));
            this.PanelTitle.Controls.Add(this.label3);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(300, 100);
            this.PanelTitle.TabIndex = 7;
            // 
            // PanelDetallesGrafico
            // 
            this.PanelDetallesGrafico.Controls.Add(this.label30);
            this.PanelDetallesGrafico.Controls.Add(this.lblAngulo);
            this.PanelDetallesGrafico.Controls.Add(this.label7);
            this.PanelDetallesGrafico.Controls.Add(this.lblCuadrante);
            this.PanelDetallesGrafico.Controls.Add(this.label6);
            this.PanelDetallesGrafico.Controls.Add(this.lblMagnitud);
            this.PanelDetallesGrafico.Controls.Add(this.label4);
            this.PanelDetallesGrafico.Location = new System.Drawing.Point(408, 0);
            this.PanelDetallesGrafico.Name = "PanelDetallesGrafico";
            this.PanelDetallesGrafico.Size = new System.Drawing.Size(464, 62);
            this.PanelDetallesGrafico.TabIndex = 7;
            this.PanelDetallesGrafico.Visible = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(152, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(164, 20);
            this.label30.TabIndex = 25;
            this.label30.Text = "Detalles del gráfico";
            // 
            // lblAngulo
            // 
            this.lblAngulo.AutoSize = true;
            this.lblAngulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngulo.Location = new System.Drawing.Point(409, 32);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(32, 18);
            this.lblAngulo.TabIndex = 24;
            this.lblAngulo.Text = "ang";
            this.lblAngulo.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(342, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ángulo: ";
            // 
            // lblCuadrante
            // 
            this.lblCuadrante.AutoSize = true;
            this.lblCuadrante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuadrante.Location = new System.Drawing.Point(267, 32);
            this.lblCuadrante.Name = "lblCuadrante";
            this.lblCuadrante.Size = new System.Drawing.Size(40, 18);
            this.lblCuadrante.TabIndex = 22;
            this.lblCuadrante.Text = "cuad";
            this.lblCuadrante.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cuadrante: ";
            // 
            // lblMagnitud
            // 
            this.lblMagnitud.AutoSize = true;
            this.lblMagnitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagnitud.Location = new System.Drawing.Point(85, 32);
            this.lblMagnitud.Name = "lblMagnitud";
            this.lblMagnitud.Size = new System.Drawing.Size(37, 18);
            this.lblMagnitud.TabIndex = 20;
            this.lblMagnitud.Text = "mag";
            this.lblMagnitud.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Magnitud: ";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txtCuadradoPuntoBy);
            this.groupBox13.Controls.Add(this.label53);
            this.groupBox13.Controls.Add(this.label54);
            this.groupBox13.Controls.Add(this.txtCuadradoPuntoBx);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(149, 45);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(123, 88);
            this.groupBox13.TabIndex = 41;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Punto B";
            // 
            // txtCuadradoPuntoBy
            // 
            this.txtCuadradoPuntoBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtCuadradoPuntoBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuadradoPuntoBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuadradoPuntoBy.Location = new System.Drawing.Point(48, 59);
            this.txtCuadradoPuntoBy.Name = "txtCuadradoPuntoBy";
            this.txtCuadradoPuntoBy.Size = new System.Drawing.Size(35, 19);
            this.txtCuadradoPuntoBy.TabIndex = 17;
            this.txtCuadradoPuntoBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(13, 31);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(18, 16);
            this.label53.TabIndex = 14;
            this.label53.Text = "X:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.White;
            this.label54.Location = new System.Drawing.Point(13, 59);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(19, 16);
            this.label54.TabIndex = 15;
            this.label54.Text = "Y:";
            // 
            // txtCuadradoPuntoBx
            // 
            this.txtCuadradoPuntoBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtCuadradoPuntoBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuadradoPuntoBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuadradoPuntoBx.Location = new System.Drawing.Point(48, 31);
            this.txtCuadradoPuntoBx.Name = "txtCuadradoPuntoBx";
            this.txtCuadradoPuntoBx.Size = new System.Drawing.Size(35, 19);
            this.txtCuadradoPuntoBx.TabIndex = 16;
            this.txtCuadradoPuntoBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.txtCuadradoPuntoAy);
            this.groupBox14.Controls.Add(this.label55);
            this.groupBox14.Controls.Add(this.txtCuadradoPuntoAx);
            this.groupBox14.Controls.Add(this.label56);
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.Location = new System.Drawing.Point(6, 45);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(123, 88);
            this.groupBox14.TabIndex = 40;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Punto A";
            // 
            // txtCuadradoPuntoAy
            // 
            this.txtCuadradoPuntoAy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtCuadradoPuntoAy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuadradoPuntoAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuadradoPuntoAy.Location = new System.Drawing.Point(57, 59);
            this.txtCuadradoPuntoAy.Name = "txtCuadradoPuntoAy";
            this.txtCuadradoPuntoAy.Size = new System.Drawing.Size(35, 19);
            this.txtCuadradoPuntoAy.TabIndex = 13;
            this.txtCuadradoPuntoAy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Location = new System.Drawing.Point(22, 31);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(18, 16);
            this.label55.TabIndex = 10;
            this.label55.Text = "X:";
            // 
            // txtCuadradoPuntoAx
            // 
            this.txtCuadradoPuntoAx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.txtCuadradoPuntoAx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuadradoPuntoAx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuadradoPuntoAx.Location = new System.Drawing.Point(57, 31);
            this.txtCuadradoPuntoAx.Name = "txtCuadradoPuntoAx";
            this.txtCuadradoPuntoAx.Size = new System.Drawing.Size(35, 19);
            this.txtCuadradoPuntoAx.TabIndex = 12;
            this.txtCuadradoPuntoAx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.White;
            this.label56.Location = new System.Drawing.Point(22, 59);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(19, 16);
            this.label56.TabIndex = 11;
            this.label56.Text = "Y:";
            // 
            // Btn_DibujarFigurasCuadrado
            // 
            this.Btn_DibujarFigurasCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DibujarFigurasCuadrado.Location = new System.Drawing.Point(105, 148);
            this.Btn_DibujarFigurasCuadrado.Name = "Btn_DibujarFigurasCuadrado";
            this.Btn_DibujarFigurasCuadrado.Size = new System.Drawing.Size(68, 26);
            this.Btn_DibujarFigurasCuadrado.TabIndex = 42;
            this.Btn_DibujarFigurasCuadrado.Text = "Dibujar";
            this.Btn_DibujarFigurasCuadrado.UseVisualStyleBackColor = true;
            this.Btn_DibujarFigurasCuadrado.Click += new System.EventHandler(this.Btn_DibujarFigurasCuadrado_Click);
            // 
            // Frm_Vectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.PanelDetallesGrafico);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.Btn_ReDraw);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "Frm_Vectores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de vectores";
            this.Load += new System.EventHandler(this.Frm_Vectores_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FreeDraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Graph)).EndInit();
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.Panel_SubMenuDibujoLibre.ResumeLayout(false);
            this.Panel_SubMenuDibujoLibre.PerformLayout();
            this.Panel_Ecuaciones.ResumeLayout(false);
            this.Panel_SubMenuCuadratica.ResumeLayout(false);
            this.Panel_SubMenuCuadratica.PerformLayout();
            this.Panel_SubMenuRecta.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.boxEcuacion.ResumeLayout(false);
            this.boxEcuacion.PerformLayout();
            this.Panel_MenuDibujarOrigen.ResumeLayout(false);
            this.Panel_MenuDibujarOrigen.PerformLayout();
            this.PanelSubMenuOperations.ResumeLayout(false);
            this.PanelSubMenuOperations.PerformLayout();
            this.PanelSubMenuOperationsProducto.ResumeLayout(false);
            this.PanelProductoVector.ResumeLayout(false);
            this.PanelProductoVector.PerformLayout();
            this.PanelProducto.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.PanelSubMenuOperationsResta.ResumeLayout(false);
            this.PanelRestaVector.ResumeLayout(false);
            this.PanelRestaVector.PerformLayout();
            this.PanelResta.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.PanelSubMenuOperationsSuma.ResumeLayout(false);
            this.PanelSumaVector.ResumeLayout(false);
            this.PanelSumaVector.PerformLayout();
            this.PanelSuma.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.PanelSubMenuOperationsSentido.ResumeLayout(false);
            this.PanelSubMenuOperationsSentido.PerformLayout();
            this.PanelSubMenuOperationsEscalar.ResumeLayout(false);
            this.PanelSubMenuOperationsEscalar.PerformLayout();
            this.PanelSubMenuDraw.ResumeLayout(false);
            this.PanelSubMenuDraw.PerformLayout();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.PanelDetallesGrafico.ResumeLayout(false);
            this.PanelDetallesGrafico.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctBox_Graph;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_ReDraw;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Panel PanelDetallesGrafico;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblAngulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCuadrante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMagnitud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Panel_MenuDibujarOrigen;
        private System.Windows.Forms.Panel PanelSubMenuOperations;
        private System.Windows.Forms.Panel PanelSubMenuOperationsProducto;
        private System.Windows.Forms.Panel PanelProductoVector;
        private System.Windows.Forms.Label lblResultadoProducto;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblProductoX2;
        private System.Windows.Forms.Label lblProductoX1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lblProductoY2;
        private System.Windows.Forms.Label lblProductoY1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel PanelProducto;
        private System.Windows.Forms.Button BtnCalcularProducto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtVectorProductoY2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtVectorProductoX2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtVectorProductoY1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtVectorProductoX1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button Btn_SubMenuOperationsProducto;
        private System.Windows.Forms.Panel PanelSubMenuOperationsResta;
        private System.Windows.Forms.Panel PanelRestaVector;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblRestaY;
        private System.Windows.Forms.Label lblRestaX;
        private System.Windows.Forms.Button Btn_CalcularResta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel PanelResta;
        private System.Windows.Forms.Button BtnCalcularResta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVectorRestaY2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtVectorRestaX2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtVectorRestaY1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtVectorRestaX1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button Btn_SubMenuOperationsResta;
        private System.Windows.Forms.Panel PanelSubMenuOperationsSuma;
        private System.Windows.Forms.Panel PanelSumaVector;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblSumaY;
        private System.Windows.Forms.Label lblSumaX;
        private System.Windows.Forms.Button Btn_CalcularSuma;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel PanelSuma;
        private System.Windows.Forms.Button BtnCalcularSuma;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtSumaVectorY2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtSumaVectorX2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtSumaVectorY1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtSumaVectorX1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button Btn_SubMenuOperationsSuma;
        private System.Windows.Forms.Panel PanelSubMenuOperationsSentido;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVectorActualY_PnlCambiarSentido;
        private System.Windows.Forms.Button BtnCambiarSentido;
        private System.Windows.Forms.Label lblVectorActualX_PnlCambiarSentido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxY;
        private System.Windows.Forms.CheckBox checkBoxX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_SubMenuOperationsSentido;
        private System.Windows.Forms.Panel PanelSubMenuOperationsEscalar;
        private System.Windows.Forms.Label lblVectorActual_PnlEscalar;
        private System.Windows.Forms.Button BtnAplicarEscalar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEscalar;
        private System.Windows.Forms.Button Btn_SubMenuOperationsEscalar;
        private System.Windows.Forms.Button BtnMenuOperations;
        private System.Windows.Forms.Panel PanelSubMenuDraw;
        private System.Windows.Forms.Button Btn_DrawVector;
        private System.Windows.Forms.TextBox txtAxisY;
        private System.Windows.Forms.TextBox txtAxisX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_MenuDibujarOrigen;
        private System.Windows.Forms.Panel Panel_Ecuaciones;
        private System.Windows.Forms.Button Btn_DibujarFiguras;
        private System.Windows.Forms.LinkLabel linkLabel_DibujarMouse;
        private System.Windows.Forms.LinkLabel linkLabel_Animar;
        private System.Windows.Forms.Panel Panel_SubMenuCuadratica;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Button Btn_SubMenuCuadratica;
        private System.Windows.Forms.Panel Panel_SubMenuRecta;
        private System.Windows.Forms.Button Btn_SubMenuRecta;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox txtPendiente;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox txtPuntoY;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox txtPuntoX;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtPuntoBY;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtPuntoBX;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtPuntoAY;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtPuntoAX;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.GroupBox boxEcuacion;
        private System.Windows.Forms.TextBox txtEcuacionB;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.TextBox txtEcuacionY;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox txtEcuacionX;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Button btn_CalcularEcuacionRecta;
        private System.Windows.Forms.PictureBox pictureBox_FreeDraw;
        private System.Windows.Forms.Button Btn_MenuDibujoLibre;
        private System.Windows.Forms.Panel Panel_SubMenuDibujoLibre;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Button Btn_DibujarFigurasCuadrado;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox txtCuadradoPuntoBy;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox txtCuadradoPuntoBx;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox txtCuadradoPuntoAy;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtCuadradoPuntoAx;
        private System.Windows.Forms.Label label56;
    }
}

