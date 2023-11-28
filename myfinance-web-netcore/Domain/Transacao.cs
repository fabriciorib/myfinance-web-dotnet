using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myfinance_web_netcore.Domain
{
    public class Transacao
    {
        public int Id {get;set;}
        public string Historico {get;set;}
        public string Tipo {get;set;}
        public double Valor {get;set;}
        public int Planocontaid {get;set;}
        public DateTime data {get;set;}
        public PlanoConta PlanoConta {get;set;}
    }
}