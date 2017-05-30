using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Meerkeuzevraag : Vraag
    {
        private Random rnd = new Random();
        private List<string> meerkeuzeantwoorden = new List<string>();
        private char[] alfabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private string gegevenAntwoord;
        private string[] mogelijkAntwoord;

        public string[] Antwoorden { get; set; }

        public override void StelVraag()
        {
            int randomgetal;
            int maxAantalAntwoorden = 1; //is 1 + #antwoorden; om in rnd te gebruiken
            int alfabetindex = 0;
            int antwoordindex = 0;
            char[] gebruikteRandomgetallen = "".ToCharArray();
            int aantalGebruikteAntwoorden = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Inhoud);
            Console.Write("         Mogelijke antwoorden:");

            foreach (string keuzeantwoord in Antwoorden)
            {
                mogelijkAntwoord[antwoordindex] = alfabet[alfabetindex] + ". " + keuzeantwoord; //antwoorden moeten er random op komen
                antwoordindex++;
                alfabetindex++;
                maxAantalAntwoorden++;
            }

            for (int i = 0; i <= antwoordindex; i++) //als alle mogelijkheden klaar zijn: break;    //als een getal al random 'gedraaid' is, geen rnd-mogelijkheid meer
            {
                List<string> gebruikteRandomgetallenToevoegen = new List<string>();
                randomgetal = rnd.Next(maxAantalAntwoorden);

                if (aantalGebruikteAntwoorden < maxAantalAntwoorden - 1 && randomgetal != Convert.ToInt32(gebruikteRandomgetallen)/*eender Welk get. in gebruikteRandomgetallen*/)
                {
                    Console.WriteLine(mogelijkAntwoord[rnd.Next(maxAantalAntwoorden)]);
                }
                else
                {
                    continue; //vs break;
                }

                gebruikteRandomgetallenToevoegen.Add(randomgetal.ToString())
                gebruikteRandomgetallen[//op de xe plaats ...toeveoegn]
                    
                aantalGebruikteAntwoorden++;
            }
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("PS: Antwoord met het volledige antwoord, NIET met de letter!"); //momenteel
            Console.Write("Antwoord: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            gegevenAntwoord = Console.ReadLine();
            Console.ResetColor();
        }

        public Random WillekeurigeVraag //willekeurige antwoorden worden door elkaar gegooid
        {
            get; set;
        }
    }
}