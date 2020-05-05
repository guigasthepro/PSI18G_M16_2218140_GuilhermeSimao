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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";

            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();
            MySqlCommand slcmd = new MySqlCommand();
            slcmd.Connection = dbcon;
            slcmd.CommandText = $"SELECT * FROM login WHERE user ='" + password.Text;
            MySqlDataReader dr = slcmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                if (password.Text == Convert.ToString(dr["pass"]))
                {
                    MessageBox.Show("Login com sucesso!");
                }

            }
            else
            {
                MessageBox.Show("O utilizador não se encontra registado, por favor peça a um administrador para o adicionar!");
            }
        }
    }
}
