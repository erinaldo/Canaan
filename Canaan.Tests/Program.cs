using Canaan.Servicos.Laboratorio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetList();
            GetItem(3);
        }

        public static void GetList()
        {
            var list = Cidade.GetByEstado(3);

            foreach (var item in list)
            {
                Console.WriteLine(string.Format("{0} - {1}", item.IdEstado, item.Nome));
            }
        }

        public static void GetItem(int id)
        {
            var item = Cidade.GetById(id);
            Console.WriteLine(string.Format("{0} - {1} : Single", item.IdCidade, item.Nome));
        }
    }
}
