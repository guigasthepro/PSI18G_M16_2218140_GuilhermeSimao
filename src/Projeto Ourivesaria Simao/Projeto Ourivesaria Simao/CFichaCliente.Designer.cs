namespace Projeto_Ourivesaria_Simao
{
    partial class CriarFichaDeCliente
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.nomecliente = new System.Windows.Forms.TextBox();
            this.telefonecliente = new System.Windows.Forms.TextBox();
            this.telefonefixocliente = new System.Windows.Forms.TextBox();
            this.emailcliente = new System.Windows.Forms.TextBox();
            this.moradacliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(208, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone fixo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Morada:";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(34, 9);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(60, 20);
            this.nome.TabIndex = 5;
            this.nome.Text = "Nome:";
            // 
            // nomecliente
            // 
            this.nomecliente.Location = new System.Drawing.Point(38, 32);
            this.nomecliente.Name = "nomecliente";
            this.nomecliente.Size = new System.Drawing.Size(252, 20);
            this.nomecliente.TabIndex = 6;
            // 
            // telefonecliente
            // 
            this.telefonecliente.Location = new System.Drawing.Point(38, 78);
            this.telefonecliente.Name = "telefonecliente";
            this.telefonecliente.Size = new System.Drawing.Size(115, 20);
            this.telefonecliente.TabIndex = 7;
            // 
            // telefonefixocliente
            // 
            this.telefonefixocliente.Location = new System.Drawing.Point(40, 125);
            this.telefonefixocliente.Name = "telefonefixocliente";
            this.telefonefixocliente.Size = new System.Drawing.Size(110, 20);
            this.telefonefixocliente.TabIndex = 8;
            // 
            // emailcliente
            // 
            this.emailcliente.Location = new System.Drawing.Point(39, 174);
            this.emailcliente.Name = "emailcliente";
            this.emailcliente.Size = new System.Drawing.Size(254, 20);
            this.emailcliente.TabIndex = 9;
            // 
            // moradacliente
            // 
            this.moradacliente.Location = new System.Drawing.Point(38, 220);
            this.moradacliente.Name = "moradacliente";
            this.moradacliente.Size = new System.Drawing.Size(236, 20);
            this.moradacliente.TabIndex = 10;
            // 
            // CriarFichaDeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.moradacliente);
            this.Controls.Add(this.emailcliente);
            this.Controls.Add(this.telefonefixocliente);
            this.Controls.Add(this.telefonecliente);
            this.Controls.Add(this.nomecliente);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CriarFichaDeCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CFichaCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox nomecliente;
        private System.Windows.Forms.TextBox telefonecliente;
        private System.Windows.Forms.TextBox telefonefixocliente;
        private System.Windows.Forms.TextBox emailcliente;
        private System.Windows.Forms.TextBox moradacliente;
    }
}