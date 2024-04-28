int vidaHeroi = 10;
int vidaMostro = 10;
Random rd = new Random();

do
{
    int ataque = rd.Next(1, 11);

    vidaMostro -= ataque;
    Console.WriteLine($"O mostro foi atacado dano de {ataque}, vida restante: {vidaMostro}");
   
    if (vidaMostro <= 0) continue;

    ataque = rd.Next(1, 11);
    vidaHeroi -= ataque;
    Console.WriteLine($"O Heroi foi atacado dano {ataque}, vida restante {vidaHeroi}");

}
while (vidaHeroi > 0 && vidaMostro > 0);

Console.WriteLine(vidaHeroi>vidaMostro? "O Herói Venceu!": "O Mostro Venceu!");