using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance.Classen
{
    public class Bezoek
    {
        public int Id { get; private set; }
        public DateTime StartDatum { get; private set; }
        public DateTime EindDatum { get; private set; }

        public List<Waarneming> Waarnemingen { get; private set; } 

        public Bezoek(int id, DateTime startDatum, DateTime eindDatum, List<Waarneming> waarnemingen)
        {
            Id = id;
            StartDatum = startDatum;
            EindDatum = eindDatum;
            Waarnemingen = waarnemingen;
        }
    }
}
