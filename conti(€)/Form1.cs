using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conti___
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tbc_inizio.Appearance = TabAppearance.FlatButtons;
            tbc_inizio.ItemSize = new Size(0, 1);
            tbc_inizio.SizeMode = TabSizeMode.Fixed;

            tbc_grafici.Appearance = TabAppearance.FlatButtons;
            tbc_grafici.ItemSize = new Size(0, 1);
            tbc_grafici.SizeMode = TabSizeMode.Fixed;
        }

        private void btn_graficoggi_Click(object sender, EventArgs e)
        {
            tbc_grafici.SelectTab(1);
        }

        private void btn_graficotot_Click(object sender, EventArgs e)
        {
            tbc_grafici.SelectTab(3);
        }

        private void btn_differenzaoggi_Click(object sender, EventArgs e)
        {
            tbc_grafici.SelectTab(2);
        }

        private void btn_differenzatot_Click(object sender, EventArgs e)
        {
            tbc_grafici.SelectTab(4);
        }

        private void btn_graficomese_Click(object sender, EventArgs e)
        {
            tbc_grafici.SelectTab(5);
        }

        private void btn_differenzamese_Click(object sender, EventArgs e)
        {
            tbc_grafici.SelectTab(6);
        }

        
    }
}
