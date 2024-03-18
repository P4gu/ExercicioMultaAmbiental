using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMultaAmbiental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Coinstrua um algoritmo que informe se ha multa ambiental.
                (acima de 50kg de peixe 100fixo acima de 50, 10 reais para cada kg a mais)
            */
            float peixe;
            float multa;

            //multa2 peixe - 50 * 10 + 100

            Console.Write("Informe a quantidade de peixes pescados em kg:");
            peixe = float.Parse(Console.ReadLine());

            multa = ((peixe - 50) * 10) + 100;
            if (peixe <= 50)
            {
                Console.WriteLine("Você não possui multa!");
            }
            else
            {
                if (peixe > 50)
                {
                    Console.WriteLine($"Você deve pagar: R${multa}!");

                }
            }
            Console.ReadKey();
        }
    }
}
