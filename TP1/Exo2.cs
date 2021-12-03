using System;

namespace TP1
{
    public class Exo2
    {
        public static int AskUser()
        {
            
            bool controle = false;
            int resultat=0 ;
            
            
            while (controle != true)
            {
                
                Console.WriteLine("Please you need to choose a number :");
                controle = int.TryParse(Console.ReadLine(), out resultat);

               
            }
            return resultat;
        }
        public static void PrimeNumber()
        
        
        {
            int start;
            int end = 1000;
            bool prime = true;

            
            for (start = 2; start <= end; start++)
            {
                
                for (int j = 2; j < start; j++)
                {
                    if (start % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                
                if (!prime)
                {
                    prime = true;
                }
                else
                {
                    Console.WriteLine(start);
                }
            }
        }
        
        
        public static void Fibonacci()
        {
            int choice;
            int F0 = 1;
            int F1 = 1;
            int F2 = 0;
            
            
            choice = AskUser();
            
            
            if (choice == 0)
            {
                Console.WriteLine("F(0) = " +F0);
            }

            
            if (choice == 1)
            {
                Console.WriteLine("F(1) = " +F1);
            }
            
            else
            {
                for (int i = 2; i <= choice; i++)
                {
                    F2 = F1 + F0;
                    F0 = F1;
                    F1 = F2;

                    
                }
                Console.WriteLine("F("+choice+") is "+ F2);
            }
        }

        public static void facto()
        {
            
            int choice = AskUser();
            int result = 1;
            

            if (choice == 0)
            {
                Console.WriteLine("facto of " + choice + "is " +1);
            }
            
            else
            {
            
                for (int i = 1; i <= choice; i++)
                {
                    result = result * i;
                }
                Console.WriteLine("facto of " + choice + " is " +result);
            }
        }
    }
            }
        
    
