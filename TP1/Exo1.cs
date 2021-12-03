using System;

namespace TP1
{
    public class Exo1
    {
        protected static int AskParameter()
        {
            bool controle = false;
            int resultat = 0;

            
            while (controle != true)
            {

                Console.WriteLine("Please choose a number to display its multiplication table :");
                controle = int.TryParse(Console.ReadLine(), out resultat);


            }

            return resultat;
        }

        public static void AfficherTable()
        {
            
            for (int i = 1; i < 11; i++)
            {
                
                Console.WriteLine('\n' + "c'est la table de " + i + '\n');

                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine(i + "*" + j + " =" + i * j);
                }
            }
        }

        public static void AfficherOddsElement()
        {
            
            int resultat = 0;

            
            for (int i = 1; i < 11; i++)
            {
            
                Console.WriteLine('\n' + "This is an odd number of table of  " + i + '\n');

                
                for (int j = 1; j < 11; j++)
                {
                    resultat = i * j;

                    if (resultat % 2 == 1)
                    {
                        Console.WriteLine(i + "*" + j + " =" + i * j);
                    }

                }
            }
        }

        public static void AfficherChoice()
        {
            
            int choice = 0;

            choice = AskParameter();

            
            Console.WriteLine('\n' + "c'est la table de " + choice + '\n');
            for (int a = 1; a < 11; a++)
           
            {
                Console.WriteLine(choice + "*" + a + " =" + choice * a);
            }

        }
    }
}    
    