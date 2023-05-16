using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;
using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Gotal_manager.Displays;

namespace Gotal_manager
{
    public partial class StorageUserControl : UserControl
    {
        public StorageData storageData { get; }
        public StorageUserControl()
        {
            InitializeComponent();
        }
        public StorageUserControl(StorageData storageData, int _sveukupnaKolicina)
        {
            InitializeComponent();

            this.storageData = storageData;

            //Uzima cijenu... od produkta
            string query = "SELECT * FROM proizvodi WHERE ProizvodID = @id";
            using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
            {
                command.Parameters.AddWithValue("@id", storageData.proizvodID);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        storageData.naziv = reader.GetString("Naziv");
                        storageData.brojProizvoda = reader.GetInt32("BrojProizvoda");
                        storageData.prodajnaCijena = reader.GetInt32("IzlaznaCijena");

                        labelID.Text=storageData.ID.ToString();
                        labelBrojProizvoda.Text = storageData.brojProizvoda.ToString();
                        labelNaziv.Text = storageData.naziv;
                        labelSveukupnoKomada.Text = _sveukupnaKolicina+" kom.";
                        labelPopust.Text =Math.Round( storageData.popust, 2) + "%";
                        labelPorez.Text = Math.Round(storageData.porez, 2) + "%";
                        labelCijena.Text = Math.Round(storageData.cijena, 2) + " €";
                        labelSveukupnoCijena.Text = Math.Round(_sveukupnaKolicina * storageData.cijena,2) + " €";
                        labelRazduzeno.Text = storageData.razduzena_kolicina+" kom.";
                        labelRazduzenoCijena.Text = Math.Round(storageData.zarada ,2) + " €";
                        labelStanje.Text = (_sveukupnaKolicina - storageData.razduzena_kolicina)+" kom.";
                        labelStanjeCijena.Text = Math.Round((_sveukupnaKolicina - storageData.razduzena_kolicina) * storageData.cijena, 2) + " €";
                    }
                    reader.Close();
                }
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            PrimkeProductHistoryForm primkeProductHistoryFormform = new PrimkeProductHistoryForm(storageData);
            primkeProductHistoryFormform.ShowDialog();


        }
    }
}
