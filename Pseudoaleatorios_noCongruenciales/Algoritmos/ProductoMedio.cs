using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pseudoaleatorios_noCongruenciales.Algoritmos
{
    internal class ProductoMedio
    {
        public ProductoMedio() { }
        public List<int> GetValues(int seed1, int seed2, int cantidad)
        {
            List<int> values = new List<int>();
            int tamano = seed1.ToString().Length;
            int x0 = seed1;
            int x1 = seed2;
            for (int i = 0; i < cantidad; i++)
            {
                long producto = (long)x0 * x1;
                string productoStr = producto.ToString().PadLeft(tamano * 2, '0');
                int inicio = (productoStr.Length - tamano) / 2;
                string central = productoStr.Substring(inicio, tamano);
                int xi = int.Parse(central);
                values.Add(xi);
                x0 = x1;
                x1 = xi;
            }
            return values;
        }

        public void EscribirEnCSV(List<int> values, string rutaArchivo)
        {
            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("Numero,Valor");
            int i = 1;

            foreach (var value in values)
            {
                csvContent.AppendLine($"{i},{value}");
                i++;
            }

            File.WriteAllText(rutaArchivo, csvContent.ToString());
        }
    }
}
