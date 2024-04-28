
string? entrada;
bool validarEntrada = false;
bool validarNumero = false;
int valor = 0;
Console.WriteLine("Informe um valor inteiro entre 5 e 10: ");
while(validarEntrada == false){
    entrada = Console.ReadLine();
    if(entrada != null){
        validarNumero = int.TryParse(entrada, out valor);
        if(validarNumero){
            if((valor >= 5) && (valor <= 10)){
                Console.WriteLine($"{valor} - Valor de entrada válido.");
                validarEntrada = true;
            }
            else{
                Console.WriteLine("Informe um valor dentro do intervalo solicitado.");
            }
        }
        else{
            Console.WriteLine("Informe um valor válido!");
        }
    }
}
