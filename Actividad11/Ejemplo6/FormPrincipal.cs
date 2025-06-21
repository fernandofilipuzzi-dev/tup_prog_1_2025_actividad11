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
            for (int n = 0; n < servicio.VerContador(); n++)
            {
                tbResultado.Text += $"{servicio.VerValor(n),5:f2}";
            }
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            int idxMaximo = servicio.CalcularMaximo();

            if (idxMaximo > -1)
            {
                lbMaximo.Text = $"Máximo: {servicio.VerValor(idxMaximo),5:f2} en la posición {idxMaximo}.";
            }
            else
            {
                lbMaximo.Text = "No hay valores registrados.";
            }
        }

        private void btnMinimo_Click(object sender, EventArgs e)
        {
            int idxMinimo = servicio.CalcularMinimo();

            if (idxMinimo > -1)
            {
                lbMinimo.Text = $"Mínimo: {servicio.VerValor(idxMinimo),5:f2} en la posición {idxMinimo}.";
            }
            else
            {
                lbMaximo.Text = "No hay valores registrados.";
            }
        }

        private void btnMayoresAlPromedio_Click(object sender, EventArgs e)
        {
            int cantidadMayores = 0;
            int[] idxInidicesMayoresAlPromedio = servicio.CalcularMayoresAlPromedio(out cantidadMayores);

            tbResultado.Clear();
            for (int n = 0; n < cantidadMayores; n++)
            {
                int indice = idxInidicesMayoresAlPromedio[n];
                tbResultado.Text += $"{servicio.VerValor(indice),5:f2}";
            }
        }
    }
}
