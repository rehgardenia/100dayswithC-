string? entrada;
bool validarEntrada = false;
string funcao ="";


do{
    Console.WriteLine("Informe um dos três: Administrador,Gerente ou Usuário:");
    entrada = Console.ReadLine();

    if(entrada != null){
        funcao = entrada.Trim().ToLower();
    }
    if(funcao =="administrador"|| funcao =="gerente"|| funcao =="usuario"){
        validarEntrada = true;
    }
    else{
         Console.WriteLine("Desculpe. Valor Inválido. Tente Novamente!");
    }

}while (validarEntrada == false);

Console.WriteLine($"{entrada} - Entrada Válida");