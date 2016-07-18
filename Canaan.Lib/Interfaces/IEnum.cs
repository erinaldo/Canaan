using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public interface IEnum<T>
    {
        Dictionary<int, string> GetValuesFromEnum();
        Dictionary<int, string> GetValuesFromEnum(string descricao);
        T GetEnumForKey(int key);
    }
}
