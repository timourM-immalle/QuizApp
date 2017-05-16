using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Vragenlijst : List<Vraag> //GEEN overerving van Vragen op zich ("Vragenlijst is Geen Vraag")
    {
        private List<Vraag> vragen = new List<Vraag>();

        //in opgave staan er puntjes tss de haakjes, dus EEN PARAMETER MEEGEVEN!
        public void VoegVraagToe(Vraag vraag)
        {
            //List<Vraag> vragen = new List<Vraag>(); //zijn die accolades hetzelfde 'dan' als u later vragen.Add(vraag); doet?
            vragen.Add(vraag);
        }

        public void Start()
        {
            foreach (Vraag vraag in vragen)
            {
                vraag.StelVraag();
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Resultaat");
            Console.WriteLine("---------");
            Console.WriteLine();
        }

        public void PrintRapport()
        {
            foreach (Vraag vraag in vragen)
            {
                if (vraag.Check())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(vraag.Inhoud);
                    Console.WriteLine("\t\tCorrect!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(vraag.Inhoud);
                    Console.WriteLine("\t\tFout: [{0}]", vraag.CorrectAntwoord);
                }
            }

            Console.ResetColor();
        }
    }
}