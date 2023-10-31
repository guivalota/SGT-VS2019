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

namespace SGT_VS2019.veiculo
{
    public partial class frmVeiculoPesquisa : Form
    {
        public frmVeiculoPesquisa()
        {
            InitializeComponent();

            Pesquisar();
            ConfigurarGrid();
        }

        private void Pesquisar()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                VeiculoBLL oBLL = new VeiculoBLL();

                String status = "Todos";
                String pesquisa = txtPlaca.Text;

                if (rdbAtivos.Checked)
                {
                    status = "Ativo";
                }else if (rdbInativo.Checked)
                {
                    status = "Inativo";
                }

                Grid.DataSource = BLLGeral.ListToDataSet(oBLL.PesquisarVeiculosList("Placa",pesquisa, status)).Tables[0];
                label2.Text = "Registros: "+ Grid.RowCount.ToString();
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
            Grid.Columns[1].HeaderText = "Placa";
            //Grid.Columns[1].Width = 250;
            Grid.Columns[2].Visible = true;
            Grid.Columns[2].HeaderText = "Status";
            //Grid.Columns[2].Width = 250;
            Grid.Columns[3].Visible = true;
            Grid.Columns[3].HeaderText = "Código Interno";
            //Grid.Columns[3].Width = 120;
            Grid.Columns[4].Visible = true;
            Grid.Columns[4].HeaderText = "Marca";
            //Grid.Columns[4].Width = 100;
            Grid.Columns[5].Visible = true;
            Grid.Columns[5].HeaderText = "Modelo";
            Grid.Columns[6].Visible = true;
            Grid.Columns[6].HeaderText = "Ano Modelo";
            //Grid.Columns[6].Width = 250;
            Grid.Columns[7].Visible = true;
            Grid.Columns[7].HeaderText = "Ano Fabricação";
            //Grid.Columns[7].Width = 150;
            Grid.Columns[8].Visible = true;
            Grid.Columns[8].HeaderText = "Cor";
            Grid.Columns[9].Visible = true;
            Grid.Columns[9].HeaderText = "Renavam";
            Grid.Columns[10].Visible = true;
            Grid.Columns[10].HeaderText = "Código Certificaddo";
            Grid.Columns[11].Visible = true;
            Grid.Columns[11].HeaderText = "Kilometragem";
            Grid.Columns[12].Visible = false;
            Grid.Columns[13].Visible = false;
            Grid.Columns[14].Visible = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
            ConfigurarGrid();
        }
    }
}
