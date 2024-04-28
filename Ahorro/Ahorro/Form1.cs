namespace Ahorro
{
    public partial class AhorroDisponible : Form
    {
        public AhorroDisponible()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(Monto.Text);
            double intereses = double.Parse(Interes.Text);
            double Periodo = double.Parse(Años.Text);

            double CapitalFinal = monto * Math.Pow(1 + (intereses / 100), Periodo);

            Resultado.Text= $"El capital total es: {CapitalFinal}";
          
        }

        private void AhorroDisponible_Load(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
