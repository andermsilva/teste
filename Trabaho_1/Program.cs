// See https://aka.ms/new-console-template for more information
Console.WriteLine("Trabalho Estrutura de dados");
//------------------Exercício 2----------------------//

Console.WriteLine("############# Escolha um Programa para executar##########");
Console.WriteLine(" 2. ################### Exercício 2 ######################");
Console.WriteLine(" 3. ################### Exercício 3 ######################");
Console.WriteLine(" 4. ################### Exercício 4 ######################");
Console.WriteLine(" 5. ################### Exercício 5 ######################");
Console.WriteLine(" 6. ################### Exercício 6 ######################");
int op = int.Parse(Console.ReadLine());

if (op == 2)
{
    Console.WriteLine("//------------------Exercício 2----------------------//");
    Console.Write("informe o número base da potencia: ");
    int b = int.Parse(Console.ReadLine());
    Console.Write("informe o número expoente da potencia: ");
    int ex = int.Parse(Console.ReadLine());
    Console.WriteLine("Resultdo de " + potencia(b, ex));
    int potencia(int x, int y)
    {
        if (y == 0)
        {
            return 1;
        }
        else
        {
            return x * potencia(x, y - 1);
        }
    }
}
else if (op == 3)
{
    Console.WriteLine("Função Cubos");
    Console.Write("Digite um número: ");
    int n = int.Parse(Console.ReadLine());

    cubos(n);
    void cubos(int n)
    {

        if (n > 0)
        {

            cubos(n - 1);
            Console.WriteLine(n * n * n);

        }
    }


}