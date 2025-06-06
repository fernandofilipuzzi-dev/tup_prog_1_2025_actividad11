namespace Ejemplo2
{
    public partial class FormPrincipal : Form
    {
        double acumulador = 0;
        int contador = 0;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            acumulador += Convert.ToDouble(tbValor.Text);
            contador++;

            tbValor.Clear();
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double promedio = acumulador / contador;

            lbResultado.Text = $"{promedio:f2}";
            tbResultado.Text = $@"Promedio:
{promedio:f2}";   
            
        }
    }
}
