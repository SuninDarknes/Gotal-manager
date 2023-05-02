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
            public double cijena;
            public string datum="";
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
                    while (reader.Read())
                    {
                        primkas.Add(new PrimkaData(
                            reader.GetInt32("PrimkaID"),
                            reader.GetDouble("Popust"),
                            reader.GetDouble("Porez"),
                            reader.GetInt32("Kolicina")
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
                            pd.datum = reader.GetDateTime("Datum").ToString("dd-MM-yyyy");

                        }
                        reader.Close();
                    }
                }
            }
            foreach (PrimkaData pd in primkas)
            {
                query = "SELECT * FROM products WHERE ProizvodID = @ProizvodID";
                using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
                {
                    command.Parameters.AddWithValue("@ProizvodID", ProductID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        
                        if (reader.Read())
                        {
                            pd.cijena = reader.GetDouble("UlaznaCijena");
                            
                        }
                        reader.Close();
                    }
                }
            }
            foreach (PrimkaData pd in primkas)
            {
                query = "SELECT * FROM deliverer WHERE DobavljacID = @DobavljacID";
                using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
                {
                    command.Parameters.AddWithValue("@DobavljacID", pd.dobavljacID);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            //cita se ime dobavljaca
                            PrimkeProductHistoryUserControl control = new PrimkeProductHistoryUserControl(pd.primkaID, reader.GetString("Naziv"), pd.popust, pd.porez, pd.kolicina, pd.cijena, pd.datum);
                            flowLayoutPanel1.Controls.Add(control);
                        }
                        reader.Close();
                    }
                }
            }

            

        }
    }
}
