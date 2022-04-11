using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEvolutionV1._3
{
    public class Parser
    {
        string url = @"https://www.avito.ru";
        string nameItem = "";        
        string prefix = $"rossiya?q={nameItem}";

        public Parser(string url)
        {
            this.url = url;
        }
    }
}
