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
    public partial class PVPFinal : Form
    {
        public PVPFinal()
        {
            InitializeComponent();
            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();

            MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas WHERE statusencomenda = 'Aguardando PVP...'", dbcon);
            DataTable dtbl = new DataTable();
            myda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dbcon.Close();

            metal.Text = "0";
            pedras.Text = "0";
            pedras1.Text = "0";
            pedras2.Text = "0";
            pedras3.Text = "0";
            pedras4.Text = "0";
            pedras5.Text = "0";
            fundicao.Text = "0";
            feitio.Text = "0";
            cravacao.Text = "0";
            polimento.Text = "0";
            banhoródio.Text = "0";
            incm.Text = "0";
            abertura.Text = "0";
        }

        private void ordenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordenar.SelectedItem == "Mais Recente")
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();

                MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas WHERE statusencomenda = 'Aguardando PVP...' ORDER BY data DESC", dbcon);
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

                MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas WHERE statusencomenda = 'Aguardando PVP...' ORDER BY data ASC", dbcon);
                DataTable dtbl = new DataTable();
                myda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dbcon.Close();
            }
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

            //Button
            mpreco.Visible = true;
            criar.Visible = true;

            string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";

            MySqlConnection dbcon = new MySqlConnection(dbcr);
            dbcon.Open();
            MySqlCommand slcmd = new MySqlCommand();
            slcmd.Connection = dbcon;
            slcmd.CommandText = $"SELECT * FROM porçamento;";
            MySqlDataReader dr = slcmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                pmetal.Text = Convert.ToString(dr["metal"]);
                ppedras.Text = Convert.ToString(dr["pedras"]);
                ppedras1.Text = Convert.ToString(dr["pedras1"]);
                ppedras2.Text = Convert.ToString(dr["pedras2"]);
                ppedras3.Text = Convert.ToString(dr["pedras3"]);
                ppedras4.Text = Convert.ToString(dr["pedras4"]);
                ppedras5.Text = Convert.ToString(dr["pedras5"]);
                pfundicao.Text = Convert.ToString(dr["fundicao"]);
                pfeitio.Text = Convert.ToString(dr["feitio"]);
                pcravacao.Text = Convert.ToString(dr["cravacao"]);
                ppolimento.Text = Convert.ToString(dr["polimento"]);
                pbanho.Text = Convert.ToString(dr["banhorodio"]);
                pincm.Text = Convert.ToString(dr["incm"]);
                pabertura.Text = Convert.ToString(dr["abertura"]);

            }
            else
            {
                MessageBox.Show("A tabela do preço dos orçamentos não foi encontrada!");
            }




            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                nome.Text = row.Cells["idencomenda"].Value.ToString();

            }
            else
            {

            }
            dbcon.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (criar.Text == "Aplicar")
            {

                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();
                string updtquery;
                updtquery = $"UPDATE porçamento SET metal=@metal, pedras=@pedras, pedras1=@pedras1, pedras2=@pedras2, pedras3=@pedras3, pedras4=@pedras4, pedras5=@pedras5, fundicao=@fundicao, feitio=@feitio, cravacao=@cravacao, polimento=@polimento, banhorodio=@banhorodio, incm=@incm, abertura=@abertura  WHERE precoid = '1'";
                MySqlCommand ucmd = new MySqlCommand(updtquery, dbcon);

                ucmd.Parameters.AddWithValue("@metal", Convert.ToDecimal(pmetal.Text));
                ucmd.Parameters.AddWithValue("@pedras", Convert.ToDecimal(ppedras.Text));
                ucmd.Parameters.AddWithValue("@pedras1", Convert.ToDecimal(ppedras1.Text));
                ucmd.Parameters.AddWithValue("@pedras2", Convert.ToDecimal(ppedras2.Text));
                ucmd.Parameters.AddWithValue("@pedras3", Convert.ToDecimal(ppedras3.Text));
                ucmd.Parameters.AddWithValue("@pedras4", Convert.ToDecimal(ppedras4.Text));
                ucmd.Parameters.AddWithValue("@pedras5", Convert.ToDecimal(ppedras5.Text));
                ucmd.Parameters.AddWithValue("@fundicao", Convert.ToDecimal(pfundicao.Text));
                ucmd.Parameters.AddWithValue("@feitio", Convert.ToDecimal(pfeitio.Text));
                ucmd.Parameters.AddWithValue("@cravacao", Convert.ToDecimal(pcravacao.Text));
                ucmd.Parameters.AddWithValue("@polimento", Convert.ToDecimal(ppolimento.Text));
                ucmd.Parameters.AddWithValue("@banhorodio", Convert.ToDecimal(pbanho.Text));
                ucmd.Parameters.AddWithValue("@incm", Convert.ToDecimal(pincm.Text));
                ucmd.Parameters.AddWithValue("@abertura", Convert.ToDecimal(pabertura.Text));

                ucmd.ExecuteNonQuery();

                MessageBox.Show("Valores alterados com sucesso");

                dbcon.Close();

                //Labels
                lpreco.Visible = false;
                lpreco1.Visible = false;
                lpmetal.Visible = false;
                lppedras.Visible = false;
                lppedras1.Visible = false;
                lppedras2.Visible = false;
                lppedras3.Visible = false;
                lppedras4.Visible = false;
                lppedras5.Visible = false;
                lpfundicao.Visible = false;
                lpfeitio.Visible = false;
                lpcravacao.Visible = false;
                lppolimento.Visible = false;
                lpbanho.Visible = false;
                lpincm.Visible = false;
                lpabertura.Visible = false;

                //Textboxes
                pmetal.Visible = false;
                ppedras.Visible = false;
                ppedras1.Visible = false;
                ppedras2.Visible = false;
                ppedras3.Visible = false;
                ppedras4.Visible = false;
                ppedras5.Visible = false;
                pfundicao.Visible = false;
                pfeitio.Visible = false;
                pcravacao.Visible = false;
                ppolimento.Visible = false;
                pbanho.Visible = false;
                pincm.Visible = false;
                pabertura.Visible = false;

                //Buttons
                criar.Text = "Criar";
                mpreco.Enabled = true;
            }
            else
            {


                decimal orcpvp = 0;
                try
                {
                    orcpvp = orcpvp + Convert.ToInt32(metal.Text) * Convert.ToDecimal(pmetal.Text);
                    orcpvp = orcpvp + Convert.ToInt32(pedras.Text) * Convert.ToDecimal(ppedras.Text);
                    orcpvp = orcpvp + Convert.ToInt32(pedras1.Text) * Convert.ToDecimal(ppedras1.Text);
                    orcpvp = orcpvp + Convert.ToInt32(pedras2.Text) * Convert.ToDecimal(ppedras2.Text);
                    orcpvp = orcpvp + Convert.ToInt32(pedras3.Text) * Convert.ToDecimal(ppedras3.Text);
                    orcpvp = orcpvp + Convert.ToInt32(pedras4.Text) * Convert.ToDecimal(ppedras4.Text);
                    orcpvp = orcpvp + Convert.ToInt32(pedras5.Text) * Convert.ToDecimal(ppedras5.Text);
                    orcpvp = orcpvp + Convert.ToInt32(fundicao.Text) * Convert.ToDecimal(pfundicao.Text);
                    orcpvp = orcpvp + Convert.ToInt32(feitio.Text) * Convert.ToDecimal(pfeitio.Text);
                    orcpvp = orcpvp + Convert.ToInt32(cravacao.Text) * Convert.ToDecimal(pcravacao.Text);
                    orcpvp = orcpvp + Convert.ToInt32(polimento.Text) * Convert.ToDecimal(ppolimento.Text);
                    orcpvp = orcpvp + Convert.ToInt32(banhoródio.Text) * Convert.ToDecimal(pbanho.Text);
                    orcpvp = orcpvp + Convert.ToInt32(incm.Text) * Convert.ToDecimal(pincm.Text);
                    orcpvp = orcpvp + Convert.ToInt32(abertura.Text) * Convert.ToDecimal(pabertura.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tem que inserir os numeros em todas as caixas mesmo que não tenha sido nada");
                }

                if (nome.Text == "")
                {
                    MessageBox.Show("Por favor selecione um user");
                }
                else
                {
                    string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                    MySqlConnection dbcon = new MySqlConnection(dbcr);
                    dbcon.Open();
                    string updtquery;
                    updtquery = $"UPDATE encomendas SET statusencomenda=@statusencomenda , pvporc=@pvporc  WHERE idencomenda = '{nome.Text}'";
                    MySqlCommand ucmd = new MySqlCommand(updtquery, dbcon);
                    ucmd.Parameters.AddWithValue("statusencomenda", "Concluido");
                    ucmd.Parameters.AddWithValue("pvporc", orcpvp);
                    ucmd.ExecuteNonQuery();


                    string insquery = "INSERT INTO horçamento (idencomenda,metal,pedras,pedras1,pedras2,pedras3,pedras4,pedras5,fundicao,feitio,cravacao,polimento,banhorodio,incm,abertura,preco) VALUES (@idencomenda,@metal,@pedras,@pedras1,@pedras2,@pedras3,@pedras4,@pedras5,@fundicao,@feitio,@cravacao,@polimento,@banhorodio,@incm,@abertura,@preco);";
                    MySqlCommand cmd = new MySqlCommand(insquery, dbcon);
                    cmd.Parameters.AddWithValue("@idencomenda", nome.Text);
                    cmd.Parameters.AddWithValue("@metal", metal.Text);
                    cmd.Parameters.AddWithValue("@pedras", pedras.Text);
                    cmd.Parameters.AddWithValue("@pedras1", pedras1.Text);
                    cmd.Parameters.AddWithValue("@pedras2", pedras2.Text);
                    cmd.Parameters.AddWithValue("@pedras3", pedras3.Text);
                    cmd.Parameters.AddWithValue("@pedras4", pedras4.Text);
                    cmd.Parameters.AddWithValue("@pedras5", pedras5.Text);
                    cmd.Parameters.AddWithValue("@fundicao", fundicao.Text);
                    cmd.Parameters.AddWithValue("@feitio", feitio.Text);
                    cmd.Parameters.AddWithValue("@cravacao", cravacao.Text);
                    cmd.Parameters.AddWithValue("@polimento", polimento.Text);
                    cmd.Parameters.AddWithValue("@banhorodio", banhoródio.Text);
                    cmd.Parameters.AddWithValue("@incm", incm.Text);
                    cmd.Parameters.AddWithValue("@abertura", abertura.Text);
                    cmd.Parameters.AddWithValue("@preco", orcpvp);
                    cmd.ExecuteNonQuery();

                    MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT idencomenda, nomeencomenda, tipoencomenda, descricao, statusencomenda FROM encomendas WHERE statusencomenda = 'Aguardando Orçamento...'", dbcon);
                    DataTable dtbl = new DataTable();
                    myda.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                    dbcon.Close();

                    //labels
                    qtd.Visible = false;
                    qtd1.Visible = false;
                    lmetal.Visible = false;
                    lpedras.Visible = false;
                    lpedras1.Visible = false;
                    lpedras2.Visible = false;
                    lpedras3.Visible = false;
                    lpedras4.Visible = false;
                    lpedras5.Visible = false;
                    lfundicao.Visible = false;
                    lfeitio.Visible = false;
                    lcravacao.Visible = false;
                    lpolimento.Visible = false;
                    lbanho.Visible = false;
                    lincm.Visible = false;
                    labertura.Visible = false;

                    //Textboxes
                    metal.Visible = false;
                    pedras.Visible = false;
                    pedras1.Visible = false;
                    pedras2.Visible = false;
                    pedras3.Visible = false;
                    pedras4.Visible = false;
                    pedras5.Visible = false;
                    fundicao.Visible = false;
                    feitio.Visible = false;
                    cravacao.Visible = false;
                    polimento.Visible = false;
                    banhoródio.Visible = false;
                    incm.Visible = false;
                    abertura.Visible = false;

                    //Button
                    mpreco.Visible = false;
                    criar.Visible = false;


                }
            }
        }
        private void mpreco_Click(object sender, EventArgs e)
        {
            //Labels
            lpreco.Visible = true;
            lpreco1.Visible = true;
            lpmetal.Visible = true;
            lppedras.Visible = true;
            lppedras1.Visible = true;
            lppedras2.Visible = true;
            lppedras3.Visible = true;
            lppedras4.Visible = true;
            lppedras5.Visible = true;
            lpfundicao.Visible = true;
            lpfeitio.Visible = true;
            lpcravacao.Visible = true;
            lppolimento.Visible = true;
            lpbanho.Visible = true;
            lpincm.Visible = true;
            lpabertura.Visible = true;

            //Textboxes
            pmetal.Visible = true;
            ppedras.Visible = true;
            ppedras1.Visible = true;
            ppedras2.Visible = true;
            ppedras3.Visible = true;
            ppedras4.Visible = true;
            ppedras5.Visible = true;
            pfundicao.Visible = true;
            pfeitio.Visible = true;
            pcravacao.Visible = true;
            ppolimento.Visible = true;
            pbanho.Visible = true;
            pincm.Visible = true;
            pabertura.Visible = true;

            //Buttons 
            mpreco.Enabled = false;
            criar.Text = "Aplicar";
        }
    }
}

