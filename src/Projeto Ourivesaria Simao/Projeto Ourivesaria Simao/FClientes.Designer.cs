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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pesquisacliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nomepesquisa = new System.Windows.Forms.TextBox();
            this.telefonepesquisa = new System.Windows.Forms.TextBox();
            this.telefonefixopesquisa = new System.Windows.Forms.TextBox();
            this.emailpesquisa = new System.Windows.Forms.TextBox();
            this.moradapesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 394);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1079, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 372);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encomendas Do Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone Fixo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Morada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nome/Numero Do Cliente:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pesquisacliente
            // 
            this.pesquisacliente.Location = new System.Drawing.Point(203, 11);
            this.pesquisacliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pesquisacliente.Name = "pesquisacliente";
            this.pesquisacliente.Size = new System.Drawing.Size(228, 22);
            this.pesquisacliente.TabIndex = 8;
            this.pesquisacliente.TextChanged += new System.EventHandler(this.Afi);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomepesquisa
            // 
            this.nomepesquisa.Location = new System.Drawing.Point(69, 79);
            this.nomepesquisa.Name = "nomepesquisa";
            this.nomepesquisa.Size = new System.Drawing.Size(200, 22);
            this.nomepesquisa.TabIndex = 10;
            // 
            // telefonepesquisa
            // 
            this.telefonepesquisa.Location = new System.Drawing.Point(88, 120);
            this.telefonepesquisa.Name = "telefonepesquisa";
            this.telefonepesquisa.Size = new System.Drawing.Size(121, 22);
            this.telefonepesquisa.TabIndex = 11;
            // 
            // telefonefixopesquisa
            // 
            this.telefonefixopesquisa.Location = new System.Drawing.Point(116, 167);
            this.telefonefixopesquisa.Name = "telefonefixopesquisa";
            this.telefonefixopesquisa.Size = new System.Drawing.Size(115, 22);
            this.telefonefixopesquisa.TabIndex = 12;
            // 
            // emailpesquisa
            // 
            this.emailpesquisa.Location = new System.Drawing.Point(68, 214);
            this.emailpesquisa.Name = "emailpesquisa";
            this.emailpesquisa.Size = new System.Drawing.Size(201, 22);
            this.emailpesquisa.TabIndex = 13;
            // 
            // moradapesquisa
            // 
            this.moradapesquisa.Location = new System.Drawing.Point(81, 262);
            this.moradapesquisa.Name = "moradapesquisa";
            this.moradapesquisa.Size = new System.Drawing.Size(188, 22);
            this.moradapesquisa.TabIndex = 14;
            // 
            // FClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1079, 636);
            this.Controls.Add(this.moradapesquisa);
            this.Controls.Add(this.emailpesquisa);
            this.Controls.Add(this.telefonefixopesquisa);
            this.Controls.Add(this.telefonepesquisa);
            this.Controls.Add(this.nomepesquisa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pesquisacliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FClientes";
            this.Text = "FClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pesquisacliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nomepesquisa;
        private System.Windows.Forms.TextBox telefonepesquisa;
        internal System.Windows.Forms.TextBox telefonefixopesquisa;
        private System.Windows.Forms.TextBox emailpesquisa;
        private System.Windows.Forms.TextBox moradapesquisa;
    }
}