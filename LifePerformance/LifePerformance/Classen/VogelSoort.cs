using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance.Classen
{
    public class VogelSoort
    {
        public string Naam { get; private set; }
        public string Afkorting { get; private set; }
        public DateTime StartBroeden { get; private set; }
        public DateTime EindBroeden { get; private set; }
        public int Punten { get; private set; }

        public VogelSoort(string naam, string afkorting, DateTime startBroeden, DateTime eindBroeden, int punten)
        {
            Naam = naam;
            Afkorting = afkorting;
            StartBroeden = startBroeden;
            EindBroeden = eindBroeden;
            Punten = punten;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
