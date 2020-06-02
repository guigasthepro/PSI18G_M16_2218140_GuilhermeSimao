namespace Projeto_Ourivesaria_Simao
{
    partial class COrçamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ordenar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.criar = new System.Windows.Forms.Button();
            this.lmetal = new System.Windows.Forms.Label();
            this.lpedras = new System.Windows.Forms.Label();
            this.lpedras1 = new System.Windows.Forms.Label();
            this.lpedras2 = new System.Windows.Forms.Label();
            this.lpedras3 = new System.Windows.Forms.Label();
            this.lpedras4 = new System.Windows.Forms.Label();
            this.lpedras5 = new System.Windows.Forms.Label();
            this.lfundicao = new System.Windows.Forms.Label();
            this.lfeitio = new System.Windows.Forms.Label();
            this.lcravacao = new System.Windows.Forms.Label();
            this.lbanho = new System.Windows.Forms.Label();
            this.lincm = new System.Windows.Forms.Label();
            this.labertura = new System.Windows.Forms.Label();
            this.lpolimento = new System.Windows.Forms.Label();
            this.qtd = new System.Windows.Forms.Label();
            this.qtd1 = new System.Windows.Forms.Label();
            this.metal = new System.Windows.Forms.TextBox();
            this.fundicao = new System.Windows.Forms.TextBox();
            this.feitio = new System.Windows.Forms.TextBox();
            this.cravacao = new System.Windows.Forms.TextBox();
            this.polimento = new System.Windows.Forms.TextBox();
            this.banhoródio = new System.Windows.Forms.TextBox();
            this.incm = new System.Windows.Forms.TextBox();
            this.abertura = new System.Windows.Forms.TextBox();
            this.pedras = new System.Windows.Forms.TextBox();
            this.pedras1 = new System.Windows.Forms.TextBox();
            this.pedras2 = new System.Windows.Forms.TextBox();
            this.pedras3 = new System.Windows.Forms.TextBox();
            this.pedras4 = new System.Windows.Forms.TextBox();
            this.pedras5 = new System.Windows.Forms.TextBox();
            this.ppedras5 = new System.Windows.Forms.TextBox();
            this.ppedras4 = new System.Windows.Forms.TextBox();
            this.ppedras3 = new System.Windows.Forms.TextBox();
            this.ppedras2 = new System.Windows.Forms.TextBox();
            this.ppedras1 = new System.Windows.Forms.TextBox();
            this.ppedras = new System.Windows.Forms.TextBox();
            this.pabertura = new System.Windows.Forms.TextBox();
            this.pincm = new System.Windows.Forms.TextBox();
            this.pbanho = new System.Windows.Forms.TextBox();
            this.ppolimento = new System.Windows.Forms.TextBox();
            this.pcravacao = new System.Windows.Forms.TextBox();
            this.pfeitio = new System.Windows.Forms.TextBox();
            this.pfundicao = new System.Windows.Forms.TextBox();
            this.pmetal = new System.Windows.Forms.TextBox();
            this.lppolimento = new System.Windows.Forms.Label();
            this.lpabertura = new System.Windows.Forms.Label();
            this.lpincm = new System.Windows.Forms.Label();
            this.lpbanho = new System.Windows.Forms.Label();
            this.lpcravacao = new System.Windows.Forms.Label();
            this.lpfeitio = new System.Windows.Forms.Label();
            this.lpfundicao = new System.Windows.Forms.Label();
            this.lppedras5 = new System.Windows.Forms.Label();
            this.lppedras4 = new System.Windows.Forms.Label();
            this.lppedras3 = new System.Windows.Forms.Label();
            this.lppedras2 = new System.Windows.Forms.Label();
            this.lppedras1 = new System.Windows.Forms.Label();
            this.lppedras = new System.Windows.Forms.Label();
            this.lpmetal = new System.Windows.Forms.Label();
            this.lpreco1 = new System.Windows.Forms.Label();
            this.lpreco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.mpreco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ordenar
            // 
            this.ordenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ordenar.FormattingEnabled = true;
            this.ordenar.Items.AddRange(new object[] {
            "Mais Recente",
            "Mais Antigo"});
            this.ordenar.Location = new System.Drawing.Point(955, 2);
            this.ordenar.Name = "ordenar";
            this.ordenar.Size = new System.Drawing.Size(121, 21);
            this.ordenar.TabIndex = 40;
            this.ordenar.SelectedIndexChanged += new System.EventHandler(this.ordenar_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(885, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ordenar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Orçamentos a fazer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(1, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 150);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // criar
            // 
            this.criar.Location = new System.Drawing.Point(483, 425);
            this.criar.Name = "criar";
            this.criar.Size = new System.Drawing.Size(75, 23);
            this.criar.TabIndex = 43;
            this.criar.Text = "Criar";
            this.criar.UseVisualStyleBackColor = true;
            this.criar.Visible = false;
            this.criar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lmetal
            // 
            this.lmetal.AutoSize = true;
            this.lmetal.Location = new System.Drawing.Point(12, 239);
            this.lmetal.Name = "lmetal";
            this.lmetal.Size = new System.Drawing.Size(33, 13);
            this.lmetal.TabIndex = 44;
            this.lmetal.Text = "Metal";
            this.lmetal.Visible = false;
            // 
            // lpedras
            // 
            this.lpedras.AutoSize = true;
            this.lpedras.Location = new System.Drawing.Point(12, 269);
            this.lpedras.Name = "lpedras";
            this.lpedras.Size = new System.Drawing.Size(40, 13);
            this.lpedras.TabIndex = 45;
            this.lpedras.Text = "Pedras";
            this.lpedras.Visible = false;
            // 
            // lpedras1
            // 
            this.lpedras1.AutoSize = true;
            this.lpedras1.Location = new System.Drawing.Point(12, 299);
            this.lpedras1.Name = "lpedras1";
            this.lpedras1.Size = new System.Drawing.Size(46, 13);
            this.lpedras1.TabIndex = 46;
            this.lpedras1.Text = "Pedras1";
            this.lpedras1.Visible = false;
            // 
            // lpedras2
            // 
            this.lpedras2.AutoSize = true;
            this.lpedras2.Location = new System.Drawing.Point(12, 329);
            this.lpedras2.Name = "lpedras2";
            this.lpedras2.Size = new System.Drawing.Size(46, 13);
            this.lpedras2.TabIndex = 47;
            this.lpedras2.Text = "Pedras2";
            this.lpedras2.Visible = false;
            // 
            // lpedras3
            // 
            this.lpedras3.AutoSize = true;
            this.lpedras3.Location = new System.Drawing.Point(12, 361);
            this.lpedras3.Name = "lpedras3";
            this.lpedras3.Size = new System.Drawing.Size(46, 13);
            this.lpedras3.TabIndex = 48;
            this.lpedras3.Text = "Pedras3";
            this.lpedras3.Visible = false;
            // 
            // lpedras4
            // 
            this.lpedras4.AutoSize = true;
            this.lpedras4.Location = new System.Drawing.Point(13, 393);
            this.lpedras4.Name = "lpedras4";
            this.lpedras4.Size = new System.Drawing.Size(46, 13);
            this.lpedras4.TabIndex = 49;
            this.lpedras4.Text = "Pedras4";
            this.lpedras4.Visible = false;
            // 
            // lpedras5
            // 
            this.lpedras5.AutoSize = true;
            this.lpedras5.Location = new System.Drawing.Point(13, 425);
            this.lpedras5.Name = "lpedras5";
            this.lpedras5.Size = new System.Drawing.Size(46, 13);
            this.lpedras5.TabIndex = 50;
            this.lpedras5.Text = "Pedras5";
            this.lpedras5.Visible = false;
            // 
            // lfundicao
            // 
            this.lfundicao.AutoSize = true;
            this.lfundicao.Location = new System.Drawing.Point(171, 239);
            this.lfundicao.Name = "lfundicao";
            this.lfundicao.Size = new System.Drawing.Size(51, 13);
            this.lfundicao.TabIndex = 51;
            this.lfundicao.Text = "Fundição";
            this.lfundicao.Visible = false;
            // 
            // lfeitio
            // 
            this.lfeitio.AutoSize = true;
            this.lfeitio.Location = new System.Drawing.Point(171, 269);
            this.lfeitio.Name = "lfeitio";
            this.lfeitio.Size = new System.Drawing.Size(32, 13);
            this.lfeitio.TabIndex = 52;
            this.lfeitio.Text = "Feitio";
            this.lfeitio.Visible = false;
            // 
            // lcravacao
            // 
            this.lcravacao.AutoSize = true;
            this.lcravacao.Location = new System.Drawing.Point(171, 300);
            this.lcravacao.Name = "lcravacao";
            this.lcravacao.Size = new System.Drawing.Size(53, 13);
            this.lcravacao.TabIndex = 53;
            this.lcravacao.Text = "Cravação";
            this.lcravacao.Visible = false;
            // 
            // lbanho
            // 
            this.lbanho.AutoSize = true;
            this.lbanho.Location = new System.Drawing.Point(171, 362);
            this.lbanho.Name = "lbanho";
            this.lbanho.Size = new System.Drawing.Size(69, 13);
            this.lbanho.TabIndex = 56;
            this.lbanho.Text = "Banho Ródio";
            this.lbanho.Visible = false;
            // 
            // lincm
            // 
            this.lincm.AutoSize = true;
            this.lincm.Location = new System.Drawing.Point(171, 395);
            this.lincm.Name = "lincm";
            this.lincm.Size = new System.Drawing.Size(30, 13);
            this.lincm.TabIndex = 57;
            this.lincm.Text = "Incm";
            this.lincm.Visible = false;
            // 
            // labertura
            // 
            this.labertura.AutoSize = true;
            this.labertura.Location = new System.Drawing.Point(171, 426);
            this.labertura.Name = "labertura";
            this.labertura.Size = new System.Drawing.Size(47, 13);
            this.labertura.TabIndex = 58;
            this.labertura.Text = "Abertura";
            this.labertura.Visible = false;
            // 
            // lpolimento
            // 
            this.lpolimento.AutoSize = true;
            this.lpolimento.Location = new System.Drawing.Point(171, 330);
            this.lpolimento.Name = "lpolimento";
            this.lpolimento.Size = new System.Drawing.Size(53, 13);
            this.lpolimento.TabIndex = 59;
            this.lpolimento.Text = "Polimento";
            this.lpolimento.Visible = false;
            // 
            // qtd
            // 
            this.qtd.AutoSize = true;
            this.qtd.Location = new System.Drawing.Point(78, 219);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(62, 13);
            this.qtd.TabIndex = 60;
            this.qtd.Text = "Quantidade";
            this.qtd.Visible = false;
            // 
            // qtd1
            // 
            this.qtd1.AutoSize = true;
            this.qtd1.Location = new System.Drawing.Point(249, 219);
            this.qtd1.Name = "qtd1";
            this.qtd1.Size = new System.Drawing.Size(62, 13);
            this.qtd1.TabIndex = 61;
            this.qtd1.Text = "Quantidade";
            this.qtd1.Visible = false;
            // 
            // metal
            // 
            this.metal.Location = new System.Drawing.Point(59, 236);
            this.metal.Name = "metal";
            this.metal.Size = new System.Drawing.Size(100, 20);
            this.metal.TabIndex = 62;
            this.metal.Visible = false;
            // 
            // fundicao
            // 
            this.fundicao.Location = new System.Drawing.Point(228, 237);
            this.fundicao.Name = "fundicao";
            this.fundicao.Size = new System.Drawing.Size(100, 20);
            this.fundicao.TabIndex = 71;
            this.fundicao.Visible = false;
            // 
            // feitio
            // 
            this.feitio.Location = new System.Drawing.Point(209, 267);
            this.feitio.Name = "feitio";
            this.feitio.Size = new System.Drawing.Size(100, 20);
            this.feitio.TabIndex = 72;
            this.feitio.Visible = false;
            // 
            // cravacao
            // 
            this.cravacao.Location = new System.Drawing.Point(228, 298);
            this.cravacao.Name = "cravacao";
            this.cravacao.Size = new System.Drawing.Size(100, 20);
            this.cravacao.TabIndex = 73;
            this.cravacao.Visible = false;
            // 
            // polimento
            // 
            this.polimento.Location = new System.Drawing.Point(228, 327);
            this.polimento.Name = "polimento";
            this.polimento.Size = new System.Drawing.Size(100, 20);
            this.polimento.TabIndex = 74;
            this.polimento.Visible = false;
            // 
            // banhoródio
            // 
            this.banhoródio.Location = new System.Drawing.Point(244, 359);
            this.banhoródio.Name = "banhoródio";
            this.banhoródio.Size = new System.Drawing.Size(100, 20);
            this.banhoródio.TabIndex = 75;
            this.banhoródio.Visible = false;
            // 
            // incm
            // 
            this.incm.Location = new System.Drawing.Point(207, 392);
            this.incm.Name = "incm";
            this.incm.Size = new System.Drawing.Size(100, 20);
            this.incm.TabIndex = 76;
            this.incm.Visible = false;
            // 
            // abertura
            // 
            this.abertura.Location = new System.Drawing.Point(224, 424);
            this.abertura.Name = "abertura";
            this.abertura.Size = new System.Drawing.Size(100, 20);
            this.abertura.TabIndex = 77;
            this.abertura.Visible = false;
            // 
            // pedras
            // 
            this.pedras.Location = new System.Drawing.Point(59, 267);
            this.pedras.Name = "pedras";
            this.pedras.Size = new System.Drawing.Size(100, 20);
            this.pedras.TabIndex = 78;
            this.pedras.Visible = false;
            // 
            // pedras1
            // 
            this.pedras1.Location = new System.Drawing.Point(58, 297);
            this.pedras1.Name = "pedras1";
            this.pedras1.Size = new System.Drawing.Size(100, 20);
            this.pedras1.TabIndex = 79;
            this.pedras1.Visible = false;
            // 
            // pedras2
            // 
            this.pedras2.Location = new System.Drawing.Point(58, 326);
            this.pedras2.Name = "pedras2";
            this.pedras2.Size = new System.Drawing.Size(100, 20);
            this.pedras2.TabIndex = 80;
            this.pedras2.Visible = false;
            // 
            // pedras3
            // 
            this.pedras3.Location = new System.Drawing.Point(58, 358);
            this.pedras3.Name = "pedras3";
            this.pedras3.Size = new System.Drawing.Size(100, 20);
            this.pedras3.TabIndex = 81;
            this.pedras3.Visible = false;
            // 
            // pedras4
            // 
            this.pedras4.Location = new System.Drawing.Point(59, 391);
            this.pedras4.Name = "pedras4";
            this.pedras4.Size = new System.Drawing.Size(100, 20);
            this.pedras4.TabIndex = 82;
            this.pedras4.Visible = false;
            // 
            // pedras5
            // 
            this.pedras5.Location = new System.Drawing.Point(59, 421);
            this.pedras5.Name = "pedras5";
            this.pedras5.Size = new System.Drawing.Size(100, 20);
            this.pedras5.TabIndex = 83;
            this.pedras5.Visible = false;
            // 
            // ppedras5
            // 
            this.ppedras5.Location = new System.Drawing.Point(780, 420);
            this.ppedras5.Name = "ppedras5";
            this.ppedras5.Size = new System.Drawing.Size(100, 20);
            this.ppedras5.TabIndex = 111;
            this.ppedras5.Visible = false;
            // 
            // ppedras4
            // 
            this.ppedras4.Location = new System.Drawing.Point(780, 390);
            this.ppedras4.Name = "ppedras4";
            this.ppedras4.Size = new System.Drawing.Size(100, 20);
            this.ppedras4.TabIndex = 110;
            this.ppedras4.Visible = false;
            // 
            // ppedras3
            // 
            this.ppedras3.Location = new System.Drawing.Point(779, 356);
            this.ppedras3.Name = "ppedras3";
            this.ppedras3.Size = new System.Drawing.Size(100, 20);
            this.ppedras3.TabIndex = 109;
            this.ppedras3.Visible = false;
            // 
            // ppedras2
            // 
            this.ppedras2.Location = new System.Drawing.Point(779, 324);
            this.ppedras2.Name = "ppedras2";
            this.ppedras2.Size = new System.Drawing.Size(100, 20);
            this.ppedras2.TabIndex = 108;
            this.ppedras2.Visible = false;
            // 
            // ppedras1
            // 
            this.ppedras1.Location = new System.Drawing.Point(779, 295);
            this.ppedras1.Name = "ppedras1";
            this.ppedras1.Size = new System.Drawing.Size(100, 20);
            this.ppedras1.TabIndex = 107;
            this.ppedras1.Visible = false;
            // 
            // ppedras
            // 
            this.ppedras.Location = new System.Drawing.Point(780, 264);
            this.ppedras.Name = "ppedras";
            this.ppedras.Size = new System.Drawing.Size(100, 20);
            this.ppedras.TabIndex = 106;
            this.ppedras.Visible = false;
            // 
            // pabertura
            // 
            this.pabertura.Location = new System.Drawing.Point(958, 423);
            this.pabertura.Name = "pabertura";
            this.pabertura.Size = new System.Drawing.Size(100, 20);
            this.pabertura.TabIndex = 105;
            this.pabertura.Visible = false;
            // 
            // pincm
            // 
            this.pincm.Location = new System.Drawing.Point(929, 389);
            this.pincm.Name = "pincm";
            this.pincm.Size = new System.Drawing.Size(100, 20);
            this.pincm.TabIndex = 104;
            this.pincm.Visible = false;
            // 
            // pbanho
            // 
            this.pbanho.Location = new System.Drawing.Point(968, 359);
            this.pbanho.Name = "pbanho";
            this.pbanho.Size = new System.Drawing.Size(100, 20);
            this.pbanho.TabIndex = 103;
            this.pbanho.Visible = false;
            // 
            // ppolimento
            // 
            this.ppolimento.Location = new System.Drawing.Point(952, 324);
            this.ppolimento.Name = "ppolimento";
            this.ppolimento.Size = new System.Drawing.Size(100, 20);
            this.ppolimento.TabIndex = 102;
            this.ppolimento.Visible = false;
            // 
            // pcravacao
            // 
            this.pcravacao.Location = new System.Drawing.Point(952, 295);
            this.pcravacao.Name = "pcravacao";
            this.pcravacao.Size = new System.Drawing.Size(100, 20);
            this.pcravacao.TabIndex = 101;
            this.pcravacao.Visible = false;
            // 
            // pfeitio
            // 
            this.pfeitio.Location = new System.Drawing.Point(931, 264);
            this.pfeitio.Name = "pfeitio";
            this.pfeitio.Size = new System.Drawing.Size(100, 20);
            this.pfeitio.TabIndex = 100;
            this.pfeitio.Visible = false;
            // 
            // pfundicao
            // 
            this.pfundicao.Location = new System.Drawing.Point(950, 233);
            this.pfundicao.Name = "pfundicao";
            this.pfundicao.Size = new System.Drawing.Size(100, 20);
            this.pfundicao.TabIndex = 99;
            this.pfundicao.Visible = false;
            // 
            // pmetal
            // 
            this.pmetal.Location = new System.Drawing.Point(780, 233);
            this.pmetal.Name = "pmetal";
            this.pmetal.Size = new System.Drawing.Size(100, 20);
            this.pmetal.TabIndex = 98;
            this.pmetal.Visible = false;
            // 
            // lppolimento
            // 
            this.lppolimento.AutoSize = true;
            this.lppolimento.Location = new System.Drawing.Point(893, 327);
            this.lppolimento.Name = "lppolimento";
            this.lppolimento.Size = new System.Drawing.Size(53, 13);
            this.lppolimento.TabIndex = 97;
            this.lppolimento.Text = "Polimento";
            this.lppolimento.Visible = false;
            // 
            // lpabertura
            // 
            this.lpabertura.AutoSize = true;
            this.lpabertura.Location = new System.Drawing.Point(893, 423);
            this.lpabertura.Name = "lpabertura";
            this.lpabertura.Size = new System.Drawing.Size(47, 13);
            this.lpabertura.TabIndex = 96;
            this.lpabertura.Text = "Abertura";
            this.lpabertura.Visible = false;
            // 
            // lpincm
            // 
            this.lpincm.AutoSize = true;
            this.lpincm.Location = new System.Drawing.Point(893, 392);
            this.lpincm.Name = "lpincm";
            this.lpincm.Size = new System.Drawing.Size(30, 13);
            this.lpincm.TabIndex = 95;
            this.lpincm.Text = "Incm";
            this.lpincm.Visible = false;
            // 
            // lpbanho
            // 
            this.lpbanho.AutoSize = true;
            this.lpbanho.Location = new System.Drawing.Point(893, 359);
            this.lpbanho.Name = "lpbanho";
            this.lpbanho.Size = new System.Drawing.Size(69, 13);
            this.lpbanho.TabIndex = 94;
            this.lpbanho.Text = "Banho Ródio";
            this.lpbanho.Visible = false;
            // 
            // lpcravacao
            // 
            this.lpcravacao.AutoSize = true;
            this.lpcravacao.Location = new System.Drawing.Point(893, 297);
            this.lpcravacao.Name = "lpcravacao";
            this.lpcravacao.Size = new System.Drawing.Size(53, 13);
            this.lpcravacao.TabIndex = 93;
            this.lpcravacao.Text = "Cravação";
            this.lpcravacao.Visible = false;
            // 
            // lpfeitio
            // 
            this.lpfeitio.AutoSize = true;
            this.lpfeitio.Location = new System.Drawing.Point(893, 266);
            this.lpfeitio.Name = "lpfeitio";
            this.lpfeitio.Size = new System.Drawing.Size(32, 13);
            this.lpfeitio.TabIndex = 92;
            this.lpfeitio.Text = "Feitio";
            this.lpfeitio.Visible = false;
            // 
            // lpfundicao
            // 
            this.lpfundicao.AutoSize = true;
            this.lpfundicao.Location = new System.Drawing.Point(893, 236);
            this.lpfundicao.Name = "lpfundicao";
            this.lpfundicao.Size = new System.Drawing.Size(51, 13);
            this.lpfundicao.TabIndex = 91;
            this.lpfundicao.Text = "Fundição";
            this.lpfundicao.Visible = false;
            // 
            // lppedras5
            // 
            this.lppedras5.AutoSize = true;
            this.lppedras5.Location = new System.Drawing.Point(734, 423);
            this.lppedras5.Name = "lppedras5";
            this.lppedras5.Size = new System.Drawing.Size(46, 13);
            this.lppedras5.TabIndex = 90;
            this.lppedras5.Text = "Pedras5";
            this.lppedras5.Visible = false;
            // 
            // lppedras4
            // 
            this.lppedras4.AutoSize = true;
            this.lppedras4.Location = new System.Drawing.Point(734, 392);
            this.lppedras4.Name = "lppedras4";
            this.lppedras4.Size = new System.Drawing.Size(46, 13);
            this.lppedras4.TabIndex = 89;
            this.lppedras4.Text = "Pedras4";
            this.lppedras4.Visible = false;
            // 
            // lppedras3
            // 
            this.lppedras3.AutoSize = true;
            this.lppedras3.Location = new System.Drawing.Point(733, 359);
            this.lppedras3.Name = "lppedras3";
            this.lppedras3.Size = new System.Drawing.Size(46, 13);
            this.lppedras3.TabIndex = 88;
            this.lppedras3.Text = "Pedras3";
            this.lppedras3.Visible = false;
            // 
            // lppedras2
            // 
            this.lppedras2.AutoSize = true;
            this.lppedras2.Location = new System.Drawing.Point(733, 327);
            this.lppedras2.Name = "lppedras2";
            this.lppedras2.Size = new System.Drawing.Size(46, 13);
            this.lppedras2.TabIndex = 87;
            this.lppedras2.Text = "Pedras2";
            this.lppedras2.Visible = false;
            // 
            // lppedras1
            // 
            this.lppedras1.AutoSize = true;
            this.lppedras1.Location = new System.Drawing.Point(733, 297);
            this.lppedras1.Name = "lppedras1";
            this.lppedras1.Size = new System.Drawing.Size(46, 13);
            this.lppedras1.TabIndex = 86;
            this.lppedras1.Text = "Pedras1";
            this.lppedras1.Visible = false;
            // 
            // lppedras
            // 
            this.lppedras.AutoSize = true;
            this.lppedras.Location = new System.Drawing.Point(733, 266);
            this.lppedras.Name = "lppedras";
            this.lppedras.Size = new System.Drawing.Size(40, 13);
            this.lppedras.TabIndex = 85;
            this.lppedras.Text = "Pedras";
            this.lppedras.Visible = false;
            // 
            // lpmetal
            // 
            this.lpmetal.AutoSize = true;
            this.lpmetal.Location = new System.Drawing.Point(733, 236);
            this.lpmetal.Name = "lpmetal";
            this.lpmetal.Size = new System.Drawing.Size(33, 13);
            this.lpmetal.TabIndex = 84;
            this.lpmetal.Text = "Metal";
            this.lpmetal.Visible = false;
            // 
            // lpreco1
            // 
            this.lpreco1.AutoSize = true;
            this.lpreco1.Location = new System.Drawing.Point(980, 215);
            this.lpreco1.Name = "lpreco1";
            this.lpreco1.Size = new System.Drawing.Size(35, 13);
            this.lpreco1.TabIndex = 113;
            this.lpreco1.Text = "Preco";
            this.lpreco1.Visible = false;
            // 
            // lpreco
            // 
            this.lpreco.AutoSize = true;
            this.lpreco.Location = new System.Drawing.Point(812, 215);
            this.lpreco.Name = "lpreco";
            this.lpreco.Size = new System.Drawing.Size(35, 13);
            this.lpreco.TabIndex = 112;
            this.lpreco.Text = "Preco";
            this.lpreco.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 114;
            this.label1.Text = "ID Encomenda:";
            // 
            // nome
            // 
            this.nome.Enabled = false;
            this.nome.Location = new System.Drawing.Point(83, 180);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(135, 20);
            this.nome.TabIndex = 115;
            // 
            // mpreco
            // 
            this.mpreco.Location = new System.Drawing.Point(462, 380);
            this.mpreco.Name = "mpreco";
            this.mpreco.Size = new System.Drawing.Size(114, 23);
            this.mpreco.TabIndex = 116;
            this.mpreco.Text = "Mudar Preço";
            this.mpreco.UseVisualStyleBackColor = true;
            this.mpreco.Visible = false;
            this.mpreco.Click += new System.EventHandler(this.mpreco_Click);
            // 
            // COrçamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 450);
            this.Controls.Add(this.mpreco);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lpreco1);
            this.Controls.Add(this.lpreco);
            this.Controls.Add(this.ppedras5);
            this.Controls.Add(this.ppedras4);
            this.Controls.Add(this.ppedras3);
            this.Controls.Add(this.ppedras2);
            this.Controls.Add(this.ppedras1);
            this.Controls.Add(this.ppedras);
            this.Controls.Add(this.pabertura);
            this.Controls.Add(this.pincm);
            this.Controls.Add(this.pbanho);
            this.Controls.Add(this.ppolimento);
            this.Controls.Add(this.pcravacao);
            this.Controls.Add(this.pfeitio);
            this.Controls.Add(this.pfundicao);
            this.Controls.Add(this.pmetal);
            this.Controls.Add(this.lppolimento);
            this.Controls.Add(this.lpabertura);
            this.Controls.Add(this.lpincm);
            this.Controls.Add(this.lpbanho);
            this.Controls.Add(this.lpcravacao);
            this.Controls.Add(this.lpfeitio);
            this.Controls.Add(this.lpfundicao);
            this.Controls.Add(this.lppedras5);
            this.Controls.Add(this.lppedras4);
            this.Controls.Add(this.lppedras3);
            this.Controls.Add(this.lppedras2);
            this.Controls.Add(this.lppedras1);
            this.Controls.Add(this.lppedras);
            this.Controls.Add(this.lpmetal);
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
            this.Controls.Add(this.criar);
            this.Controls.Add(this.ordenar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "COrçamento";
            this.Text = "COrçamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ordenar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button criar;
        private System.Windows.Forms.Label lmetal;
        private System.Windows.Forms.Label lpedras;
        private System.Windows.Forms.Label lpedras1;
        private System.Windows.Forms.Label lpedras2;
        private System.Windows.Forms.Label lpedras3;
        private System.Windows.Forms.Label lpedras4;
        private System.Windows.Forms.Label lpedras5;
        private System.Windows.Forms.Label lfundicao;
        private System.Windows.Forms.Label lfeitio;
        private System.Windows.Forms.Label lcravacao;
        private System.Windows.Forms.Label lbanho;
        private System.Windows.Forms.Label lincm;
        private System.Windows.Forms.Label labertura;
        private System.Windows.Forms.Label lpolimento;
        private System.Windows.Forms.Label qtd;
        private System.Windows.Forms.Label qtd1;
        private System.Windows.Forms.TextBox metal;
        private System.Windows.Forms.TextBox fundicao;
        private System.Windows.Forms.TextBox feitio;
        private System.Windows.Forms.TextBox cravacao;
        private System.Windows.Forms.TextBox polimento;
        private System.Windows.Forms.TextBox banhoródio;
        private System.Windows.Forms.TextBox incm;
        private System.Windows.Forms.TextBox abertura;
        private System.Windows.Forms.TextBox pedras;
        private System.Windows.Forms.TextBox pedras1;
        private System.Windows.Forms.TextBox pedras2;
        private System.Windows.Forms.TextBox pedras3;
        private System.Windows.Forms.TextBox pedras4;
        private System.Windows.Forms.TextBox pedras5;
        private System.Windows.Forms.TextBox ppedras5;
        private System.Windows.Forms.TextBox ppedras4;
        private System.Windows.Forms.TextBox ppedras3;
        private System.Windows.Forms.TextBox ppedras2;
        private System.Windows.Forms.TextBox ppedras1;
        private System.Windows.Forms.TextBox ppedras;
        private System.Windows.Forms.TextBox pabertura;
        private System.Windows.Forms.TextBox pincm;
        private System.Windows.Forms.TextBox pbanho;
        private System.Windows.Forms.TextBox ppolimento;
        private System.Windows.Forms.TextBox pcravacao;
        private System.Windows.Forms.TextBox pfeitio;
        private System.Windows.Forms.TextBox pfundicao;
        private System.Windows.Forms.TextBox pmetal;
        private System.Windows.Forms.Label lppolimento;
        private System.Windows.Forms.Label lpabertura;
        private System.Windows.Forms.Label lpincm;
        private System.Windows.Forms.Label lpbanho;
        private System.Windows.Forms.Label lpcravacao;
        private System.Windows.Forms.Label lpfeitio;
        private System.Windows.Forms.Label lpfundicao;
        private System.Windows.Forms.Label lppedras5;
        private System.Windows.Forms.Label lppedras4;
        private System.Windows.Forms.Label lppedras3;
        private System.Windows.Forms.Label lppedras2;
        private System.Windows.Forms.Label lppedras1;
        private System.Windows.Forms.Label lppedras;
        private System.Windows.Forms.Label lpmetal;
        private System.Windows.Forms.Label lpreco1;
        private System.Windows.Forms.Label lpreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Button mpreco;
    }
}