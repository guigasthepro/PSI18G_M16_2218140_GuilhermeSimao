namespace Projeto_Ourivesaria_Simao
{
    partial class AEncomendas
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
            this.label1 = new System.Windows.Forms.Label();
            this.filtro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ordenar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.apagarbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.encomenda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Encomendas de Clientes";
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(666, 4);
            this.filtro.Margin = new System.Windows.Forms.Padding(4);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(132, 20);
            this.filtro.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(596, 6);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Filtrar por:";
            // 
            // ordenar
            // 
            this.ordenar.FormattingEnabled = true;
            this.ordenar.Items.AddRange(new object[] {
            "Mais Recente",
            "Mais Antigo"});
            this.ordenar.Location = new System.Drawing.Point(894, 3);
            this.ordenar.Margin = new System.Windows.Forms.Padding(4);
            this.ordenar.Name = "ordenar";
            this.ordenar.Size = new System.Drawing.Size(160, 21);
            this.ordenar.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(808, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Ordenar por:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 185);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // apagarbtn
            // 
            this.apagarbtn.Location = new System.Drawing.Point(969, 219);
            this.apagarbtn.Name = "apagarbtn";
            this.apagarbtn.Size = new System.Drawing.Size(75, 23);
            this.apagarbtn.TabIndex = 47;
            this.apagarbtn.Text = "Apagar";
            this.apagarbtn.UseVisualStyleBackColor = true;
            this.apagarbtn.Visible = false;
            this.apagarbtn.Click += new System.EventHandler(this.apagarbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(699, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Encomenda selecionada:";
            // 
            // encomenda
            // 
            this.encomenda.Location = new System.Drawing.Point(863, 221);
            this.encomenda.Name = "encomenda";
            this.encomenda.ReadOnly = true;
            this.encomenda.Size = new System.Drawing.Size(100, 20);
            this.encomenda.TabIndex = 49;
            // 
            // AEncomendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 251);
            this.Controls.Add(this.encomenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apagarbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ordenar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AEncomendas";
            this.Text = "AEncomendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filtro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ordenar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button apagarbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox encomenda;
    }
}