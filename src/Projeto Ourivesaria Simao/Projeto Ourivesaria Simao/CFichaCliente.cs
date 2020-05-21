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
    public partial class CriarFichaDeCliente : Form
    {
        public CriarFichaDeCliente()
        {
            InitializeComponent();
        }

        private void CFichaCliente_Load(object sender, EventArgs e)
        {

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
                MessageBox.Show("Este cliente já tem uma ficha registada!");
            }
            else
            {
                dr.Close();
                string insquery = "";
                insquery = "INSERT INTO fichascliente (nomecliente,telefone,telefonefixo,email,morada) VALUES (@nomecliente,@telefone,@telefonefixo,@email,@morada);";
                MySqlCommand cmd = new MySqlCommand(insquery, dbcon);
                cmd.Parameters.AddWithValue("@nomecliente", nomecliente.Text);
                cmd.Parameters.AddWithValue("@telefone", telefonecliente.Text);
                cmd.Parameters.AddWithValue("@telefonefixo", telefonefixocliente.Text);
                cmd.Parameters.AddWithValue("@email", emailcliente.Text);
                cmd.Parameters.AddWithValue("@morada", moradacliente.Text);
                cmd.ExecuteNonQuery();
                dbcon.Close();
            }
        }
    }
}
