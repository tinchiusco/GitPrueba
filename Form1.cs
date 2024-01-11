namespace ReciboSueldo
{
    public partial class gbResultado : Form
    {
        public gbResultado()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            OcultarResultados();

        }

        void OcultarResultados()
        {
            this.lblTotalDescuentos.Text = "Total Descuentos";
            this.lblTotalCobrar.Text = "Total a Cobrar Bruto";
            this.lblTotalDescuentos.Text = "Total a Cobrar Neto";
            gbResultados.Visible = false;
        }

        void MostrarResultados(decimal importeBruto, decimal descuento, decimal total)
        {
            this.lblTotalCobrar.Text += importeBruto.ToString();
            this.lblTotalDescuentos.Text += descuento.ToString();
            this.lblTotalNeto.Text += total.ToString();
            gbResultados.Visible = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal importeBruto = CalcularImporteCobrarBruto();
            decimal descuento = CalcularDescuento(importeBruto);
            decimal total = CalcularTotal(importeBruto, descuento);
            MostrarResultados(importeBruto, descuento, total);





        }

        decimal CalcularTotal(decimal bruto, decimal descuento)
        {
            return bruto - descuento;
        }
        decimal CalcularImporteCobrarBruto()
        {
            decimal antiguedad = CalcularAntiguedad();
            decimal importeHoras = CalcularImporteHoras();
            return importeHoras + antiguedad;
        }

        decimal CalcularAntiguedad()
        {
            return numAntiguedad.Value * 30;
        }

        decimal CalcularImporteHoras()
        {
            return numHorasTrabajadas.Value * numValorHora.Value;
        }

        decimal CalcularDescuento(decimal ImporteBruto)
        {
            return ImporteBruto * 0.3m;
        }

        private void numValorHora_ValueChanged(object sender, EventArgs e)
        {
 
        }
    }
}
