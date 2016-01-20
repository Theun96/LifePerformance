using LifePerformance.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePerformance.Classen
{
    public class Administratie
    {
        public List<Kaart> Kaarten { get; } 
        public List<Project> Projecten { get; } 
        public List<VogelSoort> Vogels { get; } 
        public List<Type> Types { get; private set; }

        public Administratie()
        {
            Kaarten = new List<Kaart>();
            Projecten = new List<Project>();
            Vogels = new List<VogelSoort>();
            Types = new List<Type>();

            KaartData(false);
            ProjectData();
            //TypeData();
            VogelData();
        }

        private void KaartData(bool useDatabase)
        {
            Kaarten.Clear();

            if (useDatabase)
            {
                DataTable dt = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.Query["GetKaarten"], null);

                foreach (DataRow dr in dt.Rows)
                {
                    var id = Convert.ToInt32(dr["ID"]);
                    var bestandsLocatie = dr["BestandsLocatie"].ToString();

                    Kaarten.Add(new Kaart(id, bestandsLocatie + "\\lege_veldkaart.jpg"));
                }
            }
            else
            {
                Kaart kaart = new Kaart(1, @"C: \Users\Theun\Google Drive\Fontys\Jaar 1.2\Life Performance\Documenten\Afbeeldingen\lege_veldkaart.jpg");
                Kaarten.Add(kaart);
            }
        }

        private void ProjectData()
        {
            DataTable dt = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.Query["GetProjecten"], null);

            Projecten.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                var id = Convert.ToInt32(dr["ID"]);
                var gebiedNaam = dr["GebiedNaam"].ToString();
                var afgerond = Convert.ToBoolean(dr["Afgerond"]);

                

                foreach (Kaart k in Kaarten)
                {
                    if (k.Id == Convert.ToInt32(dr["KaartID"]))
                    {
                        var kaart = k;
                        Projecten.Add(new Project(id, gebiedNaam, afgerond, kaart));
                    }
                }
            }
        }

        private void TypeData()
        {
            
        }

        private void VogelData()
        {
            var reader = new StreamReader(File.OpenRead(@"C:\Users\Theun\Google Drive\Fontys\Jaar 1.2\Life Performance\Documenten\Opdracht\broedvogels.csv"));
            
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                var naam = values[0];
                var afkorting = values[1];
                var startBroeden = DateTime.Parse(values[2]);
                var eindBroeden = DateTime.Parse(values[3]);
                var punten = Convert.ToInt32(values[4]);

                Vogels.Add(new VogelSoort(naam, afkorting, startBroeden, eindBroeden, punten));
            }
        }
    }
}
