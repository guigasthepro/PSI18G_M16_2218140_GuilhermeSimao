﻿using System;
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
    public partial class FEncomendas : Form
    {
        public FEncomendas()
        {
            InitializeComponent();
            try
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();
                MySqlDataAdapter myda2 = new MySqlDataAdapter($"SELECT fichascliente.nomecliente, encomendas.idencomenda, encomendas.nomeencomenda, encomendas.tipoencomenda, encomendas.descricao, encomendas.statusencomenda, encomendas.começa, encomendas.termina, encomendas.pvporc, encomendas.preco FROM encomendas LEFT JOIN fichascliente ON encomendas.nrcliente = fichascliente.nrcliente", dbcon);
                DataTable dtbl2 = new DataTable();
                myda2.Fill(dtbl2);
                dataGridView1.DataSource = dtbl2;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro : " + ex);
            }

        }

        private void ordenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordenar.SelectedItem.ToString() == "Mais Recente")
            {

                try
                {
                    string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                    MySqlConnection dbcon = new MySqlConnection(dbcr);
                    dbcon.Open();

                    MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT fichascliente.nomecliente, encomendas.idencomenda, encomendas.nomeencomenda, encomendas.tipoencomenda, encomendas.descricao, encomendas.statusencomenda, encomendas.começa, encomendas.termina, encomendas.pvporc, encomendas.preco, encomendas.data FROM encomendas LEFT JOIN fichascliente ON encomendas.nrcliente = fichascliente.nrcliente ORDER BY data DESC", dbcon);
                    DataTable dtbl = new DataTable();
                    myda.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                    dbcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex);
                }

            }
            else
            {

                try
                {
                    string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                    MySqlConnection dbcon = new MySqlConnection(dbcr);
                    dbcon.Open();

                    MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT fichascliente.nomecliente, encomendas.idencomenda, encomendas.nomeencomenda, encomendas.tipoencomenda, encomendas.descricao, encomendas.statusencomenda, encomendas.começa, encomendas.termina, encomendas.pvporc, encomendas.preco, encomendas.data FROM encomendas LEFT JOIN fichascliente ON encomendas.nrcliente = fichascliente.nrcliente ORDER BY data ASC", dbcon);
                    DataTable dtbl = new DataTable();
                    myda.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                    dbcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex);
                }

            }
        }

        private void filtro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();

                MySqlDataAdapter myda = new MySqlDataAdapter($"SELECT fichascliente.nomecliente, encomendas.idencomenda, encomendas.nomeencomenda, encomendas.tipoencomenda, encomendas.descricao, encomendas.statusencomenda, encomendas.começa, encomendas.termina, encomendas.pvporc, encomendas.preco FROM encomendas LEFT JOIN fichascliente ON encomendas.nrcliente = fichascliente.nrcliente WHERE encomendas.idencomenda LIKE '%{filtro.Text}%' OR fichascliente.nomecliente LIKE '%{filtro.Text}%'", dbcon);
                DataTable dtbl = new DataTable();
                myda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dbcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string dbcr = "datasource=127.0.0.1;port=3306;username=root;password=;database=ourivesariadb";
                MySqlConnection dbcon = new MySqlConnection(dbcr);
                dbcon.Open();

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    ne.Text = row.Cells["nomeencomenda"].Value.ToString();
                    te.Text = row.Cells["tipoencomenda"].Value.ToString();
                    de.Text = row.Cells["descricao"].Value.ToString();
                    se.Text = row.Cells["statusencomenda"].Value.ToString();
                    pvporc.Text = row.Cells["pvporc"].Value.ToString();
                    ca.Text = row.Cells["começa"].Value.ToString();
                    ta.Text = row.Cells["termina"].Value.ToString();
                    preco.Text = row.Cells["preco"].Value.ToString();
                }
                else
                {

                }
                dbcon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro : " + ex);
            }

        }
    }
}
