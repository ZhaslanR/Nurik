using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int primarySum = 200;

            BankAccaunt accaunt = new BankAccaunt();
            accaunt.RegisterHandler(new AccountHadler(SMSSender.SenMassage));
            accaunt.RegisterHandler(new AccountHadler(SendConsoleMessage));

            accaunt.Add(primarySum);
            accaunt.Withdrow(500);
            
        }

        private static void SendConsoleMessage(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ReadLine();
            Console.ResetColor();
        }
    }
}
