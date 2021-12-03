using System;

namespace TP1
{
    internal class Program
    {
        public static void Main()
        {
            var multi = new Exo1();
            Exo1.AfficherChoice();
            
            var ask = new Exo2();
            Exo2.AskUser();
            
            var prime = new Exo2();
            Exo2.PrimeNumber();
            
            var fibo = new Exo2();
            Exo2.Fibonacci();
            
            var facto = new Exo2();
            Exo2.facto();
     
        }
        
    }
}