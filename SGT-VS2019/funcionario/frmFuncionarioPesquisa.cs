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
            FuncionarioBLL BLL = new FuncionarioBLL();
            var lista = BLL.PesquisarFuncionarioNomeList("");
            Grid.DataSource = lista;
            label1.Text = Grid.Rows.Count.ToString();
        }
    }
}
