using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aware.Models
{
    public class Usuario
    {
        public static int ADMIN = 0;
        public static int BASICO =1;
        public static int PESSOAL=2;
        public static int EMPRESARIAL=3;

        public int Id {get;set;}
        public string Nome {get;set;}
        public string Login {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}

        public int Tipo {get;set;}
    }
}