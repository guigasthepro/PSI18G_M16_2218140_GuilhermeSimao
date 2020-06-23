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
    public partial class AEncomendas : Form
    {
        public void UpdateDataGrid()
        {
            try
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();
                MySqlDataAdapter myda2 = new MySqlDataAdapter($"SELECT fichascliente.nomecliente, encomendas.idencomenda, encomendas.nomeencomenda, encomendas.tipoencomenda, encomendas.descricao, encomendas.statusencomenda, encomendas.começa, encomendas.termina, encomendas.pvporc, encomendas.preco FROM encomendas LEFT JOIN fichascliente ON encomendas.nrcliente = fichascliente.nrcliente", dbcon);
                DataTable dtbl2 = new DataTable();
                myda2.Fill(dtbl2);
                dataGridView1.DataSource = dtbl2;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro : " + ex);
            }
        }
        public AEncomendas()
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
                encomenda.Text = row.Cells["idencomenda"].Value.ToString();
            }
            else
            {

            }
        }

        private void apagarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();
                string dquery;
                dquery = $"DELETE FROM encomendas WHERE idencomenda = {encomenda.Text}";
                MySqlDataAdapter de = new MySqlDataAdapter(dquery, dbcon);
                de.SelectCommand.ExecuteNonQuery();
                dbcon.Close();
                MessageBox.Show("Ficha de cliente apagada.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro : " + ex);
            }


            UpdateDataGrid();

        }

        private void ordenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordenar.SelectedItem.ToString() == "Mais Recente")
            {
                try
                {
                    string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                    MySqlConnection dbcon = new MySqlConnection(dbcr);
                    dbcon.Open();

                    MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT SELECT fichascliente.nomecliente, encomendas.idencomenda, encomendas.nomeencomenda, encomendas.tipoencomenda, encomendas.descricao, encomendas.statusencomenda, encomendas.começa, encomendas.termina, encomendas.pvporc, encomendas.preco, encomendas.data FROM encomendas LEFT JOIN fichascliente ON encomendas.nrcliente = fichascliente.nrcliente ORDER BY data DESC", dbcon);
                    DataTable dtbl = new DataTable();
                    myda.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                    dbcon.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro : " + ex);
                }

            }
            else
            {
                try
                {
                    string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                    MySqlConnection dbcon = new MySqlConnection(dbcr);
                    dbcon.Open();

                    MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT fichascliente.nomecliente, encomendas.idencomenda, encomendas.nomeencomenda, encomendas.tipoencomenda, encomendas.descricao, encomendas.statusencomenda, encomendas.começa, encomendas.termina, encomendas.pvporc, encomendas.preco, encomendas.data FROM encomendas LEFT JOIN fichascliente ON encomendas.nrcliente = fichascliente.nrcliente ORDER BY data ASC", dbcon);
                    DataTable dtbl = new DataTable();
                    myda.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                    dbcon.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro : " + ex);
                }
            }
        }

        private void filtro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();

                MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT fichascliente.nomecliente, encomendas.idencomenda, encomendas.nomeencomenda, encomendas.tipoencomenda, encomendas.descricao, encomendas.statusencomenda, encomendas.começa, encomendas.termina, encomendas.pvporc, encomendas.preco FROM encomendas LEFT JOIN fichascliente ON encomendas.nrcliente = fichascliente.nrcliente WHERE nomeencomenda LIKE '%{filtro.Text}%' OR nomecliente LIKE '%{filtro.Text}%' OR idencomenda LIKE '%{filtro.Text}%'", dbcon);
                DataTable dtbl = new DataTable();
                myda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dbcon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro : " + ex);
            }
        }
    }
}
