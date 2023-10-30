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

namespace SGT_VS2019.funcionario
{
    public partial class frmFuncionarioPesquisa : Form
    {
        public frmFuncionarioPesquisa()
        {
            InitializeComponent();

            Pesquisar();

        }

        public void Pesquisar()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                FuncionarioBLL oBLL = new FuncionarioBLL();

                string status = "Todos";
                if (rdbAtivos.Checked)
                {
                    status = "Ativo";
                }else if (rdbInativos.Checked)
                {
                    status = "Inativo";
                }

                Grid.DataSource = BLLGeral.ListToDataSet(oBLL.PesquisarFuncionarioNomeList(txtNome.Text, status)).Tables[0];
                lblQtdRegistros.Text = "Registros: " + Grid.RowCount.ToString();
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}
