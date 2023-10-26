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
    public class ClienteBLL
    {
        public DataSet PesquisarClientes()
        {
            ClienteDAL oDAL = new ClienteDAL();
            return oDAL.PesquisarClientes();
        }

        public DataSet PesquisarClientes(string nome)
        {
            ClienteDAL oDAL = new ClienteDAL();
            return oDAL.PesquisarClientesNome(nome);
        }

        public Cliente PesquisarClientesId(int id)
        {
            ClienteDAL oDAL = new ClienteDAL();
            return oDAL.PesquisarClientesId(id);
        }

        public List<Cliente> PesquisarClientesNomeList(String nome)
        {
            ClienteDAL oDAL = new ClienteDAL();
            return oDAL.PesquisarClientesNomeList(nome);
        }
    }
}
