using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class FuncionarioBLL
    {
        public DataSet PesquisarFuncionarios()
        {
            FuncionarioDAL oDAL = new FuncionarioDAL();
            return oDAL.PesquisarFuncionarios();
        }

        public DataSet PesquisarFuncionarioNome(string nome)
        {
            FuncionarioDAL oDAL = new FuncionarioDAL();
            return oDAL.PesquisarFuncionarioNome(nome);
        }

        public List<Funcionario> PesquisarFuncionarioNomeList(String nome)
        {
            FuncionarioDAL oDAL = new FuncionarioDAL();
            return oDAL.PesquisarFuncionarioNomeList(nome);
        }
    }
}
