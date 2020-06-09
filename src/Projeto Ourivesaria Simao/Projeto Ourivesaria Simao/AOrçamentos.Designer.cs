namespace Projeto_Ourivesaria_Simao
{
    partial class AOrçamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.filtro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ordenar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.apagarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(782, 4);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(100, 20);
            this.filtro.TabIndex = 125;
            this.filtro.TextChanged += new System.EventHandler(this.filtro_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(727, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 124;
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
            this.ordenar.TabIndex = 123;
            this.ordenar.SelectedIndexChanged += new System.EventHandler(this.ordenar_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(888, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 122;
            this.label8.Text = "Ordenar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 121;
            this.label2.Text = "Lista de orçamentos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 150);
            this.dataGridView1.TabIndex = 120;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // orc
            // 
            this.orc.Location = new System.Drawing.Point(894, 182);
            this.orc.Name = "orc";
            this.orc.ReadOnly = true;
            this.orc.Size = new System.Drawing.Size(100, 20);
            this.orc.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(736, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 127;
            this.label1.Text = "Orçamento selecionado:";
            // 
            // apagarbtn
            // 
            this.apagarbtn.Location = new System.Drawing.Point(1000, 180);
            this.apagarbtn.Name = "apagarbtn";
            this.apagarbtn.Size = new System.Drawing.Size(75, 23);
            this.apagarbtn.TabIndex = 126;
            this.apagarbtn.Text = "Apagar";
            this.apagarbtn.UseVisualStyleBackColor = true;
            this.apagarbtn.Visible = false;
            this.apagarbtn.Click += new System.EventHandler(this.apagarbtn_Click);
            // 
            // AOrçamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 206);
            this.Controls.Add(this.orc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apagarbtn);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ordenar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AOrçamentos";
            this.Text = "AOrçamentos";
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
        private System.Windows.Forms.TextBox orc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apagarbtn;
    }
}