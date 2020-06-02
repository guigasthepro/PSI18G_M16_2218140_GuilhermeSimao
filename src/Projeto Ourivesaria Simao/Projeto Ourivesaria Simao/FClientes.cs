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
    public partial class FClientes : Form
    {
        string nomeencomenda;
        string blahblah;
        public void UpdateDataGrid()
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();
            MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT nomecliente,telefone,telefonefixo,email,morada FROM fichascliente", dbcon);
            DataTable dtbl = new DataTable();
            myda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dbcon.Close();
        }
        public FClientes()
        {
            InitializeComponent();
            UpdateDataGrid();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];


                MySqlDataAdapter myda2 = new MySqlDataAdapter($"SELECT idencomenda,nomeencomenda, nomecliente, tipoencomenda, descricao, statusencomenda FROM encomendas WHERE nomecliente = '{row.Cells["nomecliente"].Value.ToString()}'", dbcon);
                DataTable dtbl2 = new DataTable();
                myda2.Fill(dtbl2);
                dataGridView2.DataSource = dtbl2;

                nomecliente.Text = row.Cells["nomecliente"].Value.ToString();
                telefonecliente.Text = row.Cells["telefone"].Value.ToString();
                telefonefcliente.Text = row.Cells["telefonefixo"].Value.ToString();
                emailcliente.Text = row.Cells["email"].Value.ToString();
                moradacliente.Text = row.Cells["morada"].Value.ToString();
                mudarbtn.Visible = true;

            }
            else
            {

            }
            dbcon.Close();
        }

        private void mudar(object sender, EventArgs e)
        { 
            telefonecliente.ReadOnly = false;
            telefonefcliente.ReadOnly = false;
            emailcliente.ReadOnly = false;
            moradacliente.ReadOnly = false;
            aplicarbtn.Visible = true;
        }

        private void aplicarbtn_Click(object sender, EventArgs e)
        {

            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();
            string updtquery;
            updtquery = $"UPDATE fichascliente SET nomecliente=@nomecliente ,telefone=@telefone, telefonefixo=@telefonefixo, email=@email, morada=@morada  WHERE nomecliente = '{nomecliente.Text}'";
            MySqlCommand ucmd = new MySqlCommand(updtquery, dbcon);

            ucmd.Parameters.AddWithValue("@nomecliente", nomecliente.Text);
            ucmd.Parameters.AddWithValue("@telefone", telefonecliente.Text);
            ucmd.Parameters.AddWithValue("@telefonefixo", telefonefcliente.Text);
            ucmd.Parameters.AddWithValue("@email", emailcliente.Text);
            ucmd.Parameters.AddWithValue("@morada", moradacliente.Text);
            ucmd.ExecuteNonQuery();
            dbcon.Close();

            UpdateDataGrid();

            nomecliente.Text = "";
            telefonecliente.Text = "";
            telefonefcliente.Text = "";
            emailcliente.Text = "";
            moradacliente.Text = "";

            nomecliente.ReadOnly = true;
            telefonecliente.ReadOnly = true;
            telefonefcliente.ReadOnly = true;
            emailcliente.ReadOnly = true;
            moradacliente.ReadOnly = true;
            aplicarbtn.Visible = false;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();

            MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT nomecliente, telefone, telefonefixo, email, morada FROM fichascliente WHERE nomecliente LIKE '%{filtro.Text}%' OR nrcliente LIKE '%{filtro.Text}%' OR telefone LIKE '%{filtro.Text}%'" , dbcon);
            DataTable dtbl = new DataTable();
            myda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dbcon.Close();
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ordenar.SelectedItem == "Mais Recente")
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


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];

                nomeencomenda = row.Cells["nomeencomenda"].Value.ToString();
                statusenc.Text = row.Cells["idencomenda"].Value.ToString();

            }
            else
            {

            }
            dbcon.Close();
        }
        public void entregue_Click(object sender, EventArgs e)
        {
            try
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";

                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();
                MySqlCommand slcmd = new MySqlCommand();
                slcmd.Connection = dbcon;
                slcmd.CommandText = $"SELECT * FROM encomendas WHERE idencomenda = '{statusenc.Text}'";
                MySqlDataReader dr = slcmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Close();
                    string updtquery;
                    updtquery = $"UPDATE encomendas SET statusencomenda=@statusencomenda WHERE idencomenda= '{statusenc.Text}'";
                    MySqlCommand ucmd = new MySqlCommand(updtquery, dbcon);
                    ucmd.Parameters.AddWithValue("@statusencomenda", "Entregue");
                    ucmd.ExecuteNonQuery();
                    dbcon.Close();
                    MessageBox.Show("A encomenda foi entregue com sucesso");
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro : " + ex);
            }
        }
    }
}
