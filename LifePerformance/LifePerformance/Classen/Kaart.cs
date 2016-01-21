using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance.Classen
{
    [Serializable]
    [DataContract]
    public class Kaart
    {
        [DataMember]
        public int Id { get; private set; }
        [DataMember]
        public string Naam { get; private set; }
        [DataMember]
        public string BestandsLocatie { get; private set; }

        public Kaart()
        {
            
        }

        public Kaart(int id, string naam, string bestandsLocatie)
        {
            Id = id;
            Naam = naam;
            BestandsLocatie = bestandsLocatie;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
