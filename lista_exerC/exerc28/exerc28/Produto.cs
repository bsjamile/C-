using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc28
{
    internal class Produto
    {
        public string PrecoProd(double preco)
        {
            return (preco * 0.9).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
