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
    public partial class FEncomendas : Form
    {
        public FEncomendas()
        {
            InitializeComponent();

            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();
            MySqlDataAdapter myda2 = new MySqlDataAdapter($"SELECT idencomenda,nomecliente,nomeencomenda,tipoencomenda,descricao,statusencomenda FROM encomendas", dbcon);
            DataTable dtbl2 = new DataTable();
            myda2.Fill(dtbl2);
            dataGridView1.DataSource = dtbl2;
        }

        private void ordenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordenar.SelectedItem == "Mais Recente")
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();

                MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda,nomecliente, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas ORDER BY data DESC", dbcon);
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

                MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda,nomecliente, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas ORDER BY data ASC", dbcon);
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
             
            MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda,nomecliente, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas WHERE nomecliente LIKE '%{filtro.Text}%'", dbcon);
            DataTable dtbl = new DataTable();
            myda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dbcon.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                ne.Text = row.Cells["nomeencomenda"].Value.ToString();
                te.Text = row.Cells["tipoencomenda"].Value.ToString();
                de.Text = row.Cells["descricao"].Value.ToString();
                se.Text = row.Cells["statusencomenda"].Value.ToString();
                //começa.Text = row.Cells["começa"].Value.ToString();
                //termina.Text = row.Cells["termina"].Value.ToString();
            }
            else
            {

            }
            dbcon.Close();
        }
    }
}
