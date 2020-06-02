namespace Projeto_Ourivesaria_Simao
{
    partial class GStock
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
            this.filtro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ordenar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.remover = new System.Windows.Forms.Button();
            this.pid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editar = new System.Windows.Forms.Button();
            this.adicionar = new System.Windows.Forms.Button();
            this.lquantidade = new System.Windows.Forms.Label();
            this.lfornecedor = new System.Windows.Forms.Label();
            this.lpreco = new System.Windows.Forms.Label();
            this.tpreco = new System.Windows.Forms.TextBox();
            this.tfornecedor = new System.Windows.Forms.TextBox();
            this.tquantidade = new System.Windows.Forms.TextBox();
            this.allfunctions = new System.Windows.Forms.Button();
            this.lnome = new System.Windows.Forms.Label();
            this.tnome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(764, 3);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(100, 20);
            this.filtro.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(697, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Filtrar por:";
            // 
            // ordenar
            // 
            this.ordenar.FormattingEnabled = true;
            this.ordenar.Items.AddRange(new object[] {
            "Mais Recente",
            "Mais Antigo"});
            this.ordenar.Location = new System.Drawing.Point(954, 2);
            this.ordenar.Name = "ordenar";
            this.ordenar.Size = new System.Drawing.Size(121, 21);
            this.ordenar.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(870, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Ordenar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Lista de items";
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 150);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // remover
            // 
            this.remover.Location = new System.Drawing.Point(167, 181);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(75, 23);
            this.remover.TabIndex = 49;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = true;
            this.remover.Visible = false;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // pid
            // 
            this.pid.Enabled = false;
            this.pid.Location = new System.Drawing.Point(61, 182);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(100, 20);
            this.pid.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "ProdutoID";
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(248, 181);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 53;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Visible = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(998, 183);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(75, 23);
            this.adicionar.TabIndex = 50;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lquantidade
            // 
            this.lquantidade.AutoSize = true;
            this.lquantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lquantidade.Location = new System.Drawing.Point(2, 238);
            this.lquantidade.Name = "lquantidade";
            this.lquantidade.Size = new System.Drawing.Size(84, 16);
            this.lquantidade.TabIndex = 54;
            this.lquantidade.Text = "Quantidade: ";
            this.lquantidade.Visible = false;
            // 
            // lfornecedor
            // 
            this.lfornecedor.AutoSize = true;
            this.lfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfornecedor.Location = new System.Drawing.Point(2, 262);
            this.lfornecedor.Name = "lfornecedor";
            this.lfornecedor.Size = new System.Drawing.Size(81, 16);
            this.lfornecedor.TabIndex = 55;
            this.lfornecedor.Text = "Fornecedor:";
            this.lfornecedor.Visible = false;
            // 
            // lpreco
            // 
            this.lpreco.AutoSize = true;
            this.lpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpreco.Location = new System.Drawing.Point(2, 286);
            this.lpreco.Name = "lpreco";
            this.lpreco.Size = new System.Drawing.Size(47, 16);
            this.lpreco.TabIndex = 56;
            this.lpreco.Text = "Preço:";
            this.lpreco.Visible = false;
            // 
            // tpreco
            // 
            this.tpreco.Location = new System.Drawing.Point(52, 287);
            this.tpreco.Name = "tpreco";
            this.tpreco.Size = new System.Drawing.Size(100, 20);
            this.tpreco.TabIndex = 57;
            this.tpreco.Visible = false;
            // 
            // tfornecedor
            // 
            this.tfornecedor.Location = new System.Drawing.Point(86, 261);
            this.tfornecedor.Name = "tfornecedor";
            this.tfornecedor.Size = new System.Drawing.Size(100, 20);
            this.tfornecedor.TabIndex = 58;
            this.tfornecedor.Visible = false;
            // 
            // tquantidade
            // 
            this.tquantidade.Location = new System.Drawing.Point(86, 237);
            this.tquantidade.Name = "tquantidade";
            this.tquantidade.Size = new System.Drawing.Size(100, 20);
            this.tquantidade.TabIndex = 59;
            this.tquantidade.Visible = false;
            // 
            // allfunctions
            // 
            this.allfunctions.Location = new System.Drawing.Point(158, 287);
            this.allfunctions.Name = "allfunctions";
            this.allfunctions.Size = new System.Drawing.Size(75, 23);
            this.allfunctions.TabIndex = 60;
            this.allfunctions.Text = "name";
            this.allfunctions.UseVisualStyleBackColor = true;
            this.allfunctions.Visible = false;
            this.allfunctions.Click += new System.EventHandler(this.allfunctions_Click);
            // 
            // lnome
            // 
            this.lnome.AutoSize = true;
            this.lnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnome.Location = new System.Drawing.Point(2, 214);
            this.lnome.Name = "lnome";
            this.lnome.Size = new System.Drawing.Size(48, 16);
            this.lnome.TabIndex = 61;
            this.lnome.Text = "Nome:";
            this.lnome.Visible = false;
            // 
            // tnome
            // 
            this.tnome.Location = new System.Drawing.Point(50, 213);
            this.tnome.Name = "tnome";
            this.tnome.Size = new System.Drawing.Size(162, 20);
            this.tnome.TabIndex = 62;
            this.tnome.Visible = false;
            // 
            // GStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 327);
            this.Controls.Add(this.tnome);
            this.Controls.Add(this.lnome);
            this.Controls.Add(this.allfunctions);
            this.Controls.Add(this.tquantidade);
            this.Controls.Add(this.tfornecedor);
            this.Controls.Add(this.tpreco);
            this.Controls.Add(this.lpreco);
            this.Controls.Add(this.lfornecedor);
            this.Controls.Add(this.lquantidade);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ordenar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GStock";
            this.Text = "GStock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filtro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ordenar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Label lquantidade;
        private System.Windows.Forms.Label lfornecedor;
        private System.Windows.Forms.Label lpreco;
        private System.Windows.Forms.TextBox tpreco;
        private System.Windows.Forms.TextBox tfornecedor;
        private System.Windows.Forms.TextBox tquantidade;
        private System.Windows.Forms.Button allfunctions;
        private System.Windows.Forms.Label lnome;
        private System.Windows.Forms.TextBox tnome;
    }
}