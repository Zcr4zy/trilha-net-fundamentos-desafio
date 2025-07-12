using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Modelo { get; set; }  
        public int? NumeroTicketEstacionamento { get; set; }
    }
}