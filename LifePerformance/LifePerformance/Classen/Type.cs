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
    public class Type
    {
        [DataMember]
        public int Id { get; private set; }
        [DataMember]
        public string SoortType { get; private set; }
        [DataMember]
        public string Afkorting { get; private set; }
        [DataMember]
        public string Uitleg { get; private set; }
        [DataMember]
        public int Punten { get; private set; }

        public Type()
        {
            
        }

        public Type(int id, string soortType, string afkorting, string uitleg, int punten)
        {
            Id = id;
            SoortType = soortType;
            Afkorting = afkorting;
            Uitleg = uitleg;
            Punten = punten;
        }

        public override string ToString()
        {
            return Afkorting + " - " + SoortType;
        }
    }
}
