using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Currency.Proxy.Models
{
    public class CurrenciesResult
    {
        public int code { get; }
        public Currencies[] currencies { get; set; }
        public string source { get; }

        public CurrenciesResult() 
        {
            code = 200;
            source = "currencies.proxy.source";
        }

    }
}
