using System;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1, n2, mn;

            Console.Write("Digite o primeiro número:..");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número:...");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
//Primeira Resolução
            /*if(n1 > n2){
                mn = n1;
            }
            else
            {
                mn = n2;
            }
            */
//Segunda Resolução        
           /* mn = n2;

            if(n1 > n2){
                mn = n1;
            }*/
// terceira resolução

            mn = n1 > n2 ? n1 : n2;

            Console.WriteLine($"O maior número é: {mn}");
        }
    }
}
