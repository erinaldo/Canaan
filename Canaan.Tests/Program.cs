using Canaan.Servicos.Laboratorio.Services;
using System;
using System.Collections.Generic;
using System.IO;
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
            //GetItem(3);
            
            var imagem = File.ReadAllBytes(@"C:\Users\jobvi\Pictures\DSC_003801.canaan");
            var decrypt = Canaan.Lib.Utilitarios.Criptografia.Descriptografa(imagem);

            File.WriteAllBytes(@"C:\Users\jobvi\Pictures\DSC_003801.jpg", imagem);
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
