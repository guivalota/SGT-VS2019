using BLL;
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
    public partial class frmClientePesquisa : Form
    {
        private int selectedRow = -1;
        public frmClientePesquisa()
        {
            InitializeComponent();
            Pesquisar();
            ConfigurarGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Pesquisar();
            }
        }

        private void Pesquisar()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                ClienteBLL oBLL = new ClienteBLL();
                Grid.DataSource = BLLGeral.ListToDataSet(oBLL.PesquisarClientesNomeList(txtNome.Text)).Tables[0];
                lblQtdRegistros.Text = "Registros: "+ Grid.RowCount.ToString();

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

        private void ConfigurarGrid()
        {
            Grid.Columns[0].Visible = false;
            Grid.Columns[1].Visible = true;
            Grid.Columns[1].HeaderText = "Nome/Razão Social";
            Grid.Columns[1].Width = 250;
            Grid.Columns[2].Visible = true;
            Grid.Columns[2].HeaderText = "Nome Fantasia";
            Grid.Columns[2].Width = 250;
            Grid.Columns[3].Visible = true;
            Grid.Columns[3].HeaderText = "CPF/CNPJ";
            Grid.Columns[3].Width = 120;
            Grid.Columns[4].Visible = true;
            Grid.Columns[4].HeaderText = "Documento";
            Grid.Columns[4].Width = 100;
            Grid.Columns[5].Visible = true;
            Grid.Columns[5].HeaderText = "Tipo";
            Grid.Columns[6].Visible = true;
            Grid.Columns[6].HeaderText = "Endereço";
            Grid.Columns[6].Width = 250;
            Grid.Columns[7].Visible = true;
            Grid.Columns[7].HeaderText = "E-mail";
            Grid.Columns[7].Width = 150;
            Grid.Columns[8].Visible = true;
            Grid.Columns[8].HeaderText = "Telefone 1";
            Grid.Columns[9].Visible = true;
            Grid.Columns[9].HeaderText = "Telefone 2";
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
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (selectedRow != -1)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    ClienteBLL oBLL = new ClienteBLL();
                    frmCliente frm = new frmCliente();
                    frm.clienteSelecionado = oBLL.PesquisarClientesId(int.Parse(Grid.Rows[selectedRow].Cells[0].Value.ToString()));
                    frm.PreencherCliente();
                    frm.BloquearCampos(false);
                    Cursor.Current = Cursors.Default;
                    frm.ShowDialog();
                }catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
                
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                frmCliente frm = new frmCliente();
                Cursor.Current = Cursors.Default;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (selectedRow != -1)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    ClienteBLL oBLL = new ClienteBLL();
                    frmCliente frm = new frmCliente();
                    frm.clienteSelecionado = oBLL.PesquisarClientesId(int.Parse(Grid.Rows[selectedRow].Cells[0].Value.ToString()));
                    frm.PreencherCliente();
                    frm.BloquearCampos(true);
                    Cursor.Current = Cursors.Default;
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
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (selectedRow != -1)
            {
                try
                {
                    var retorno = MessageBox.Show(this, "Tem certeza que deseja deletar esse Cliente?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(retorno == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        ClienteBLL oBLL = new ClienteBLL();
                        Cliente clienteDeletar = oBLL.PesquisarClientesId(int.Parse(Grid.Rows[selectedRow].Cells[0].Value.ToString()));
                        //Deletar Cliente
                        MessageBox.Show(this, "Cliente Excluido com sucesso!", "Sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
