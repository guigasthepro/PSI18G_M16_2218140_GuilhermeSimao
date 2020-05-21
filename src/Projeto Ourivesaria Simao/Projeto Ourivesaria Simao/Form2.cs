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
        public Form2(string user)
        {
            InitializeComponent();
            username.Text = user; // Indica o nome de utilizador que está logado no programa!


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
                if (Convert.ToBoolean(dr["atendimento"]))
                {

                    gStock.Visible = false;
                    stEncomendas.Visible = false;
                    cOrçamento.Visible = false;
                    hOrçamentos.Visible = false;
                    gstocko.Visible = false;
                    aEncomendas.Visible = false;
                    aFClientes.Visible = false;
                    aOrçamentos.Visible = false;
                    rUtilizador.Visible = false;
                   
                }
                else if(Convert.ToBoolean(dr["oficina"]))
                {
                    FEncomendas.Visible = false;
                    FClientes.Visible = false;
                    cFEncomendas.Visible = false;
                    cFClientes.Visible = false;
                    cOrçamento.Visible = false;
                    hOrçamentos.Visible = false;
                    gstocko.Visible = false;
                    aEncomendas.Visible = false;
                    aFClientes.Visible = false;
                    aOrçamentos.Visible = false;
                    rUtilizador.Visible = false;
                }
                else if (Convert.ToBoolean(dr["orçamento"]))
                {
                    FEncomendas.Visible = false;
                    FClientes.Visible = false;
                    cFEncomendas.Visible = false;
                    cFClientes.Visible = false;
                    gStock.Visible = false;
                    stEncomendas.Visible = false;
                    aEncomendas.Visible = false;
                    aFClientes.Visible = false;
                    aOrçamentos.Visible = false;
                    rUtilizador.Visible = false;
                }

                else if(Convert.ToBoolean(dr["administrador"]))
                {
                    //Não acontece nada, pois ele é administrador e tem acesso a tudo!
                }


            }
            else
            {
                MessageBox.Show("Erro: Não foi encontrado username com essa nome!");
            }
            dbcon.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
        }

        private void programexit(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void criarFichaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarFichaDeCliente cfcmdi = new CriarFichaDeCliente();
            cfcmdi.MdiParent = this;
            cfcmdi.Show();

        }

        private void criarFichaEncomendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CFichaEncomenda cfemdi = new CFichaEncomenda ();
            cfemdi.MdiParent = this;
            cfemdi.Show();
        }

        private void fichaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FClientes cfmdi = new FClientes();
            cfmdi.MdiParent = this;
            cfmdi.Show();
        }

        private void fichaEncomendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FEncomendas cemdi = new FEncomendas();
            cemdi.MdiParent = this;
            cemdi.Show();
        }

        private void rUtilizador_Click(object sender, EventArgs e)
        {
            RUtilizador rutilizador = new RUtilizador();
            rutilizador.MdiParent = this;
            rutilizador.Show();
        }

        private void aEncomendas_Click(object sender, EventArgs e)
        {
            AEncomendas aencomendas = new AEncomendas();
            aencomendas.MdiParent = this;
            aencomendas.Show();
        }

        private void aFClientes_Click(object sender, EventArgs e)
        {
            AFClientes afclientes = new AFClientes();
            afclientes.MdiParent = this;
            afclientes.Show();
        }
    }
}
