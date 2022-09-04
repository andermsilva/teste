// See https://aka.ms/new-console-template for more information
Console.Clear();
int op = 0;

while(op != 3){
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1 – Funções sem vetor ");
    Console.WriteLine("2 – Funções com vetor");
    Console.WriteLine("3 –SAIR");
    Console.Write("Digite a opção desejada: ");
    op = Int32.Parse(Console.ReadLine());
    
    if(op == 1){
        int op2, n1,n2;
        Console.WriteLine("1 – Inteiros em ordem crescente");
        Console.WriteLine("2 – Inteiros em ordem decrescente");
        Console.WriteLine("3 - Inteiros ímpares (crescente)");
        Console.WriteLine("4 - Somatório dos inteiros");
        
        Console.Write("Digite a opção desejada... ");

        op2 = Int32.Parse(Console.ReadLine());
        Console.Write("Informe o primeiro numero inteiro: ");
        n1 = Int32.Parse(Console.ReadLine());
        Console.Write("Informe o segundo numero inteiro: ");
        n2 = Int32.Parse(Console.ReadLine());

        if(op2 == 1){
            ordemCrescente(n1,n2);
        }
        if(op2 == 2){
            ordemDecrescente(n1,n2);
        }
        if(op2 == 3){
            ordenarImpares(n1,n2);
        }
        if(op2 == 4){
           Console.Write(somaInteros(n1,n2));
         
        }
    }
    if(op == 2){
        int [] vetor = new int[4];

        int pos = 0;
        Console.Write("Digite o um número: ");
        int num = Int32.Parse(Console.ReadLine());

        while(pos <= (4-1)){
            vetor[pos] = num;
            Console.Write("Digite o proximo número: ");
            num = Int32.Parse(Console.ReadLine());
            pos ++;
        }
    
    }
    
    
    Console.ReadKey();
}

  
    
void ordemCrescente(int n1, int n2){
    if(n1<= n2){
        Console.WriteLine(n1);
        ordemCrescente(n1+1,n2);

    }
}
void ordemDecrescente(int n1, int n2){
    if (n2 >= n1){
        Console.WriteLine(n2);
        ordemDecrescente(n1,n2 - 1);
    }
}
void ordenarImpares(int n1, int n2){
    if(n1<= n2){
        if(n1 % 2 != 0)
        Console.WriteLine(n1);
        ordenarImpares(n1 + 1, n2);
    }
}
int somaInteros(int n1, int n2){
    int soma =0;
    int aux =0;
    aux  = n1;

    if(n1 <= n2){
       


       soma = 0 ;
       
       Console.WriteLine(aux +" - s"+soma);
       somaInteros(n1+1, n2);

        //Console.WriteLine(aux+aux+" aux");
    }
    
    return soma ;
}