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
    public class Project
    {
        [DataMember]
        public string GebiedNaam { get; private set; }
        [DataMember]
        public bool Afgerond { get; private set; }
        [DataMember]
        public Kaart Kaart { get; private set; }

        [DataMember]
        public List<Bezoek> Bezoeken { get; private set; }
        
        public Bezoek LaatsteBezoek
        {
            get
            {
                int aantalBezoeken = Bezoeken.Count;
                return aantalBezoeken == 0 ? null : Bezoeken[aantalBezoeken - 1];
            }
        }
        
        public Project()
        {
            
        }

        public Project(string gebiedNaam, bool afgerond, Kaart kaart)
        {
            GebiedNaam = gebiedNaam;
            Afgerond = afgerond;
            Kaart = kaart;

            Bezoeken = new List<Bezoek>();
        }

        public override string ToString()
        {
            return GebiedNaam;
        }
    }
}
