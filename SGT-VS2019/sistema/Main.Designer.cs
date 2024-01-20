
namespace SGT_VS2019
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorioCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorioVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorioMotorista = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorioOleoDiesel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorioPedagio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNovoContrato = new System.Windows.Forms.ToolStripMenuItem();
            this.mnucontratosCadastrados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.contratosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatóriosToolStripMenuItem,
            this.mnuSair});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRelatorioCliente,
            this.mnuRelatorioVeiculo,
            this.mnuRelatorioMotorista,
            this.mnuRelatorioOleoDiesel,
            this.mnuRelatorioPedagio});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // mnuRelatorioCliente
            // 
            this.mnuRelatorioCliente.Name = "mnuRelatorioCliente";
            this.mnuRelatorioCliente.Size = new System.Drawing.Size(180, 22);
            this.mnuRelatorioCliente.Text = "Clientes";
            this.mnuRelatorioCliente.Click += new System.EventHandler(this.mnuRelatorioCliente_Click);
            // 
            // mnuRelatorioVeiculo
            // 
            this.mnuRelatorioVeiculo.Name = "mnuRelatorioVeiculo";
            this.mnuRelatorioVeiculo.Size = new System.Drawing.Size(180, 22);
            this.mnuRelatorioVeiculo.Text = "Veículos";
            this.mnuRelatorioVeiculo.Click += new System.EventHandler(this.mnuRelatorioVeiculo_Click);
            // 
            // mnuRelatorioMotorista
            // 
            this.mnuRelatorioMotorista.Name = "mnuRelatorioMotorista";
            this.mnuRelatorioMotorista.Size = new System.Drawing.Size(180, 22);
            this.mnuRelatorioMotorista.Text = "Motoristas";
            this.mnuRelatorioMotorista.Click += new System.EventHandler(this.mnuRelatorioMotorista_Click);
            // 
            // mnuRelatorioOleoDiesel
            // 
            this.mnuRelatorioOleoDiesel.Name = "mnuRelatorioOleoDiesel";
            this.mnuRelatorioOleoDiesel.Size = new System.Drawing.Size(180, 22);
            this.mnuRelatorioOleoDiesel.Text = "Óleo Diesel";
            this.mnuRelatorioOleoDiesel.Click += new System.EventHandler(this.mnuRelatorioOleoDiesel_Click);
            // 
            // mnuRelatorioPedagio
            // 
            this.mnuRelatorioPedagio.Name = "mnuRelatorioPedagio";
            this.mnuRelatorioPedagio.Size = new System.Drawing.Size(180, 22);
            this.mnuRelatorioPedagio.Text = "Pedagio";
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(180, 22);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCliente,
            this.mnuVeiculo,
            this.mnuFuncionario});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.clienteToolStripMenuItem.Text = "Cadastro";
            // 
            // mnuCliente
            // 
            this.mnuCliente.Name = "mnuCliente";
            this.mnuCliente.Size = new System.Drawing.Size(137, 22);
            this.mnuCliente.Text = "Cliente";
            this.mnuCliente.Click += new System.EventHandler(this.mnuCliente_Click);
            // 
            // mnuVeiculo
            // 
            this.mnuVeiculo.Name = "mnuVeiculo";
            this.mnuVeiculo.Size = new System.Drawing.Size(137, 22);
            this.mnuVeiculo.Text = "Veiculo";
            this.mnuVeiculo.Click += new System.EventHandler(this.mnuVeiculo_Click);
            // 
            // mnuFuncionario
            // 
            this.mnuFuncionario.Name = "mnuFuncionario";
            this.mnuFuncionario.Size = new System.Drawing.Size(137, 22);
            this.mnuFuncionario.Text = "Funcionário";
            this.mnuFuncionario.Click += new System.EventHandler(this.mnuFuncionario_Click);
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNovoContrato,
            this.mnucontratosCadastrados});
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.contratosToolStripMenuItem.Text = "Contratos";
            // 
            // mnuNovoContrato
            // 
            this.mnuNovoContrato.Name = "mnuNovoContrato";
            this.mnuNovoContrato.Size = new System.Drawing.Size(194, 22);
            this.mnuNovoContrato.Text = "Novo Contrato";
            this.mnuNovoContrato.Click += new System.EventHandler(this.mnuNovoContrato_Click);
            // 
            // mnucontratosCadastrados
            // 
            this.mnucontratosCadastrados.Name = "mnucontratosCadastrados";
            this.mnucontratosCadastrados.Size = new System.Drawing.Size(194, 22);
            this.mnucontratosCadastrados.Text = "Contratos Cadastrados";
            this.mnucontratosCadastrados.Click += new System.EventHandler(this.mnucontratosCadastrados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGT";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCliente;
        private System.Windows.Forms.ToolStripMenuItem mnuVeiculo;
        private System.Windows.Forms.ToolStripMenuItem mnuFuncionario;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnucontratosCadastrados;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuNovoContrato;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorioCliente;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorioVeiculo;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorioMotorista;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorioOleoDiesel;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorioPedagio;
    }
}

