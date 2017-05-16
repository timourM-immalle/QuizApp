using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Tijdvraag : Vraag
    {
        private int antwoordtijd; //aangezien ik van de DateTime's specifiek de seconden heb genomen, is het type geen TimeSpan, maar een int

        public override void StelVraag()
        {
            var huidigeTijd = DateTime.Now;

            base.StelVraag();
            antwoordtijd = DateTime.Now.Second - huidigeTijd.Second;
        }

        public int Antwoordtijd
        {
            get { return antwoordtijd; }
        }
    }
}