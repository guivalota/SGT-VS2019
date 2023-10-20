using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        public Cliente() { }

        public int Idcliente { get; set; }
        public string Nomerazaosocial { get; set; }
        public string CPFCNPJ { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Homepage { get; set; }
        public string ISRG { get; set; }
        public string Nomefantasia { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Telefone3 { get; set; }
        public string Telefone4 { get; set; }
        public string Tipo { get; set; }
        public string TipoTelefone1 { get; set; }
        public string TipoTelefone2 { get; set; }
        public string TipoTelefone3 { get; set; }
        public string TipoTelefone4 { get; set; }
        public string UF { get; set; }
    }
}
