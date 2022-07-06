using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc24
{
    internal class Litros
    {
        public void QtdLitros(double qtdRefresco)
        {
            double agua = 0.8 * qtdRefresco;
            double maracuja = 0.2 * qtdRefresco;

            Console.WriteLine($"Para {qtdRefresco.ToString("F2", CultureInfo.InvariantCulture)} litros de Refresco é necessário:\nÁgua: {agua.ToString("F2", CultureInfo.InvariantCulture)} litros\nSuco de Maracujá: {maracuja.ToString("F2", CultureInfo.InvariantCulture)} litros");

        }
    }
}
