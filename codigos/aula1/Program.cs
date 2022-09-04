// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using test;
public class Person
{
    
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    // Other properties, methods, events...
}


class Program
{
    static void Main()
    {
        Console.Clear();
        Tipo[] tipos = new Tipo[2];

        string nm;
        int cod;

        for (int i = 1; i <= 2; i++)
        {
            Console.WriteLine("Informe o ID: ");
            cod = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome: ");
            nm = Console.ReadLine();
            tipos[i - 1] = new Tipo(nm, cod);
        }

        /* tipos[0] = new Tipo("Carlos",1);
        tipos[1] = new Tipo("João",2); */



        foreach (Tipo tp in tipos)
        {
            Console.WriteLine(" Nome = {0} Id = {1}", tp.Nome, tp.Id);

            if (tp.Id > 2) {

                tp.Nome = "Aprovado";
             }
            Console.WriteLine("Nome = {0} Id = {1}", tp.Nome, tp.Id);
        }

        /* Tipo t1 = new Tipo("Anderson",1);
        Tipo t2 = new Tipo("jessica",2); */


        /*  Console.WriteLine("Tipo1 Nome = {0} Id = {1}", t1.Nome, t1.Id);
         Console.WriteLine("Tipo2 Nome = {0} Id = {1}", t2.Nome, t2.Id);
                */

    }
}

