using Ejemplo6.Models;

namespace Ejemplo6
{
    public partial class FormPrincipal : Form
    {
        Servicio servicio = new Servicio();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
            servicio.RegistrarValor(Convert.ToDouble(tbValor.Text));

            tbValor.Clear();
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double promedio = servicio.CalcularPromedio();

            lbResultado.Text = $"{promedio:f2}";
            tbResultado.Text = $@"Promedio:
{promedio:f2}";

        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int valorBuscar = Convert.ToInt32(tbBuscar.Text);
            int idx = servicio.Buscar(valorBuscar);

            if (idx > -1)
            {
                tbResultado.Text = $"Valor encontrado en la posición {idx}.";
            }
            else
            {
                tbResultado.Text = "Valor no buscado";
            }
        }

        private void btnListarOrdenado_Click(object sender, EventArgs e)
        {

            servicio.Ordenar();

            tbResultado.Clear();
            for (int n = 0; n < servicio.Contador; n++)
            {
                tbResultado.Text += $"{servicio.Valores[n],5:f2}";
            }

        }

    }
}
