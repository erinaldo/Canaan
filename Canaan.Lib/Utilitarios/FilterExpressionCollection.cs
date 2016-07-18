using Canaan.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class FilterExpressionCollection : BindingList<FilterExpression>
    {
        public void AddFilterExpression(FilterExpression filter)
        {
            Add(filter);
        }

        public string BuildExpression()
        {
            StringBuilder strBuilder = new StringBuilder();

            foreach (var expression in this.Select((item, i) => new { item, i }))
            {
                //if (expression.i % 2 != 0)
                //    strBuilder.Append(GetLogico(expression.item.Logico));
                if(expression.i != 0)
                    strBuilder.Append(GetLogico(expression.item.Logico));


                strBuilder.Append(expression.item.Property);
                strBuilder.Append(GetRelacional(expression.item.Relacional, expression.i));
            }

            return strBuilder.ToString();
        }

        private string GetLogico(EnumOperadorLogico enumOperadorLogico)
        {
            switch (enumOperadorLogico)
            {
                case EnumOperadorLogico.E:
                    return "&&";
                case EnumOperadorLogico.OU:
                    return "||";
                case EnumOperadorLogico.None :
                    return string.Empty;
                default:
                    return "&&";
            }
        }

        private string GetRelacional(EnumOperadorRelacional enumOperadorRelacional, int index)
        {
            switch (enumOperadorRelacional)
            {
                case EnumOperadorRelacional.Contains:
                    return string.Format(".Contains(@{0})", index);
                case EnumOperadorRelacional.Igual:
                    return string.Format("==@{0}", index);
                case EnumOperadorRelacional.MenorQue:
                    return string.Format("<@{0}", index);
                case EnumOperadorRelacional.MaiorQue:
                    return string.Format(">@{0}", index);
                default:
                    return string.Format("==@{0}", index);
            }

        }
    }
}
