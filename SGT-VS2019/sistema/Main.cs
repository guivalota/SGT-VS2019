﻿using SGT_VS2019.cliente;
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
    }
}
