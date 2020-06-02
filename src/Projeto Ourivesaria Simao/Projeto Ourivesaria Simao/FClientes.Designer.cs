namespace Projeto_Ourivesaria_Simao
{
    partial class FClientes
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nomecliente = new System.Windows.Forms.TextBox();
            this.telefonecliente = new System.Windows.Forms.TextBox();
            this.telefonefcliente = new System.Windows.Forms.TextBox();
            this.emailcliente = new System.Windows.Forms.TextBox();
            this.moradacliente = new System.Windows.Forms.TextBox();
            this.mudarbtn = new System.Windows.Forms.Button();
            this.aplicarbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ordenar = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.filtro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusenc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 447);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1079, 185);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.TabStop = false;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 425);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encomendas Do Cliente:";
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
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fichas de Clientes";
            // 
            // telefone
            // 
            this.telefone.AutoSize = true;
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(4, 259);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(65, 16);
            this.telefone.TabIndex = 18;
            this.telefone.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telefone Fixo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Morada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Informações Ficha Do Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nome Do Cliente:";
            // 
            // nomecliente
            // 
            this.nomecliente.Location = new System.Drawing.Point(122, 222);
            this.nomecliente.Name = "nomecliente";
            this.nomecliente.ReadOnly = true;
            this.nomecliente.Size = new System.Drawing.Size(222, 22);
            this.nomecliente.TabIndex = 24;
            this.nomecliente.TabStop = false;
            // 
            // telefonecliente
            // 
            this.telefonecliente.Location = new System.Drawing.Point(72, 256);
            this.telefonecliente.Name = "telefonecliente";
            this.telefonecliente.ReadOnly = true;
            this.telefonecliente.Size = new System.Drawing.Size(147, 22);
            this.telefonecliente.TabIndex = 25;
            this.telefonecliente.TabStop = false;
            // 
            // telefonefcliente
            // 
            this.telefonefcliente.Location = new System.Drawing.Point(100, 298);
            this.telefonefcliente.Name = "telefonefcliente";
            this.telefonefcliente.ReadOnly = true;
            this.telefonefcliente.Size = new System.Drawing.Size(137, 22);
            this.telefonefcliente.TabIndex = 26;
            this.telefonefcliente.TabStop = false;
            // 
            // emailcliente
            // 
            this.emailcliente.Location = new System.Drawing.Point(53, 336);
            this.emailcliente.Name = "emailcliente";
            this.emailcliente.ReadOnly = true;
            this.emailcliente.Size = new System.Drawing.Size(219, 22);
            this.emailcliente.TabIndex = 27;
            this.emailcliente.TabStop = false;
            // 
            // moradacliente
            // 
            this.moradacliente.Location = new System.Drawing.Point(66, 372);
            this.moradacliente.Name = "moradacliente";
            this.moradacliente.ReadOnly = true;
            this.moradacliente.Size = new System.Drawing.Size(206, 22);
            this.moradacliente.TabIndex = 28;
            this.moradacliente.TabStop = false;
            // 
            // mudarbtn
            // 
            this.mudarbtn.Location = new System.Drawing.Point(298, 374);
            this.mudarbtn.Name = "mudarbtn";
            this.mudarbtn.Size = new System.Drawing.Size(75, 23);
            this.mudarbtn.TabIndex = 29;
            this.mudarbtn.TabStop = false;
            this.mudarbtn.Text = "Mudar";
            this.mudarbtn.UseVisualStyleBackColor = true;
            this.mudarbtn.Visible = false;
            this.mudarbtn.Click += new System.EventHandler(this.mudar);
            // 
            // aplicarbtn
            // 
            this.aplicarbtn.Location = new System.Drawing.Point(387, 374);
            this.aplicarbtn.Name = "aplicarbtn";
            this.aplicarbtn.Size = new System.Drawing.Size(75, 23);
            this.aplicarbtn.TabIndex = 30;
            this.aplicarbtn.TabStop = false;
            this.aplicarbtn.Text = "Aplicar";
            this.aplicarbtn.UseVisualStyleBackColor = true;
            this.aplicarbtn.Visible = false;
            this.aplicarbtn.Click += new System.EventHandler(this.aplicarbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(870, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Ordenar por:";
            // 
            // ordenar
            // 
            this.ordenar.FormattingEnabled = true;
            this.ordenar.Items.AddRange(new object[] {
            "Mais Recente",
            "Mais Antigo"});
            this.ordenar.Location = new System.Drawing.Point(954, 2);
            this.ordenar.Name = "ordenar";
            this.ordenar.Size = new System.Drawing.Size(121, 24);
            this.ordenar.TabIndex = 32;
            this.ordenar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(697, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Filtrar por:";
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(764, 3);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(100, 22);
            this.filtro.TabIndex = 35;
            this.filtro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1003, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Entregue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.entregue_Click);
            // 
            // statusenc
            // 
            this.statusenc.Location = new System.Drawing.Point(897, 635);
            this.statusenc.Name = "statusenc";
            this.statusenc.Size = new System.Drawing.Size(100, 22);
            this.statusenc.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(797, 638);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "IDEncomenda:";
            // 
            // FClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1079, 658);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.statusenc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ordenar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.aplicarbtn);
            this.Controls.Add(this.mudarbtn);
            this.Controls.Add(this.moradacliente);
            this.Controls.Add(this.emailcliente);
            this.Controls.Add(this.telefonefcliente);
            this.Controls.Add(this.telefonecliente);
            this.Controls.Add(this.nomecliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FClientes";
            this.Text = "FClientes";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nomecliente;
        private System.Windows.Forms.TextBox telefonecliente;
        private System.Windows.Forms.TextBox telefonefcliente;
        private System.Windows.Forms.TextBox emailcliente;
        private System.Windows.Forms.TextBox moradacliente;
        private System.Windows.Forms.Button mudarbtn;
        private System.Windows.Forms.Button aplicarbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ordenar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox filtro;
        private System.Windows.Forms.Button entregue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox statusenc;
        private System.Windows.Forms.Label label9;
    }
}