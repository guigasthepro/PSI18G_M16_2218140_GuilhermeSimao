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
    public partial class GStock : Form
    {
        int qtd;
        public GStock()
        {
            InitializeComponent();
            try
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();

                MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT produtoid, nome, quantidade, fornecedor, preço FROM stock", dbcon);
                DataTable dtbl = new DataTable();
                myda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dbcon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro:" + ex);
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            lnome.Visible = true;
            tnome.Visible = true;

            lquantidade.Visible = true;
            tquantidade.Visible = true;

            lfornecedor.Visible = true;
            tfornecedor.Visible = true;

            lpreco.Visible = true;
            tpreco.Visible = true;

            allfunctions.Text = "Adicionar";
            allfunctions.Visible = true;



        }
        private void editar_Click(object sender, EventArgs e)
        {
            lnome.Visible = false;
            tnome.Visible = false;

            lquantidade.Visible = true;
            tquantidade.Visible = true;

            lfornecedor.Visible = true;
            tfornecedor.Visible = true;

            lpreco.Visible = true;
            tpreco.Visible = true;

            allfunctions.Text = "Editar";
            allfunctions.Visible = true;
        }
        private void remover_Click(object sender, EventArgs e)
        {
            lnome.Visible = false;
            tnome.Visible = false;

            lquantidade.Visible = true;
            tquantidade.Visible = true;

            lfornecedor.Visible = false;
            tfornecedor.Visible = false;

            lpreco.Visible = false;
            tpreco.Visible = false;

            allfunctions.Text = "Remover";
            allfunctions.Visible = true;
        }



        public void allfunctions_Click(object sender, EventArgs e)
        {
            if(allfunctions.Text.ToString() == "Adicionar")
            {
                try
                {
                    string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                    MySqlConnection dbcon = new MySqlConnection(dbcr);
                    dbcon.Open();
                    string insquery = "";
                    insquery = "INSERT INTO stock (nome,Quantidade,Fornecedor,Preço) VALUES (@nome,@quantidade,@fornecedor,@preço);";
                    MySqlCommand cmd = new MySqlCommand(insquery, dbcon);
                    cmd.Parameters.AddWithValue("@nome", tnome.Text);
                    cmd.Parameters.AddWithValue("@quantidade", tquantidade.Text);
                    cmd.Parameters.AddWithValue("@fornecedor", tfornecedor.Text);
                    cmd.Parameters.AddWithValue("@preço", tpreco.Text);
                    cmd.ExecuteNonQuery();
                    dbcon.Close();
                    MessageBox.Show("Item inserido com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex);
                }

            }
            else if(allfunctions.Text.ToString() == "Editar")
            {
                try
                {
                    string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                    MySqlConnection dbcon = new MySqlConnection(dbcr);
                    dbcon.Open();
                    string updtquery = $"UPDATE stock SET quantidade=@quantidade, preço=@preço, fornecedor=@fornecedor WHERE produtoid = '{pid.Text}'";
                    MySqlCommand ucmd = new MySqlCommand(updtquery, dbcon);
                    ucmd.Parameters.AddWithValue("quantidade", tquantidade.Text);
                    ucmd.Parameters.AddWithValue("fornecedor", tfornecedor.Text);
                    ucmd.Parameters.AddWithValue("preço", tpreco.Text);
                    ucmd.ExecuteNonQuery();
                    MessageBox.Show("Item editado com sucesso");
                    dbcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex);
                }

                LoadDataGrid();

            }
            else if(allfunctions.Text.ToString() == "Remover")
            {
                try
                {
                    string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                    MySqlConnection dbcon = new MySqlConnection(dbcr);
                    dbcon.Open();
                    string updtquery = $"UPDATE stock SET quantidade=@quantidade WHERE produtoid = '{pid.Text}'";
                    MySqlCommand ucmd = new MySqlCommand(updtquery, dbcon);
                    qtd = qtd - Convert.ToInt32(tquantidade.Text);
                    ucmd.Parameters.AddWithValue("quantidade", qtd);
                    ucmd.ExecuteNonQuery();
                    MessageBox.Show("Item removido com sucesso");
                    dbcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex);
                }

                LoadDataGrid();
            }
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                pid.Text = row.Cells["produtoid"].Value.ToString();

                try
                {
                    qtd = Convert.ToInt32(row.Cells["quantidade"].Value);
                    remover.Visible = true;
                    editar.Visible = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("´Selecione um utilizador valido");
                    remover.Visible = false;
                    editar.Visible = false;
                }          
                
            }
            else
            {

            }


        }

        private void filtro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();

                MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT nome, fornecedor FROM stock WHERE nome LIKE '%{filtro.Text}%' OR fornecedor LIKE '%{filtro.Text}%'", dbcon);
                DataTable dtbl = new DataTable();
                myda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dbcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);
            }

        }

        private void ordenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordenar.SelectedItem == "Mais Recente")
            {
                try
                {
                    string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                    MySqlConnection dbcon = new MySqlConnection(dbcr);
                    dbcon.Open();

                    MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT nome, fornecedor FROM stock ORDER BY data DESC", dbcon);
                    DataTable dtbl = new DataTable();
                    myda.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                    dbcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex);
                }

            }
            else
            {
                try
                {
                    string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                    MySqlConnection dbcon = new MySqlConnection(dbcr);
                    dbcon.Open();

                    MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT nome, fornecedor FROM stock ORDER BY data ASC", dbcon);
                    DataTable dtbl = new DataTable();
                    myda.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                    dbcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex);
                }

            }
        }

        public void LoadDataGrid()
        {
            try
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();

                MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT produtoid, nome, quantidade, fornecedor, preço FROM stock", dbcon);
                DataTable dtbl = new DataTable();
                myda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dbcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);
            }

        }

    }
}
