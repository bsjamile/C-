using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc20
{
    internal class Producao
    {
        public string QtdNovelo(int qtdBlusa, double qtdNovelo)
        {
            return (qtdBlusa * qtdNovelo).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
