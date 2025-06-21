

namespace Ejemplo6.Models
{
    internal class Servicio
    {
        double[] valores = new double[100];
        int contador = 0;

        public int VerContador()
        {
            return contador;
        }

        public double VerValor(int idx)
        {
            if (idx >= 0 && idx < contador)
                return valores[idx];
            return 0;
        }

        public void RegistrarValor(double valor)
        {
            valores[contador] = valor;
            contador++;
        }

        public double CalcularPromedio()
        {
            double acumulador = 0;
            for (int n = 0; n < contador; n++)
            {
                acumulador += valores[n];
            }

            double promedio = acumulador / contador;
            return promedio;
        }

        public int Buscar(int valorBuscar)
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

        public void Ordenar()
        {
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
        }

        void Intercambiar(double[] valores, int a, int b)
        {
            double aux = valores[a];
            valores[a] = valores[b];
            valores[b] = aux;
        }

        public int CalcularMaximo()
        {
            int idxMaximo = -1;

            for (int n = 0; n < contador; n++)
            {
                if (n == 0 || valores[n] > valores[idxMaximo])
                    idxMaximo = n;
            }

            return idxMaximo;
        }
        public int CalcularMinimo()
        {
            int idxMinimo = -1;

            for (int n = 0; n < contador; n++)
            {
                if (n == 0 || valores[n] < valores[idxMinimo])
                    idxMinimo = n;
            }

            return idxMinimo;
        }

        public int[] CalcularMayoresAlPromedio(out int cantidadMayores)
        {
            int[] idxMayores = new int[contador];

            Ordenar();

            double promedio = CalcularPromedio();

            cantidadMayores = 0;
            for (int n = 0; n < contador; n++)
            {
                if (valores[n] > promedio)
                {
                    idxMayores[cantidadMayores] = n;
                    cantidadMayores++;
                }
            }
            return idxMayores;
        }

    }
}
