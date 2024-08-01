using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meuapp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    //menor, maior ou igual
            int n1, n2, n3 ;
            Console.WriteLine("Digite o valor de n1 = ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de n2 = ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de n3 = ");
            n3 = int.Parse(Console.ReadLine());
                    //&& operador 

            if (n1 > n2 && n1 > n3)
                Console.WriteLine("O valor de n1 é maior que n2 e n3");
            else if (n2 > n1 && n2 > n3)
                Console.WriteLine("O valor de n2 é maior que n1 e n3");
            else
                Console.WriteLine("O valor de n3 é maior que n2 e n1");
            Console.ReadKey();
        }
    }
}
