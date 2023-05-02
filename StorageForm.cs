using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotal_manager
{
    public partial class StorageForm : Form
    {
        List<StorageUserControl> storageUsers = new List<StorageUserControl>();
        public StorageForm()
        {
            InitializeComponent();
        }

        class StorageData
        {
            public int proizvodID;
            public double cijena, popust, porez;
            public int kolicina;
            public StorageData(int proizvodID,double cijena, double popust, double porez, int kolicina)
            {
                this.proizvodID = proizvodID;
                this.cijena= cijena;
                this.popust= popust;
                this.porez= porez;
                this.kolicina= kolicina;
            }
            public double calc() { return Racunaj.izlaznaCijenaIzUlazne(cijena, popust, porez, kolicina); }

            public override int GetHashCode()
            {
                return (proizvodID+":"+cijena+":"+popust+":"+porez).GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null || !(obj is StorageData))
                    return false;

                StorageData other = (StorageData)obj;
                return proizvodID == other.proizvodID && cijena == other.cijena && popust == other.popust && porez == other.porez;
            }

        };


        private void StorageForm_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {
            MainFlowPanel.Controls.Clear();
            storageUsers.Clear();


            string sql = "SELECT * FROM `primke-stavke`;";
            MySqlCommand command = new MySqlCommand(sql, DatabaseManager.Connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<StorageData> primke = new List<StorageData>();
            while (reader.Read())
                primke.Add(new StorageData(reader.GetInt32("ProizvodID"), reader.GetDouble("Cijena"), reader.GetDouble("Popust"), reader.GetDouble("Porez"), reader.GetInt32("Kolicina")));
            reader.Close();


            Dictionary<StorageData, int> data = new Dictionary<StorageData, int>();
            foreach (StorageData sd in primke)
                data[sd]+= sd.kolicina;

            foreach (KeyValuePair<StorageData, int> entry in data)
            {


                StorageUserControl userControl = new StorageUserControl(entry.Key.proizvodID, entry.Value, );

                MainFlowPanel.Controls.Add(userControl);
                storageUsers.Add(userControl);
            }
        }



        private void buttonPrimka_Click(object sender, EventArgs e)
        {
            PrimkaForm ps = new PrimkaForm();
            ps.ShowDialog();
            refreshData();
        }
    }
}
