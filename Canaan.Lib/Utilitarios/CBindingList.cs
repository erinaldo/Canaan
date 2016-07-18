using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Utilitarios
{
    public class CBindingList<T> : BindingList<T>
    {

        public CBindingList(IList<T> list)
            :base(list)
        {

        }

        public void AddRange(IList<T> source)
        {
            foreach (var item in source)
            {
                Add(item);
            }
        }
    }
}
