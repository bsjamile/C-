using System.Collections.Generic;
using System.Globalization;

Console.Write("How many employees will be resgistered? ");
int.TryParse(Console.ReadLine(), out int quant);

List<Employee> list = new List<Employee>();

int id, i;
string name;
double salary;

for (i = 1; i <= quant; i++)
{
    Console.WriteLine($"Employee #{i}");
    Console.Write("Id :");
    int.TryParse(Console.ReadLine(), out id);
    Console.Write("Name :");
    name = Console.ReadLine();
    Console.Write("Salary :");
    salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    list.Add(id);
    list1.Add(name);
    list2.Add(salary);

    list.Add(new Employee(id, name, salary));

    Console.WriteLine("");
}

Console.Write("Enter the employee id that will have salary increase : ");
int.TryParse(Console.ReadLine(), out id);

int a = list.Find(x => x.Equals(id));


Console.WriteLine("Updated list of employees:");
foreach(string x in list1)
{
    Console.WriteLine(e);
}

