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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);//Comando que efetua a ligação a base de dados
                dbcon.Open();
                dbcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            password.UseSystemPasswordChar = false;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";

            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();
            MySqlCommand slcmd = new MySqlCommand();
            slcmd.Connection = dbcon;
            slcmd.CommandText = $"SELECT * FROM login WHERE user = '{username.Text}'";
            MySqlDataReader dr = slcmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                if(password.Text == Convert.ToString(dr["pass"]))
                {
                    MessageBox.Show("Login com sucesso!");
                    this.Hide();
                    Form2 form2 = new Form2(username.Text);
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Palavra Passe Incorreta!");
                }
                
            }
            else
            {
                MessageBox.Show("O utilizador não se encontra registado, por favor peça a um administrador para o adicionar!");
            }
            dbcon.Close();


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
