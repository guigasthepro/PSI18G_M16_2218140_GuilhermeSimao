namespace Projeto_Ourivesaria_Simao
{
    partial class HOrçamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOrçamento));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filtro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ordenar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pedras5 = new System.Windows.Forms.TextBox();
            this.pedras4 = new System.Windows.Forms.TextBox();
            this.pedras3 = new System.Windows.Forms.TextBox();
            this.pedras2 = new System.Windows.Forms.TextBox();
            this.pedras1 = new System.Windows.Forms.TextBox();
            this.pedras = new System.Windows.Forms.TextBox();
            this.abertura = new System.Windows.Forms.TextBox();
            this.incm = new System.Windows.Forms.TextBox();
            this.banhoródio = new System.Windows.Forms.TextBox();
            this.polimento = new System.Windows.Forms.TextBox();
            this.cravacao = new System.Windows.Forms.TextBox();
            this.feitio = new System.Windows.Forms.TextBox();
            this.fundicao = new System.Windows.Forms.TextBox();
            this.metal = new System.Windows.Forms.TextBox();
            this.qtd1 = new System.Windows.Forms.Label();
            this.qtd = new System.Windows.Forms.Label();
            this.lpolimento = new System.Windows.Forms.Label();
            this.labertura = new System.Windows.Forms.Label();
            this.lincm = new System.Windows.Forms.Label();
            this.lbanho = new System.Windows.Forms.Label();
            this.lcravacao = new System.Windows.Forms.Label();
            this.lfeitio = new System.Windows.Forms.Label();
            this.lfundicao = new System.Windows.Forms.Label();
            this.lpedras5 = new System.Windows.Forms.Label();
            this.lpedras4 = new System.Windows.Forms.Label();
            this.lpedras3 = new System.Windows.Forms.Label();
            this.lpedras2 = new System.Windows.Forms.Label();
            this.lpedras1 = new System.Windows.Forms.Label();
            this.lpedras = new System.Windows.Forms.Label();
            this.lmetal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.preco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 150);
            this.dataGridView1.TabIndex = 84;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(783, 3);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(100, 20);
            this.filtro.TabIndex = 119;
            this.filtro.TextChanged += new System.EventHandler(this.filtro_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(728, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 118;
            this.label10.Text = "Filtrar por:";
            // 
            // ordenar
            // 
            this.ordenar.FormattingEnabled = true;
            this.ordenar.Items.AddRange(new object[] {
            "Mais Recente",
            "Mais Antigo"});
            this.ordenar.Location = new System.Drawing.Point(957, 2);
            this.ordenar.Name = "ordenar";
            this.ordenar.Size = new System.Drawing.Size(121, 21);
            this.ordenar.TabIndex = 117;
            this.ordenar.SelectedIndexChanged += new System.EventHandler(this.ordenar_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(889, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 116;
            this.label8.Text = "Ordenar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 115;
            this.label2.Text = "Lista de orçamentos";
            // 
            // pedras5
            // 
            this.pedras5.Location = new System.Drawing.Point(59, 399);
            this.pedras5.Name = "pedras5";
            this.pedras5.Size = new System.Drawing.Size(100, 20);
            this.pedras5.TabIndex = 149;
            this.pedras5.Visible = false;
            // 
            // pedras4
            // 
            this.pedras4.Location = new System.Drawing.Point(59, 369);
            this.pedras4.Name = "pedras4";
            this.pedras4.Size = new System.Drawing.Size(100, 20);
            this.pedras4.TabIndex = 148;
            this.pedras4.Visible = false;
            // 
            // pedras3
            // 
            this.pedras3.Location = new System.Drawing.Point(58, 336);
            this.pedras3.Name = "pedras3";
            this.pedras3.Size = new System.Drawing.Size(100, 20);
            this.pedras3.TabIndex = 147;
            this.pedras3.Visible = false;
            // 
            // pedras2
            // 
            this.pedras2.Location = new System.Drawing.Point(58, 304);
            this.pedras2.Name = "pedras2";
            this.pedras2.Size = new System.Drawing.Size(100, 20);
            this.pedras2.TabIndex = 146;
            this.pedras2.Visible = false;
            // 
            // pedras1
            // 
            this.pedras1.Location = new System.Drawing.Point(58, 275);
            this.pedras1.Name = "pedras1";
            this.pedras1.Size = new System.Drawing.Size(100, 20);
            this.pedras1.TabIndex = 145;
            this.pedras1.Visible = false;
            // 
            // pedras
            // 
            this.pedras.Location = new System.Drawing.Point(59, 245);
            this.pedras.Name = "pedras";
            this.pedras.Size = new System.Drawing.Size(100, 20);
            this.pedras.TabIndex = 144;
            this.pedras.Visible = false;
            // 
            // abertura
            // 
            this.abertura.Location = new System.Drawing.Point(224, 402);
            this.abertura.Name = "abertura";
            this.abertura.Size = new System.Drawing.Size(100, 20);
            this.abertura.TabIndex = 143;
            this.abertura.Visible = false;
            // 
            // incm
            // 
            this.incm.Location = new System.Drawing.Point(207, 370);
            this.incm.Name = "incm";
            this.incm.Size = new System.Drawing.Size(100, 20);
            this.incm.TabIndex = 142;
            this.incm.Visible = false;
            // 
            // banhoródio
            // 
            this.banhoródio.Location = new System.Drawing.Point(244, 337);
            this.banhoródio.Name = "banhoródio";
            this.banhoródio.Size = new System.Drawing.Size(100, 20);
            this.banhoródio.TabIndex = 141;
            this.banhoródio.Visible = false;
            // 
            // polimento
            // 
            this.polimento.Location = new System.Drawing.Point(228, 305);
            this.polimento.Name = "polimento";
            this.polimento.Size = new System.Drawing.Size(100, 20);
            this.polimento.TabIndex = 140;
            this.polimento.Visible = false;
            // 
            // cravacao
            // 
            this.cravacao.Location = new System.Drawing.Point(228, 276);
            this.cravacao.Name = "cravacao";
            this.cravacao.Size = new System.Drawing.Size(100, 20);
            this.cravacao.TabIndex = 139;
            this.cravacao.Visible = false;
            // 
            // feitio
            // 
            this.feitio.Location = new System.Drawing.Point(209, 245);
            this.feitio.Name = "feitio";
            this.feitio.Size = new System.Drawing.Size(100, 20);
            this.feitio.TabIndex = 138;
            this.feitio.Visible = false;
            // 
            // fundicao
            // 
            this.fundicao.Location = new System.Drawing.Point(228, 215);
            this.fundicao.Name = "fundicao";
            this.fundicao.Size = new System.Drawing.Size(100, 20);
            this.fundicao.TabIndex = 137;
            this.fundicao.Visible = false;
            // 
            // metal
            // 
            this.metal.Location = new System.Drawing.Point(59, 214);
            this.metal.Name = "metal";
            this.metal.Size = new System.Drawing.Size(100, 20);
            this.metal.TabIndex = 136;
            this.metal.Visible = false;
            // 
            // qtd1
            // 
            this.qtd1.AutoSize = true;
            this.qtd1.Location = new System.Drawing.Point(249, 197);
            this.qtd1.Name = "qtd1";
            this.qtd1.Size = new System.Drawing.Size(62, 13);
            this.qtd1.TabIndex = 135;
            this.qtd1.Text = "Quantidade";
            this.qtd1.Visible = false;
            // 
            // qtd
            // 
            this.qtd.AutoSize = true;
            this.qtd.Location = new System.Drawing.Point(78, 197);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(62, 13);
            this.qtd.TabIndex = 134;
            this.qtd.Text = "Quantidade";
            this.qtd.Visible = false;
            // 
            // lpolimento
            // 
            this.lpolimento.AutoSize = true;
            this.lpolimento.Location = new System.Drawing.Point(171, 308);
            this.lpolimento.Name = "lpolimento";
            this.lpolimento.Size = new System.Drawing.Size(53, 13);
            this.lpolimento.TabIndex = 133;
            this.lpolimento.Text = "Polimento";
            this.lpolimento.Visible = false;
            // 
            // labertura
            // 
            this.labertura.AutoSize = true;
            this.labertura.Location = new System.Drawing.Point(171, 404);
            this.labertura.Name = "labertura";
            this.labertura.Size = new System.Drawing.Size(47, 13);
            this.labertura.TabIndex = 132;
            this.labertura.Text = "Abertura";
            this.labertura.Visible = false;
            // 
            // lincm
            // 
            this.lincm.AutoSize = true;
            this.lincm.Location = new System.Drawing.Point(171, 373);
            this.lincm.Name = "lincm";
            this.lincm.Size = new System.Drawing.Size(30, 13);
            this.lincm.TabIndex = 131;
            this.lincm.Text = "Incm";
            this.lincm.Visible = false;
            // 
            // lbanho
            // 
            this.lbanho.AutoSize = true;
            this.lbanho.Location = new System.Drawing.Point(171, 340);
            this.lbanho.Name = "lbanho";
            this.lbanho.Size = new System.Drawing.Size(69, 13);
            this.lbanho.TabIndex = 130;
            this.lbanho.Text = "Banho Ródio";
            this.lbanho.Visible = false;
            // 
            // lcravacao
            // 
            this.lcravacao.AutoSize = true;
            this.lcravacao.Location = new System.Drawing.Point(171, 278);
            this.lcravacao.Name = "lcravacao";
            this.lcravacao.Size = new System.Drawing.Size(53, 13);
            this.lcravacao.TabIndex = 129;
            this.lcravacao.Text = "Cravação";
            this.lcravacao.Visible = false;
            // 
            // lfeitio
            // 
            this.lfeitio.AutoSize = true;
            this.lfeitio.Location = new System.Drawing.Point(171, 247);
            this.lfeitio.Name = "lfeitio";
            this.lfeitio.Size = new System.Drawing.Size(32, 13);
            this.lfeitio.TabIndex = 128;
            this.lfeitio.Text = "Feitio";
            this.lfeitio.Visible = false;
            // 
            // lfundicao
            // 
            this.lfundicao.AutoSize = true;
            this.lfundicao.Location = new System.Drawing.Point(171, 217);
            this.lfundicao.Name = "lfundicao";
            this.lfundicao.Size = new System.Drawing.Size(51, 13);
            this.lfundicao.TabIndex = 127;
            this.lfundicao.Text = "Fundição";
            this.lfundicao.Visible = false;
            // 
            // lpedras5
            // 
            this.lpedras5.AutoSize = true;
            this.lpedras5.Location = new System.Drawing.Point(13, 403);
            this.lpedras5.Name = "lpedras5";
            this.lpedras5.Size = new System.Drawing.Size(46, 13);
            this.lpedras5.TabIndex = 126;
            this.lpedras5.Text = "Pedras5";
            this.lpedras5.Visible = false;
            // 
            // lpedras4
            // 
            this.lpedras4.AutoSize = true;
            this.lpedras4.Location = new System.Drawing.Point(13, 371);
            this.lpedras4.Name = "lpedras4";
            this.lpedras4.Size = new System.Drawing.Size(46, 13);
            this.lpedras4.TabIndex = 125;
            this.lpedras4.Text = "Pedras4";
            this.lpedras4.Visible = false;
            // 
            // lpedras3
            // 
            this.lpedras3.AutoSize = true;
            this.lpedras3.Location = new System.Drawing.Point(12, 339);
            this.lpedras3.Name = "lpedras3";
            this.lpedras3.Size = new System.Drawing.Size(46, 13);
            this.lpedras3.TabIndex = 124;
            this.lpedras3.Text = "Pedras3";
            this.lpedras3.Visible = false;
            // 
            // lpedras2
            // 
            this.lpedras2.AutoSize = true;
            this.lpedras2.Location = new System.Drawing.Point(12, 307);
            this.lpedras2.Name = "lpedras2";
            this.lpedras2.Size = new System.Drawing.Size(46, 13);
            this.lpedras2.TabIndex = 123;
            this.lpedras2.Text = "Pedras2";
            this.lpedras2.Visible = false;
            // 
            // lpedras1
            // 
            this.lpedras1.AutoSize = true;
            this.lpedras1.Location = new System.Drawing.Point(12, 277);
            this.lpedras1.Name = "lpedras1";
            this.lpedras1.Size = new System.Drawing.Size(46, 13);
            this.lpedras1.TabIndex = 122;
            this.lpedras1.Text = "Pedras1";
            this.lpedras1.Visible = false;
            // 
            // lpedras
            // 
            this.lpedras.AutoSize = true;
            this.lpedras.Location = new System.Drawing.Point(12, 247);
            this.lpedras.Name = "lpedras";
            this.lpedras.Size = new System.Drawing.Size(40, 13);
            this.lpedras.TabIndex = 121;
            this.lpedras.Text = "Pedras";
            this.lpedras.Visible = false;
            // 
            // lmetal
            // 
            this.lmetal.AutoSize = true;
            this.lmetal.Location = new System.Drawing.Point(12, 217);
            this.lmetal.Name = "lmetal";
            this.lmetal.Size = new System.Drawing.Size(33, 13);
            this.lmetal.TabIndex = 120;
            this.lmetal.Text = "Metal";
            this.lmetal.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 150;
            this.label1.Text = "Preço";
            this.label1.Visible = false;
            // 
            // preco
            // 
            this.preco.Location = new System.Drawing.Point(371, 404);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(100, 20);
            this.preco.TabIndex = 151;
            this.preco.Visible = false;
            // 
            // HOrçamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 450);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pedras5);
            this.Controls.Add(this.pedras4);
            this.Controls.Add(this.pedras3);
            this.Controls.Add(this.pedras2);
            this.Controls.Add(this.pedras1);
            this.Controls.Add(this.pedras);
            this.Controls.Add(this.abertura);
            this.Controls.Add(this.incm);
            this.Controls.Add(this.banhoródio);
            this.Controls.Add(this.polimento);
            this.Controls.Add(this.cravacao);
            this.Controls.Add(this.feitio);
            this.Controls.Add(this.fundicao);
            this.Controls.Add(this.metal);
            this.Controls.Add(this.qtd1);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.lpolimento);
            this.Controls.Add(this.labertura);
            this.Controls.Add(this.lincm);
            this.Controls.Add(this.lbanho);
            this.Controls.Add(this.lcravacao);
            this.Controls.Add(this.lfeitio);
            this.Controls.Add(this.lfundicao);
            this.Controls.Add(this.lpedras5);
            this.Controls.Add(this.lpedras4);
            this.Controls.Add(this.lpedras3);
            this.Controls.Add(this.lpedras2);
            this.Controls.Add(this.lpedras1);
            this.Controls.Add(this.lpedras);
            this.Controls.Add(this.lmetal);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ordenar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HOrçamento";
            this.Text = "Menu - Histórico de Orçamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox filtro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ordenar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pedras5;
        private System.Windows.Forms.TextBox pedras4;
        private System.Windows.Forms.TextBox pedras3;
        private System.Windows.Forms.TextBox pedras2;
        private System.Windows.Forms.TextBox pedras1;
        private System.Windows.Forms.TextBox pedras;
        private System.Windows.Forms.TextBox abertura;
        private System.Windows.Forms.TextBox incm;
        private System.Windows.Forms.TextBox banhoródio;
        private System.Windows.Forms.TextBox polimento;
        private System.Windows.Forms.TextBox cravacao;
        private System.Windows.Forms.TextBox feitio;
        private System.Windows.Forms.TextBox fundicao;
        private System.Windows.Forms.TextBox metal;
        private System.Windows.Forms.Label qtd1;
        private System.Windows.Forms.Label qtd;
        private System.Windows.Forms.Label lpolimento;
        private System.Windows.Forms.Label labertura;
        private System.Windows.Forms.Label lincm;
        private System.Windows.Forms.Label lbanho;
        private System.Windows.Forms.Label lcravacao;
        private System.Windows.Forms.Label lfeitio;
        private System.Windows.Forms.Label lfundicao;
        private System.Windows.Forms.Label lpedras5;
        private System.Windows.Forms.Label lpedras4;
        private System.Windows.Forms.Label lpedras3;
        private System.Windows.Forms.Label lpedras2;
        private System.Windows.Forms.Label lpedras1;
        private System.Windows.Forms.Label lpedras;
        private System.Windows.Forms.Label lmetal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox preco;
    }
}