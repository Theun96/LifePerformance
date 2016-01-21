using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance.Classen
{
    [DataContract]
    [Serializable]
    public class Bezoek
    {
        [DataMember]
        public int BezoekNummer { get; private set; }
        [DataMember]
        public DateTime StartDatum { get; private set; }
        [DataMember]
        public DateTime EindDatum { get; set; }
        [DataMember]
        public bool BezoekBeeindigd { get; set; }

        [DataMember]
        public List<Waarneming> Waarnemingen { get; set; }

        public Bezoek()
        {
            
        }

        public Bezoek(int bezoekNummer, DateTime startDatum)
        {
            StartDatum = startDatum;
            BezoekNummer = bezoekNummer;
            BezoekBeeindigd = false;

            Waarnemingen = new List<Waarneming>();
        }

        public void BeindigBezoek()
        {
            BezoekBeeindigd = true;
        }

        public override string ToString()
        {
            var beeindigd = BezoekBeeindigd ? "Beindigd" : "Lopend";

            return "Bezoek " + BezoekNummer + ": " + beeindigd;
        }

        public int AddWaarneming(VogelSoort vogel, Type type, Point locatie)
        {
            Waarneming newWaarneming = new Waarneming(vogel, type, locatie);

            Waarnemingen.Add(newWaarneming);

            return 1;
        }
    }
}
