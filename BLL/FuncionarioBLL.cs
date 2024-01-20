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
        FuncionarioDAL oDAL = new FuncionarioDAL();
        public DataSet PesquisarFuncionarios()
        {
            return oDAL.PesquisarFuncionarios();
        }

        public DataSet PesquisarFuncionarioNome(string nome)
        {
            return oDAL.PesquisarFuncionarioNome(nome);
        }

        public List<Funcionario> PesquisarFuncionarioNomeList(String nome, String tipoPesquisa)
        {
            return oDAL.PesquisarFuncionarioNomeList(nome, tipoPesquisa);
        }

        public Funcionario PesquisarFuncionarioId(int idFuncionario)
        {
            return oDAL.PesquisarFuncionarioId(idFuncionario);
        }
    }
}
