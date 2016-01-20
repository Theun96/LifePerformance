using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance.Classen
{
    public class Type
    {
        public int Id { get; private set; }
        public string SoortType { get; private set; }
        public string Afkorting { get; private set; }
        public string Uitleg { get; private set; }
        public int Punten { get; private set; }

        public Type(int id, string soortType, string afkorting, string uitleg, int punten)
        {
            Id = id;
            SoortType = soortType;
            Afkorting = afkorting;
            Uitleg = uitleg;
            Punten = punten;
        }
    }
}
