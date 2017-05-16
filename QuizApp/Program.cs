using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vragenlijst vragenlijst = new Vragenlijst();

            vragenlijst.VoegVraagToe(new Tijdvraag { Inhoud = "Hoeveel is 1 + 1?", CorrectAntwoord = "2" });
            vragenlijst.VoegVraagToe(new Tijdvraag { Inhoud = "Hoeveel is 2 * 3?", CorrectAntwoord = "6" });

            vragenlijst.Start();
            vragenlijst.PrintRapport();
        }
    }
}