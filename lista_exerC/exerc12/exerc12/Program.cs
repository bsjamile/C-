namespace exerc12
{
    class program
    {
        static void Main(string[] args)
        {
            Salario s = new Salario();

            Console.Write("Salário: ");
            double.TryParse(Console.ReadLine(), out double sal);

            s.SalarioAumento(sal);
        }
    }
}