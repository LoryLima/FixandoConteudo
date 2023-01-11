using ExercicioPropostoConjuntos;


HashSet<Student> alunos = new HashSet<Student>();

Console.WriteLine("Quantos alunos tem no curso A: ");
int alunosCursoA = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o código dos alunos: ");
for (int i = 1; i <= alunosCursoA; i++)
{
    int idA = int.Parse(Console.ReadLine());
    alunos.Add(new Student(idA)); 
}

Console.WriteLine("Quantos alunos tem no curso A: ");
int alunosCursoB = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o código dos alunos: ");
for (int i = 1; i <= alunosCursoB; i++)
{
    int idB = int.Parse(Console.ReadLine());
    alunos.Add(new Student(idB));
}

Console.WriteLine("Quantos alunos tem no curso C: ");
int alunosCursoC = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o código dos alunos: ");
for (int i = 1; i <= alunosCursoC; i++)
{
    int idC = int.Parse(Console.ReadLine());
    alunos.Add(new Student(idC));
}

Console.WriteLine("Total de estudantes " + alunos.Count);

