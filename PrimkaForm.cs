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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gotal_manager
{
    public partial class PrimkaForm : Form
    {
        List<string> autoWords = new List<string>();
        List<int> autoWordsIDs = new List<int>();

        public PrimkaForm()
        {
            InitializeComponent();
        }

        private void PrimkaForm_Load(object sender, EventArgs e)
        {

            
            string sql = "SELECT * FROM deliverer WHERE Arhivirano=0 ORDER BY DobavljacID ASC;";
            MySqlCommand command = new MySqlCommand(sql, DatabaseManager.Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                autoWordsIDs.Add( reader.GetInt32("DobavljacID"));
                autoWords.Add(reader.GetString("Naziv"));

            }
            reader.Close();

            AutoCompleteStringCollection acs = new AutoCompleteStringCollection();
            acs.AddRange(autoWords.ToArray());
            textBoxDobavljac.AutoCompleteCustomSource = acs;

        }

        private void textBoxDobavljac_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currentText = textBoxDobavljac.Text;

            if (!char.IsControl(e.KeyChar))
            {
                currentText += e.KeyChar;
            }

            bool foundMatch = false;
            foreach (string value in autoWords)
            {
                if (value.StartsWith(currentText, StringComparison.OrdinalIgnoreCase))
                {
                    foundMatch = true;
                    break;
                }
            }

            if (!foundMatch)
            {
                e.Handled = true;
            }
        }
    }
}
