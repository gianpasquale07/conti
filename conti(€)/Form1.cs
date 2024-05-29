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

       
    }
}
