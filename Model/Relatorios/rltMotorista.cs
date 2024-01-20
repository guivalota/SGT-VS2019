using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Relatorios
{
    public class rltMotorista
    {
        public DateTime dia { get; set; }
        public double Alimentacao { get; set; }
        public double Hospedagem { get; set; }
        public double Estacionamento { get; set; }
        public double Pedagio { get; set; }
        public double Diaria { get; set; }
        public double Outros { get; set; }
    }
}
