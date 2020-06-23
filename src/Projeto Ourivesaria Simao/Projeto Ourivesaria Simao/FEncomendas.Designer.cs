namespace Projeto_Ourivesaria_Simao
{
    partial class FEncomendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEncomendas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filtro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ordenar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nencomenda = new System.Windows.Forms.Label();
            this.tencomenda = new System.Windows.Forms.Label();
            this.dencomenda = new System.Windows.Forms.Label();
            this.sencomenda = new System.Windows.Forms.Label();
            this.começa = new System.Windows.Forms.Label();
            this.termina = new System.Windows.Forms.Label();
            this.ne = new System.Windows.Forms.TextBox();
            this.te = new System.Windows.Forms.TextBox();
            this.de = new System.Windows.Forms.TextBox();
            this.se = new System.Windows.Forms.TextBox();
            this.ca = new System.Windows.Forms.TextBox();
            this.ta = new System.Windows.Forms.TextBox();
            this.preco = new System.Windows.Forms.TextBox();
            this.Preço = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pvporc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(671, 4);
            this.filtro.Margin = new System.Windows.Forms.Padding(4);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(132, 22);
            this.filtro.TabIndex = 39;
            this.filtro.TextChanged += new System.EventHandler(this.filtro_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(601, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "Filtrar por:";
            // 
            // ordenar
            // 
            this.ordenar.FormattingEnabled = true;
            this.ordenar.Items.AddRange(new object[] {
            "Mais Recente",
            "Mais Antigo"});
            this.ordenar.Location = new System.Drawing.Point(899, 3);
            this.ordenar.Margin = new System.Windows.Forms.Padding(4);
            this.ordenar.Name = "ordenar";
            this.ordenar.Size = new System.Drawing.Size(160, 24);
            this.ordenar.TabIndex = 37;
            this.ordenar.SelectedIndexChanged += new System.EventHandler(this.ordenar_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(813, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Ordenar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Encomendas de Clientes";
            // 
            // nencomenda
            // 
            this.nencomenda.AutoSize = true;
            this.nencomenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nencomenda.Location = new System.Drawing.Point(12, 250);
            this.nencomenda.Name = "nencomenda";
            this.nencomenda.Size = new System.Drawing.Size(135, 18);
            this.nencomenda.TabIndex = 41;
            this.nencomenda.Text = "Nome encomenda:";
            // 
            // tencomenda
            // 
            this.tencomenda.AutoSize = true;
            this.tencomenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tencomenda.Location = new System.Drawing.Point(12, 300);
            this.tencomenda.Name = "tencomenda";
            this.tencomenda.Size = new System.Drawing.Size(143, 18);
            this.tencomenda.TabIndex = 42;
            this.tencomenda.Text = "Tipo de encomenda:";
            // 
            // dencomenda
            // 
            this.dencomenda.AutoSize = true;
            this.dencomenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dencomenda.Location = new System.Drawing.Point(12, 348);
            this.dencomenda.Name = "dencomenda";
            this.dencomenda.Size = new System.Drawing.Size(182, 18);
            this.dencomenda.TabIndex = 43;
            this.dencomenda.Text = "Descrição da encomenda:";
            // 
            // sencomenda
            // 
            this.sencomenda.AutoSize = true;
            this.sencomenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sencomenda.Location = new System.Drawing.Point(12, 398);
            this.sencomenda.Name = "sencomenda";
            this.sencomenda.Size = new System.Drawing.Size(158, 18);
            this.sencomenda.TabIndex = 44;
            this.sencomenda.Text = "Status da Encomenda:";
            // 
            // começa
            // 
            this.começa.AccessibleDescription = "";
            this.começa.AccessibleName = "";
            this.começa.AutoSize = true;
            this.começa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.começa.Location = new System.Drawing.Point(804, 294);
            this.começa.Name = "começa";
            this.começa.Size = new System.Drawing.Size(105, 18);
            this.começa.TabIndex = 45;
            this.começa.Text = "Começada às:";
            // 
            // termina
            // 
            this.termina.AutoSize = true;
            this.termina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termina.Location = new System.Drawing.Point(804, 345);
            this.termina.Name = "termina";
            this.termina.Size = new System.Drawing.Size(102, 18);
            this.termina.TabIndex = 46;
            this.termina.Text = "Terminada às:";
            // 
            // ne
            // 
            this.ne.Location = new System.Drawing.Point(149, 249);
            this.ne.Name = "ne";
            this.ne.Size = new System.Drawing.Size(305, 22);
            this.ne.TabIndex = 48;
            // 
            // te
            // 
            this.te.Location = new System.Drawing.Point(158, 297);
            this.te.Name = "te";
            this.te.Size = new System.Drawing.Size(204, 22);
            this.te.TabIndex = 49;
            // 
            // de
            // 
            this.de.Location = new System.Drawing.Point(194, 346);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(474, 22);
            this.de.TabIndex = 50;
            // 
            // se
            // 
            this.se.Location = new System.Drawing.Point(176, 394);
            this.se.Name = "se";
            this.se.Size = new System.Drawing.Size(186, 22);
            this.se.TabIndex = 51;
            // 
            // ca
            // 
            this.ca.AcceptsReturn = true;
            this.ca.Location = new System.Drawing.Point(911, 294);
            this.ca.Name = "ca";
            this.ca.Size = new System.Drawing.Size(130, 22);
            this.ca.TabIndex = 52;
            // 
            // ta
            // 
            this.ta.Location = new System.Drawing.Point(910, 341);
            this.ta.Name = "ta";
            this.ta.Size = new System.Drawing.Size(131, 22);
            this.ta.TabIndex = 53;
            // 
            // preco
            // 
            this.preco.Location = new System.Drawing.Point(859, 397);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(131, 22);
            this.preco.TabIndex = 56;
            // 
            // Preço
            // 
            this.Preço.AutoSize = true;
            this.Preço.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preço.Location = new System.Drawing.Point(805, 397);
            this.Preço.Name = "Preço";
            this.Preço.Size = new System.Drawing.Size(52, 18);
            this.Preço.TabIndex = 55;
            this.Preço.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(805, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 58;
            this.label3.Text = "Preço do Orçamento:";
            // 
            // pvporc
            // 
            this.pvporc.Location = new System.Drawing.Point(958, 245);
            this.pvporc.Name = "pvporc";
            this.pvporc.Size = new System.Drawing.Size(100, 22);
            this.pvporc.TabIndex = 59;
            // 
            // FEncomendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 463);
            this.Controls.Add(this.pvporc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.Preço);
            this.Controls.Add(this.ta);
            this.Controls.Add(this.ca);
            this.Controls.Add(this.se);
            this.Controls.Add(this.de);
            this.Controls.Add(this.te);
            this.Controls.Add(this.ne);
            this.Controls.Add(this.termina);
            this.Controls.Add(this.começa);
            this.Controls.Add(this.sencomenda);
            this.Controls.Add(this.dencomenda);
            this.Controls.Add(this.tencomenda);
            this.Controls.Add(this.nencomenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ordenar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FEncomendas";
            this.Text = "Menu - Encomendas";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nencomenda;
        private System.Windows.Forms.Label tencomenda;
        private System.Windows.Forms.Label dencomenda;
        private System.Windows.Forms.Label sencomenda;
        private System.Windows.Forms.Label começa;
        private System.Windows.Forms.Label termina;
        private System.Windows.Forms.TextBox ne;
        private System.Windows.Forms.TextBox te;
        private System.Windows.Forms.TextBox de;
        private System.Windows.Forms.TextBox se;
        private System.Windows.Forms.TextBox ca;
        private System.Windows.Forms.TextBox ta;
        private System.Windows.Forms.TextBox preco;
        private System.Windows.Forms.Label Preço;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pvporc;
    }
}