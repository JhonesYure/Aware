using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Aware.Models;
using Microsoft.AspNetCore.Http;

namespace Aware.Controllers
{
    public class UsuarioController : Controller
    {
        //INSERIR
        public IActionResult Cadastro ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro (Usuario novoUser)
        {
            UsuarioService us = new UsuarioService();
            us.Inserir(novoUser);
            
            return View();
        }
        //LISTA
        public IActionResult Listagem()
        {
            //AUTENTICAÇÃO//
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaUsuarioAdmin(this);

            return View(new UsuarioService().Listar());
        }
        //EDITAR
        public IActionResult Excluir(int id)
        {
            UsuarioService us = new UsuarioService();
            Usuario usuarioEncontrado = us.BuscarId(id);

            return View(usuarioEncontrado);
        }
        [HttpPost]
        public IActionResult Excluir(string decisao, Usuario u)
        {
            UsuarioService us = new UsuarioService();
            if(decisao == "EXCLUIR")
            {
                ViewData["mensagem"]= "Conta deletada com sucesso!";
                us.Excluir(u.Id);

                return RedirectToAction("Index");
            }
            else
            {
                ViewData["mensagem"]= "Processo de exclusão cancelada";
                us.Excluir(u.Id);

                return RedirectToAction("Index");
            }
        }
         //ADMIN
        public IActionResult NeedAdmin()
        {
            //AUTENTICAÇÃO//
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaUsuarioAdmin(this);
            return View();
        }
        //LOGOUT
        public IActionResult Sair()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}