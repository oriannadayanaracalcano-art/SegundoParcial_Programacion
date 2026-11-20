namespace Examen_Cafeteria_Orianna_Calcaño
{
    partial class frmPedidos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCliente = new TextBox();
            dtpFecha = new DateTimePicker();
            chkFrecuente = new CheckBox();
            txtProductos = new TextBox();
            txtPrecio = new TextBox();
            nudCantidad = new NumericUpDown();
            groupBox1 = new GroupBox();
            rbtGrande = new RadioButton();
            rbtNormal = new RadioButton();
            chkPorcionExtra = new CheckBox();
            groupBox2 = new GroupBox();
            rbtLlevar = new RadioButton();
            rbtLocal = new RadioButton();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            IbIEncabezado = new Label();
            lstPedido = new ListBox();
            IbITextoSubtotal = new Label();
            IbITextoDescuento = new Label();
            IbITextoEmpaque = new Label();
            IbITextoitbis = new Label();
            IbITextoTotal = new Label();
            IbISubtotal = new Label();
            IbIDescuento = new Label();
            IbIEmpaque = new Label();
            IbIItbis = new Label();
            IbITotal = new Label();
            IbITextoCliente = new Label();
            IbITextoFecha = new Label();
            txtProducto = new Label();
            IbITextoPrecio = new Label();
            IbITextoCantidad = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(81, 48);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(231, 23);
            txtCliente.TabIndex = 0;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(83, 122);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(224, 23);
            dtpFecha.TabIndex = 1;
            // 
            // chkFrecuente
            // 
            chkFrecuente.AutoSize = true;
            chkFrecuente.Location = new Point(83, 85);
            chkFrecuente.Name = "chkFrecuente";
            chkFrecuente.Size = new Size(118, 19);
            chkFrecuente.TabIndex = 2;
            chkFrecuente.Text = "Cliente Frecuente";
            chkFrecuente.UseVisualStyleBackColor = true;
            chkFrecuente.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtProductos
            // 
            txtProductos.Location = new Point(84, 162);
            txtProductos.Name = "txtProductos";
            txtProductos.Size = new Size(223, 23);
            txtProductos.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(82, 205);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(225, 23);
            txtPrecio.TabIndex = 4;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(81, 244);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(159, 23);
            nudCantidad.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtGrande);
            groupBox1.Controls.Add(rbtNormal);
            groupBox1.Location = new Point(85, 294);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(136, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tamaño";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbtGrande
            // 
            rbtGrande.AutoSize = true;
            rbtGrande.Location = new Point(11, 58);
            rbtGrande.Name = "rbtGrande";
            rbtGrande.Size = new Size(112, 19);
            rbtGrande.TabIndex = 8;
            rbtGrande.TabStop = true;
            rbtGrande.Text = "Grande (+RD 25)";
            rbtGrande.UseVisualStyleBackColor = true;
            // 
            // rbtNormal
            // 
            rbtNormal.AutoSize = true;
            rbtNormal.Location = new Point(10, 22);
            rbtNormal.Name = "rbtNormal";
            rbtNormal.Size = new Size(65, 19);
            rbtNormal.TabIndex = 7;
            rbtNormal.TabStop = true;
            rbtNormal.Text = "Normal";
            rbtNormal.UseVisualStyleBackColor = true;
            // 
            // chkPorcionExtra
            // 
            chkPorcionExtra.AutoSize = true;
            chkPorcionExtra.Location = new Point(85, 411);
            chkPorcionExtra.Name = "chkPorcionExtra";
            chkPorcionExtra.Size = new Size(151, 19);
            chkPorcionExtra.TabIndex = 7;
            chkPorcionExtra.Text = "Porcion extra (+RD$ 30)";
            chkPorcionExtra.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtLlevar);
            groupBox2.Controls.Add(rbtLocal);
            groupBox2.Location = new Point(235, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(150, 100);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Servicio";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // rbtLlevar
            // 
            rbtLlevar.AutoSize = true;
            rbtLlevar.Location = new Point(7, 62);
            rbtLlevar.Name = "rbtLlevar";
            rbtLlevar.Size = new Size(134, 19);
            rbtLlevar.TabIndex = 1;
            rbtLlevar.TabStop = true;
            rbtLlevar.Text = "Para llevar (+RD$ 20)";
            rbtLlevar.UseVisualStyleBackColor = true;
            // 
            // rbtLocal
            // 
            rbtLocal.AutoSize = true;
            rbtLocal.Location = new Point(6, 21);
            rbtLocal.Name = "rbtLocal";
            rbtLocal.Size = new Size(121, 19);
            rbtLocal.TabIndex = 0;
            rbtLocal.TabStop = true;
            rbtLocal.Text = "Consumir en local";
            rbtLocal.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(85, 460);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(101, 23);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular Total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(192, 460);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(99, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Nuevo Pedido";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(297, 460);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(407, 34);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(283, 49);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // IbIEncabezado
            // 
            IbIEncabezado.AutoSize = true;
            IbIEncabezado.Location = new Point(418, 91);
            IbIEncabezado.Name = "IbIEncabezado";
            IbIEncabezado.Size = new Size(227, 15);
            IbIEncabezado.TabIndex = 13;
            IbIEncabezado.Text = "cant.                Producto      Precio       Total";
            // 
            // lstPedido
            // 
            lstPedido.FormattingEnabled = true;
            lstPedido.Location = new Point(418, 109);
            lstPedido.Name = "lstPedido";
            lstPedido.Size = new Size(250, 124);
            lstPedido.TabIndex = 14;
            lstPedido.SelectedIndexChanged += lstPedido_SelectedIndexChanged;
            // 
            // IbITextoSubtotal
            // 
            IbITextoSubtotal.AutoSize = true;
            IbITextoSubtotal.Location = new Point(432, 271);
            IbITextoSubtotal.Name = "IbITextoSubtotal";
            IbITextoSubtotal.Size = new Size(57, 15);
            IbITextoSubtotal.TabIndex = 15;
            IbITextoSubtotal.Text = "Subtotal :";
            // 
            // IbITextoDescuento
            // 
            IbITextoDescuento.AutoSize = true;
            IbITextoDescuento.Location = new Point(434, 304);
            IbITextoDescuento.Name = "IbITextoDescuento";
            IbITextoDescuento.Size = new Size(69, 15);
            IbITextoDescuento.TabIndex = 16;
            IbITextoDescuento.Text = "Descuento :";
            // 
            // IbITextoEmpaque
            // 
            IbITextoEmpaque.AutoSize = true;
            IbITextoEmpaque.Location = new Point(433, 337);
            IbITextoEmpaque.Name = "IbITextoEmpaque";
            IbITextoEmpaque.Size = new Size(63, 15);
            IbITextoEmpaque.TabIndex = 17;
            IbITextoEmpaque.Text = "Empaque :";
            // 
            // IbITextoitbis
            // 
            IbITextoitbis.AutoSize = true;
            IbITextoitbis.Location = new Point(436, 371);
            IbITextoitbis.Name = "IbITextoitbis";
            IbITextoitbis.Size = new Size(65, 15);
            IbITextoitbis.TabIndex = 18;
            IbITextoitbis.Text = "ITBIS (18%)";
            // 
            // IbITextoTotal
            // 
            IbITextoTotal.AutoSize = true;
            IbITextoTotal.Location = new Point(432, 401);
            IbITextoTotal.Name = "IbITextoTotal";
            IbITextoTotal.Size = new Size(96, 15);
            IbITextoTotal.TabIndex = 19;
            IbITextoTotal.Text = "TOTAL A PAGAR :";
            // 
            // IbISubtotal
            // 
            IbISubtotal.AutoSize = true;
            IbISubtotal.Location = new Point(501, 270);
            IbISubtotal.Name = "IbISubtotal";
            IbISubtotal.Size = new Size(52, 15);
            IbISubtotal.TabIndex = 20;
            IbISubtotal.Text = "RD$ 0.00";
            // 
            // IbIDescuento
            // 
            IbIDescuento.AutoSize = true;
            IbIDescuento.Location = new Point(506, 306);
            IbIDescuento.Name = "IbIDescuento";
            IbIDescuento.Size = new Size(52, 15);
            IbIDescuento.TabIndex = 21;
            IbIDescuento.Text = "RD$ 0.00";
            // 
            // IbIEmpaque
            // 
            IbIEmpaque.AutoSize = true;
            IbIEmpaque.Location = new Point(505, 339);
            IbIEmpaque.Name = "IbIEmpaque";
            IbIEmpaque.Size = new Size(52, 15);
            IbIEmpaque.TabIndex = 22;
            IbIEmpaque.Text = "RD$ 0.00";
            // 
            // IbIItbis
            // 
            IbIItbis.AutoSize = true;
            IbIItbis.Location = new Point(508, 371);
            IbIItbis.Name = "IbIItbis";
            IbIItbis.Size = new Size(52, 15);
            IbIItbis.TabIndex = 23;
            IbIItbis.Text = "RD$ 0.00";
            // 
            // IbITotal
            // 
            IbITotal.AutoSize = true;
            IbITotal.Location = new Point(532, 402);
            IbITotal.Name = "IbITotal";
            IbITotal.Size = new Size(52, 15);
            IbITotal.TabIndex = 24;
            IbITotal.Text = "RD$ 0.00";
            // 
            // IbITextoCliente
            // 
            IbITextoCliente.AutoSize = true;
            IbITextoCliente.Location = new Point(24, 51);
            IbITextoCliente.Name = "IbITextoCliente";
            IbITextoCliente.Size = new Size(50, 15);
            IbITextoCliente.TabIndex = 25;
            IbITextoCliente.Text = "Cliente :";
            // 
            // IbITextoFecha
            // 
            IbITextoFecha.AutoSize = true;
            IbITextoFecha.Location = new Point(36, 128);
            IbITextoFecha.Name = "IbITextoFecha";
            IbITextoFecha.Size = new Size(44, 15);
            IbITextoFecha.TabIndex = 26;
            IbITextoFecha.Text = "Fecha :";
            // 
            // txtProducto
            // 
            txtProducto.AutoSize = true;
            txtProducto.Location = new Point(18, 165);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(62, 15);
            txtProducto.TabIndex = 27;
            txtProducto.Text = "Producto :";
            // 
            // IbITextoPrecio
            // 
            IbITextoPrecio.AutoSize = true;
            IbITextoPrecio.Location = new Point(28, 208);
            IbITextoPrecio.Name = "IbITextoPrecio";
            IbITextoPrecio.Size = new Size(46, 15);
            IbITextoPrecio.TabIndex = 28;
            IbITextoPrecio.Text = "Precio :";
            // 
            // IbITextoCantidad
            // 
            IbITextoCantidad.AutoSize = true;
            IbITextoCantidad.Location = new Point(13, 246);
            IbITextoCantidad.Name = "IbITextoCantidad";
            IbITextoCantidad.Size = new Size(61, 15);
            IbITextoCantidad.TabIndex = 29;
            IbITextoCantidad.Text = "Cantidad :";
            // 
            // frmPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(800, 550);
            Controls.Add(IbITextoCantidad);
            Controls.Add(IbITextoPrecio);
            Controls.Add(txtProducto);
            Controls.Add(IbITextoFecha);
            Controls.Add(IbITextoCliente);
            Controls.Add(IbITotal);
            Controls.Add(IbIItbis);
            Controls.Add(IbIEmpaque);
            Controls.Add(IbIDescuento);
            Controls.Add(IbISubtotal);
            Controls.Add(IbITextoTotal);
            Controls.Add(IbITextoitbis);
            Controls.Add(IbITextoEmpaque);
            Controls.Add(IbITextoDescuento);
            Controls.Add(IbITextoSubtotal);
            Controls.Add(lstPedido);
            Controls.Add(IbIEncabezado);
            Controls.Add(btnAgregar);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox2);
            Controls.Add(chkPorcionExtra);
            Controls.Add(groupBox1);
            Controls.Add(nudCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtProductos);
            Controls.Add(chkFrecuente);
            Controls.Add(dtpFecha);
            Controls.Add(txtCliente);
            Name = "frmPedidos";
            Text = "Cateria el buen sabor -Pedidos";
            Load += frmPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private DateTimePicker dtpFecha;
        private CheckBox chkFrecuente;
        private TextBox txtProductos;
        private TextBox txtPrecio;
        private NumericUpDown nudCantidad;
        private GroupBox groupBox1;
        private RadioButton rbtNormal;
        private RadioButton rbtGrande;
        private CheckBox chkPorcionExtra;
        private GroupBox groupBox2;
        private RadioButton rbtLocal;
        private RadioButton rbtLlevar;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnAgregar;
        private Label IbIEncabezado;
        private ListBox lstPedido;
        private Label IbITextoSubtotal;
        private Label IbITextoDescuento;
        private Label IbITextoEmpaque;
        private Label IbITextoitbis;
        private Label IbITextoTotal;
        private Label IbISubtotal;
        private Label IbIDescuento;
        private Label IbIEmpaque;
        private Label IbIItbis;
        private Label IbITotal;
        private Label IbITextoCliente;
        private Label IbITextoFecha;
        private Label txtProducto;
        private Label IbITextoPrecio;
        private Label IbITextoCantidad;
    }
}
