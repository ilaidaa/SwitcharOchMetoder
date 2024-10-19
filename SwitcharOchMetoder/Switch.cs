using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitcharOchMetoder
{
    internal class Switch
    {
        public static void TakeNumberIfSats()
        {
            while (true) //Så att programmet fortsätter att köra och inte avslutas efter första inmatningen av användaren
            {

                Console.Clear(); //Rensar konsolen efter varje resultat

                Console.Write("Skriv in ett heltal mellan 1-9: ");
                int.TryParse(Console.ReadLine(), out int number);

                //Om du vill använda if sats ser det ut såhär
                if (number < 4 && number > 0 && number < 10)
                {
                    Console.WriteLine("Ditt nummer multipliceras med 10. Resultatet blir: " + number * 10);
                }
                else if (number < 7 && number > 0 && number < 10)
                {
                    Console.WriteLine("Ditt nummer multipliceras med 100. Resultatet blir: " + number * 100);
                }
                else if (number < 10 && number > 0 && number < 10)
                {
                    Console.WriteLine("Ditt nummer multipliceras med 1000. Resultatet blir: " + number * 1000);
                }
                else
                {
                    Console.WriteLine("Fel inmatning. Skriv ett tal mellan 1-9.");
                }

                Console.ReadKey(); //Så att resultatet syns och inte rensas direkt av Console.Clear();

            }

        }

        public static void TakeNumberSwitch()
        {

            while (true)
            {

                Console.Clear();

                Console.Write("Skriv in ett heltal mellan 1-9: ");
                int.TryParse(Console.ReadLine(), out int number);

                //Om du vill använda switch ser det ut såhär
                switch (number)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine("Ditt nummer multipliceras med 10. Resultatet blir: " + number * 10);
                        break;
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine("Ditt nummer multipliceras med 100. Resultatet blir: " + number * 100);
                        break;
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine("Ditt nummer multipliceras med 1000. Resultatet blir: " + number * 1000);
                        break;
                    default:
                        Console.WriteLine("Fel inmatning. Skriv ett heltal mellan 1-9");
                        break;
                }

                Console.ReadKey();
            }

        }




    }
}
