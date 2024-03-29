using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {   
            if(string.IsNullOrEmpty(controller.HttpContext.Session.GetString("login")))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }
        public static bool VerificaLoginSenha(string login, string senha, Controller controller)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                verificarAdmin(bc);
               
                senha = Criptografia.txtcripto(senha);

                IQueryable<Usuario> UsuarioEncontrado = bc.Usuarios.Where(u => u.Login == login && u.Senha== senha);
                List<Usuario> ListaUsuarioEncontrado = UsuarioEncontrado.ToList();

                if(ListaUsuarioEncontrado.Count==0)
                {
                    return false;
                } else 
                {
                    controller.HttpContext.Session.SetString("login", ListaUsuarioEncontrado[0].Login);
                    controller.HttpContext.Session.SetString("nome", ListaUsuarioEncontrado[0].Nome);
                    controller.HttpContext.Session.SetInt32("tipo", ListaUsuarioEncontrado[0].Tipo);

                    return true;
                }
            }
        }
        //ADMIN
        public static void verificarAdmin(BibliotecaContext bc)
        {
          
               IQueryable<Usuario> UsuarioEncontrado = bc.Usuarios.Where(u => u.Login == "admin");

               if (UsuarioEncontrado.ToList().Count==0)
               {
                   Usuario admin = new Usuario();
                   admin.Nome = "Administrador";
                   admin.Login = "admin";
                   admin.Senha = Criptografia.txtcripto("123");
                   admin.Tipo = Usuario.ADMIN;

                   bc.Usuarios.Add(admin);
                   bc.SaveChanges();
               }
           
        }
        public static void verificarUsuarioAdmin(Controller controller)
        {
            if(!(controller.HttpContext.Session.GetInt32("tipo")== Usuario.ADMIN))
            {
                controller.Request.HttpContext.Response.Redirect("/Usuario/NeedAdmin");
            }
        }
       
    }

}