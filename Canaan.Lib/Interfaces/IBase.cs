using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    interface IBase<T>
    {
        List<T> Get();
        List<T> GetByNome(string nome);
        List<T> Filter(string filtro, object[] parameters);
        T GetById(int id);
        T Insert(T item);
        T Update(T item);
        T Delete(int id);
        dynamic CarregaGrid(List<T> lista);
    }
}
