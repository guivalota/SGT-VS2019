using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Contrato
    {
        public int IdContrato { get; set; }
        public string CaminhoArquivo { get; set; }
        public DateTime? DataContrato { get; set; }
        public DateTime? DataFinal { get; set; }
        public DateTime? DataInicio { get; set; }
        public string Destino { get; set; }
        public int Diarias { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime? HorarioFinal { get; set; }
        public DateTime? HorarioInicial { get; set; }
        public int IdGastos { get; set; }
        public int IdLocatario { get; set; }
        public string NomeLocatario { get; set; }
        public int IdMotorista { get; set; }
        public string NomeMotorista { get; set; }
        public double KmFinal { get; set; }
        public double KmInicial { get; set; }
        public string Placa { get; set; }
        public double Valor { get; set; }
    }
}
