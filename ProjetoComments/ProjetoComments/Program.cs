using ProjetoComments.Entities;


Comment comentario = new Comment("Tenha uma ótima viagem!");
Comment comentario2 = new Comment("Legal!!");

Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Viajando para a Irlanda", "Estou indo visitar esse lugar incrível", 12);

p1.AddComment(comentario);

Console.WriteLine(p1);



