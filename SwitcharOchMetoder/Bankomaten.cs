using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitcharOchMetoder
{
    

    internal class Bankomaten
    {
        //Detta är en global variabel som läggs i Bankomat klassen som innehåller alla metoder.
        //Nu kan alla metoder som är i Bankomat klassen nå variabeln.
        public static int saldo = 0;





        //Metod 1 - Basmetoden
        //Denna metod är den som ska skrivas i Main och som använder alla de mindre metoderna längre ner.
        public static void PrintMeny()
        {
            //While loop så att koden körs till användaren avslutar den.
            while (true)
            {
                Console.Clear(); //Rensar konsolen efter varje körning 


                Console.Write("Tryck in siffran på den funktion du vill använda: "); //Ge användaren instruktioner och låt användaren svar hamna på samma rad för design
                Console.WriteLine(); //Design
                                     //Skriv ut menyn
                Console.WriteLine("1. Insättning.");
                Console.WriteLine("2. Uttag.");
                Console.WriteLine("3. Saldo.");
                Console.WriteLine("4. Avsluta");

                //Spara användarens inmatning
                //Detta ska  vara int för att användaren ska skriva in en siffra beroende på vilken funktion hen vill använda.
               if(int.TryParse(Console.ReadLine(), out int input))
                {

                    //Lägg in svaret i en switch sats för att säga åt programmet vad den ska göra i de olika raderna i menyn
                    switch (input)
                    {
                        case 1:
                            Insert();
                            break;
                        case 2:
                            WithDrawl();
                            break;
                        case 3:
                            ShowBalance();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Ogiltig inmatning."); // Om användaren skriver ett HELTAL som INTE är 1-4. Tex 9 eller 0.
                                                                    //Eftersom att switch satsen tar in en int så kontrollerar den bara om användaren skriver fel int tex 9 eller o.
                                                                    //På rad 72 hanteras felmatning av strängar eller annat t.ex
                            break;
                           
                    }
                }



                else 
                {
                    Console.WriteLine("Ogiltig inmatning."); //Om användaren inte skriver in ett tal mellan 1-4 och skriver in en sträng eller kanske en double.
                                                             //Så den hanterar andra felinmatningar än int som hanterad på rad 60
                }



                Console.ReadKey(); //Pausar program till den ska köras om igen. Hör ihop med Console.Clear() i början av while loopen

            }
        }










        //Metod 2 : "submetod"
        //Hanterar det som ska hända under en insättning
        public static void Insert()
        {
            Console.Write("Skriv in summan du vill sätta in. Du får inte sätta in mer än 10.000:- per gång (lagen om penningtvätt): ");

            if (!int.TryParse(Console.ReadLine(), out int insert)) //Spara summan användaren sätter in och kolla 
                                                                   //! : Kollar vad som händer när insert inte är en summa, kanske är den en sträng eller decimal
                                                                   //Om det inte är ett helttal ska strängen i if satsen skrivas ut till användaren
            {
                Console.WriteLine("Ogiltig inmatning, vänligen skriv ett giltigt heltal.");
                return; // Avbryt metoden om inmatningen är ogiltig.
            }



            else if(insert <= 10000 && insert > 0)
            {
                Console.WriteLine("Godkänd insättning.");
                saldo += insert; //Sparar insättningen i den globala variabeln saldo
                                 //Detta betyder saldo = saldo + insert
                                 //Detta säkerställer att det nya insättningsbeloppet läggs till det nuvarande saldot istället för att ersätta det.
            }
            else
            {
                Console.Write("Nekad insättning. Följ instruktionerna dumb ass.");
            }

        }








        //Metod 3 : "submetod"
        //Hanterar det som ska hända under ett uttag
        public static void WithDrawl()
        {
            Console.Write("Skriv in summan du vill ta ut: ");
            if(!int.TryParse(Console.ReadLine(), out int withdrawl))
            {
                Console.WriteLine("Ogiltig inmatning, vänligen skriv ett giltigt heltal.");
            } 


            else if(withdrawl <= saldo && withdrawl > 0)
            {
                Console.WriteLine("Godkänd Uttag.");
                saldo -= withdrawl; //Tar bort uttaget från den globala variabeln saldo
            }
            else
            {
                Console.WriteLine("Nekad Uttag. Du har inte tillräckligt med pengar i kontot.");
            }

         
        }






        //Metod 4 : "subklass"
        //Metode som visar saldot på skärmen
        public static void ShowBalance()
        {
            Console.WriteLine("Ditt saldo är: " + saldo);
        }
    }
}
