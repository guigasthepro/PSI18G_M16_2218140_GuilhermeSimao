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
        public FClientes()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";

            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();
            MySqlCommand slcmd = new MySqlCommand();
            slcmd.Connection = dbcon;
            slcmd.CommandText = $"SELECT * from fichascliente WHERE nome = '{pesquisacliente.Text}'";
            MySqlDataReader dr = slcmd.ExecuteReader();
                
            if(dr.HasRows)
            {
                dr.Read();
                nomepesquisa.Text = Convert.ToString(dr["nome"]);
                telefonepesquisa.Text = Convert.ToString(dr["telefone"]);
                telefonefixopesquisa.Text = Convert.ToString(dr["telefonefixo"]);
                emailpesquisa.Text = Convert.ToString(dr["email"]);
                moradapesquisa.Text = Convert.ToString(dr["morada"]);
            }
            else
            {
                MessageBox.Show("Ficha de cliente não foi encontrada, verifique se o cliente já tem uma ficha registada!");
            }
        }

        private void Afi(object sender, EventArgs e)
        {

        }
    }
}
