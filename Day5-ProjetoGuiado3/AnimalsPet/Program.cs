
using System.Collections;
using System.Diagnostics;

static void ListarAnimais(){}
static void AdicionarAnimal(){}
static void ExibirCaes(){}
static void ExibirGatos(){}
static void  CompletarApelidoPersonalidade(){}
static void CompletarDescricaoFisica(){}
static void EditarIdade(){}
static void EditarPersonalidade(){}
// the ourAnimals array will store the following: 


string animalEspecies = "";
string animalID = "";
string animalIdade = "";
string animalFisicaDescricao = "";
string animalPersonalidadeDescricao = "";
string animalApelido = "";

// variables that support data entry
int maxPets = 8;
string? lerEntrada;
string selecaoMenu = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement
// Cria algumas entradas iniciais na matriz ourAnimals
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalEspecies = "cão";
            animalID = "d1";
            animalIdade = "2";
            animalFisicaDescricao = "cão de porte médio, cor creme, fêmea, da raça golden retriever, pesando cerca de 65 libras. Treinada para fazer suas necessidades no local adequado.";
            animalPersonalidadeDescricao = "adora receber carinho na barriga e gosta de perseguir o próprio rabo. Dá muitos beijos.";
            animalApelido = "lola";
            break;
        case 1:
            animalEspecies = "cão";
            animalID = "d2";
            animalIdade = "9";
            animalFisicaDescricao = "cão de grande porte, marrom-avermelhado, macho, da raça golden retriever, pesando cerca de 85 libras. Treinado para fazer suas necessidades no local adequado.";
            animalPersonalidadeDescricao = "adora receber carinho nas orelhas quando te recebe na porta, ou a qualquer momento! Adora se apoiar em você e dar abraços de cão.";
            animalApelido = "loki";
            break;
        case 2:
            animalEspecies = "gato";
            animalID = "c3";
            animalIdade = "1";
            animalFisicaDescricao = "gata de pequeno porte, branca, fêmea, pesando cerca de 8 libras. Treinada para usar a caixa de areia.";
            animalPersonalidadeDescricao = "amigável";
            animalApelido = "Puss";
            break;
        case 3:
            animalEspecies = "gato";
            animalID = "c4";
            animalIdade = "2"; // Idade não especificada
            animalFisicaDescricao = "gato de médio porte, cinza com listras pretas, macho, pesando cerca de 10 libras. Pelagem densa e macia.";
            animalPersonalidadeDescricao = "curioso e brincalhão, gosta de explorar novos lugares e brincar com brinquedos de corda.";
            animalApelido = "Shadow";
            break;
        case 4:
            animalEspecies = "gato";
            animalID = "c5";
            animalIdade = "4"; // Idade não especificada
            animalFisicaDescricao = "gata de porte pequeno, pelagem longa e branca, fêmea, pesando cerca de 7 libras. Olhos azuis.";
            animalPersonalidadeDescricao = "calma e afetuosa, gosta de se aconchegar no colo e receber carinho.";
            animalApelido = "Snowball";
            break;

        default:
            animalEspecies = "";
            animalID = "";
            animalIdade = "";
            animalApelido = "";
            animalFisicaDescricao = "";
            animalPersonalidadeDescricao = "";
            break;
    }


    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Espécie: " + animalEspecies;
    ourAnimals[i, 2] = "Idade: " + animalIdade;
    ourAnimals[i, 3] = "Apelido: " + animalApelido;
    ourAnimals[i, 4] = "Descrição física: " + animalFisicaDescricao;
    ourAnimals[i, 5] = "Personalidade: " + animalPersonalidadeDescricao;

}

// display the top-level menu options

