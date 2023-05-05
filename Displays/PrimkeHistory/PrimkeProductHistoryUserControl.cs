using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotal_manager.Displays
{
    public partial class PrimkeProductHistoryUserControl : UserControl
    {
        public PrimkeProductHistoryUserControl()
        {
            InitializeComponent();
        }
        public PrimkeProductHistoryUserControl(int PrimkaID, string dobavljac, double popust, double porez, int kolicina, double cijena, string datum)
        {
            InitializeComponent();
            labelPrimkaID.Text = PrimkaID.ToString();
            labelDobavljac.Text = dobavljac;
            labelPopust.Text = popust + "%";
            labelPorez.Text = porez + "%";
            labelKolicina.Text = kolicina.ToString();
            labelCijena.Text = cijena+ " €";
            labelUkupnaCijena.Text = Racunaj.izlaznaCijenaIzUlazne(cijena, popust, porez, kolicina) + " €";
            labelDatum.Text = datum;
        }
    }
}
