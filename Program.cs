using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

int resultado = 0;

// 1. Faça um programa em C# que mostre na tela a tabuada do 5.

//Console.WriteLine("Digite um número para saber a sua tabuada.");
//double num = LerNumero();

//static double LerNumero()
//{
//    double numero;
//    while (!double.TryParse(Console.ReadLine(), out numero) || numero < 0 || numero > 1000)
//    {
//        Console.WriteLine("Cacacter inválido. Digite um valor entre 0 e 999.");
//    }
//    return numero;
//}

//for (int i = 0; i < 11; i++)
//{
//    resultado = (int)(num * i);
//    Console.WriteLine("{0} {1} {2} {3} {4}", num, "x", i, "=", resultado);
//}



// 2. Faça um programa em C# que solicite ao usuário um número inteiro e mostre na tela os
// próximos 10 números inteiros a partir do número digitado.

//Console.WriteLine("Digite um número inteiro para saber os seus 10 sequênciais.");
//int num = LerNumero();

//static int LerNumero()
//{
//    int numero;
//    while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0 || numero > 1000)
//    {
//        Console.WriteLine("Cacacter inválido. Digite um valor entre 0 e 999.");
//    }
//    return numero;
//}

//for (int i = 1; i < 11; i++)
//{
//    resultado = num + i;
//    Console.WriteLine(resultado);
//}



// 3. Elabore um programa em C# que mostre na tela somente os números pares entre 100 e 200.Incluindo - os.

//for (int i = 100; i <= 200; i ++)
//{
//    if(i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}



// 4. Elabore um programa em C# que seja capaz de contar a quantidade de números ímpares
// existentes entre dois números fornecidos pelo usuário.

//Console.WriteLine("Contagem de números ímpares.\n\nDigite um número: ");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite outro número: ");
//int num2 = int.Parse(Console.ReadLine());

//int count = 0;

//for (int i = (int)num1; i <= num2; i++)
//{
//    if (i % 2 != 0)
//    {
//        count++;
//    }
//}

//Console.WriteLine($"Entre {num1} e {num2} existem {count} número(s) ímpar(es)");



// 5. Faça um programa em C# que solicitei ao usuário dois números inteiros e mostre na tela a
// soma dos elementos existentes entre os dois números informados.

//Console.WriteLine("Soma entre dois números.\n\nDigite um número: ");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite outro número: ");
//int num2 = int.Parse(Console.ReadLine());

//int count = 0;

//for (int i = (int)num1 + 1; i < num2; i++)
//{
//    count += i;
//}

//Console.WriteLine($"A soma dos valores entre {num1} e {num2} é de {count}");



// 6. Faça um programa em C# que leia 50 idades e mostre na tela a média simples das idades digitadas.
// Observações: 
// - Não aceitar idade < 0
// - Necessariamente precisa ter 50 idades válidas

//Console.WriteLine("Média de idades\n\nQual a quantidade de idades que quer inserir para saber sua média?: ");
//int qntdIdade = LerQntdIdade();

//int somaIdades = 0;

//for (int i = 1; i <= qntdIdade; i++)
//{
//    Console.WriteLine($"Digite a idade {i}:");
//    int idade = LerIdade();

//    somaIdades += idade;
//}

//double mediaIdades = (double)somaIdades / qntdIdade;

//Console.WriteLine($"A média das idades é de: {mediaIdades}");
//static int LerIdade()
//{
//    int idade;
//    while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0 || idade > 120)
//    {
//        Console.WriteLine("Valor inválido. Tente Novamente. ");
//    }
//    return idade;
//}
//static int LerQntdIdade()
//{
//    int qntdIdade;
//    while (!int.TryParse(Console.ReadLine(), out qntdIdade) || qntdIdade < 0 || qntdIdade > 120)
//    {
//        Console.WriteLine("Valor inválido. Tente Novamente. ");
//    }
//    return qntdIdade;
//}



// 7. Faça um programa em C# que gere números inteiros aleatórios entre 100 e 110.
// Calcular a soma dos números gerados até que o número n1 (valor informado pelo usuário) seja gerado.
// Como gerar números aleatórios:
// Random randNum = new Random();
// int numeroAleatorio = randNum.Next(100, 110);

