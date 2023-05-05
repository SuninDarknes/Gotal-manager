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
        StorageData storageData;

        public PrimkeProductHistoryForm()
        {
            InitializeComponent();
        }
        public PrimkeProductHistoryForm(StorageData storageData)
        {
            InitializeComponent();
            this.storageData = storageData;
        }

        class PrimkaData
        {
            public int primkaID;
            public int dobavljacID;
            public int kolicina;
            public string datum="";
            public PrimkaData(int primkaID, int kolicina)
            {
                this.primkaID = primkaID;
                this.kolicina = kolicina;
            }
        };


        private void PrimkeProductHistoryForm_Load(object sender, EventArgs e)
        {
            
            List<PrimkaData> primkas = new List<PrimkaData>();
            string query = "SELECT * FROM `primke-stavke` WHERE ProizvodID = @ProizvodID AND Cijena = @Cijena AND Popust = @Popust AND Porez = @Porez";
            using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
            {
                command.Parameters.AddWithValue("@ProizvodID", storageData.proizvodID);
                command.Parameters.AddWithValue("@Cijena", storageData.cijena);
                command.Parameters.AddWithValue("@Popust", storageData.popust);
                command.Parameters.AddWithValue("@Porez", storageData.porez);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        primkas.Add(new PrimkaData(
                            reader.GetInt32("PrimkaID"),
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
                query = "SELECT * FROM dobavljaci WHERE DobavljacID = @DobavljacID";
                using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
                {
                    command.Parameters.AddWithValue("@DobavljacID", pd.dobavljacID);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            //cita se ime dobavljaca
                            PrimkeProductHistoryUserControl control = new PrimkeProductHistoryUserControl(pd.primkaID, reader.GetString("Naziv"), storageData.popust, storageData.porez, storageData.kolicina, storageData.cijena, pd.datum);
                            flowLayoutPanel1.Controls.Add(control);
                        }
                        reader.Close();
                    }
                }
            }

            

        }

        private void PrimkeProductHistoryForm_SizeChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Size = new Size(675, Size.Height - 474 + 395);
        }
    }
}
