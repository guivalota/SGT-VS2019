using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RelatorioDAL
    {
        public DataSet rltOleoDiesel(string placa, DateTime dtInicial, DateTime dtFinal)
        {
            GeralDAL geralDAL = new GeralDAL();
            StringBuilder sql = new StringBuilder();
            sql.Append(" select c.datacontrato as dia, gv.KMINICIAL, gv.KMFINAL, (gv.KMFINAL - gv.KMINICIAL) KMTOTAL,gv.GASTOCOMBUSTIVEL lgastos, (gv.GASTOCOMBUSTIVEL * (gv.KMFINAL - gv.KMINICIAL)) as GASTOCOMBUSTIVEL, (gv.GASTOALIMENTACAO+gv.GASTOCOMBUSTIVEL+gv.GASTOESTACIONAMENTO+gv.GASTOHOSPEDAGEM+gv.GASTOOUTROS+gv.GASTOPEDAGIO+gv.DIARIAMOTORISTA) DESPESAS, ");
            sql.Append("  (gv.TOTALENTRADA- (gv.GASTOALIMENTACAO+gv.GASTOCOMBUSTIVEL+gv.GASTOESTACIONAMENTO+gv.GASTOHOSPEDAGEM+gv.GASTOOUTROS+gv.GASTOPEDAGIO+gv.DIARIAMOTORISTA)) LUCROVIAGEM ");
            sql.Append(" from gastoviagem gv ");
            sql.Append(" inner join contrato c on(c.idcontrato = gv.idcontrato) ");
            sql.Append(" where gv.idcontrato != 0 and c.placa = '" + placa + "' and c.datacontrato>= '" + dtInicial.ToString("yyyy-MM-dd") + "' and c.datacontrato<= '" +dtFinal.ToString("yyyy-MM-dd")+"'");

            return geralDAL.PegarDataSet(sql.ToString());
        }

        public DataSet ListarVeiculosRelatorioOeloDiesel()
        {
            GeralDAL geralDAL = new GeralDAL();
            string sql = "Select codigoInterno, placa from VEICULO WHERE status  = 'Ativo'";
            return geralDAL.PegarDataSet(sql);
        }

        public DataSet PesquisarMotoristas()
        {
            GeralDAL geralDAL = new GeralDAL();
            string sql = "Select idfuncionario, nome from FUNCIONARIO where status = 'Ativo' order by nome";
            return geralDAL.PegarDataSet(sql);
        }

        public DataSet rltMotorista(int idMotorista, DateTime dtInicial, DateTime dtFinal)
        {
            GeralDAL geralDAL = new GeralDAL();
            StringBuilder sql = new StringBuilder();
            sql.Append(" select c.datacontrato as dia, gv.gastoalimentacao Alimentacao, gv.GASTOHOSPEDAGEM hospedagem, gv.GASTOESTACIONAMENTO estacionamento, gv.GASTOPEDAGIO Pedagio, gv.DIARIAMOTORISTA diaria, gv.GASTOOUTROS outros ");
            sql.Append(" from gastoviagem gv ");
            sql.Append(" inner join contrato c on(c.idcontrato = gv.idcontrato) ");
            sql.Append(" where gv.idcontrato != 0 and c.idmotorista = " + idMotorista + " and c.datacontrato>= '" + dtInicial.ToString("yyyy-MM-dd") + "' and c.datacontrato<= '" + dtFinal.ToString("yyyy-MM-dd") + "' order by c.datacontrato");

            return geralDAL.PegarDataSet(sql.ToString());
        }

    }
}
