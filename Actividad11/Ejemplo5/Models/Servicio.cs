

namespace Ejemplo5.Models
{
    internal class Servicio
    {
        public double[] Valores = new double[100];
        public int Contador = 0;

        public void RegistrarValor(double valor)
        {
            Valores[Contador] += valor;
           Contador++;

        }

        public double CalcularPromedio()
        {
            double acumulador = 0;
            for (int n = 0; n <Contador; n++)
            {
                acumulador += Valores[n];
            }

            double promedio = acumulador / Contador;
            return promedio;
        }

        public int Buscar(int valorBuscar)
        {
            int idx = -1;
            int n = 0;
            while (n < Contador && idx == -1)
            {
                if (Valores[n] == valorBuscar)
                {
                    idx = n;
                }
                n++;
            }
            return idx;
        }

        public int Ordenar()
        {
            int idx = -1;
            for (int pivote = 0; pivote < Contador - 1; pivote++)
            {
                for (int comp = pivote + 1; comp < Contador; comp++)
                {
                    if (Valores[pivote] > Valores[comp])
                    {
                        Intercambiar(Valores, pivote, comp);
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
    }
}
