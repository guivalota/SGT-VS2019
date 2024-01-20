using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RelatorioBLL
    {
        RelatorioDAL DAL = new RelatorioDAL();
        public DataSet rltOleoDiesel(string placa, DateTime dtInicial, DateTime dtFinal)
        {
            return DAL.rltOleoDiesel(placa, dtInicial, dtFinal);
        }
        public DataSet ListarVeiculosRelatorioOeloDiesel()
        {
            return DAL.ListarVeiculosRelatorioOeloDiesel();
        }
        public DataSet PesquisarMotoristas()
        {
            return DAL.PesquisarMotoristas();
        }
        public DataSet rltMotorista(int idMotorista, DateTime dtInicial, DateTime dtFinal)
        {
            return DAL.rltMotorista(idMotorista, dtInicial, dtFinal);
        }
    }
}
