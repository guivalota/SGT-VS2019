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
    public partial class frmRelatorioMotorista : Form
    {
        public frmRelatorioMotorista()
        {
            InitializeComponent();
            RelatorioBLL oBLL = new RelatorioBLL();
            try
            {
                cmbMotorista.Items.Clear();
                cmbMotorista.DataSource = oBLL.PesquisarMotoristas().Tables[0];
                cmbMotorista.DisplayMember = "Nome";
                cmbMotorista.ValueMember = "IdFuncionario";
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
                string caminhoRelatorio = "C:\\Users\\gui_v\\OneDrive\\Documentos\\Visual Studio 2019\\SGT-VS2019\\SGT-VS2019\\sistema\\relatorios\\rltMotorista.rdlc";
                RelatorioBLL oBLL = new RelatorioBLL();
                frm.reporViewer.LocalReport.ReportPath = caminhoRelatorio;
                Microsoft.Reporting.WinForms.ReportDataSource rptdBody = new Microsoft.Reporting.WinForms.ReportDataSource();
                rptdBody.Name = "DataSet1";
                FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
                string idMotorista = cmbMotorista.SelectedValue.ToString();
                Funcionario funcionario = funcionarioBLL.PesquisarFuncionarioId(int.Parse(idMotorista));
                rptdBody.Value = oBLL.rltMotorista(funcionario.IdFuncionario, dtpInicio.Value, dtpFinal.Value).Tables[0];
                frm.reporViewer.LocalReport.DataSources.Add(rptdBody);

                frm.reporViewer.LocalReport.SetParameters(new ReportParameter("NomeMotorista", funcionario.Nome));
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
