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

namespace Gotal_manager
{
    public partial class StorageUserControl : UserControl
    {
        public StorageUserControl(int _id = 0, int _sveukupnaKolicina = 0, int _razduzenaKolicina = 0, double _popust = 0)
        {
            InitializeComponent();

            //Uzima cijenu... od produkta
            string query = "SELECT * FROM products AND ProizvodID = @id";
            using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
            {
                command.Parameters.AddWithValue("@id", _id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        labelBrojProizvoda.Text = reader.GetInt32("BrojProizvoda").ToString();
                        labelNaziv.Text = reader.GetString("Naziv");
                        labelSveukupnoKomada.Text = _sveukupnaKolicina.ToString();
                        double cijena = reader.GetDouble("IzlaznaCijena");
                        labelCijena.Text = cijena.ToString()+ "€";
                        labelSveukupnoCijena.Text = (_sveukupnaKolicina * cijena).ToString() + "€";
                        labelRazduzeno.Text = _razduzenaKolicina.ToString();
                        labelRazduzenoCijena.Text=(_razduzenaKolicina*cijena).ToString()+ "€";
                        labelStanje.Text= (_sveukupnaKolicina-_razduzenaKolicina).ToString();
                        labelStanjeCijena.Text = ((_sveukupnaKolicina - _razduzenaKolicina) * cijena).ToString() + "€";
                    }
                }
            }
        }





        

    }
}
