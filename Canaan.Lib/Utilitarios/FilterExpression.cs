using Canaan.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class FilterExpression : IEqualityComparer<FilterExpression>
    {
        public string Property { get; set; }
        public EnumOperadorLogico Logico { get; set; }
        public EnumOperadorRelacional Relacional { get; set; }
        public string Type { get; set; }
        public string Valor { get; set; }
        public string Classe { get; set; }

        public FilterExpression()
        {

        }

        public bool Equals(FilterExpression x, FilterExpression y)
        {
            if (x.Property == y.Property)
                return true;

            return false;
        }

        public int GetHashCode(FilterExpression obj)
        {
            int hCode = obj.Property.Length;
            return hCode.GetHashCode();
        }
    }
}
