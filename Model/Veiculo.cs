using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Veiculo
    {
        public int IdVeiculo { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public string Chassi { get; set; }
        public string CodCertificado { get; set; }
        public string CodInterno { get; set; }
        public string CodRenavam { get; set; }
        public string Combustivel { get; set; }
        public string Cor { get; set; }
        public double Km { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public string Status { get; set; }

    }
}
