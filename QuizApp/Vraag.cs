using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Vraag //( : object) //deze klasse encapsuleert Inhoud en CorrectAntwoord en gegevenAntwoord; dat houdt de klasse ook bij
    {
        private string gegevenAntwoord;

        public string Inhoud { get; set; }
        public string CorrectAntwoord { get; set; }

        public virtual void StelVraag()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Inhoud);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Antwoord: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            gegevenAntwoord = Console.ReadLine();
            Console.ResetColor();
        }

        public bool Check()
        {
            if (gegevenAntwoord == CorrectAntwoord)
            {
                return true;
            }
            return false;
        }

        //public virtual void PrintRapportLijn()
        //{
        //    string fmt = "{0, -40} {1,20}";
        //}
    }
}