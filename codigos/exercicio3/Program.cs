
Console.WriteLine("Função Cubos");
Console.Write("Digite um número: ");
int n = int.Parse(Console.ReadLine());

cubos(n);
void cubos(int n){

    if(n > 0){

       cubos(n-1);
       Console.WriteLine( n * n * n) ;
      
    }
}

