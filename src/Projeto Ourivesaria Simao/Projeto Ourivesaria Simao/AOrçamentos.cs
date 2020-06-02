using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Ourivesaria_Simao
{
    public partial class AOrçamentos : Form
    {
        public AOrçamentos()
        {
            InitializeComponent();


            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();

            MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idorçamento, idencomenda FROM horçamento", dbcon);
            DataTable dtbl = new DataTable();
            myda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dbcon.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                orc.Text = row.Cells["idorçamento"].Value.ToString();

            }
            else
            {

            }
        }

        private void apagarbtn_Click(object sender, EventArgs e)
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();
            string dquery;
            dquery = $"DELETE FROM horçamento WHERE idorçamento = {orc.Text}";
            MySqlDataAdapter de = new MySqlDataAdapter(dquery, dbcon);
            de.SelectCommand.ExecuteNonQuery();
            dbcon.Close();
            MessageBox.Show("Ficha de cliente apagada.");

            MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idorçamento, ideencomenda FROM horçamento", dbcon);
            DataTable dtbl = new DataTable();
            myda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }
    }
}
