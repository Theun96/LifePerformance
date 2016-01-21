using LifePerformance.Data;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LifePerformance.Classen
{
    [DataContract]
    public class Administratie
    {
        private Project _huidigProject;
        [DataMember]
        public List<Kaart> Kaarten { get; }
        [DataMember]
        public List<Project> Projecten { get; private set; }
        [DataMember]
        public List<VogelSoort> Vogels { get; }
        [DataMember]
        public List<Type> Types { get; private set; }
        
        public Administratie()
        {
            Kaarten = new List<Kaart>();
            Projecten = new List<Project>();
            Vogels = new List<VogelSoort>();
            Types = new List<Type>();

            KaartData(false);
            ProjectData();
            TypeData();
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
                    var naam = dr["Naam"].ToString();
                    var bestandsLocatie = dr["BestandsLocatie"].ToString();

                    Kaarten.Add(new Kaart(id, naam, bestandsLocatie + "\\lege_veldkaart.png"));
                }
            }
            else
            {
                Kaart kaart = new Kaart(1, "vallei", @"C:\Users\Theun\Google Drive\Fontys\Jaar 1.2\Life Performance\Documenten\Afbeeldingen\lege_veldkaart.png");
                Kaarten.Add(kaart);
            }
        }

        private void ProjectData()
        {
            DataTable dt = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.Query["GetProjecten"], null);

            Projecten.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                var gebiedNaam = dr["GebiedNaam"].ToString();
                var afgerond = Convert.ToBoolean(dr["Afgerond"]);



                foreach (Kaart k in Kaarten)
                {
                    if (k.Id == Convert.ToInt32(dr["KaartID"]))
                    {
                        var kaart = k;
                        Projecten.Add(new Project(gebiedNaam, afgerond, kaart));
                    }
                }
            }
        }

        private void TypeData()
        {
            DataTable dt = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.Query["GetTypen"], null);

            Types.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                var id = Convert.ToInt32(dr["ID"]);
                var soortType = dr["SoortType"].ToString();
                var afkorting = dr["Afkorting"].ToString();
                var uitleg = dr["Uitleg"].ToString();
                var punten = Convert.ToInt32(dr["Punten"]);

                Types.Add(new Type(id, soortType, afkorting, uitleg, punten));
            }
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

        public void SetHuidigProject(Project p)
        {
            _huidigProject = p;
        }

        public int AddProject(string gebiedNaam, Kaart kaart)
        {
            try
            {
                Project newProject = new Project(gebiedNaam, false, kaart);

                Projecten.Add(newProject);

                OracleParameter[] parameters =
                {
                    new OracleParameter("gebiednaam", gebiedNaam),
                    new OracleParameter("kaartid", kaart.Id),
                };

                DatabaseManager.ExecuteInsertQuery(DatabaseQuerys.Query["AddProject"], parameters);

                _huidigProject = newProject;

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public List<Bezoek> GetBezoeken()
        {
            return _huidigProject.Bezoeken;
        }

        public List<Waarneming> WaarnemingHuidigBezoek()
        {
            try
            {
                return _huidigProject.LaatsteBezoek.Waarnemingen;
            }
            catch (Exception)
            {
                return null;
            }
        } 

        public int AddBezoek()
        {
            try
            {
                if (_huidigProject.Bezoeken.Count == 0)
                {
                    _huidigProject.Bezoeken.Add(new Bezoek(1, DateTime.Now));
                    return 1;
                }

                int aantalBezoeken = _huidigProject.Bezoeken.Count;
                int volgendNummer = _huidigProject.Bezoeken[aantalBezoeken - 1].BezoekNummer + 1;
                
                Bezoek b = new Bezoek(volgendNummer, DateTime.Now);
                _huidigProject.Bezoeken.Add(b);

                SaveAsXml();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int CloseBezoek()
        {
            try
            {
                int aantalBezoeken = _huidigProject.Bezoeken.Count;
                Bezoek huidigBezoek = _huidigProject.Bezoeken[aantalBezoeken - 1];

                foreach (Bezoek bezoek in _huidigProject.Bezoeken)
                {
                    if (bezoek == huidigBezoek)
                    {
                        bezoek.EindDatum = DateTime.Now;
                        bezoek.BezoekBeeindigd = true;
                        return 1;
                    }
                }
                return 0;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int AddWaarneming(VogelSoort vogelSoort, Type type, Point locatie)
        {
            if(_huidigProject.LaatsteBezoek.BezoekBeeindigd) return 1;

            _huidigProject.LaatsteBezoek.AddWaarneming(vogelSoort, type, locatie);

            return 1;
        }

        public void SaveAsXml()
        {
            DataContractSerializer dcs = new DataContractSerializer(typeof(Project));

            using (FileStream fs = new FileStream(@"C:\Users\Theun\Google Drive\Fontys\Jaar 1.2\Life Performance\Applicatie\project.xml", FileMode.Create, FileAccess.Write))
            {
                dcs.WriteObject(fs, _huidigProject.Bezoeken);
            }
        }
    }
}
