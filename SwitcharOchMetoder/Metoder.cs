using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitcharOchMetoder
{
    internal class Metoder
    {
        // Metod 1 för att addera två heltal
        public static int Add(int number1, int number2)
        {
            // Returnerar summan av de två talen
            return number1 + number2;
        }





        // Metod 2 för att beräkna moms (25%)
        public static double Vat(double number)
        {
            // Returnerar momsen som är 25% av det angivna talet
            return number * 0.25;
        }






        // Metod 3 för att beräkna totalsumman inklusive moms
        public static double VatAndSum(double number, double vat)
        {
            // Returnerar totalsumman, dvs summan plus momsen
            return number + vat;
        }






        // Metod 4 som visar resultatet och använder de andra tre metoderna
        public static void ShowResult()
        {
            //Använs första metoden
            // Be användaren mata in det första heltalet
            Console.Write("Skriv in ett heltal: ");
            int.TryParse(Console.ReadLine(), out int number1);

            // Be användaren mata in det andra heltalet
            Console.Write("Skriv in ett till heltal: ");
            int.TryParse(Console.ReadLine(), out int number2);

            // Beräkna summan av de två talen med hjälp av Add-metoden
            double sum = Add(number1, number2);
            Console.WriteLine("Summan av talen är: " + sum + " kr.");







            //Använd andra metoden
            // Beräkna momsen på summan med hjälp av Vat-metoden
            double vat = Vat(sum);
            Console.WriteLine("Momsen är: " + vat + " kr.");







            //Använd tredje metoden
            // Beräkna totalsumman inklusive moms med hjälp av VatAndSum-metoden
            double total = VatAndSum(sum, vat);
            Console.WriteLine("Totalsumman inklusive moms: " + total + " kr.");
        }

    }
}
