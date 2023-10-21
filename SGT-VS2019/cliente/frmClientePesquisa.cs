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

namespace SGT_VS2019.cliente
{
    public partial class frmClientePesquisa : Form
    {
        public frmClientePesquisa()
        {
            InitializeComponent();
            ClienteBLL oBLL = new ClienteBLL();
            Grid.DataSource = BLLGeral.ListToDataSet(oBLL.PesquisarClientesNomeList(txtNome.Text)).Tables[0];
            label2.Text = Grid.RowCount.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ClienteBLL oBLL = new ClienteBLL();
            Grid.DataSource = BLLGeral.ListToDataSet(oBLL.PesquisarClientesNomeList(txtNome.Text)).Tables[0];
            label2.Text = Grid.RowCount.ToString();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ClienteBLL oBLL = new ClienteBLL();
                
                Grid.DataSource = BLLGeral.ListToDataSet(oBLL.PesquisarClientesNomeList(txtNome.Text)).Tables[0];
                label2.Text = Grid.RowCount.ToString();
            }
        }


    }
}
