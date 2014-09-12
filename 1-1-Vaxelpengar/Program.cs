using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_Vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {

            // Värden (DEL 1)

            double totalSum = 0;            // Totalsumman på vad det kostar.
            int paid;                   // Vad kunden betalar.
            double roundingOffAmount;   // Öresavrundningen.
            int moneyBack;              // Hur mycket pengar kunden får tillbaka.
            double subtotal;               // Delsumman.


            // Här matas den totala summan och belopp in. (DEL 2) 

            // Här matas Totalsumman in.

            while (true)
            {

                try
                {
                    Console.Write("Ange totalsumma     : ");  
                    totalSum = double.Parse(Console.ReadLine()); //Totalsumman

                    if (totalSum <= 1)                                       //om värdet är mindre elr = än 1...
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Totalsumman är för liten !\n");  // "Totalsumman är för liten."
                        Console.ResetColor();
                        return;
                    }

                    break;
                }
                catch                                                       // Om det blir formatfel...
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("ERROR.");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Formatfel! Försök igen.\n");         // Felmeddelande
                    Console.ResetColor();
                }
            }


            // Erhållet belopp.
            while (true)
            {
                try
                {
                    Console.Write("Ange erhållet belopp: ");                
                    paid = int.Parse(Console.ReadLine());

                   
                    if (totalSum > paid)                                    // Om erhållet belopp är mindre än..
                    {                                                       // Totalsumman
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Talen stämde inte överens!, Starta om programmet.\n"); //Felmeddelande
                        Console.ResetColor();
                        return;
                    } break;
                }
                catch                                                       // Om det blir Formatfel eller Overflow...
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("ERROR.");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Formatfel eller OverFlow! Försök igen.\n");         //Felmeddelande
                    Console.ResetColor();
                }
            }
            



            // Växlingen . (DEL 3)

            subtotal = (uint)Math.Round(totalSum, MidpointRounding.AwayFromZero); //Öresavrundning. 0,5 rundas upp till 1.
            roundingOffAmount = subtotal - totalSum;                              

            moneyBack = paid - (int)subtotal;




            // Presentation av resulatet. (DEL 4)
            Console.WriteLine("");

            Console.WriteLine("KVITTO");

            Console.WriteLine("---------------------------");
            Console.WriteLine("Totalt        :   {0,5:c}", totalSum);
            Console.WriteLine("Öresavrundning:   {0,5:c}", roundingOffAmount);
            Console.WriteLine("Att Betala    :   {0,5:c0}", totalSum);
            Console.WriteLine("Kontant       :   {0,5:c0}", paid);
            Console.WriteLine("Tillbaka      :   {0,5:c}", moneyBack);
            Console.WriteLine("---------------------------");



            // Presentation av hur många sedlar kunden får tillbaka. (DEL 5)
            if (moneyBack >= 500)                                               //Ifall "moneyBack" stämmer överens
            {                                                                   //med villkoren så kommer summan divideras
                Console.WriteLine("500-lappar : {0}", moneyBack / 500);         //med antalet 500-lappar för att sedan låta
                moneyBack %= 500;                                               //modulus räkna ut resten som bli över.
            }                                                                   //denna process fortsätter sedan nedåt till
            if (moneyBack >= 100)                                               //1-kronorna.
            {
                Console.WriteLine("100-lappar : {0}", moneyBack / 100);
                moneyBack %= 100;
            }
            if (moneyBack >= 50)
            {
                Console.WriteLine("50-lappar  : {0}", moneyBack / 50);
                moneyBack %= 50;
            }
            if (moneyBack >= 20)
            {
                Console.WriteLine("20-lappar  : {0}", moneyBack / 20);
                moneyBack %= 20;
            }
            if (moneyBack >= 10)
            {
                Console.WriteLine("10-kronor  : {0}", moneyBack / 10);
                moneyBack %= 10;
            }
            if (moneyBack >= 5)
            {
                Console.WriteLine("5-kronor  : {0}", moneyBack / 5);
                moneyBack %= 5;
            }
            if (moneyBack >= 1)
            {
                Console.WriteLine("1-kronor  : {0}", moneyBack / 1);
                moneyBack %= 1;


            }

        }
    }
}

