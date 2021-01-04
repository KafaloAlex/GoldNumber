using System;

namespace Nombre_d_Or
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Ce programme calcule le nombre d'or utilisé par les anciens comme nombre idéal pour la sculpture et 
             * l'architecture. Si l'on considère deux suites numériques(U) et(V) telles que pour n strictement supérieur à 2*/
            //Un = Un-1 + Un-2
            //Vn = Un / Un-1

            /*On montre que la suite Vn tend vers une limite appelé nombre d'or (nbreOr = 1,61803398874989484820458683436564) */

            Console.Title = "Calcul du nombre d'Or";

            Console.Write("Entrez la précision du calcul : ");
            var nbre = Double.Parse(Console.ReadLine());

            int Un2 = 1; //Répresente Un-2
            int n, Un, Un1= 2; //n étant le rang de la suite actuelle 
            double Vn, Vn1 = 2;

            for (n = 2; ; n++)
            {
                Un = Un1 + Un2;
                Vn = (double)Un / (double)Un1;

                if (Math.Abs(Vn - Vn1) <= nbre) //Précison atteinte break;
                {
                    break;
                }
                else
                {
                    Un2 = Un1;
                    Un1 = Un;
                    Vn1 = Vn;
                }
            }

            Console.WriteLine("Nombre d'or : {0}\nRang : {1}", Vn, n);
        }
    }
}
