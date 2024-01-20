using BLL;
using Microsoft.Reporting.WinForms;
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

namespace SGT_VS2019.sistema.relatorios
{
    public partial class frmRelatorioOleoDiesel : Form
    {
        public frmRelatorioOleoDiesel()
        {
            InitializeComponent();
            RelatorioBLL oBLL = new RelatorioBLL();
            try
            {
                cmbVeiculo.Items.Clear();
                cmbVeiculo.DataSource = oBLL.ListarVeiculosRelatorioOeloDiesel().Tables[0];
                cmbVeiculo.DisplayMember = "Placa";
                cmbVeiculo.ValueMember = "CodigoInterno";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                frmRelatorio frm = new frmRelatorio();
                //string caminhoRelatorio = Environment.CurrentDirectory + "\\sistemas\\relatorios\\rltCliente.rlc";
                string caminhoRelatorio = "C:\\Users\\gui_v\\OneDrive\\Documentos\\Visual Studio 2019\\SGT-VS2019\\SGT-VS2019\\sistema\\relatorios\\rltOleoDiesel.rdlc";
                RelatorioBLL oBLL = new RelatorioBLL();
                frm.reporViewer.LocalReport.ReportPath = caminhoRelatorio;
                Microsoft.Reporting.WinForms.ReportDataSource rptdBody = new Microsoft.Reporting.WinForms.ReportDataSource();
                rptdBody.Name = "DataSet1";

                string codigoInternoVeiculo = cmbVeiculo.SelectedValue.ToString();
                VeiculoBLL vBLL = new VeiculoBLL();
                Veiculo veiculo = vBLL.PesquisarVeiculoCodigoInterno(codigoInternoVeiculo);

                rptdBody.Value = oBLL.rltOleoDiesel(veiculo.Placa, dtpInicio.Value, dtpFinal.Value).Tables[0];
                frm.reporViewer.LocalReport.DataSources.Add(rptdBody);

                frm.reporViewer.LocalReport.SetParameters(new ReportParameter("Van", veiculo.CodInterno + " - "+veiculo.Placa));
                frm.Show();
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
