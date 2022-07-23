using System.Linq;
using System.Collections.Generic;
using System.Collections;
using Microsoft;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
namespace Biblioteca.Models
{
    public class Usuario
    {
        public static int ADMIN = 0;
        public static int BASICO = 1;
        public static int PESSOAL =2;
        public static int EMPRESARIAL = 3;

        public int ID {get;set;}
        public string Nome {get;set;}
        public string Login {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        
        public int Tipo {get;set;}
    }
}