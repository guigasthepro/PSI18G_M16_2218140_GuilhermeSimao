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
    public partial class Oficina : Form
    {
        public Oficina()
        {
            InitializeComponent();

            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();

            MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas", dbcon);
            DataTable dtbl = new DataTable();
            myda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dbcon.Close();


        }

        private void Atribuir_Click(object sender, EventArgs e)
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";

            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();
            MySqlCommand slcmd = new MySqlCommand();
            slcmd.Connection = dbcon;
            slcmd.CommandText = $"SELECT idencomenda, statusencomenda FROM encomendas WHERE idencomenda = '{nome.Text}'";
            MySqlDataReader dr = slcmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                string status = Convert.ToString(dr["statusencomenda"]);
                dr.Close();

                if (status == "Aguardando Oficina...")
                {
                    tblabel.Visible = true;
                    esctb.Visible = true;
                    atb.Visible = true;
                }
                else
                {
                    MessageBox.Show("A encomenda ainda não está pronta para a oficina, ou já foi atribuida a um trabalhador");
                }
            }
        }

        private void transferir_Click(object sender, EventArgs e)
        {
            transfer.Visible = true;
            esctb.Visible = true;
            tblabel.Visible = true;

           
        }

        private void concluir_Click(object sender, EventArgs e)
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";

            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();
            MySqlCommand slcmd = new MySqlCommand();
            slcmd.Connection = dbcon;
            slcmd.CommandText = $"SELECT idencomenda, statusencomenda FROM encomendas WHERE idencomenda = '{nome.Text}'";
            MySqlDataReader dr = slcmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                string status = Convert.ToString(dr["statusencomenda"]);
                dr.Close();

                if (status == "No Acácio" || status == "No Felipe"|| status == "No João" || status == "No Marco")
                {
                    string updtquery = $"UPDATE encomendas SET statusencomenda=@statusencomenda , termina=@termina WHERE idencomenda = '{nome.Text}'";
                    MySqlCommand ucmd = new MySqlCommand(updtquery, dbcon);
                    ucmd.Parameters.AddWithValue("statusencomenda", "Aguardando Casa Da Moeda...");
                    ucmd.Parameters.AddWithValue("termina", DateTime.Now);
                    ucmd.ExecuteNonQuery();

                    MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas", dbcon);
                    DataTable dtbl = new DataTable();
                    myda.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                    dbcon.Close();
                    MessageBox.Show("Encomenda concluida com sucesso");

                }
                else
                {
                    MessageBox.Show("A encomenda ainda não está pronta para a oficina");
                }
            }
        }

        private void atb_Click(object sender, EventArgs e)
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";

            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();
            MySqlCommand slcmd = new MySqlCommand();
            slcmd.Connection = dbcon;
            slcmd.CommandText = $"SELECT idencomenda, statusencomenda FROM encomendas WHERE idencomenda = '{nome.Text}'";
            MySqlDataReader dr = slcmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                string status = Convert.ToString(dr["statusencomenda"]);
                dr.Close();

                if (status == "Aguardando Oficina...")
                {
                    if (esctb.SelectedItem == "Acácio")
                    {
                        string updtquery = $"UPDATE encomendas SET statusencomenda=@statusencomenda , começa=@começa WHERE idencomenda = '{nome.Text}'";
                        MySqlCommand ucmd = new MySqlCommand(updtquery, dbcon);
                        ucmd.Parameters.AddWithValue("statusencomenda", "No Acácio");
                        ucmd.Parameters.AddWithValue("começa", DateTime.Now);
                        ucmd.ExecuteNonQuery();

                        tblabel.Visible = false;
                        esctb.Visible = false;
                        atb.Visible = false;

                        MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas", dbcon);
                        DataTable dtbl = new DataTable();
                        myda.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                        dbcon.Close();

                    }
                    else if (esctb.SelectedItem == "Marco")
                    {
                        string updtquery = $"UPDATE encomendas SET statusencomenda=@statusencomenda , começa=@começa WHERE idencomenda = '{nome.Text}'";
                        MySqlCommand ucmd = new MySqlCommand(updtquery, dbcon);
                        ucmd.Parameters.AddWithValue("statusencomenda", "No Marco");
                        ucmd.Parameters.AddWithValue("começa", DateTime.Now);
                        ucmd.ExecuteNonQuery();

                        tblabel.Visible = false;
                        esctb.Visible = false;
                        atb.Visible = false;

                        MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas", dbcon);
                        DataTable dtbl = new DataTable();
                        myda.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                        dbcon.Close();



                    }
                    else if (esctb.SelectedItem == "João")
                    {
                        string updtquery = $"UPDATE encomendas SET statusencomenda=@statusencomenda , começa=@começa  WHERE idencomenda = '{nome.Text}'";
                        MySqlCommand ucmd = new MySqlCommand(updtquery, dbcon);
                        ucmd.Parameters.AddWithValue("statusencomenda", "No João");
                        ucmd.Parameters.AddWithValue("começa", DateTime.Now);
                        ucmd.ExecuteNonQuery();

                        tblabel.Visible = false;
                        esctb.Visible = false;
                        atb.Visible = false;

                        MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas", dbcon);
                        DataTable dtbl = new DataTable();
                        myda.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                        dbcon.Close();

                    }
                    else
                    {
                        string updtquery = $"UPDATE encomendas SET statusencomenda=@statusencomenda , começa=@começa  WHERE idencomenda = '{nome.Text}'";
                        MySqlCommand ucmd = new MySqlCommand(updtquery, dbcon);
                        ucmd.Parameters.AddWithValue("statusencomenda", "No Felipe");
                        ucmd.Parameters.AddWithValue("começa", DateTime.Now);
                        ucmd.ExecuteNonQuery();

                        tblabel.Visible = false;
                        esctb.Visible = false;
                        atb.Visible = false;

                        MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas", dbcon);
                        DataTable dtbl = new DataTable();
                        myda.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                        dbcon.Close();

                    }
                }
            }
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                nome.Text = row.Cells["idencomenda"].Value.ToString();

                Atribuir.Visible = true;
                concluir.Visible = true;
                transferir.Visible = true;
                ccm.Visible = true;
            }
            else
            {

            }
        }

        private void ccm_Click(object sender, EventArgs e)
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";

            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();
            MySqlCommand slcmd = new MySqlCommand();
            slcmd.Connection = dbcon;
            slcmd.CommandText = $"SELECT idencomenda, statusencomenda FROM encomendas WHERE idencomenda = '{nome.Text}'";
            MySqlDataReader dr = slcmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                string status = Convert.ToString(dr["statusencomenda"]);
                dr.Close();

                if (status == "Aguardando Casa Da Moeda...")
                {
                    string updtquery = $"UPDATE encomendas SET statusencomenda=@statusencomenda WHERE idencomenda = '{nome.Text}'";
                    MySqlCommand ucmd = new MySqlCommand(updtquery, dbcon);
                    ucmd.Parameters.AddWithValue("statusencomenda", "Aguardando PVP...");
                    ucmd.ExecuteNonQuery();

                    MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas", dbcon);
                    DataTable dtbl = new DataTable();
                    myda.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                    dbcon.Close();
                    MessageBox.Show("Casa da moeda concluida com sucesso");

                }
                else
                {
                    MessageBox.Show("A encomenda ainda não está na casa da moeda");
                }
            }
        }

        private void transfer_Click(object sender, EventArgs e)
        {

            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";

            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();
            MySqlCommand slcmd = new MySqlCommand();
            slcmd.Connection = dbcon;
            slcmd.CommandText = $"SELECT idencomenda, statusencomenda FROM encomendas WHERE idencomenda = '{nome.Text}'";
            MySqlDataReader dr = slcmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                string status = Convert.ToString(dr["statusencomenda"]);
                dr.Close();

                if (status == "No Acácio" || status == "No Marco" || status == "No João" || status == "No Felipe")
                {
                    if (esctb.SelectedItem == "Acácio")
                    {
                        string updtquery = $"UPDATE encomendas SET statusencomenda=@statusencomenda WHERE idencomenda = '{nome.Text}'";
                        MySqlCommand ucmd = new MySqlCommand(updtquery, dbcon);
                        ucmd.Parameters.AddWithValue("statusencomenda", "No Acácio");
                        ucmd.ExecuteNonQuery();

                        tblabel.Visible = false;
                        esctb.Visible = false;
                        atb.Visible = false;

                        MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas", dbcon);
                        DataTable dtbl = new DataTable();
                        myda.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                        dbcon.Close();

                        MessageBox.Show($"Encomenda transferida a Acácio com sucesso ");

                    }
                    else if (esctb.SelectedItem == "Marco")
                    {
                        string updtquery = $"UPDATE encomendas SET statusencomenda=@statusencomenda  WHERE idencomenda = '{nome.Text}'";
                        MySqlCommand ucmd = new MySqlCommand(updtquery, dbcon);
                        ucmd.Parameters.AddWithValue("statusencomenda", "No Marco");
                        ucmd.ExecuteNonQuery();

                        tblabel.Visible = false;
                        esctb.Visible = false;
                        atb.Visible = false;

                        MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas", dbcon);
                        DataTable dtbl = new DataTable();
                        myda.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                        dbcon.Close();
                        MessageBox.Show($"Encomenda transferida a Marco com sucesso ");



                    }
                    else if (esctb.SelectedItem == "João")
                    {
                        string updtquery = $"UPDATE encomendas SET statusencomenda=@statusencomenda  WHERE idencomenda = '{nome.Text}'";
                        MySqlCommand ucmd = new MySqlCommand(updtquery, dbcon);
                        ucmd.Parameters.AddWithValue("statusencomenda", "No João");
                        ucmd.ExecuteNonQuery();

                        tblabel.Visible = false;
                        esctb.Visible = false;
                        atb.Visible = false;

                        MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas", dbcon);
                        DataTable dtbl = new DataTable();
                        myda.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                        dbcon.Close();
                        MessageBox.Show($"Encomenda transferida a João com sucesso ");

                    }
                    else
                    {
                        string updtquery = $"UPDATE encomendas SET statusencomenda=@statusencomenda   WHERE idencomenda = '{nome.Text}'";
                        MySqlCommand ucmd = new MySqlCommand(updtquery, dbcon);
                        ucmd.Parameters.AddWithValue("statusencomenda", "No Felipe");
                        ucmd.ExecuteNonQuery();

                        tblabel.Visible = false;
                        esctb.Visible = false;
                        atb.Visible = false;

                        MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas", dbcon);
                        DataTable dtbl = new DataTable();
                        myda.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                        dbcon.Close();
                        MessageBox.Show($"Encomenda transferida a Felipe com sucesso ");

                    }
                }
                else
                {
                    MessageBox.Show("A encomenda ainda foi está atribuida a nenhum trabalhador");
                }
                    
            }
        }

        private void ordenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordenar.SelectedItem == "Mais Recente")
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();

                MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, descricao, statusencomenda FROM encomendas ORDER BY data DESC", dbcon);
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

                MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, descricao, statusencomenda FROM encomendas ORDER BY data ASC", dbcon);
                DataTable dtbl = new DataTable();
                myda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dbcon.Close();
            }
        }
    }
}
