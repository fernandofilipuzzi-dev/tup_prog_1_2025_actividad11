namespace Ejemplo5
{
    public partial class FormPrincipal : Form
    {
        double[] valores = new double[100];
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

        int Buscar(int valorBuscar)
        {
            int idx = -1;
            int n = 0;
            while (n < contador && idx == -1)
            {
                if (valores[n] == valorBuscar)
                {
                    idx = n;
                }
                n++;
            }
            return idx;
        }

        int Ordenar()
        {
            int idx = -1;
            for (int pivote = 0; pivote < contador - 1; pivote++)
            {
                for (int comp = pivote + 1; comp < contador; comp++)
                {
                    if (valores[pivote] > valores[comp])
                    {
                        Intercambiar(valores, pivote, comp);
                    }
                }
            }

            return idx;
        }

        void Intercambiar(double[] valores, int a, int b)
        {
            double aux = valores[a];
            valores[a] = valores[b];
            valores[b] = aux;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int valorBuscar = Convert.ToInt32(tbBuscar.Text);
            int idx = Buscar(valorBuscar);

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
            Ordenar();

            tbResultado.Clear();
            for (int n = 0; n < contador; n++)
            {
                tbResultado.Text += $"{valores[n],5:f2}";
            }
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            int idxMaximo=-1;

            for (int n = 0; n < contador; n++)
            {
                if (n==0 || valores[n] > valores[idxMaximo])
                    idxMaximo = n;
            }
            if (idxMaximo > -1)
            {
                lbMaximo.Text = $"Máximo: {valores[idxMaximo],5:f2} en la posición {idxMaximo}.";
            }
            else
            {
                lbMaximo.Text = "No hay valores registrados.";
            }
        }

        private void btnMinimo_Click(object sender, EventArgs e)
        {
            int idxMinimo = -1;

            for (int n = 0; n < contador; n++)
            {
                if (n == 0 || valores[n] < valores[idxMinimo])
                    idxMinimo = n;
            }
            if (idxMinimo > -1)
            {
                lbMinimo.Text = $"Máximo: {valores[idxMinimo],5:f2} en la posición {idxMinimo}.";
            }
            else
            {
                lbMinimo.Text = "No hay valores registrados.";
            }
        }

        private void btnMayoresAlPromedio_Click(object sender, EventArgs e)
        {
            Ordenar();

            double acumulador = 0;

            for (int n = 0; n < contador; n++)
            {
                acumulador += valores[n];
            }

            double promedio = acumulador / contador;

            tbResultado.Clear();
            for (int n = 0; n < contador; n++)
            {
                if (valores[n]>promedio)
                    tbResultado.Text += $"{valores[n],5:f2}";
            }
        }
    }
}
