using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance.Classen
{
    public class Project
    {
        public int Id { get; private set; }
        public string GebiedNaam { get; private set; }
        public bool Afgerond { get; private set; }
        public Kaart Kaart { get; private set; }

        public List<Bezoek> Bezoeken { get; private set; }
        
        public Project(int id, string gebiedNaam, bool afgerond, Kaart kaart)
        {
            Id = id;
            GebiedNaam = gebiedNaam;
            Afgerond = afgerond;
            Kaart = kaart;

            Bezoeken = new List<Bezoek>();
        }
    }
}
