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
    public partial class CFichaEncomenda : Form
    {

        public void UpdateDataGrid()
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
            MySqlConnection dbcon = new MySqlConnection(dbcr);//Comando que efetua a ligação a base de dados
            dbcon.Open();
            MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT nomecliente,telefone,telefonefixo,email,morada FROM fichascliente", dbcon);
            DataTable dtbl = new DataTable();
            myda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dbcon.Close();
            
        }
        public CFichaEncomenda()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
            MySqlConnection dbcon = new MySqlConnection(dbcr);//Comando que efetua a ligação a base de dados
            dbcon.Open();

            MySqlCommand slcmd = new MySqlCommand();
            slcmd.Connection = dbcon;
            slcmd.CommandText = $"SELECT * FROM fichascliente WHERE nomecliente = '{nomecliente.Text}'";
            MySqlDataReader dr = slcmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                int nrcliente = Convert.ToInt32(dr["nrcliente"]);
                string nomecliente = Convert.ToString(dr["nomecliente"]);
                dr.Close();
      
                MySqlCommand cmd = new MySqlCommand("INSERT INTO encomendas (nomecliente,nrcliente,nomeencomenda,descricao,tipoencomenda,pedirorc,statusencomenda) VALUES (@nomecliente,@nrcliente,@nomeencomenda,@descricao,@tipoencomenda,@pedirorc,@statusencomenda);", dbcon);
                cmd.Parameters.AddWithValue("@nrcliente", nrcliente);
                cmd.Parameters.AddWithValue("@nomecliente", nomecliente);
                cmd.Parameters.AddWithValue("@nomeencomenda", nomeencomenda.Text);

                //Este if indica que tipo de encomenda ele vai inserir na base de dados
                if(Convert.ToString(tserv.SelectedIndex) == "Arranjo" )
                {
                    cmd.Parameters.AddWithValue("@tipoencomenda", "Arranjo");
                }
                else if(Convert.ToString(tserv.SelectedIndex) == "Orçamento")
                {
                    cmd.Parameters.AddWithValue("@tipoencomenda", "Orçamento");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@tipoencomenda", "Produção");
                }

                //este if vai indicar se o cliente pediu ou não orçamento
                if(Convert.ToString(confirmation.SelectedIndex) == "Sim")
                {
                    cmd.Parameters.AddWithValue("@pedirorc", "Sim");
                    cmd.Parameters.AddWithValue("@statusencomenda", "Aguardando Orçamento...");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@pedirorc", "Não");
                    cmd.Parameters.AddWithValue("@statusencomenda", "Aguardando entrada na oficina...");
                }


                cmd.Parameters.AddWithValue("@descricao", descricao.Text);
                cmd.ExecuteNonQuery();
                dbcon.Close();
                MessageBox.Show("Encomenda criada com sucesso!");
            }
            else
            {
                MessageBox.Show("O cliente não tem ficha de cliente registada, por favor crie uma!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                nomecliente.Text = row.Cells["nomecliente"].Value.ToString();
            }
            else
            {

            }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            porc.Visible = true;
            confirmation.Visible = true;
        }
    }
}
