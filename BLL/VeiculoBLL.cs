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
    public class VeiculoBLL
    {
        public DataSet PesquisarVeiculos()
        {
            VeiculoDAL oDAL = new VeiculoDAL();
            return oDAL.PesquisarVeiculos();
        }

        public DataSet PesquisarVeiculos(string nome)
        {
            VeiculoDAL oDAL = new VeiculoDAL();
            return oDAL.PesquisarVeiculos(nome);
        }
        public List<Veiculo> PesquisarVeiculosList(string campo, string pesquisa, string status)
        {
            VeiculoDAL oDAL = new VeiculoDAL();
            return oDAL.PesquisarVeiculosList(campo, pesquisa, status);
        }
    }
}
