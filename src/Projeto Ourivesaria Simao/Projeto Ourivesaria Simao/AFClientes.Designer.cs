namespace Projeto_Ourivesaria_Simao
{
    partial class AFClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AFClientes));
            this.filtro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ordenar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.encomenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.apagarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(781, 4);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(100, 20);
            this.filtro.TabIndex = 41;
            this.filtro.TextChanged += new System.EventHandler(this.filtro_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(726, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Filtrar por:";
            // 
            // ordenar
            // 
            this.ordenar.FormattingEnabled = true;
            this.ordenar.Items.AddRange(new object[] {
            "Mais Recente",
            "Mais Antigo"});
            this.ordenar.Location = new System.Drawing.Point(956, 3);
            this.ordenar.Name = "ordenar";
            this.ordenar.Size = new System.Drawing.Size(121, 21);
            this.ordenar.TabIndex = 39;
            this.ordenar.SelectedIndexChanged += new System.EventHandler(this.ordenar_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(887, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ordenar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fichas de Clientes";
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
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // encomenda
            // 
            this.encomenda.Location = new System.Drawing.Point(894, 183);
            this.encomenda.Name = "encomenda";
            this.encomenda.ReadOnly = true;
            this.encomenda.Size = new System.Drawing.Size(100, 20);
            this.encomenda.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(730, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Encomenda selecionada:";
            // 
            // apagarbtn
            // 
            this.apagarbtn.Location = new System.Drawing.Point(1000, 181);
            this.apagarbtn.Name = "apagarbtn";
            this.apagarbtn.Size = new System.Drawing.Size(75, 23);
            this.apagarbtn.TabIndex = 50;
            this.apagarbtn.Text = "Apagar";
            this.apagarbtn.UseVisualStyleBackColor = true;
            this.apagarbtn.Visible = false;
            this.apagarbtn.Click += new System.EventHandler(this.apagarbtn_Click);
            // 
            // AFClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 207);
            this.Controls.Add(this.encomenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apagarbtn);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ordenar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AFClientes";
            this.Text = "Menu - Apagar Fichas de Cliente";
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
        private System.Windows.Forms.TextBox encomenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apagarbtn;
    }
}