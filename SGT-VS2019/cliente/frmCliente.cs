using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGT_VS2019.cliente
{
    public partial class frmCliente : Form
    {
        public Cliente clienteSelecionado = null;
        public frmCliente()
        {
            InitializeComponent();
        }

        public void PreencherCliente()
        {
            if (clienteSelecionado != null)
            {
                if (clienteSelecionado.Tipo == "Fisica")
                {
                    rdbFisica.Checked = true;
                    lblNome.Text = "Nome*:";
                    lblNomeFantasia.Visible = false;
                    txtNomeFantasia.Visible = false;
                    lblCpf.Text = "CPF*:";
                }
                else
                {
                    rdbJuridica.Checked = true;
                    lblNome.Text = "Razão Social*:";
                    lblNomeFantasia.Visible = true;
                    txtNomeFantasia.Visible = true;
                    lblCpf.Text = "CPNJ*:";
                }
                txtNome.Text = clienteSelecionado.Nomerazaosocial;
                txtNomeFantasia.Text = clienteSelecionado.Nomefantasia;
                txtCpf.Text = clienteSelecionado.CPFCNPJ;
                txtDocumento.Text = clienteSelecionado.ISRG;

                txtCep.Text = clienteSelecionado.Cep;
                cmbUf.Text = clienteSelecionado.UF;
                txtEndereco.Text = clienteSelecionado.Endereco;
                txtBairro.Text = clienteSelecionado.Bairro;
                txtComplemento.Text = clienteSelecionado.Complemento;
                txtCidade.Text = clienteSelecionado.Cidade;

                txtHomePage.Text = clienteSelecionado.Homepage;
                txtEmail.Text = clienteSelecionado.Email;
                txtTelefone1.Text = clienteSelecionado.Telefone1;
                txtTelefone2.Text = clienteSelecionado.Telefone2;
                txtTelefone3.Text = clienteSelecionado.Telefone3;
                txtTelefone4.Text = clienteSelecionado.Telefone4;
            }
        }


        public void BloquearCampos(bool status)
        {
            gpbTipoPessoa.Enabled = status;
            gpbPessoa.Enabled = status;
            gpbLogradouro.Enabled = status;
            gpbContato.Enabled = status;


            //Permitir que possa fechar a tela
            btnGravar.Enabled = status;
            btnLimpar.Enabled = status;
            btnFechar.Enabled = true;
        }

        private void rdbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbJuridica.Checked)
            {
                lblNome.Text = "Razão Social*:";
                lblNomeFantasia.Visible = true;
                txtNomeFantasia.Visible = true;
                lblCpf.Text = "CPNJ*:";
            }
            else
            {
                lblNome.Text = "Nome*:";
                lblNomeFantasia.Visible = false;
                txtNomeFantasia.Visible = false;
                lblCpf.Text = "CPF*:";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rdbFisica.Checked = true;

            txtNome.Text = "";
            txtNomeFantasia.Text = "";
            txtCpf.Text = "";
            txtDocumento.Text = "";

            txtCep.Text = "";
            cmbUf.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtComplemento.Text = "";
            txtCidade.Text = "";

            txtHomePage.Text = "";
            txtEmail.Text = "";
            txtTelefone1.Text = "";
            txtTelefone2.Text = "";
            txtTelefone3.Text = "";
            txtTelefone4.Text = "";
        }

        private bool ValidaCampos()
        {
            if (rdbFisica.Checked)
            {
                if(txtNome.Text.Replace(" ","") == "")
                {
                    txtNome.Focus();
                    MessageBox.Show(txtNome, "Campo Nome é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtCpf.Text.Replace(".","").Replace("-","") == "")
                {
                    txtCpf.Focus();
                    MessageBox.Show(txtCpf, "Campo CPF é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                if (txtNome.Text.Replace(" ", "") == "")
                {
                    txtNome.Focus();
                    MessageBox.Show(txtNome, "Campo Razão Social é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtNomeFantasia.Text.Replace(" ", "") == "")
                {
                    txtNomeFantasia.Focus();
                    MessageBox.Show(txtNomeFantasia, "Campo Nome Fantasia é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (txtCpf.Text.Replace(".", "").Replace("-", "") == "")
                {
                    txtCpf.Focus();
                    MessageBox.Show(txtCpf, "Campo CNPJ é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Gravar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void Gravar()
        {
            ValidaCampos();
        }
    }
}
