using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class Session
    {
        public Dados.Usuario Usuario { get; set; }
        public Dados.UsuarioFilial Contexto { get; set; }
        public string LogoReport { get; set; }

        private static Session instance;
        

        private Session() { }

        public static Session Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }
    }
}
