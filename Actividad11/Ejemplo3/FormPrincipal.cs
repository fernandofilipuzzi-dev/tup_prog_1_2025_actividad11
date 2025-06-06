namespace Ejemplo3
{
    public partial class FormPrincipal : Form
    {
        double[] valores =new double[100];
        int contador = 0;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            valores[contador] += Convert.ToDouble(tbValor.Text);
            contador++;

            tbValor.Clear();
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double acumulador = 0;

            for (int n = 0; n < contador; n++)
            {
                acumulador += valores[n];
            }

            double promedio = acumulador / contador; 

            lbResultado.Text = $"{promedio:f2}";
            tbResultado.Text = $@"Promedio:
{promedio:f2}";

        }
    }
}
