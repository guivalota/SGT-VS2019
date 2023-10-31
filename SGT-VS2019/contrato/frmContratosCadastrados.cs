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
    }
}
