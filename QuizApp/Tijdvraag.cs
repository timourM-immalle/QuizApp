using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Tijdvraag : Vraag
    {
        public override void StelVraag()
        {
            var huidigeTijd = DateTime.Now;

            base.StelVraag();
            Console.WriteLine(DateTime.Now.Second - huidigeTijd.Second + " seconden");
        }
    }
}