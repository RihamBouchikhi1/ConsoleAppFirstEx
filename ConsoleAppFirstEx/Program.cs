using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirstEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Nb;
            Console.WriteLine("entrez un nombre entier");
            Nb = int.Parse(Console.ReadLine());
            Estpremier(Nb);


        }  
        
        public static void Estpremier(int N)
        {
            int drap = 1;
            int sqrt_int = (int)Math.Sqrt(N);

            for (int i = 2; i <= sqrt_int; i++)
            {
                if(N % i == 0)
                {
                    drap = 0;
                    break;
                }
                
            }

            if (drap == 0)
                Console.WriteLine("le nombre n'est pas premier");
            else
                Console.WriteLine("le nombre est premier");



        }

    }
}
