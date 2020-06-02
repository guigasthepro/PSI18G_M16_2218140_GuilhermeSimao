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
    public partial class HOrçamento : Form
    {
        public HOrçamento()
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

            //Labels
            qtd.Visible = true;
            qtd1.Visible = true;
            lmetal.Visible = true;
            lpedras.Visible = true;
            lpedras1.Visible = true;
            lpedras2.Visible = true;
            lpedras3.Visible = true;
            lpedras4.Visible = true;
            lpedras5.Visible = true;
            lfundicao.Visible = true;
            lfeitio.Visible = true;
            lcravacao.Visible = true;
            lpolimento.Visible = true;
            lbanho.Visible = true;
            lincm.Visible = true;
            labertura.Visible = true;
            label1.Visible = true;
            
            //Textboxes
            metal.Visible = true;
            pedras.Visible = true;
            pedras1.Visible = true;
            pedras2.Visible = true;
            pedras3.Visible = true;
            pedras4.Visible = true;
            pedras5.Visible = true;
            fundicao.Visible = true;
            feitio.Visible = true;
            cravacao.Visible = true;
            polimento.Visible = true;
            banhoródio.Visible = true;
            incm.Visible = true;
            abertura.Visible = true;
            preco.Visible = true;




            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";

                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();
                MySqlCommand slcmd = new MySqlCommand();
                slcmd.Connection = dbcon;
                slcmd.CommandText = $"SELECT * FROM horçamento WHERE idorçamento = '{row.Cells["idorçamento"].Value.ToString()}'";
                MySqlDataReader dr = slcmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    metal.Text = Convert.ToString(dr["metal"]);
                    pedras.Text = Convert.ToString(dr["pedras"]);
                    pedras1.Text = Convert.ToString(dr["pedras1"]);
                    pedras2.Text = Convert.ToString(dr["pedras2"]);
                    pedras3.Text = Convert.ToString(dr["pedras3"]);
                    pedras4.Text = Convert.ToString(dr["pedras4"]);
                    pedras5.Text = Convert.ToString(dr["pedras5"]);
                    fundicao.Text = Convert.ToString(dr["fundicao"]);
                    feitio.Text = Convert.ToString(dr["feitio"]);
                    cravacao.Text = Convert.ToString(dr["cravacao"]);
                    polimento.Text = Convert.ToString(dr["polimento"]);
                    banhoródio.Text = Convert.ToString(dr["banhorodio"]);
                    incm.Text = Convert.ToString(dr["incm"]);
                    abertura.Text = Convert.ToString(dr["abertura"]);
                    preco.Text = Convert.ToString(dr["preco"]);

                }
                else
                {
                    MessageBox.Show("A tabela do preço dos orçamentos não foi encontrada!");
                }

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

                MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas WHERE statusencomenda = 'Aguardando Orçamento...' ORDER BY data DESC", dbcon);
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

                MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas WHERE statusencomenda = 'Aguardando Orçamento...' ORDER BY data ASC", dbcon);
                DataTable dtbl = new DataTable();
                myda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dbcon.Close();
            }
        }
    }
}
