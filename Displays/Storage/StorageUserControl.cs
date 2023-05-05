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
                        labelID.Text=storageData.ID.ToString();
                        labelBrojProizvoda.Text = reader.GetInt32("BrojProizvoda").ToString();
                        storageData.naziv = reader.GetString("Naziv");
                        labelNaziv.Text = storageData.naziv;
                        labelSveukupnoKomada.Text = _sveukupnaKolicina+" kom.";
                        labelPopust.Text = storageData.popust + "%";
                        labelPorez.Text = storageData.porez + "%";
                        labelCijena.Text = storageData.cijena + " €";
                        labelSveukupnoCijena.Text = (_sveukupnaKolicina * storageData.cijena) + " €";
                        labelRazduzeno.Text = storageData.razduzena_kolicina+" kom.";
                        labelRazduzenoCijena.Text = (storageData.razduzena_kolicina * storageData.cijena) + " €";
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
