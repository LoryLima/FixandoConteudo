

using Contratos.Entities;
using Contratos.Entities.Enums;

Console.WriteLine("Entre com o nome do departamento: ");
string depName = Console.ReadLine();
Console.WriteLine("- - Entre com os dados do trabalhador - -");
Console.Write("Nome: ");
string workerName = Console.ReadLine();
Console.Write("Level (Junior/Médio/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Salário base: ");
double baseSalary = double.Parse(Console.ReadLine());
;

Department dept = new Department(depName);
Worker worker = new Worker(workerName, level, baseSalary, dept);

Console.Write("Quantos contratos o trabalhador tem? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Entre com o #{i} contrato:");
    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Valor por hora R$: ");
    double valuerPerHour = double.Parse(Console.ReadLine());
    Console.Write("Quantidade de horas: ");
    int hours = int.Parse(Console.ReadLine());
    HourContract contract = new HourContract(date, valuerPerHour, hours);
    worker.AddContract(contract);
}

Console.WriteLine();

Console.Write("Entre com o mês e o ano para calcular o ganho (MM/YYYY): ");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.Substring(0, 2));
int year = int.Parse(monthAndYear.Substring(3));
Console.WriteLine($"Nome {worker.Name}");
Console.WriteLine($"Departamento: {worker.Department.Name} ");
Console.WriteLine($"Ganhos no período {monthAndYear}: {worker.Income(year, month)}");




