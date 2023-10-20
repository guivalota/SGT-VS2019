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
            VeiculoBLL oBLL = new VeiculoBLL();
            Grid.DataSource = oBLL.PesquisarVeiculosList("");
            label2.Text = Grid.RowCount.ToString();
        }
    }
}
