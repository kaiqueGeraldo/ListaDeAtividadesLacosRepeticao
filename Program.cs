bool ReiniciarPrograma = true;
while (ReiniciarPrograma)
{
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

    //for (int i = 100; i < 202; i ++)
    //{
    //    if(i % 2 == 0)
    //    {
    //        Console.WriteLine(i);
    //    }
    //}












    Console.WriteLine("\nDeseja reiniciar o programa? (S/N) ");
    string reiniciarPrograma = Console.ReadLine();

    if (reiniciarPrograma.ToUpper() != "S")
    {
        Console.WriteLine("Encerrando programa....");
        break;
    }
    Console.Clear();
}