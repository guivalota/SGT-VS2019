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
    public partial class frmNovoContrato : Form
    {
        public frmNovoContrato()
        {
            InitializeComponent();
            InicializarCompo();
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
        }
    }


    
}
