namespace Projeto_Ourivesaria_Simao
{
    partial class Form2
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
            this.atendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cFClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.cFEncomendas = new System.Windows.Forms.ToolStripMenuItem();
            this.FClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.FEncomendas = new System.Windows.Forms.ToolStripMenuItem();
            this.oficinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stEncomendas = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOrçamento = new System.Windows.Forms.ToolStripMenuItem();
            this.hOrçamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.gstocko = new System.Windows.Forms.ToolStripMenuItem();
            this.preçoFinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.painelAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aFClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.aEncomendas = new System.Windows.Forms.ToolStripMenuItem();
            this.aOrçamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.rUtilizador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.username = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // atendimentoToolStripMenuItem
            // 
            this.atendimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cFClientes,
            this.cFEncomendas,
            this.FClientes,
            this.FEncomendas});
            this.atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            this.atendimentoToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.atendimentoToolStripMenuItem.Text = "Atendimento";
            // 
            // cFClientes
            // 
            this.cFClientes.Name = "cFClientes";
            this.cFClientes.Size = new System.Drawing.Size(201, 22);
            this.cFClientes.Text = "Criar Ficha Clientes";
            this.cFClientes.Click += new System.EventHandler(this.criarFichaClientesToolStripMenuItem_Click);
            // 
            // cFEncomendas
            // 
            this.cFEncomendas.Name = "cFEncomendas";
            this.cFEncomendas.Size = new System.Drawing.Size(201, 22);
            this.cFEncomendas.Text = "Criar Ficha Encomendas";
            this.cFEncomendas.Click += new System.EventHandler(this.criarFichaEncomendasToolStripMenuItem_Click);
            // 
            // FClientes
            // 
            this.FClientes.Name = "FClientes";
            this.FClientes.Size = new System.Drawing.Size(201, 22);
            this.FClientes.Text = "Ficha Clientes";
            this.FClientes.Click += new System.EventHandler(this.fichaClientesToolStripMenuItem_Click);
            // 
            // FEncomendas
            // 
            this.FEncomendas.Name = "FEncomendas";
            this.FEncomendas.Size = new System.Drawing.Size(201, 22);
            this.FEncomendas.Text = "Ficha Encomendas";
            this.FEncomendas.Click += new System.EventHandler(this.fichaEncomendasToolStripMenuItem_Click);
            // 
            // oficinaToolStripMenuItem
            // 
            this.oficinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stEncomendas});
            this.oficinaToolStripMenuItem.Name = "oficinaToolStripMenuItem";
            this.oficinaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.oficinaToolStripMenuItem.Text = "Oficina";
            // 
            // stEncomendas
            // 
            this.stEncomendas.Name = "stEncomendas";
            this.stEncomendas.Size = new System.Drawing.Size(183, 22);
            this.stEncomendas.Text = "Encomendas Oficina";
            this.stEncomendas.Click += new System.EventHandler(this.stEncomendas_Click);
            // 
            // orçamentosToolStripMenuItem
            // 
            this.orçamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOrçamento,
            this.hOrçamentos,
            this.gstocko,
            this.preçoFinalToolStripMenuItem});
            this.orçamentosToolStripMenuItem.Name = "orçamentosToolStripMenuItem";
            this.orçamentosToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.orçamentosToolStripMenuItem.Text = "Orçamentos";
            // 
            // cOrçamento
            // 
            this.cOrçamento.Name = "cOrçamento";
            this.cOrçamento.Size = new System.Drawing.Size(190, 22);
            this.cOrçamento.Text = "Criar Orçamento";
            this.cOrçamento.Click += new System.EventHandler(this.cOrçamento_Click);
            // 
            // hOrçamentos
            // 
            this.hOrçamentos.Name = "hOrçamentos";
            this.hOrçamentos.Size = new System.Drawing.Size(190, 22);
            this.hOrçamentos.Text = "Histórico Orçamentos";
            this.hOrçamentos.Click += new System.EventHandler(this.hOrçamentos_Click);
            // 
            // gstocko
            // 
            this.gstocko.Name = "gstocko";
            this.gstocko.Size = new System.Drawing.Size(190, 22);
            this.gstocko.Text = "Gestão de Stock";
            this.gstocko.Click += new System.EventHandler(this.gstocko_Click);
            // 
            // preçoFinalToolStripMenuItem
            // 
            this.preçoFinalToolStripMenuItem.Name = "preçoFinalToolStripMenuItem";
            this.preçoFinalToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.preçoFinalToolStripMenuItem.Text = "Preço Final";
            this.preçoFinalToolStripMenuItem.Click += new System.EventHandler(this.preçoFinalToolStripMenuItem_Click);
            // 
            // painelAdminToolStripMenuItem
            // 
            this.painelAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aFClientes,
            this.aEncomendas,
            this.aOrçamentos,
            this.rUtilizador});
            this.painelAdminToolStripMenuItem.Name = "painelAdminToolStripMenuItem";
            this.painelAdminToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.painelAdminToolStripMenuItem.Text = "Painel Admin";
            // 
            // aFClientes
            // 
            this.aFClientes.Name = "aFClientes";
            this.aFClientes.Size = new System.Drawing.Size(209, 22);
            this.aFClientes.Text = "Apagar Fichas de Clientes";
            this.aFClientes.Click += new System.EventHandler(this.aFClientes_Click);
            // 
            // aEncomendas
            // 
            this.aEncomendas.Name = "aEncomendas";
            this.aEncomendas.Size = new System.Drawing.Size(209, 22);
            this.aEncomendas.Text = "Apagar Encomendas";
            this.aEncomendas.Click += new System.EventHandler(this.aEncomendas_Click);
            // 
            // aOrçamentos
            // 
            this.aOrçamentos.Name = "aOrçamentos";
            this.aOrçamentos.Size = new System.Drawing.Size(209, 22);
            this.aOrçamentos.Text = "Apagar Orçamentos";
            this.aOrçamentos.Click += new System.EventHandler(this.aOrçamentos_Click);
            // 
            // rUtilizador
            // 
            this.rUtilizador.Name = "rUtilizador";
            this.rUtilizador.Size = new System.Drawing.Size(209, 22);
            this.rUtilizador.Text = "Registar Utilizador";
            this.rUtilizador.Click += new System.EventHandler(this.rUtilizador_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atendimentoToolStripMenuItem,
            this.oficinaToolStripMenuItem,
            this.orçamentosToolStripMenuItem,
            this.painelAdminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.username});
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // username
            // 
            this.username.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(79, 20);
            this.username.Text = "{username}";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.programexit);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1004, 737);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Ourivesaria Simão";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.programexit);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem atendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FClientes;
        private System.Windows.Forms.ToolStripMenuItem FEncomendas;
        private System.Windows.Forms.ToolStripMenuItem oficinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stEncomendas;
        private System.Windows.Forms.ToolStripMenuItem orçamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOrçamento;
        private System.Windows.Forms.ToolStripMenuItem hOrçamentos;
        private System.Windows.Forms.ToolStripMenuItem gstocko;
        private System.Windows.Forms.ToolStripMenuItem painelAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aEncomendas;
        private System.Windows.Forms.ToolStripMenuItem aFClientes;
        private System.Windows.Forms.ToolStripMenuItem aOrçamentos;
        private System.Windows.Forms.ToolStripMenuItem rUtilizador;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cFClientes;
        private System.Windows.Forms.ToolStripMenuItem cFEncomendas;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem username;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preçoFinalToolStripMenuItem;
    }
}