using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance.Classen
{
    [DataContract]
    [Serializable]
    public class VogelSoort
    {
        [DataMember]
        public string Naam { get; private set; }
        [DataMember]
        public string Afkorting { get; private set; }
        [DataMember]
        public DateTime StartBroeden { get; private set; }
        [DataMember]
        public DateTime EindBroeden { get; private set; }
        [DataMember]
        public int Punten { get; private set; }

        public VogelSoort()
        {
            
        }

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
