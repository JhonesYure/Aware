using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Aware.Models;

namespace Aware.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {
            if(string.IsNullOrEmpty(controller.HttpContext.Session.GetString("login")))
            {
                controller.Request.HttpContext.Response.Redirect("Home/Index");
            }
        }

        public static bool VerificaLoginSenha(string login, string senha, Controller controller)
        {
           using(AwareContext ac = new AwareContext())
           {
              IQueryable<Usuario> UsuarioEncontrado = ac.Usuarios.Where(u => u.Login == login && u.Senha == senha);
              List<Usuario> ListaUsuario = UsuarioEncontrado.ToList();

              if(ListaUsuario.Count==0)
              {
                return false;
              }
              else
              {
                controller.HttpContext.Session.SetString("login", ListaUsuario[0].Login);
                controller.HttpContext.Session.SetString("nome", ListaUsuario[0].Nome);
                controller.HttpContext.Session.SetInt32("tipo", ListaUsuario[0].Tipo);

                return true;
              }
           }
        }

        //ADMIN
        public static void verificaAdmin(AwareContext ac)
        {
            IQueryable<Usuario> UsuarioEncontrado = ac.Usuarios.Where(u => u.Login=="admin");

            if (UsuarioEncontrado.ToList().Count==0)
            {
                Usuario admin = new Usuario();
                admin.Nome  = "Administrador";
                admin.Login = "admin";
                admin.Senha = Criptografia.txtcripto("123");
                admin.Tipo = Usuario.ADMIN;

                ac.Usuarios.Add(admin);
                ac.SaveChanges();
            }
        }

        public static void verificaUsuarioAdmin(Controller controller)
        {
            if(!(controller.HttpContext.Session.GetInt32("tipo")==Usuario.ADMIN))
            {
                controller.Request.HttpContext.Response.Redirect("/Usuario/NeedAdmin");
            }
        }
    }
}