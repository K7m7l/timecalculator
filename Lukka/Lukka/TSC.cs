using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aika
{
    public partial class TSC : Form
    {
        public TSC()
        {
            InitializeComponent();


            buildCrud();
        }

        private void buildCrud()
        {
            Panel panel = new Panel();
            panel.Height = 50;
            panel.Width = flowLayoutPanel1.Width;

            TextBox tbI = new TextBox();tbI.Width = 250;tbI.KeyPress += (i, e) => { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.'); };
            TextBox tbO = new TextBox();tbO.Location = new System.Drawing.Point(300, 0);tbO.Width = 250; tbO.KeyPress += (i, e) => { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.'); };
            Button Abtn = new Button();Abtn.Click += (k, o) => { buildCrud(); }; Abtn.Location = new System.Drawing.Point(600, 0);Abtn.Text = "+";
            Button Dbtn = new Button();Dbtn.Click += (k, o) => { flowLayoutPanel1.Controls.Remove(((Panel)((Button)k).Parent)); }; Dbtn.Location = new System.Drawing.Point(700, 0);Dbtn.Text = "-"; 

            panel.Controls.Add(tbI);
            panel.Controls.Add(tbO);
            panel.Controls.Add(Abtn);
            panel.Controls.Add(Dbtn);

            flowLayoutPanel1.Controls.Add(panel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Panel> panels = new List<Panel>();

            foreach (var pan in flowLayoutPanel1.Controls)
            {
                if(pan.GetType() == typeof(Panel))
                {
                    panels.Add((Panel)pan);
                }
            }

            List<KeyValuePair<string, string>> startstops = new List<KeyValuePair<string, string>>();

            foreach(var panel in panels)
            {
                string start = ((TextBox)(panel.Controls[0])).Text;
                string stop = ((TextBox)(panel.Controls[1])).Text;

                startstops.Add(new KeyValuePair<string, string>(start, stop));
            }

            List<TimeSpan> inTime = new List<TimeSpan>();
            List<TimeSpan> outTime = new List<TimeSpan>();
            int y = 0;
            
            foreach(KeyValuePair<string, string> startstop in startstops)
            {
                DateTime startdateTime = DateTime.ParseExact(startstop.Key, "HH.mm", CultureInfo.InvariantCulture);
                DateTime stopdateTime = DateTime.ParseExact(startstop.Value, "HH.mm", CultureInfo.InvariantCulture);

                var outt = stopdateTime - startdateTime;
                outTime.Add(outt);

                if(y > 0)
                {
                    DateTime prevstopdateTime = DateTime.ParseExact(startstops[y - 1].Value, "HH.mm", CultureInfo.InvariantCulture);
                    var inn = startdateTime - prevstopdateTime;
                    inTime.Add(inn);
                }
                y++;
            }

            TimeSpan its = new TimeSpan();
            //inTime.ForEach(it => its.Add(it));

            TimeSpan ots = new TimeSpan();
            //outTime.ForEach(ot => ots.Add(ot));
            foreach (TimeSpan t in inTime)
            {
                its = its + t;
            }
            foreach (TimeSpan t in outTime)
            {
                ots = ots + t;
            }

            textBox1.Text = "InTime is :" + ots.ToString();
            textBox2.Text = "OutTime is :" + its.ToString();
        }
    }
}
