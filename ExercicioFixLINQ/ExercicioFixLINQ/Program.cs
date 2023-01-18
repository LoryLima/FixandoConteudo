using ExercicioFixLINQ.Entities;
using System.Globalization;

List<Funcionario> listaFuncionarios = new List<Funcionario>();

Console.Write("Entre com o caminho do arquivo: ");
string caminho = Console.ReadLine();
Console.Write("Entre com o salário do funcionário: ");
double salarioFuncionario = double.Parse(Console.ReadLine());


using (StreamReader leitor = File.OpenText(caminho))
{
    while (!leitor.EndOfStream)
    {
        string[] camposFuncionario = leitor.ReadLine().Split(',');
        string nome = camposFuncionario[0];
        string email = camposFuncionario[1];
        double salario = double.Parse(camposFuncionario[2]);

        listaFuncionarios.Add(new Funcionario(nome, email, salario));
    }
}

Console.WriteLine($"Email dos funcionários que recebem acima de {salarioFuncionario:C}: ");
var emailSalario = listaFuncionarios.Where(x => x.Salario > salarioFuncionario).Select(x => x.Email).ToList();
foreach (var info in emailSalario)
{
    Console.WriteLine(info);
}
Console.Write("Selecione uma letra para receber a soma dos salários dos funcionários cujo o nome começam com ela: ");
char letra = char.Parse(Console.ReadLine().ToUpper());

Console.WriteLine($"Soma dos salários de todas as pessoas que começam com a letra {letra}:");
var letraSalario = listaFuncionarios.Where(x => x.Nome.StartsWith(letra)).Select(x => x.Salario).Sum();
Console.WriteLine($"{letraSalario:C}");


