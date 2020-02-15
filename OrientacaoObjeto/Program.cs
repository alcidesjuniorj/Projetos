using System;

namespace OrientacaoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("TV", 90.00, 5);

            p1.Nome = "TV LG 42polegadas";

            Console.WriteLine(p1);
        }
    }
}
