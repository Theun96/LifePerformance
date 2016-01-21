using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance.Data
{
    public static class DatabaseQuerys
    {
        public static Dictionary<string, string> Query = new Dictionary<string, string>();

        static DatabaseQuerys()
        {
            Query["GetProjecten"] = "SELECT * FROM Project";
            Query["GetKaarten"] = "SELECT * FROM Kaart";
            Query["GetTypen"] = "SELECT * FROM Type";
            Query["AddProject"] = "INSERT INTO Project (GEBIEDNAAM, AFGEROND, KAARTID) VALUES (:gebiednaam, 0, :kaartid)";
        }
    }
}
