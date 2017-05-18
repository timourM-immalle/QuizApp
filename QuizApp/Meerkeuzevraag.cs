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

        public Random WillekeurigeVraag
        {
            get; set;
        }
    }
}