//Random randNum = new Random();

//int soma = 0;
//int num1;

//Console.WriteLine("Digite o número desejado:");
//num1 = int.Parse(Console.ReadLine());

//int numeroAleatorio;
//do
//{
//    numeroAleatorio = randNum.Next(100, 110);
//    Console.WriteLine($"Número gerado: {numeroAleatorio}");
//    soma += numeroAleatorio;
//} while (numeroAleatorio != num1);

//Console.WriteLine($"Soma dos números gerados até o número {num1}: {soma}");



// 8. Foi realizada uma pesquisa em 15 (quinze) cidades brasileiras para coletar dados sobre acidentes de transito.

// Foram obtidos os seguintes dados:
// a) Nome da cidade
// b) Número de veículos de passeio (em 2019)
// c) Número de acidentes de transito com vítimas (em 2019).

// Deseja-se saber: 
// A). Qual a cidade que possui o maior número de acidentes de transito 
// B). Qual a cidade que possui o menor número de acidentes de transito 
// C). Qual a média de veículos nas quinzes cidades juntas 
// D). Qual a média de acidentes de transito nas cidades com menos de 2.000 veículos de passeio.



// 9. . Faça um programa em C# que mostre o menu de opções a seguir:

// Digite a opção desejada:
// 1.Somar dois números
// 2. Raiz quadrada de um número
// 3. Sair

// Importante:
// a). Caso o usuário escolha a opção 1, o algoritmo deve solicitar ao usuário dois números 
// inteiros. Depois somar os números recebidos e mostrar na tela o resultado. Voltar para o 
// menu de opções.
// b). Caso o usuário escolha a opção 2, o algoritmo deve solicitar ao usuário um número inteiro e 
// mostrar na tela a raiz quadrada desse número. Voltar para o menu de opções.
// c). Caso o usuário escolha a opção 3, deve aparecer na tela a mensagem: “Saindo…”. Somente 
// na opção 3 o programa deve ser encerrado.
// d). Caso o usuário digite um número diferente do permitido (1,2,3) deve aparecer na tela a 
// mensagem: “Opção inválida. Digite novamente” e voltar para o menu permitindo que o 
// usuário digite novamente a opção desejada.

do
{
    Console.WriteLine("Menu de opções. Escolha a desejada.\n\n1. Somar dois números.\n2. Raiz quadrada de um número.\n3. Sair.\n");
    int opcao = LerOpcao();

    if (opcao == 1)
    {
        Console.WriteLine("\nOpção 1 selecionada. Insira dois valores para ver sua soma.\n\nDigite um número: ");
        double num1 = LerNum();

        Console.WriteLine("Digite outro número: ");
        double num2 = LerNum();

        double soma = num1 + num2;

        Console.WriteLine($"{num1} + {num2} = {soma}");

        static double LerNum()
        {
            double num;
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("\nOpção inválida. Digite novamente. ");
            }
            return num;
        }
    }
    else if (opcao == 2)
    {
        Console.WriteLine("\nOpção 2 selecionada. Insira um valor para saber sua raiz quadrada.\n\nDigite um número: ");
        double num1 = LerNum();

        double raizQuadrada = Math.Sqrt(num1);

        Console.WriteLine($"A raiz quadrada de {num1} é: {raizQuadrada}");

        static double LerNum()
        {
            double num;
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("\nOpção inválida. Digite novamente. ");
            }
            return num;
        }
    }
    else
    {
        Console.WriteLine("Saindo...");
        break;
    }

    static int LerOpcao()
    {
        int num;
        while (!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > 3)
        {
            Console.WriteLine("\nOpção inválida. Digite novamente");
        }
        return num;
    }

    Console.WriteLine("\nDeseja limpar o console para reiniciar?: (S/N)");
    string limparConsole = Console.ReadLine();

    if (limparConsole.ToUpper() != "S")
    {
    }
    else
    {
        Console.Clear();
    }
} while (true);