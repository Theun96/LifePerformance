using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance.Classen
{
    public class Kaart
    {
        public int Id { get; private set; }
        public string BestandsLocatie { get; private set; }

        public Kaart(int id, string bestandsLocatie)
        {
            Id = id;
            BestandsLocatie = bestandsLocatie;
        }
    }
}
