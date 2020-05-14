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
        public CFichaEncomenda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
            MySqlConnection dbcon = new MySqlConnection(dbcr);//Comando que efetua a ligação a base de dados
            dbcon.Open();

            MySqlCommand slcmd = new MySqlCommand();
            slcmd.Connection = dbcon;
            slcmd.CommandText = $"SELECT * FROM fichascliente WHERE nome = '{nomecliente.Text}'";
            MySqlDataReader dr = slcmd.ExecuteReader();

            if (dr.HasRows)
            {

                dr.Close();
                string insquery = "";
                insquery = "INSERT INTO encomendas (nomecliente,nomeencomenda,descricao,tipoencomenda) VALUES (@nomecliente,@nomeencomenda,@descricao,@tipoencomenda);";
                MySqlCommand cmd = new MySqlCommand(insquery, dbcon);
                cmd.Parameters.AddWithValue("@nomecliente", nomecliente.Text);
                cmd.Parameters.AddWithValue("@nomeencomenda", telefonecliente.Text);
                cmd.Parameters.AddWithValue("@tipoencomenda", telefonefixocliente.Text);
                cmd.Parameters.AddWithValue("@descricao", emailcliente.Text);
                cmd.Parameters.AddWithValue("@morada", moradacliente.Text);
                cmd.ExecuteNonQuery();
                dbcon.Close();
            }
            else
            {

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
