
// Desafio da lógica de decisão

string permissão = "Admin|Manager";
int nivel = 55;


if (permissão.Contains("Admin"))
{
    if (nivel > 55)
        Console.WriteLine("Bem Vindo, Super Usuário Administrador!");
    else
        Console.WriteLine("Bem Vindo, Usuário Administrador!");
}
else if (permissão.Contains("Manager"))
{
    if (nivel >= 20)
    {
        Console.WriteLine("Contate um administrador para acessar seu usuário.");
    }
    else
    {
        Console.WriteLine("Você não tem privilégios suficiente para o acesso.");
    }
}
else
{
    Console.WriteLine("Você não tem privilégios suficiente para o acesso.");
}
