using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ContratoBLL
    {
        public DataSet PesquisarContrato()
        {
            ContratoDAL DAL = new ContratoDAL();
            return DAL.PesquisarContrato();
        }

        public DataSet PesquisarContrato(string arg)
        {
            ContratoDAL DAL = new ContratoDAL();
            return DAL.PesquisarContrato(arg);
        }

        public List<Contrato> PesquisarContratoList(string arg)
        {
            ContratoDAL DAL = new ContratoDAL();
            return DAL.PesquisarContratoList(arg);
        }
    }
}
