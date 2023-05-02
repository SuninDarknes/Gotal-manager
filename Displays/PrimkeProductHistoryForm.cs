using MySql.Data.MySqlClient;
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
    public partial class PrimkeProductHistoryForm : Form
    {
        int ProductID;

        public PrimkeProductHistoryForm()
        {
            InitializeComponent();
        }
        public PrimkeProductHistoryForm(int ProductID)
        {
            InitializeComponent();
            this.ProductID = ProductID;
        }

        class PrimkaData
        {
            public int primkaID;
            public int dobavljacID;
            public double popust;
            public double porez;
            public int kolicina;
            public string? datum;
            public PrimkaData(int primkaID, double popust, double porez, int kolicina)
            {
                this.primkaID = primkaID;
                this.popust = popust;
                this.porez = porez;
                this.kolicina = kolicina;
            }
        };


        private void PrimkeProductHistoryForm_Load(object sender, EventArgs e)
        {
            List<PrimkaData> primkas = new List<PrimkaData>();
            string query = "SELECT * FROM `primke-stavke` WHERE ProizvodID = @ProizvodID";
            using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
            {
                command.Parameters.AddWithValue("@ProizvodID", ProductID);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        primkas.Add(new PrimkaData(
                            reader.GetInt32("PrimkaID"),
                            reader.GetDouble("Popust"),
                            reader.GetDouble("Porez"),
                            reader.GetInt32("BrojProizvoda")
                            ));
                    }
                    reader.Close();
                }
            }
            foreach(PrimkaData pd in primkas)
            {
                query = "SELECT * FROM primke WHERE PrimkaID = @PrimkaID";
                using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
                {
                    command.Parameters.AddWithValue("@PrimkaID", pd.primkaID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pd.dobavljacID = reader.GetInt32("DobavljacID");

                        }
                        reader.Close();
                    }
                }
            }
            foreach (PrimkaData pd in primkas)
            {
                query = "SELECT * FROM primke WHERE PrimkaID = @PrimkaID";
                using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
                {
                    command.Parameters.AddWithValue("@PrimkaID", pd.primkaID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                        }
                        reader.Close();
                    }
                }
            }

            //PrimkeProductHistoryUserControl control = new PrimkeProductHistoryUserControl(pd.primkaID, );

        }
    }
}
