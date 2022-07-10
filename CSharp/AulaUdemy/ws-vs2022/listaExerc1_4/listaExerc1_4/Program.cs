using System.Globalization;

int number;
double horasT, valorH, salary;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("---------------------------");
    Console.WriteLine();
    Console.WriteLine("Digite o número do funcionário: ");
    number = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
    horasT = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Digite o Valor que recebe por hora: ");
    valorH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    salary = horasT * valorH;

    Console.WriteLine();
    Console.WriteLine($"NUMBER = {number}");
    Console.WriteLine($"SALARY = U$ {salary.ToString("F2",CultureInfo.InvariantCulture)}");
    Console.WriteLine();
}

