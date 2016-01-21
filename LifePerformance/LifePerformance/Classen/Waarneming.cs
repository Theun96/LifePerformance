using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LifePerformance.Forms;

namespace LifePerformance.Classen
{
    [DataContract]
    [Serializable]
    public class Waarneming
    {
        [DataMember]
        public Panel WaarnemingPanel { get; private set; }
        [DataMember]
        public VogelSoort Vogel { get; private set; }
        [DataMember]
        public Type Type { get; private set; }

        [DataMember]
        public DateTime Time { get; private set; }

        [DataMember]
        public Point Locatie { get; private set; }

        public Waarneming()
        {
            
        }

        public Waarneming(VogelSoort vogel, Type type, Point locatie)
        {
            Vogel = vogel;
            Type = type;
            Locatie = locatie;

            Time = DateTime.Now;

            AddWaarneming();
        }

        private void AddWaarneming()
        {
            WaarnemingPanel = new Panel
            {
                Size = new Size(40, 30),
                Location = Locatie,
                BackColor = Color.Transparent
            };
            
            Label l = new Label
            {
                Text = Vogel.Afkorting,
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                Size = new Size(10,10),
            };

            WaarnemingPanel.Paint += Paint;
            l.Click += Panel_Click;
            WaarnemingPanel.Controls.Add(l);

            l.AutoSize = true;
            l.Location = new Point((WaarnemingPanel.Size.Width / 2) - (l.Size.Width / 2), (WaarnemingPanel.Size.Height / 2) - (l.Size.Height / 2));

            WaarnemingPanel.Click += Panel_Click;
        }

        private void Paint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            var g = e.Graphics;


            if (Type.Afkorting == "VA")
            {
                g.DrawLine(new Pen(Color.Black, 3), 2, 2, p.Size.Width - 4, 2);
            }
            if (Type.Afkorting == "NI")
            {
                g.DrawEllipse(new Pen(Color.Black, 3), 2, 2, p.Size.Width - 4, p.Size.Height - 4);
            }
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            WaarnemingInfo waarnemingInfo = new WaarnemingInfo(Vogel, Type, Time);

            waarnemingInfo.ShowDialog();

            Vogel = waarnemingInfo.Vogel;
            Type = waarnemingInfo.Type;

            AddWaarneming();
        }
    }
}
