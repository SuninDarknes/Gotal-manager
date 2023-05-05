using Gotal_manager.Inputs.Storage.Izdatnice;
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
        Dictionary<StorageData, int> storageDatas = new Dictionary<StorageData, int>();
        public StorageForm()
        {
            InitializeComponent();
        }




        private void StorageForm_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {
            MainFlowPanel.Controls.Clear();
            storageUsers.Clear();
            storageDatas.Clear();


            string sql = "SELECT * FROM `primke-stavke`;";
            MySqlCommand command = new MySqlCommand(sql, DatabaseManager.Connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<StorageData> primke = new List<StorageData>();
            while (reader.Read())
                primke.Add(new StorageData(reader.GetInt32("ProizvodID"), reader.GetInt32("ID"), reader.GetDouble("Cijena"), reader.GetDouble("Popust"), reader.GetDouble("Porez"), reader.GetInt32("Kolicina")));
            reader.Close();


            foreach (StorageData sd in primke)
                if (storageDatas.ContainsKey(sd))
                    storageDatas[sd] += sd.kolicina;
                else storageDatas[sd] = sd.kolicina;


            foreach (KeyValuePair<StorageData, int> entry in storageDatas)
            {
                StorageUserControl userControl = new StorageUserControl(entry.Key, entry.Value);

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

        private void StorageForm_SizeChanged(object sender, EventArgs e)
        {
            MainFlowPanel.Size = new Size(1221, Size.Height - 489 + 369);
            SmallErrorLabel.Location = new Point(15, Size.Height - 489 + 426);

        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (StorageUserControl suc in MainFlowPanel.Controls)
            {
                
                if (suc.storageData.naziv.ToLower().Contains(textBoxSearch.Text.ToLower()) || textBoxSearch.Text == "")
                    suc.Visible = true;
                else suc.Visible = false;

            }
        }

        private void buttonIzdatnica_Click(object sender, EventArgs e)
        {
            IzdatnicaForm izdatnicaForm = new IzdatnicaForm(storageDatas);
            izdatnicaForm.ShowDialog();
            refreshData();
        }
    }
}
