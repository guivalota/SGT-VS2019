using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }

        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public string Conjuge { get; set; }
        public string Ctps { get; set; }
        public DateTime? DataNascimento { get; set; }
        public DateTime? DataNascimentoConjuge { get; set; }
        public string Filho { get; set; }
        public string Habilitacao { get; set; }
        public string NumeroHabilitacao { get; set; }
        public string Serie { get; set; }
        public string Telefone3 { get; set; }
        public string Telefone4 { get; set; }
        public string Uf { get; set; }
        public DateTime? ValidadeCnh { get; set; }
        public string status { get; set; }
    }
}
