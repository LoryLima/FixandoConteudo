using System;
using WowBased.Entities;



Painting pintarConsole = new Painting();

pintarConsole.PaintRed();
Console.WriteLine("* * * * Registro de Personagens para entrar na Guilda World of Warcraft * * * *");
pintarConsole.RemovePaint();
Console.WriteLine();
Console.Write("Quantos jogadores serão registrados na guilda? ");
int n = int.Parse(Console.ReadLine());

List<Jogador> jogadores = new List<Jogador>();


for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Jogador #{i}: ");
    Console.Write("Nome do personagem: ");
    string nick = Console.ReadLine();
    Console.Write("Classe: ");
    string classe = Console.ReadLine();
    Console.Write("Especialidade do personagem: ");
    string spec = Console.ReadLine();
    jogadores.Add(new Jogador(nick, classe, spec));
}

Console.WriteLine();
Console.Write("Deseja tirar a média de Dano Por Segundo de algum personagem (S/N)? ");
char opcao = char.Parse(Console.ReadLine().ToLower());

if (opcao == 's')
{
    Console.Write("Entre com o nome do personagem que você quer a média de dano ->  ");

    string nickname = Console.ReadLine();
    Jogador player = jogadores.Find(p => p.Nick == nickname);
    if (player != null)
    {
        Console.Write("Insira o Dano por Segundo(DPS) máximo durante a luta: ");
        int danoMax = int.Parse(Console.ReadLine());
        Console.Write("Insira o Dano por Segundo(DPS) após o combate ser finalizado: ");
        int danoFinal = int.Parse(Console.ReadLine());

        Console.WriteLine($"Sua média de dano é: {player.MediaDps(danoFinal, danoMax)}");
    }
    else
    {
        Console.WriteLine("Jogador não encontrado!");
    }

}
Console.WriteLine();


Console.WriteLine(" <- Lista de jogadadores registrados -> ");
Console.WriteLine();
foreach (Jogador jogador in jogadores)
{
    Console.WriteLine();
    pintarConsole.PaintGreen();
    Console.WriteLine(("* * * * * * * * * * * * * * * * * * * *"));
    pintarConsole.RemovePaint();
    Console.WriteLine(jogador);

}
pintarConsole.PaintGreen();
Console.WriteLine(("* * * * * * * * * * * * * * * * * * * *"));
Console.ResetColor();
