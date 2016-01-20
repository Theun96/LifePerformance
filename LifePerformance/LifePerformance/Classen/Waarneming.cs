using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance.Classen
{
    public class Waarneming
    {
        public int Id { get; private set; }

        public VogelSoort Vogel { get; set; }
        public Type Type { get; set; }

        public Waarneming(int id)
        {
            Id = id;
        }
    }
}
