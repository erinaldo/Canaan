using System;
using System.Collections.Generic;
using System.Linq;

namespace Canaan.Dados
{
    public class FilterAttribute : Attribute
    {
        public string Nome { get; set; }
        public bool Recursive { get; set; }
    }
}
