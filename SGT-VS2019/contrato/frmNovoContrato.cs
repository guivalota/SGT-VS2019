using BLL;
using Model;
using SGT_VS2019.cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGT_VS2019.contrato
{
    public partial class frmNovoContrato : Form
    {
        private Cliente clienseSelecionado = null;
        string valor;
        public frmNovoContrato()
        {
            InitializeComponent();
            InicializarCompo();
            txtValor.Text = "R$ 0,00";
        }

        private void InicializarCompo()
        {
            ConfigurarTempoTela();
            ContratoBLL oBLL = new ContratoBLL();
            try
            {
                cmbMotorista.Items.Clear();
                cmbMotorista.DataSource = oBLL.PesquisarMotorista().Tables[0];
                cmbMotorista.DisplayMember = "Nome";
                cmbMotorista.ValueMember = "IdFuncionario";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                cmbVeiculo.Items.Clear();
                cmbVeiculo.DataSource = oBLL.ListarVeiculos().Tables[0];
                cmbVeiculo.DisplayMember = "Placa";
                cmbVeiculo.ValueMember = "IdVeiculo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                cmbEstadoCivil.Items.Add("SOLTEIRO");
                cmbEstadoCivil.Items.Add("CASADO");
                cmbEstadoCivil.Items.Add("VIUVO");
                cmbEstadoCivil.Items.Add("DIVORCIADO");
                cmbEstadoCivil.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                frmClientePesquisa frm = new frmClientePesquisa();
                frm.selecionaCliente = true;
                frm.SelecionaCliente();
                frm.ShowDialog();
                clienseSelecionado = frm.clienseSelecionado;
                if(clienseSelecionado != null)
                {
                    txtLocatario.Text = clienseSelecionado.Nomerazaosocial;
                }
                else
                {
                    txtLocatario.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void Limpar()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                clienseSelecionado = null;
                txtLocatario.Text = "";
                cmbVeiculo.SelectedIndex = 0;
                cmbMotorista.SelectedIndex = 0;
                cmbEstadoCivil.SelectedIndex = 0;
                dtpDataInicio.Value = DateTime.Today;
                dtpDataFim.Value = DateTime.Today;
                dtpDataContrato.Value = DateTime.Today;

                txtDiarias.Text = "";
                txtValor.Text = "R$ 0,00";
                txtDestino.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void ConfigurarTempoTela()
        {
            dtpHoraInicial.Format = DateTimePickerFormat.Custom;
            dtpHoraInicial.CustomFormat = "HH:mm";
            dtpHoraInicial.ShowUpDown = true;

            dtpHoraFinal.Format = DateTimePickerFormat.Custom;
            dtpHoraFinal.CustomFormat = "HH:mm";
            dtpHoraFinal.ShowUpDown = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtValor_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                valor = txtValor.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
                if (valor.Length == 0)
                {
                    txtValor.Text = "0,00" + valor;
                }
                if (valor.Length == 1)
                {
                    txtValor.Text = "0,0" + valor;
                }
                if (valor.Length == 2)
                {
                    txtValor.Text = "0," + valor;
                }
                else if (valor.Length >= 3)
                {
                    if (txtValor.Text.StartsWith("0,"))
                    {
                        txtValor.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                    }
                    else if (txtValor.Text.Contains("00,"))
                    {
                        txtValor.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                    }
                    else
                    {
                        txtValor.Text = valor.Insert(valor.Length - 2, ",");
                    }
                }
                valor = txtValor.Text;
                txtValor.Text = string.Format("{0:C}", Convert.ToDouble(valor));
                txtValor.Select(txtValor.Text.Length, 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            valor = txtValor.Text.Replace("R$", "");
            txtValor.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }


        private bool ValidaCampos()
        {
            if(clienseSelecionado == null)
            {
                MessageBox.Show(this, "Selecione um Cliente para continuar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnPesquisar.Focus();
                return false;
            }
            if(dtpDataInicio.Value.Date > dtpDataFim.Value.Date)
            {
                MessageBox.Show(this, "A Data Inicial não pode superior a Data Final", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDataInicio.Focus();
                return false;
            }
            if (txtDiarias.Text == "")
            {
                MessageBox.Show(this, "Informe o numero de Diarias", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiarias.Focus();
                return false;
            }

            if (double.Parse(txtValor.Text.Replace("R$", "").Replace(".","").Replace(",",".")) == 0)
            {
                MessageBox.Show(this, "Informe o valor do contrato", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return false;
            }

            if(txtDestino.Text == "")
            {
                MessageBox.Show(this, "Informe o Destino", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDestino.Focus();
                return false;
            }


            return true;
        }

        private void btnGerarContrato_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (ValidaCampos())
                {
                    if(MessageBox.Show(this, "Confirmar o Cadastro do Contrato?", "Confirmação de Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }


    
}
