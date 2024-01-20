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
            ConfigurarGrid();
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

        private void ConfigurarGrid()
        {
            Grid.Columns[0].Visible = false;
            Grid.Columns[1].Visible = true;
            Grid.Columns[1].HeaderText = "Nome";
            Grid.Columns[1].Width = 250;
            Grid.Columns[2].Visible = true;
            Grid.Columns[2].HeaderText = "Cargo";
            Grid.Columns[2].Width = 100;
            Grid.Columns[3].Visible = true;
            Grid.Columns[3].HeaderText = "CPF";
            Grid.Columns[3].Width = 100;
            Grid.Columns[4].Visible = true;
            Grid.Columns[4].HeaderText = "RG";
            Grid.Columns[4].Width = 90;
            Grid.Columns[5].Visible = true;
            Grid.Columns[5].HeaderText = "Endereço";
            Grid.Columns[5].Width = 250;
            Grid.Columns[6].Visible = true;
            Grid.Columns[6].HeaderText = "E-mail";
            Grid.Columns[6].Width = 250;
            Grid.Columns[7].Visible = true;
            Grid.Columns[7].HeaderText = "Telefone";
            Grid.Columns[7].Width = 100;
            Grid.Columns[8].Visible = true;
            Grid.Columns[8].HeaderText = "Celular";
            Grid.Columns[8].Width = 100;
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
            Grid.Columns[19].Visible = false;
            Grid.Columns[20].Visible = false;
            Grid.Columns[21].Visible = false;
            Grid.Columns[22].Visible = false;
            Grid.Columns[23].Visible = false;
            Grid.Columns[24].Visible = false;
            Grid.Columns[25].Visible = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
