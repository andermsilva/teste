
string op = "0";
while (op != "3")
{
    Console.Clear();
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1 - Funções sem  vetor");
    Console.WriteLine("2 - Função com vetor");
    Console.WriteLine("3 - Sair");
    Console.Write("Digite a opção desejada: ");
    op = Console.ReadLine();
    if (op == "1")
    {
        int nI, nF;
        Console.Write("Numero Inicial: ");
        nI = int.Parse(Console.ReadLine());
        Console.Write("Numero Final: ");
        nF = int.Parse(Console.ReadLine());

        Console.WriteLine("MENU 2");
        Console.WriteLine("1 - Crescente");
        Console.WriteLine("2 - Decrescente");
        Console.WriteLine("3 - Impares");
        Console.WriteLine("4 - Somatório");
        string op2 = Console.ReadLine();
        //if (op2 == "1")
          //  crescente(nI,nF);
    }
    Console.ReadKey();
}
