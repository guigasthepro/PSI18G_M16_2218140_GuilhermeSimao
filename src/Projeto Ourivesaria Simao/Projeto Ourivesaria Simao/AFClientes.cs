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
    public partial class AFClientes : Form
    {
        public void UpdateDataGrid()
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();

            MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT nrcliente,nomecliente,telefone,telefonefixo,email,morada FROM fichascliente", dbcon);
            DataTable dtbl = new DataTable();
            myda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        public AFClientes()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                apagarbtn.Visible = true;
                encomenda.Text = row.Cells["nrcliente"].Value.ToString();
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
            dquery = $"DELETE FROM fichascliente WHERE nrcliente = '{encomenda.Text}'";
            MySqlDataAdapter de = new MySqlDataAdapter(dquery, dbcon);
            de.SelectCommand.ExecuteNonQuery();
            dbcon.Close();
            MessageBox.Show("Ficha de cliente apagada.");

            UpdateDataGrid();
        }

        private void ordenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordenar.SelectedItem == "Mais Recente")
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();

                MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT nomecliente, telefone, telefonefixo, email, morada FROM fichascliente ORDER BY data DESC", dbcon);
                DataTable dtbl = new DataTable();
                myda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dbcon.Close();
            }
            else
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();

                MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT nomecliente, telefone, telefonefixo, email, morada FROM fichascliente ORDER BY data ASC", dbcon);
                DataTable dtbl = new DataTable();
                myda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dbcon.Close();
            }
        }

        private void filtro_TextChanged(object sender, EventArgs e)
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();

            MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT nomecliente, telefone, telefonefixo, email, morada FROM fichascliente WHERE nomecliente LIKE '%{filtro.Text}%' OR nrcliente LIKE '%{filtro.Text}%' OR telefone LIKE '%{filtro.Text}%'", dbcon);
            DataTable dtbl = new DataTable();
            myda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dbcon.Close();
        }
    }
}
