namespace Gestion_Ciber_Cafe_GUI
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageNuevo = new System.Windows.Forms.TabPage();
            this.tabPageCargar = new System.Windows.Forms.TabPage();
            this.panelLateralDetalleProducto = new System.Windows.Forms.Panel();
            this.labelDetalleProducto = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelValorVenta = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnGenerarCodigoBarras = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.checkBoxMostrarCodigo = new System.Windows.Forms.CheckBox();
            this.labelMostrarCodigo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelListaProductos = new System.Windows.Forms.Label();
            this.grillaListaProductos = new System.Windows.Forms.DataGridView();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.tabPageNuevo.SuspendLayout();
            this.panelLateralDetalleProducto.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox5.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources.minimizar1;
            this.pictureBox5.Location = new System.Drawing.Point(889, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.pictureBox5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox4.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources.equis_salir;
            this.pictureBox4.Location = new System.Drawing.Point(917, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseMove);
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPrincipal.Controls.Add(this.tabPageNuevo);
            this.tabPrincipal.Controls.Add(this.tabPageCargar);
            this.tabPrincipal.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPrincipal.Location = new System.Drawing.Point(-5, 37);
            this.tabPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Drawing.Point(0, 0);
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(961, 464);
            this.tabPrincipal.TabIndex = 13;
            // 
            // tabPageNuevo
            // 
            this.tabPageNuevo.BackColor = System.Drawing.SystemColors.GrayText;
            this.tabPageNuevo.Controls.Add(this.panel1);
            this.tabPageNuevo.Controls.Add(this.panelLateralDetalleProducto);
            this.tabPageNuevo.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageNuevo.Location = new System.Drawing.Point(4, 4);
            this.tabPageNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageNuevo.Name = "tabPageNuevo";
            this.tabPageNuevo.Size = new System.Drawing.Size(953, 435);
            this.tabPageNuevo.TabIndex = 0;
            this.tabPageNuevo.Text = "Nuevo";
            // 
            // tabPageCargar
            // 
            this.tabPageCargar.BackColor = System.Drawing.SystemColors.GrayText;
            this.tabPageCargar.Location = new System.Drawing.Point(4, 4);
            this.tabPageCargar.Name = "tabPageCargar";
            this.tabPageCargar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCargar.Size = new System.Drawing.Size(953, 435);
            this.tabPageCargar.TabIndex = 1;
            this.tabPageCargar.Text = "Gargar";
            // 
            // panelLateralDetalleProducto
            // 
            this.panelLateralDetalleProducto.AutoScroll = true;
            this.panelLateralDetalleProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelLateralDetalleProducto.Controls.Add(this.labelMostrarCodigo);
            this.panelLateralDetalleProducto.Controls.Add(this.checkBoxMostrarCodigo);
            this.panelLateralDetalleProducto.Controls.Add(this.btnGenerarCodigoBarras);
            this.panelLateralDetalleProducto.Controls.Add(this.panelSubMenu);
            this.panelLateralDetalleProducto.Controls.Add(this.textBox3);
            this.panelLateralDetalleProducto.Controls.Add(this.labelValorVenta);
            this.panelLateralDetalleProducto.Controls.Add(this.textBoxDescripcion);
            this.panelLateralDetalleProducto.Controls.Add(this.labelDescripcion);
            this.panelLateralDetalleProducto.Controls.Add(this.textBoxNombre);
            this.panelLateralDetalleProducto.Controls.Add(this.labelNombre);
            this.panelLateralDetalleProducto.Controls.Add(this.textBoxCodigo);
            this.panelLateralDetalleProducto.Controls.Add(this.labelCodigo);
            this.panelLateralDetalleProducto.Controls.Add(this.labelDetalleProducto);
            this.panelLateralDetalleProducto.Controls.Add(this.pictureBox1);
            this.panelLateralDetalleProducto.Controls.Add(this.pictureBox2);
            this.panelLateralDetalleProducto.Controls.Add(this.pictureBox3);
            this.panelLateralDetalleProducto.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateralDetalleProducto.Location = new System.Drawing.Point(0, 0);
            this.panelLateralDetalleProducto.Name = "panelLateralDetalleProducto";
            this.panelLateralDetalleProducto.Size = new System.Drawing.Size(239, 435);
            this.panelLateralDetalleProducto.TabIndex = 0;
            // 
            // labelDetalleProducto
            // 
            this.labelDetalleProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDetalleProducto.AutoSize = true;
            this.labelDetalleProducto.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalleProducto.ForeColor = System.Drawing.Color.Indigo;
            this.labelDetalleProducto.Location = new System.Drawing.Point(13, 21);
            this.labelDetalleProducto.Name = "labelDetalleProducto";
            this.labelDetalleProducto.Size = new System.Drawing.Size(189, 27);
            this.labelDetalleProducto.TabIndex = 0;
            this.labelDetalleProducto.Text = "Detalle de Producto";
            // 
            // labelCodigo
            // 
            this.labelCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(13, 67);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(58, 19);
            this.labelCodigo.TabIndex = 1;
            this.labelCodigo.Text = "Codigo:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCodigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(13, 89);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(212, 16);
            this.textBoxCodigo.TabIndex = 2;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(13, 137);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(212, 16);
            this.textBoxNombre.TabIndex = 4;
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(13, 115);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(64, 19);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescripcion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(13, 233);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescripcion.Size = new System.Drawing.Size(212, 46);
            this.textBoxDescripcion.TabIndex = 6;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(13, 211);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(89, 19);
            this.labelDescripcion.TabIndex = 5;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(13, 185);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 16);
            this.textBox3.TabIndex = 8;
            // 
            // labelValorVenta
            // 
            this.labelValorVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelValorVenta.AutoSize = true;
            this.labelValorVenta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorVenta.Location = new System.Drawing.Point(13, 163);
            this.labelValorVenta.Name = "labelValorVenta";
            this.labelValorVenta.Size = new System.Drawing.Size(107, 19);
            this.labelValorVenta.TabIndex = 7;
            this.labelValorVenta.Text = "Valor de Venta:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(0, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(239, 39);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelSubMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelSubMenu.Controls.Add(this.btnEliminar);
            this.panelSubMenu.Controls.Add(this.btnGuardar);
            this.panelSubMenu.Location = new System.Drawing.Point(0, 355);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(239, 78);
            this.panelSubMenu.TabIndex = 10;
            // 
            // btnGenerarCodigoBarras
            // 
            this.btnGenerarCodigoBarras.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGenerarCodigoBarras.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGenerarCodigoBarras.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerarCodigoBarras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCodigoBarras.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCodigoBarras.Location = new System.Drawing.Point(13, 285);
            this.btnGenerarCodigoBarras.Name = "btnGenerarCodigoBarras";
            this.btnGenerarCodigoBarras.Size = new System.Drawing.Size(212, 40);
            this.btnGenerarCodigoBarras.TabIndex = 11;
            this.btnGenerarCodigoBarras.Text = "Generar Codigo";
            this.btnGenerarCodigoBarras.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(0, 39);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(239, 39);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // checkBoxMostrarCodigo
            // 
            this.checkBoxMostrarCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxMostrarCodigo.AutoSize = true;
            this.checkBoxMostrarCodigo.Location = new System.Drawing.Point(31, 331);
            this.checkBoxMostrarCodigo.Name = "checkBoxMostrarCodigo";
            this.checkBoxMostrarCodigo.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMostrarCodigo.TabIndex = 12;
            this.checkBoxMostrarCodigo.UseVisualStyleBackColor = true;
            // 
            // labelMostrarCodigo
            // 
            this.labelMostrarCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMostrarCodigo.AutoSize = true;
            this.labelMostrarCodigo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostrarCodigo.Location = new System.Drawing.Point(52, 331);
            this.labelMostrarCodigo.Name = "labelMostrarCodigo";
            this.labelMostrarCodigo.Size = new System.Drawing.Size(146, 14);
            this.labelMostrarCodigo.TabIndex = 13;
            this.labelMostrarCodigo.Text = "Mostrar codigo en la etiqueta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources.linea;
            this.pictureBox1.Location = new System.Drawing.Point(12, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 4);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources.linea;
            this.pictureBox2.Location = new System.Drawing.Point(12, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 4);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources.linea;
            this.pictureBox3.Location = new System.Drawing.Point(12, 201);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 4);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.textBoxBuscar);
            this.panel1.Controls.Add(this.labelBuscar);
            this.panel1.Controls.Add(this.grillaListaProductos);
            this.panel1.Controls.Add(this.labelListaProductos);
            this.panel1.Location = new System.Drawing.Point(239, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 435);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelListaProductos
            // 
            this.labelListaProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelListaProductos.AutoSize = true;
            this.labelListaProductos.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaProductos.ForeColor = System.Drawing.Color.Indigo;
            this.labelListaProductos.Location = new System.Drawing.Point(6, 21);
            this.labelListaProductos.Name = "labelListaProductos";
            this.labelListaProductos.Size = new System.Drawing.Size(177, 27);
            this.labelListaProductos.TabIndex = 1;
            this.labelListaProductos.Text = "Lista de Productos";
            // 
            // grillaListaProductos
            // 
            this.grillaListaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grillaListaProductos.BackgroundColor = System.Drawing.Color.Azure;
            this.grillaListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaListaProductos.Location = new System.Drawing.Point(11, 51);
            this.grillaListaProductos.Name = "grillaListaProductos";
            this.grillaListaProductos.Size = new System.Drawing.Size(690, 372);
            this.grillaListaProductos.TabIndex = 2;
            // 
            // labelBuscar
            // 
            this.labelBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.Location = new System.Drawing.Point(426, 28);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(52, 16);
            this.labelBuscar.TabIndex = 3;
            this.labelBuscar.Text = "Buscar:";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Location = new System.Drawing.Point(484, 24);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(190, 20);
            this.textBoxBuscar.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(676, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 20);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(951, 500);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.tabPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(951, 500);
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.tabPageNuevo.ResumeLayout(false);
            this.panelLateralDetalleProducto.ResumeLayout(false);
            this.panelLateralDetalleProducto.PerformLayout();
            this.panelSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaListaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabPage tabPageNuevo;
        private System.Windows.Forms.TabPage tabPageCargar;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.Panel panelLateralDetalleProducto;
        private System.Windows.Forms.Label labelDetalleProducto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelValorVenta;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelMostrarCodigo;
        private System.Windows.Forms.CheckBox checkBoxMostrarCodigo;
        private System.Windows.Forms.Button btnGenerarCodigoBarras;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.DataGridView grillaListaProductos;
        private System.Windows.Forms.Label labelListaProductos;
    }
}