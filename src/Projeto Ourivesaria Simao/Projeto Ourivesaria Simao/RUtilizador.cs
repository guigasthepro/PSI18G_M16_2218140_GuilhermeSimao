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
    public partial class RUtilizador : Form
    {
        public RUtilizador()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tipoutilizador.SelectedItem.ToString() == "atendimento")
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);//Comando que efetua a ligação a base de dados
                dbcon.Open();

                MySqlCommand slcmd = new MySqlCommand();
                slcmd.Connection = dbcon;
                slcmd.CommandText = $"SELECT * FROM login WHERE user = '{nomeutilizador.Text}'";
                MySqlDataReader dr = slcmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Já existe um utilizador com este nome!");
                }
                else
                {
                    try
                    {
                        dr.Close();
                        string insquery = "";
                        insquery = "INSERT INTO login (user,pass,atendimento,oficina,orçamento,administrador) VALUES (@user,@pass,@atendimento,@oficina,@orçamento,@administrador);";
                        MySqlCommand cmd = new MySqlCommand(insquery, dbcon);
                        cmd.Parameters.AddWithValue("@user", nomeutilizador.Text);
                        cmd.Parameters.AddWithValue("@pass", password.Text);
                        cmd.Parameters.AddWithValue("@atendimento", 1);
                        cmd.Parameters.AddWithValue("@oficina", 0);
                        cmd.Parameters.AddWithValue("@orçamento", 0);
                        cmd.Parameters.AddWithValue("@administrador", 0);
                        cmd.ExecuteNonQuery();
                        dbcon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex);
                    }
                }
                MessageBox.Show("User do antendimento criado com sucesso!");
            }
            else if (tipoutilizador.SelectedItem.ToString() == "oficina")
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);//Comando que efetua a ligação a base de dados
                dbcon.Open();

                MySqlCommand slcmd = new MySqlCommand();
                slcmd.Connection = dbcon;
                slcmd.CommandText = $"SELECT * FROM login WHERE user = '{nomeutilizador.Text}'";
                MySqlDataReader dr = slcmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Já existe um utilizador com este nome!");
                }
                else
                {
                    try
                    {
                        dr.Close();
                        string insquery = "";
                        insquery = "INSERT INTO login (user,pass,atendimento,oficina,orçamento,administrador) VALUES (@user,@pass,@atendimento,@oficina,@orçamento,@administrador);";
                        MySqlCommand cmd = new MySqlCommand(insquery, dbcon);
                        cmd.Parameters.AddWithValue("@user", nomeutilizador.Text);
                        cmd.Parameters.AddWithValue("@pass", password.Text);
                        cmd.Parameters.AddWithValue("@atendimento", 0);
                        cmd.Parameters.AddWithValue("@oficina", 1);
                        cmd.Parameters.AddWithValue("@orçamento", 0);
                        cmd.Parameters.AddWithValue("@administrador", 0);
                        cmd.ExecuteNonQuery();
                        dbcon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex);
                    }
                }
                MessageBox.Show("User da oficina criado com sucesso!");
            }
            else if (tipoutilizador.SelectedItem.ToString() == "orçamento")
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);//Comando que efetua a ligação a base de dados
                dbcon.Open();

                MySqlCommand slcmd = new MySqlCommand();
                slcmd.Connection = dbcon;
                slcmd.CommandText = $"SELECT * FROM login WHERE user = '{nomeutilizador.Text}'";
                MySqlDataReader dr = slcmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Já existe um utilizador com este nome!");
                }
                else
                {
                    try
                    {
                        dr.Close();
                        string insquery = "";
                        insquery = "INSERT INTO login (user,pass,atendimento,oficina,orçamento,administrador) VALUES (@user,@pass,@atendimento,@oficina,@orçamento,@administrador);";
                        MySqlCommand cmd = new MySqlCommand(insquery, dbcon);
                        cmd.Parameters.AddWithValue("@user", nomeutilizador.Text);
                        cmd.Parameters.AddWithValue("@pass", password.Text);
                        cmd.Parameters.AddWithValue("@atendimento", 0);
                        cmd.Parameters.AddWithValue("@oficina", 0);
                        cmd.Parameters.AddWithValue("@orçamento", 1);
                        cmd.Parameters.AddWithValue("@administrador", 0);
                        cmd.ExecuteNonQuery();
                        dbcon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex);
                    }
                }
                MessageBox.Show("User admin criado com sucesso!");
            }
            else
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);//Comando que efetua a ligação a base de dados
                dbcon.Open();

                MySqlCommand slcmd = new MySqlCommand();
                slcmd.Connection = dbcon;
                slcmd.CommandText = $"SELECT * FROM login WHERE user = '{nomeutilizador.Text}'";
                MySqlDataReader dr = slcmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Já existe um utilizador com este nome!");
                }
                else
                {
                    try
                    {
                        dr.Close();
                        string insquery = "";
                        insquery = "INSERT INTO login (user, pass, atendimento, oficina, orçamento, administrador) VALUES (@user, @pass, @atendimento, @oficina, @orçamento,@administrador);";
                        MySqlCommand cmd = new MySqlCommand(insquery, dbcon);
                        cmd.Parameters.AddWithValue("@user", nomeutilizador.Text);
                        cmd.Parameters.AddWithValue("@pass", password.Text);
                        cmd.Parameters.AddWithValue("@atendimento", 0);
                        cmd.Parameters.AddWithValue("@oficina", 0);
                        cmd.Parameters.AddWithValue("@orçamento", 0);
                        cmd.Parameters.AddWithValue("@administrador", 1);
                        cmd.ExecuteNonQuery();
                        dbcon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex);
                    }
                }
                MessageBox.Show("User da oficina criado com sucesso!");
            }
        }
    }
}
