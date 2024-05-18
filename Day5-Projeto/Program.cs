public class Animal
{
    public string animalID;
    public string animalEspecie;
    public string animalIdade;
    public string animalCaracteristica;
    public string animalPersonalidade;
    public string animalApelido;

    void listarAnimal()
    {
        Console.WriteLine($"ID(#): {this.animalID}");
        Console.WriteLine($"Espécie: {this.animalEspecie}");
        Console.WriteLine($"Idade: {this.animalIdade}");
        Console.WriteLine($"Apelido: {this.animalApelido}");
        Console.WriteLine($"Características: {this.animalCaracteristicas}");
        Console.WriteLine($"Personalidade:{this.animalPersonalidade}");

    }

}


int maxAnimal = 8;
string? lerEntrada;
string menuSelecao = "";
Animal gato1 = new Animal();


string[,] animais = new string[maxAnimal, 6];
int i = 0;
switch (i)
{
    case 0:
        animalEspecie = "dog";
        animalID = "d1";
        animalIdade = "2";
        animalCaracteristica = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
        animalPersonalidade = "raivoso";
        animalApelido = "lola";
        break;
    case 1:
        animalEspecie = "dog";
        animalID = "d2";
        animalIdade = "9";
        animalCaracteristica = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
        animalPersonalidade = "amável";
        animalApelido = "loki";
        break;
    case 2:
        animalEspecie = "cat";
        animalID = "c3";
        animalIdade = "1";
        animalCaracteristica = "small white female weighing about 8 pounds. litter box trained.";
        animalPersonalidade = "amigavel";
        animalApelido = "Buss";
        break;
    case 3:
        animalEspecie = "cat";
        animalID = "c4";
        animalIdade = "0.4";
        animalCaracteristica = "pequeno macho filhote fofo";
        animalPersonalidade = "lindinho";
        animalApelido = "leo";
        break;
    default:
        animalEspecie = "";
        animalID = "";
        animalIdade = "";
        animalCaracteristica = "";
        animalPersonalidade = "";
        animalApelido = "";
        break;

}

do
{
    Console.WriteLine("Bem Vindo ao PetFrinds App . Seu menu de opções são:");
    Console.WriteLine("1. Listar todos animais");
    Console.WriteLine("2. Adicionar um novo animal para nosso array");
    Console.WriteLine("3. Certifique-se de que as idades e descrições físicas dos animais estejam completas");
    Console.WriteLine("4.Certifique-se de que os apelidos dos animais e as descrições de personalidade estejam completos");
    Console.WriteLine("5. Edite a idade de um animal");
    Console.WriteLine("6. Edite a descrição da personalidade de um animal");
    Console.WriteLine("7. Exiba todos os gatos com uma característica específica");
    Console.WriteLine("8. Exiba todos os cães com uma característica específica");

    Console.WriteLine("Digite o número da sua seleção (ou digite Exit para sair do programa)");

    menuSelecao = Console.ReadLine();

    switch (menuSelecao)
    {
        case "1":// List all of our current pet information
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            lerEntrada = Console.ReadLine();
            break;

        case "2":
            // Add a new animal friend to the ourAnimals array
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            lerEntrada = Console.ReadLine();
            break;

        case "3":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            lerEntrada = Console.ReadLine();
            break;

        case "4":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            lerEntrada = Console.ReadLine();
            break;

        case "5":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            lerEntrada = Console.ReadLine();
            break;

        case "6":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            lerEntrada = Console.ReadLine();
            break;

        case "7":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            lerEntrada = Console.ReadLine();
            break;

        case "8":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            lerEntrada = Console.ReadLine();
            break;
        default:
            break;

    }

} while (menuSelecao != "exit");