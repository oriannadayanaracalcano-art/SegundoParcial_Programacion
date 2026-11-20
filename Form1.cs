using System.Drawing.Text;

namespace Examen_Cafeteria_Orianna_Calcaño
{
    public partial class frmPedidos : Form
    {
        private decimal subtotal = 0;
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lstPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {


            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 20;
            nudCantidad.Value = 1;

            rbtNormal.Checked = true;
            rbtLocal.Checked = true;

            IbIEncabezado.Text = "Cant.       Producto                 Precio       Total";

            IbISubtotal.Text = "RD$ 0.00";
            IbIDescuento.Text = "RD$ 0.00";
            IbIEmpaque.Text = "RD$ 0.00";
            IbIItbis.Text = "RD$ 0.00";
            IbITotal.Text = "RD$ 0.00";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string producto = txtProducto.Text;
            decimal precio = decimal.Parse(txtPrecio.Text);
            int cantidad = (int)nudCantidad.Value;

            decimal precioUnitario = precio;

            if (rbtGrande.Checked)
            {
                precioUnitario += 25;
            }

            if (chkPorcionExtra.Checked)
            {
                precioUnitario += 30;
            }

            decimal totalLinea = precioUnitario * cantidad;

            string tamano = rbtGrande.Checked ? "Grande" : "Normal";

            string linea = cantidad.ToString().PadRight(6) +
                           (producto + " (" + tamano + ")").PadRight(24) +
                           precioUnitario.ToString("N2").PadLeft(10) +
                           totalLinea.ToString("N2").PadLeft(12);

            lstPedido.Items.Add(linea);

            subtotal += totalLinea;

            IbISubtotal.Text = "RD$ " + subtotal.ToString("N2");

            txtProducto.Text = "";
            txtPrecio.Clear();
            nudCantidad.Value = 1;
            rbtNormal.Checked = true;
            chkPorcionExtra.Checked = false;

            txtProducto.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal descuento = 0;
            decimal empaque = 0;
            decimal itbis;
            decimal total;

            if (chkFrecuente.Checked)
            {
                descuento = subtotal * 0.10m;
            }

            if (rbtLlevar.Checked)
            {
                empaque = 20;
            }

            decimal baseImponible = subtotal - descuento + empaque;

            itbis = baseImponible * 0.18m;

            total = baseImponible + itbis;

            IbISubtotal.Text = "RD$ " + subtotal.ToString("N2");
            IbIDescuento.Text = "RD$ " + descuento.ToString("N2");
            IbIEmpaque.Text = "RD$ " + empaque.ToString("N2");
            IbIItbis.Text = "RD$ " + itbis.ToString("N2");
            IbITotal.Text = "RD$ " + total.ToString("N2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            subtotal = 0;

            txtCliente.Text = "";
            txtProducto.Text = "";
            txtPrecio.Text = "";

            nudCantidad.Value = 1;

            rbtNormal.Checked = true;
            rbtLocal.Checked = true;

            chkFrecuente.Checked = false;
            chkPorcionExtra.Checked = false;

            lstPedido.Items.Clear();

            IbISubtotal.Text = "RD$ 0.00";
            IbIDescuento.Text = "RD$ 0.00";
            IbIEmpaque.Text = "RD$ 0.00";
            IbIItbis.Text = "RD$ 0.00";
            IbITotal.Text = "RD$ 0.00";

            txtCliente.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
