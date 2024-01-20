using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Relatorios
{
    public class rltOleoDiesel
    {
        public DateTime dia { get; set; }
        public double kmInicial { get; set; }
        public double kmFinal { get; set; }
        public double kmtotal { get; set; }
        public double lGastos { get; set; }
        public double gastoCombustivel { get; set; }
        public double despesas { get; set; }
        public double lucroViagem { get; set; }
    }
}
