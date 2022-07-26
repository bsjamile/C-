using System.Globalization;

namespace lista5_2
{
    class Funcionario
    {
        public string Nome;
        public double sal1;
        public double sal2;

        public double Media(double sal1, double sal2)
        {
            double media = (sal1 + sal2) / 2;
            return media;
        }

        public override string ToString()
        {
            return $"Salário médio = {Media(sal1, sal2).ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
