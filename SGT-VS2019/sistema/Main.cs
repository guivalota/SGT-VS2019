using BLL;
using Microsoft.Reporting.WinForms;
using SGT_VS2019.cliente;
using SGT_VS2019.contrato;
using SGT_VS2019.funcionario;
using SGT_VS2019.sistema;
using SGT_VS2019.sistema.relatorios;
using SGT_VS2019.veiculo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGT_VS2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuCliente_Click(object sender, EventArgs e)
        {
            frmClientePesquisa frm = new frmClientePesquisa();
            frm.ShowDialog();
        }

        private void mnuVeiculo_Click(object sender, EventArgs e)
        {
            frmVeiculoPesquisa frm = new frmVeiculoPesquisa();
            frm.ShowDialog();
        }

        private void mnuFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionarioPesquisa frm = new frmFuncionarioPesquisa();
            frm.ShowDialog();
        }

        private void mnucontratosCadastrados_Click(object sender, EventArgs e)
        {
            frmContratosCadastrados frm = new frmContratosCadastrados();
            frm.ShowDialog();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuNovoContrato_Click(object sender, EventArgs e)
        {
            frmNovoContrato frm = new frmNovoContrato();
            frm.ShowDialog();
        }

        private void mnuRelatorioCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                frmRelatorio frm = new frmRelatorio();
                //string caminhoRelatorio = Environment.CurrentDirectory + "\\sistemas\\relatorios\\rltCliente.rlc";
                string caminhoRelatorio = "C:\\Users\\gui_v\\OneDrive\\Documentos\\Visual Studio 2019\\SGT-VS2019\\SGT-VS2019\\sistema\\relatorios\\rltCliente.rdlc";
                ClienteBLL oBLL = new ClienteBLL();

                DataSet dt = oBLL.PesquisarClientes();
                frm.reporViewer.LocalReport.ReportPath = caminhoRelatorio;
                Microsoft.Reporting.WinForms.ReportDataSource rptdBody = new Microsoft.Reporting.WinForms.ReportDataSource();
                rptdBody.Name = "DataSet";
                rptdBody.Value = BLLGeral.ListToDataSet(oBLL.PesquisarClientesNomeList("")).Tables[0];
                frm.reporViewer.LocalReport.DataSources.Add(rptdBody);
                frm.Show();

            }
            catch(Exception ex)
            {

            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            
        }

        private void mnuRelatorioVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                frmRelatorioOleoDiesel frm = new frmRelatorioOleoDiesel();
                frm.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void mnuRelatorioMotorista_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                frmRelatorioMotorista frm = new frmRelatorioMotorista();
                frm.ShowDialog();
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

        private void mnuRelatorioOleoDiesel_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                frmRelatorio frm = new frmRelatorio();
                //string caminhoRelatorio = Environment.CurrentDirectory + "\\sistemas\\relatorios\\rltCliente.rlc";
                string caminhoRelatorio = "C:\\Users\\gui_v\\OneDrive\\Documentos\\Visual Studio 2019\\SGT-VS2019\\SGT-VS2019\\sistema\\relatorios\\contratoLocacao1.rdlc";
                //ClienteBLL oBLL = new ClienteBLL();

                //DataSet dt = oBLL.PesquisarClientes();
                frm.reporViewer.LocalReport.ReportPath = caminhoRelatorio;
                //Microsoft.Reporting.WinForms.ReportDataSource rptdBody = new Microsoft.Reporting.WinForms.ReportDataSource();
                //rptdBody.Name = "DataSet";
                //rptdBody.Value = BLLGeral.ListToDataSet(oBLL.PesquisarClientesNomeList("")).Tables[0];
                //frm.reporViewer.LocalReport.DataSources.Add(rptdBody);
                frm.Show();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
