
namespace SGT_VS2019.cliente
{
    partial class frmCliente
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
            this.gpbTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rdbJuridica = new System.Windows.Forms.RadioButton();
            this.rdbFisica = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbPessoa = new System.Windows.Forms.GroupBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbLogradouro = new System.Windows.Forms.GroupBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbContato = new System.Windows.Forms.GroupBox();
            this.txtTelefone4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelefone3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelefone2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefone1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHomePage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gpbBotoes = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.gpbTipoPessoa.SuspendLayout();
            this.gpbPessoa.SuspendLayout();
            this.gpbLogradouro.SuspendLayout();
            this.gpbContato.SuspendLayout();
            this.gpbBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbTipoPessoa
            // 
            this.gpbTipoPessoa.Controls.Add(this.rdbJuridica);
            this.gpbTipoPessoa.Controls.Add(this.rdbFisica);
            this.gpbTipoPessoa.Controls.Add(this.label1);
            this.gpbTipoPessoa.Location = new System.Drawing.Point(12, 12);
            this.gpbTipoPessoa.Name = "gpbTipoPessoa";
            this.gpbTipoPessoa.Size = new System.Drawing.Size(523, 68);
            this.gpbTipoPessoa.TabIndex = 0;
            this.gpbTipoPessoa.TabStop = false;
            // 
            // rdbJuridica
            // 
            this.rdbJuridica.AutoSize = true;
            this.rdbJuridica.Checked = true;
            this.rdbJuridica.Location = new System.Drawing.Point(139, 25);
            this.rdbJuridica.Name = "rdbJuridica";
            this.rdbJuridica.Size = new System.Drawing.Size(61, 17);
            this.rdbJuridica.TabIndex = 2;
            this.rdbJuridica.TabStop = true;
            this.rdbJuridica.Text = "Juridica";
            this.rdbJuridica.UseVisualStyleBackColor = true;
            this.rdbJuridica.CheckedChanged += new System.EventHandler(this.rdbJuridica_CheckedChanged);
            // 
            // rdbFisica
            // 
            this.rdbFisica.AutoSize = true;
            this.rdbFisica.Location = new System.Drawing.Point(81, 25);
            this.rdbFisica.Name = "rdbFisica";
            this.rdbFisica.Size = new System.Drawing.Size(52, 17);
            this.rdbFisica.TabIndex = 1;
            this.rdbFisica.Text = "Fisica";
            this.rdbFisica.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Pessoa:";
            // 
            // gpbPessoa
            // 
            this.gpbPessoa.Controls.Add(this.txtDocumento);
            this.gpbPessoa.Controls.Add(this.txtCpf);
            this.gpbPessoa.Controls.Add(this.txtNomeFantasia);
            this.gpbPessoa.Controls.Add(this.txtNome);
            this.gpbPessoa.Controls.Add(this.lblDocumento);
            this.gpbPessoa.Controls.Add(this.lblCpf);
            this.gpbPessoa.Controls.Add(this.lblNomeFantasia);
            this.gpbPessoa.Controls.Add(this.lblNome);
            this.gpbPessoa.Location = new System.Drawing.Point(12, 86);
            this.gpbPessoa.Name = "gpbPessoa";
            this.gpbPessoa.Size = new System.Drawing.Size(523, 117);
            this.gpbPessoa.TabIndex = 1;
            this.gpbPessoa.TabStop = false;
            this.gpbPessoa.Text = "Pessoa";
            // 
            // txtDocumento
            // 
            this.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDocumento.Location = new System.Drawing.Point(366, 81);
            this.txtDocumento.MaxLength = 255;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(151, 20);
            this.txtDocumento.TabIndex = 7;
            // 
            // txtCpf
            // 
            this.txtCpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCpf.Location = new System.Drawing.Point(53, 81);
            this.txtCpf.MaxLength = 255;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(163, 20);
            this.txtCpf.TabIndex = 6;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantasia.Location = new System.Drawing.Point(97, 57);
            this.txtNomeFantasia.MaxLength = 255;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(420, 20);
            this.txtNomeFantasia.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(81, 31);
            this.txtNome.MaxLength = 255;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(436, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(295, 84);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(65, 13);
            this.lblDocumento.TabIndex = 3;
            this.lblDocumento.Text = "Documento:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(6, 84);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(41, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CNPJ*:";
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(6, 60);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(85, 13);
            this.lblNomeFantasia.TabIndex = 1;
            this.lblNomeFantasia.Text = "Nome Fantasia*:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(75, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Razão social*:";
            // 
            // gpbLogradouro
            // 
            this.gpbLogradouro.Controls.Add(this.txtCidade);
            this.gpbLogradouro.Controls.Add(this.txtComplemento);
            this.gpbLogradouro.Controls.Add(this.txtBairro);
            this.gpbLogradouro.Controls.Add(this.txtEndereco);
            this.gpbLogradouro.Controls.Add(this.cmbUf);
            this.gpbLogradouro.Controls.Add(this.txtCep);
            this.gpbLogradouro.Controls.Add(this.label7);
            this.gpbLogradouro.Controls.Add(this.label6);
            this.gpbLogradouro.Controls.Add(this.label5);
            this.gpbLogradouro.Controls.Add(this.label4);
            this.gpbLogradouro.Controls.Add(this.label3);
            this.gpbLogradouro.Controls.Add(this.label2);
            this.gpbLogradouro.Location = new System.Drawing.Point(12, 209);
            this.gpbLogradouro.Name = "gpbLogradouro";
            this.gpbLogradouro.Size = new System.Drawing.Size(523, 144);
            this.gpbLogradouro.TabIndex = 2;
            this.gpbLogradouro.TabStop = false;
            this.gpbLogradouro.Text = "Logradouro";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(55, 109);
            this.txtCidade.MaxLength = 255;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(462, 20);
            this.txtCidade.TabIndex = 11;
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Location = new System.Drawing.Point(348, 81);
            this.txtComplemento.MaxLength = 255;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(169, 20);
            this.txtComplemento.TabIndex = 10;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(39, 81);
            this.txtBairro.MaxLength = 255;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(223, 20);
            this.txtBairro.TabIndex = 9;
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(69, 56);
            this.txtEndereco.MaxLength = 255;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(448, 20);
            this.txtEndereco.TabIndex = 8;
            // 
            // cmbUf
            // 
            this.cmbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Items.AddRange(new object[] {
            "RO",
            "AC",
            "AM",
            "RR",
            "PA",
            "AP",
            "TO",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
            this.cmbUf.Location = new System.Drawing.Point(175, 25);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(49, 21);
            this.cmbUf.TabIndex = 7;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(39, 25);
            this.txtCep.MaxLength = 255;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 6;
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Complemento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bairro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "UF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cep:";
            // 
            // gpbContato
            // 
            this.gpbContato.Controls.Add(this.txtTelefone4);
            this.gpbContato.Controls.Add(this.label12);
            this.gpbContato.Controls.Add(this.txtTelefone3);
            this.gpbContato.Controls.Add(this.label13);
            this.gpbContato.Controls.Add(this.txtTelefone2);
            this.gpbContato.Controls.Add(this.label11);
            this.gpbContato.Controls.Add(this.txtTelefone1);
            this.gpbContato.Controls.Add(this.label10);
            this.gpbContato.Controls.Add(this.txtEmail);
            this.gpbContato.Controls.Add(this.txtHomePage);
            this.gpbContato.Controls.Add(this.label9);
            this.gpbContato.Controls.Add(this.label8);
            this.gpbContato.Location = new System.Drawing.Point(12, 359);
            this.gpbContato.Name = "gpbContato";
            this.gpbContato.Size = new System.Drawing.Size(523, 148);
            this.gpbContato.TabIndex = 3;
            this.gpbContato.TabStop = false;
            this.gpbContato.Text = "Contato";
            // 
            // txtTelefone4
            // 
            this.txtTelefone4.Location = new System.Drawing.Point(366, 108);
            this.txtTelefone4.MaxLength = 255;
            this.txtTelefone4.Name = "txtTelefone4";
            this.txtTelefone4.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone4.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Telefone 4:";
            // 
            // txtTelefone3
            // 
            this.txtTelefone3.Location = new System.Drawing.Point(162, 108);
            this.txtTelefone3.MaxLength = 255;
            this.txtTelefone3.Name = "txtTelefone3";
            this.txtTelefone3.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone3.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(101, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Telefone 3:";
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Location = new System.Drawing.Point(366, 82);
            this.txtTelefone2.MaxLength = 255;
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone2.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Telefone 2:";
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.Location = new System.Drawing.Point(162, 82);
            this.txtTelefone1.MaxLength = 255;
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone1.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Telefone 1:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(39, 51);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(478, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtHomePage
            // 
            this.txtHomePage.Location = new System.Drawing.Point(78, 25);
            this.txtHomePage.MaxLength = 255;
            this.txtHomePage.Name = "txtHomePage";
            this.txtHomePage.Size = new System.Drawing.Size(439, 20);
            this.txtHomePage.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Home Page:";
            // 
            // gpbBotoes
            // 
            this.gpbBotoes.Controls.Add(this.btnFechar);
            this.gpbBotoes.Controls.Add(this.btnLimpar);
            this.gpbBotoes.Controls.Add(this.btnGravar);
            this.gpbBotoes.Location = new System.Drawing.Point(140, 513);
            this.gpbBotoes.Name = "gpbBotoes";
            this.gpbBotoes.Size = new System.Drawing.Size(274, 59);
            this.gpbBotoes.TabIndex = 4;
            this.gpbBotoes.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(183, 19);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(102, 19);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(21, 19);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 583);
            this.Controls.Add(this.gpbBotoes);
            this.Controls.Add(this.gpbContato);
            this.Controls.Add(this.gpbLogradouro);
            this.Controls.Add(this.gpbPessoa);
            this.Controls.Add(this.gpbTipoPessoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.gpbTipoPessoa.ResumeLayout(false);
            this.gpbTipoPessoa.PerformLayout();
            this.gpbPessoa.ResumeLayout(false);
            this.gpbPessoa.PerformLayout();
            this.gpbLogradouro.ResumeLayout(false);
            this.gpbLogradouro.PerformLayout();
            this.gpbContato.ResumeLayout(false);
            this.gpbContato.PerformLayout();
            this.gpbBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTipoPessoa;
        private System.Windows.Forms.RadioButton rdbJuridica;
        private System.Windows.Forms.RadioButton rdbFisica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbPessoa;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbLogradouro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbContato;
        private System.Windows.Forms.TextBox txtTelefone4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTelefone3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTelefone2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTelefone1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHomePage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gpbBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnGravar;
    }
}