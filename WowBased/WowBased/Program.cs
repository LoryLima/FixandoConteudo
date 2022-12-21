


using WowBased.Entities;

Console.Write("Quantos jogadores serão registrados no grupo? ");
int n = int.Parse(Console.ReadLine());

List<Jogador> jogadores = new List<Jogador>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Jogador #{i}: ");
    Console.Write("Nome do personagem: ");
    string nick = Console.ReadLine();
    Console.Write("Classe: ");
    string classe = Console.ReadLine();
    Console.Write("Especialidade do jogador: ");
    string spec = Console.ReadLine();

    jogadores.Add(new Jogador(nick, classe, spec));
}


Console.WriteLine("Entre com o nome do personagem que você quer a média de dano: ");
string nickname = Console.ReadLine();
Jogador player = jogadores.Find(x => x.Nick == nickname);

if (player != null)
{

    Console.WriteLine("Insira o Dano por Segundo(DPS) máximo durante a luta: ");
    int danoMax = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o Dano por Segundo(DPS) após o combate ser finalizado: ");
    int danoFinal = int.Parse(Console.ReadLine());

    Console.WriteLine($"Sua média de dano é: {player.MediaDps(danoFinal, danoMax)}");
}
else
{
    Console.WriteLine("Jogador não encontrado!");
}

foreach (Jogador testando in jogadores)
{
    Console.WriteLine(testando);
}


