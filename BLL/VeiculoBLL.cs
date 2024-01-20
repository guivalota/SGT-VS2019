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
        VeiculoDAL oDAL = new VeiculoDAL();
        public DataSet PesquisarVeiculos()
        {
            return oDAL.PesquisarVeiculos();
        }

        public DataSet PesquisarVeiculos(string nome)
        {
            return oDAL.PesquisarVeiculos(nome);
        }
        public List<Veiculo> PesquisarVeiculosList(string campo, string pesquisa, string status)
        {
            return oDAL.PesquisarVeiculosList(campo, pesquisa, status);
        }
        public Veiculo PesquisarVeiculoCodigoInterno(string pesquisa)
        {
            return oDAL.PesquisarVeiculoCodigoInterno(pesquisa);
        }
    }
}
