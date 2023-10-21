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

namespace SGT_VS2019.contrato
{
    public partial class frmContratosCadastrados : Form
    {
        public frmContratosCadastrados()
        {
            InitializeComponent();
            ContratoBLL BLL = new ContratoBLL();

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Grid.DataSource = BLLGeral.ListToDataSet(BLL.PesquisarContratoList("")).Tables[0];
                lblQtdGrid.Text = Grid.Rows.Count.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro: "+ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            
        }
    }
}
