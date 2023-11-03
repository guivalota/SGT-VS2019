using BLL;
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
    public partial class frmContratosCadastrados : Form
    {
        private int selectedRow = -1;
        public frmContratosCadastrados()
        {
            InitializeComponent();
            InicializarCompo();
            Pesquisar();
        }

        private void InicializarCompo()
        {
            ContratoBLL oBLL = new ContratoBLL();
            try
            {
                cmbMotorista.Items.Clear();
                cmbMotorista.DataSource = oBLL.PesquisarMotorista().Tables[0];
                cmbMotorista.DisplayMember = "Nome";
                cmbMotorista.ValueMember = "IdFuncionario";
            }catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                cmbCliente.Items.Clear();
                cmbCliente.DataSource = oBLL.PesquisarClientes().Tables[0];
                cmbCliente.DisplayMember = "NomeRazaoSocial";
                cmbCliente.ValueMember = "IdCliente";
            }catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pesquisar()
        {
            string campo = "";
            int id =0;
            if (rdbCliente.Checked)
            {
                campo = "c.idlocatario";
                id = int.Parse(cmbCliente.SelectedValue.ToString());
            }
            else if (rdbFuncionario.Checked)
            {
                campo = "c.idmotorista";
                id = int.Parse(cmbMotorista.SelectedValue.ToString());
            }
            ContratoBLL BLL = new ContratoBLL();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Grid.DataSource = BLLGeral.ListToDataSet(BLL.PesquisarContratoList(campo, id)).Tables[0];
                lblQtdGrid.Text = Grid.Rows.Count.ToString();
                ConfigurarGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void ConfigurarGrid()
        {
            Grid.Columns[0].Visible = false;
            Grid.Columns[1].Visible = true;
            Grid.Columns[1].HeaderText = "Data";
            Grid.Columns[1].DefaultCellStyle.Format = @"dd/MM/yyyy";
            Grid.Columns[1].Width = 80;
            Grid.Columns[2].Visible = true;
            Grid.Columns[2].HeaderText = "Cliente";
            Grid.Columns[2].Width = 250;
            Grid.Columns[3].Visible = true;
            Grid.Columns[3].HeaderText = "Destino";
            Grid.Columns[3].Width = 250;
            Grid.Columns[4].Visible = true;
            Grid.Columns[4].HeaderText = "Motorista";
            Grid.Columns[4].Width = 250;
            Grid.Columns[5].Visible = true;
            Grid.Columns[5].HeaderText = "Veiculo";
            Grid.Columns[5].Width = 75;
            Grid.Columns[6].Visible = false;
            Grid.Columns[7].Visible = false;
            Grid.Columns[8].Visible = false;
            Grid.Columns[9].Visible = false;
            Grid.Columns[10].Visible = false;
            Grid.Columns[11].Visible = false;
            Grid.Columns[12].Visible = false;
            Grid.Columns[13].Visible = false;
            Grid.Columns[14].Visible = false;
            Grid.Columns[15].Visible = false;
            Grid.Columns[16].Visible = false;
            Grid.Columns[17].Visible = false;
            Grid.Columns[18].Visible = false;
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTodos.Checked)
            {
                cmbMotorista.Visible = false;
                cmbCliente.Visible = false;
            }
        }

        private void rdbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCliente.Checked)
            {
                cmbCliente.Visible = true;
                cmbMotorista.Visible = false;
            }
        }

        private void rdbFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbFuncionario.Checked)
            {
                cmbMotorista.Visible = true;
                cmbCliente.Visible = false;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                frmNovoContrato frm = new frmNovoContrato();
                frm.ShowDialog();
                Pesquisar();
                selectedRow = -1;
            }catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.Dispose();
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

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
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
    }
}
