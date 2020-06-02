namespace Projeto_Ourivesaria_Simao
{
    partial class Oficina
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
            this.nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ordenar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblabel = new System.Windows.Forms.Label();
            this.Atribuir = new System.Windows.Forms.Button();
            this.transferir = new System.Windows.Forms.Button();
            this.concluir = new System.Windows.Forms.Button();
            this.esctb = new System.Windows.Forms.ComboBox();
            this.atb = new System.Windows.Forms.Button();
            this.ccm = new System.Windows.Forms.Button();
            this.transfer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.Enabled = false;
            this.nome.Location = new System.Drawing.Point(82, 181);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(135, 20);
            this.nome.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "ID Encomenda:";
            // 
            // ordenar
            // 
            this.ordenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ordenar.FormattingEnabled = true;
            this.ordenar.Items.AddRange(new object[] {
            "Mais Recente",
            "Mais Antigo"});
            this.ordenar.Location = new System.Drawing.Point(954, 3);
            this.ordenar.Name = "ordenar";
            this.ordenar.Size = new System.Drawing.Size(121, 21);
            this.ordenar.TabIndex = 119;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(884, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 118;
            this.label8.Text = "Ordenar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 117;
            this.label2.Text = "Orçamentos a fazer";
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
            this.dataGridView1.Location = new System.Drawing.Point(1, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 150);
            this.dataGridView1.TabIndex = 116;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tblabel
            // 
            this.tblabel.AutoSize = true;
            this.tblabel.Location = new System.Drawing.Point(1, 221);
            this.tblabel.Name = "tblabel";
            this.tblabel.Size = new System.Drawing.Size(109, 13);
            this.tblabel.TabIndex = 122;
            this.tblabel.Text = "Nome do trabalhador:";
            this.tblabel.Visible = false;
            // 
            // Atribuir
            // 
            this.Atribuir.Location = new System.Drawing.Point(223, 180);
            this.Atribuir.Name = "Atribuir";
            this.Atribuir.Size = new System.Drawing.Size(75, 23);
            this.Atribuir.TabIndex = 123;
            this.Atribuir.Text = "Atribuir";
            this.Atribuir.UseVisualStyleBackColor = true;
            this.Atribuir.Visible = false;
            this.Atribuir.Click += new System.EventHandler(this.Atribuir_Click);
            // 
            // transferir
            // 
            this.transferir.Location = new System.Drawing.Point(304, 181);
            this.transferir.Name = "transferir";
            this.transferir.Size = new System.Drawing.Size(75, 23);
            this.transferir.TabIndex = 124;
            this.transferir.Text = "Transferir";
            this.transferir.UseVisualStyleBackColor = true;
            this.transferir.Visible = false;
            this.transferir.Click += new System.EventHandler(this.transferir_Click);
            // 
            // concluir
            // 
            this.concluir.Location = new System.Drawing.Point(918, 182);
            this.concluir.Name = "concluir";
            this.concluir.Size = new System.Drawing.Size(75, 23);
            this.concluir.TabIndex = 125;
            this.concluir.Text = "Concluir";
            this.concluir.UseVisualStyleBackColor = true;
            this.concluir.Visible = false;
            this.concluir.Click += new System.EventHandler(this.concluir_Click);
            // 
            // esctb
            // 
            this.esctb.FormattingEnabled = true;
            this.esctb.Items.AddRange(new object[] {
            "Acácio",
            "Marco",
            "João",
            "Felipe"});
            this.esctb.Location = new System.Drawing.Point(113, 218);
            this.esctb.Name = "esctb";
            this.esctb.Size = new System.Drawing.Size(177, 21);
            this.esctb.TabIndex = 126;
            this.esctb.Visible = false;
            // 
            // atb
            // 
            this.atb.Location = new System.Drawing.Point(296, 216);
            this.atb.Name = "atb";
            this.atb.Size = new System.Drawing.Size(75, 23);
            this.atb.TabIndex = 127;
            this.atb.Text = "Atribuir";
            this.atb.UseVisualStyleBackColor = true;
            this.atb.Visible = false;
            this.atb.Click += new System.EventHandler(this.atb_Click);
            // 
            // ccm
            // 
            this.ccm.Location = new System.Drawing.Point(999, 182);
            this.ccm.Name = "ccm";
            this.ccm.Size = new System.Drawing.Size(75, 23);
            this.ccm.TabIndex = 128;
            this.ccm.Text = "Concluir CM";
            this.ccm.UseVisualStyleBackColor = true;
            this.ccm.Visible = false;
            this.ccm.Click += new System.EventHandler(this.ccm_Click);
            // 
            // transfer
            // 
            this.transfer.Location = new System.Drawing.Point(296, 216);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(75, 23);
            this.transfer.TabIndex = 129;
            this.transfer.Text = "Transferir";
            this.transfer.UseVisualStyleBackColor = true;
            this.transfer.Visible = false;
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // Oficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 248);
            this.Controls.Add(this.transfer);
            this.Controls.Add(this.ccm);
            this.Controls.Add(this.atb);
            this.Controls.Add(this.esctb);
            this.Controls.Add(this.concluir);
            this.Controls.Add(this.transferir);
            this.Controls.Add(this.Atribuir);
            this.Controls.Add(this.tblabel);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ordenar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Oficina";
            this.Text = "Oficina";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ordenar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label tblabel;
        private System.Windows.Forms.Button Atribuir;
        private System.Windows.Forms.Button transferir;
        private System.Windows.Forms.Button concluir;
        private System.Windows.Forms.ComboBox esctb;
        private System.Windows.Forms.Button atb;
        private System.Windows.Forms.Button ccm;
        private System.Windows.Forms.Button transfer;
    }
}