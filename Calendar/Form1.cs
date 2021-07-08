using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void bGCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(ColorDialog color = new ColorDialog())
            {
                if(color.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText("Settings\\calendarBG.txt", color.Color.Name);
                }
            }
        }

        private void bGSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog color = new ColorDialog())
            {
                if (color.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText("Settings\\searchBG.txt", color.Color.Name);
                }
            }
        }

        private void bGNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog color = new ColorDialog())
            {
                if (color.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText("Settings\\notesBG.txt", color.Color.Name);
                }
            }
        }

        private void bGPanelWithInstrumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog color = new ColorDialog())
            {
                if (color.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText("Settings\\instrumentBG.txt", color.Color.Name);
                }
            }
        }
    }
}