while (selecaoMenu != "sair")
{

    Console.Clear();
    Console.WriteLine("Bem-vindo ao aplicativo PetFriends. Suas opções principais de menu são:");
    Console.WriteLine(" 1. Listar todas as informações dos nossos animais de estimação atuais");
    Console.WriteLine(" 2. Adicionar um novo amigo animal à nossa matriz ourAnimals");
    Console.WriteLine(" 3. Garantir que as idades dos animais e descrições físicas estejam completas");
    Console.WriteLine(" 4. Garantir que os apelidos dos animais e descrições de personalidade estejam completos");
    Console.WriteLine(" 5. Editar a idade de um animal");
    Console.WriteLine(" 6. Editar a descrição da personalidade de um animal");
    Console.WriteLine(" 7. Exibir todos os gatos com uma característica específica");
    Console.WriteLine(" 8. Exibir todos os cães com uma característica específica");
    Console.WriteLine();
    Console.WriteLine("Digite o número da sua seleção (ou digite Sair para sair do programa)");

    lerEntrada = Console.ReadLine();
    if (lerEntrada != null)
    {
        selecaoMenu = lerEntrada.ToLower();
        switch (selecaoMenu)
        {
            case "1":
                ListarAnimais();
                Console.WriteLine("Teste, em andamento");
                Console.WriteLine($"Você selecionou a opção de menu {selecaoMenu}.");
                Console.WriteLine("Pressione a tecla Enter para continuar");
                // pause code execution
                lerEntrada = Console.ReadLine();
                break;
            case "2":
                AdicionarAnimal();
                Console.WriteLine("Teste, em andamento");
                Console.WriteLine($"Você selecionou a opção de menu {selecaoMenu}.");
                Console.WriteLine("Pressione a tecla Enter para continuar");
                // pause code execution
                lerEntrada = Console.ReadLine();
                break;
            case "3":
                CompletarDescricaoFisica();
                Console.WriteLine("Desafio, em andamento");
                Console.WriteLine($"Você selecionou a opção de menu {selecaoMenu}.");
                Console.WriteLine("Pressione a tecla Enter para continuar");
                // pause code execution
                lerEntrada = Console.ReadLine();
                break;
            case "4":
                CompletarApelidoPersonalidade();
                Console.WriteLine("Desafio, em andamento");
                Console.WriteLine($"Você selecionou a opção de menu {selecaoMenu}.");
                Console.WriteLine("Pressione a tecla Enter para continuar");
                // pause code execution
                lerEntrada = Console.ReadLine();
                break;
            case "5":
                EditarIdade();
                Console.WriteLine("Teste, em constução");
                Console.WriteLine($"Você selecionou a opção de menu {selecaoMenu}.");
                Console.WriteLine("Pressione a tecla Enter para continuar");
                // pause code execution
                lerEntrada = Console.ReadLine();
                break;
            case "6":
                EditarPersonalidade();
                Console.WriteLine("Teste, em construção");
                Console.WriteLine($"Você selecionou a opção de menu {selecaoMenu}.");
                Console.WriteLine("Pressione a tecla Enter para continuar");
                // pause code execution
                lerEntrada = Console.ReadLine();
                break;
            case "7":
                ExibirGatos();
                Console.WriteLine("Teste, em construção");
                Console.WriteLine($"Você selecionou a opção de menu {selecaoMenu}.");
                Console.WriteLine("Pressione a tecla Enter para continuar");
                // pause code execution
                lerEntrada = Console.ReadLine();
                break;
            case "8":
                ExibirCaes();
                Console.WriteLine("Teste, em construção");
                Console.WriteLine($"Você selecionou a opção de menu {selecaoMenu}.");
                Console.WriteLine("Pressione a tecla Enter para continuar");
                // pause code execution
                lerEntrada = Console.ReadLine();
                break;
            case "sair":
                Console.WriteLine("Tchauzinho!");
                Console.WriteLine("Pressione a tecla Enter para continuar");
                // pause code execution
                lerEntrada = Console.ReadLine();

                break;
            default:
                Console.WriteLine("Opção Invalida. Tente Novamente!");
                Console.WriteLine("Pressione a tecla Enter para continuar");
                // pause code execution
                lerEntrada = Console.ReadLine();

                break;
        }
    }



}