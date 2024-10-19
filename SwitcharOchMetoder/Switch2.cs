using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitcharOchMetoder
{
    internal class Switch2
    {

        public static void SimulateElevator()
        {
            for(int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Våning 0: Entreplan.");
                        Thread.Sleep(1000);
                        break;
                    case 1:
                        Console.WriteLine("Våning 1: Säljavdelningen.");
                        Thread.Sleep(1000);
                        break;
                    case 2:
                        Console.WriteLine("Våning 2: It-avdelningen.");
                        Thread.Sleep(1000);
                        break;
                    case 3:
                        Console.WriteLine("Våning 3: Projekt-ledningen.");
                        Thread.Sleep(1000);
                        break;
                    case 4:
                        Console.WriteLine("Våning 4: Chefen.");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }



        public static void SimulateElevatorBetter()
        {
            string[] floors =
            {
                "Våning 0: Entrèplan.",
                "Våning 1: Säljavdelningen.",
                "Våning 2: IT-avdelningen.",
                "Våning 3: Projekt-ledningen.",
                "Våning 4: Chefen."
            };


            for(int i = 0; i < floors.Length; i++)
            {
                Console.WriteLine(floors[i]);
                Thread.Sleep(1000);
            }
        }

    }
}
