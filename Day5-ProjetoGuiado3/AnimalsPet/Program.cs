using System;
using System.Collections;
using System.Diagnostics;
public class Program
{
    public static string animalEspecies = "";
    public static string animalID = "";
    public static string animalIdade = "";
    public static string animalFisicaDescricao = "";
    public static string animalPersonalidadeDescricao = "";
    public static string animalApelido = "";

    // variables that support data entry
    public static int maxPets = 8;
    public static string? lerEntrada;
    public static string selecaoMenu = "";
    public static string[,] ourAnimals = new string[maxPets, 6];

    public static void ListarAnimais()
    {
        for (int i = 0; i < maxPets; i++)
        {
            if (ourAnimals[i, 0] != "ID #: ")
            {
                Console.WriteLine();
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine(ourAnimals[i, j]);
                }
            }
        }
    }
    static void AdicionarAnimal()
    {
        // variaveis locais
        string outroPet = "s";
        int petCount = 0;
        string? entrada;
        // contagem dos animais
        for (int i = 0; i < maxPets; i++)
        {
            if (ourAnimals[i, 0] != "ID #: ")
            {
                petCount += 1;
            }
        }
        if (petCount < maxPets)
        {
            Console.WriteLine($"Atualmente temos {petCount} animais de estimação que precisam de lares. Podemos cuidar de mais {maxPets - petCount}.");
        }
        // adicionar outro animal
        while (outroPet == "s" && petCount < maxPets)
        {
            petCount += 1;
            if (petCount < maxPets)
            {
                Console.WriteLine("Você deseja adicionar outro animal(s/n)?");
                do
                {
                    entrada = Console.ReadLine();
                    if (entrada != null)
                    {
                        outroPet = entrada.ToLower();
                        if (outroPet == "s")
                        {
                            bool validarEntrada = false;
                            // ler especie
                            do
                            {
                                Console.WriteLine("\n\rDigite 'cão' ou 'gato' para começar uma nova entrada");
                                entrada = Console.ReadLine();
                                if (entrada != null)
                                {
                                    animalEspecies = entrada.ToLower();
                                    if (animalEspecies != "cao" && animalEspecies != "gato")
                                        validarEntrada = false;
                                    else
                                        validarEntrada = true;
                                }

                            } while (validarEntrada == false);
                            // criar id
                            animalID = animalEspecies.Substring(0, 1) + (petCount + 1.ToString());
                            // ler idade
                            do
                            {
                                int petIdade;
                                Console.WriteLine("Digite a idade do animal de estimação? se for desconhecida");
                                entrada = Console.ReadLine();
                                if (entrada != null)
                                {
                                    animalIdade = entrada;
                                    if (animalIdade != "?")
                                    {
                                        validarEntrada = int.TryParse(animalIdade, out petIdade);
                                    }
                                    else
                                    {
                                        validarEntrada = true;
                                    }
                                }
                            } while (validarEntrada == false);
                            // ler  descricao física
                            do
                            {
                                Console.WriteLine("Digite uma descrição física do animal de estimação (tamanho, cor, gênero, peso, treinado para fazer suas necessidades no lugar certo)");
                                entrada = Console.ReadLine();
                                if (entrada != null)
                                {
                                    animalFisicaDescricao = entrada.ToLower();
                                    if (animalFisicaDescricao == "")
                                    {
                                        animalFisicaDescricao = "tbd";
                                    }
                                }
                            } while (animalFisicaDescricao == "");
                            // ler personalidade
                            do
                            {
                                Console.WriteLine("Digite uma descrição da personalidade do animal de estimação (gostos ou desgostos, truques, nível de energia)"); entrada = Console.ReadLine();
                                if (entrada != null)
                                {
                                    animalPersonalidadeDescricao = entrada.ToLower();
                                    if (animalPersonalidadeDescricao == "")
                                    {
                                        animalPersonalidadeDescricao = "tbd";
                                    }
                                }
                            } while (animalPersonalidadeDescricao == "");
                            // ler apelido
                            do
                            {
                                Console.WriteLine("Digite o apelido do seu animal");
                                entrada = Console.ReadLine();
                                if (entrada != null)
                                {

                                    animalApelido = entrada.ToLower();
                                    if (
                                        animalApelido == "")
                                    {

                                        animalApelido = "tbd";
                                    }
                                }
                            } while (
                                animalApelido == "");

                            ourAnimals[petCount, 0] = "ID #: " + animalID;
                            ourAnimals[petCount, 1] = "Espécie: " + animalEspecies;
                            ourAnimals[petCount, 2] = "Idade: " + animalIdade;
                            ourAnimals[petCount, 3] = "Apelido: " + animalApelido;
                            ourAnimals[petCount, 4] = "Descrição Física: " + animalFisicaDescricao;
                            ourAnimals[petCount, 5] = "Personalidade: " + animalPersonalidadeDescricao;
                        }
                    }

                } while (outroPet != "s" && outroPet != "n");

            }
        }
        if (petCount >= maxPets)
        {
            Console.WriteLine("Atingimos nosso limite no número de animais de estimação que podemos cuidar.");
        }
    }
    static void CompletarDescricaoIdade()
    {
        for (int i = 0; i < maxPets; i++)
        {
            string? entrada;
            if (ourAnimals[i, 2] == "Idade: ?")
            {
                Console.WriteLine($"Animal com Informações Incompletas - {ourAnimals[i, 0]}");
                int petIdade;
                bool validarEntrada = false;
                do
                {
                    Console.WriteLine("Digite a idade do animal de estimação? ");
                    entrada = Console.ReadLine();
                    if (entrada != null)
                    {
                        animalIdade = entrada;
                        if (animalIdade != "?")
                        {
                            validarEntrada = int.TryParse(animalIdade, out petIdade);
                            ourAnimals[i, 2] = "Idade: " + animalIdade;
                        }
                        else
                        {
                            validarEntrada = false;
                        }
                    }
                } while (validarEntrada == false || animalIdade == "");
            }
            // Completar Descrição Física
            if (ourAnimals[i, 4] == "Descrição Física: ?")
            {
                Console.WriteLine($"Animal com Informações Incompletas - {ourAnimals[i, 0]}");
                do
                {
                    Console.WriteLine("Digite uma descrição física do animal de estimação (tamanho, cor, gênero, peso, treinado para fazer suas necessidades no lugar certo)");
                    entrada = Console.ReadLine();
                    if (entrada != null)
                    {
                        animalFisicaDescricao = entrada.ToLower();
                        if (animalFisicaDescricao == "?")
                        {
                            animalFisicaDescricao = "";
                        }
                        else
                        {
                            ourAnimals[i, 4] = "Descrição Física: " + animalFisicaDescricao;
                        }
                    }
                } while (animalFisicaDescricao == "");

            }
        }
    }
    static void CompletarApelidoPersonalidade()
    {
        for (int i = 0; i < maxPets; i++)
        {
            string? entrada;
            if (ourAnimals[i, 3] == "Apelido: ?")
            {
                Console.WriteLine($"Animal com Informações Incompletas - {ourAnimals[i, 0]}");

                do
                {
                    Console.WriteLine("Digite o apelido do animal de estimação? ");
                    entrada = Console.ReadLine();
                    if (entrada != null)
                    {
                        animalApelido = entrada.ToLower();
                        if (animalIdade != "?")
                        {
                            ourAnimals[i, 3] = "Apelido: " + animalApelido;
                        }
                        else
                        {
                            animalApelido = "";
                        }
                    }
                } while (animalApelido == "");
            }
            // Completar Descrição Física
            if (ourAnimals[i, 5] == "Personalidade: ?")
            {
                Console.WriteLine($"Animal com Informações Incompletas - {ourAnimals[i, 0]}");
                do
                {
                    Console.WriteLine("Digite uma descrição da personalidade do animal de estimação (gostos ou desgostos, truques, nível de energia)"); 
                    entrada = Console.ReadLine();
                    if (entrada != null)
                    {
                        animalPersonalidadeDescricao = entrada.ToLower();
                        if (animalPersonalidadeDescricao != "?")
                        {
                           ourAnimals[i, 5] = "Personalidade: " + animalPersonalidadeDescricao;
                        }
                        else{
                            animalPersonalidadeDescricao= "";
                        }

                    }
                } while (animalPersonalidadeDescricao == "");

            }
        }
    }

    static void ExibirCaes() { }
    static void ExibirGatos() { }

    public static void Main(string[] args)
    {
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
            ourAnimals[i, 4] = "Descrição Física: " + animalFisicaDescricao;
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
            Console.WriteLine(" 4. Garantir que os animalApelidos dos animais e descrições de personalidade estejam completos");
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
                        Console.WriteLine("Pressione a tecla Enter para continuar");
                        lerEntrada = Console.ReadLine();
                        break;
                    case "2":
                        AdicionarAnimal();
                        Console.WriteLine("Pressione a tecla Enter para continuar");
                        lerEntrada = Console.ReadLine();
                        break;
                    case "3":
                        CompletarDescricaoIdade();
                        Console.WriteLine("Pressione a tecla Enter para continuar");
                        // pause code execution
                        lerEntrada = Console.ReadLine();
                        break;
                    case "4":
                        CompletarApelidoPersonalidade();
                        Console.WriteLine("Pressione a tecla Enter para continuar");
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
    }
}