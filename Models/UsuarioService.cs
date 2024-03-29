using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Models
{
    public class UsuarioService
    {
        //LISTAR
        public List<Usuario> Listar()
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuarios.ToList();
            }
        }
        public Usuario Listar(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuarios.Find(id);
            }
        }
        //INCLUIR
        public void Inserir(Usuario novoUsuario)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
               novoUsuario.Senha = Criptografia.txtcripto(novoUsuario.Senha);
               bc.Usuarios.Add(novoUsuario);
               bc.SaveChanges();
            }
        }
        //EDITAR
            public void EditarUsuario(Usuario editaUsuario)
            {
                using(BibliotecaContext bc = new BibliotecaContext())
                {
                    Usuario u = bc.Usuarios.Find(editaUsuario.ID);
                    u.Nome = editaUsuario.Nome;
                    u.Login = editaUsuario.Login;
                    u.Email = editaUsuario.Email;
                    u.Senha = Criptografia.txtcripto("senha");
                    u.Tipo = editaUsuario.Tipo;

                    bc.SaveChanges();
                }
            }
            //EXCLUIR
            public void Excluir(int id)
            {
                using(BibliotecaContext bc = new BibliotecaContext())
                {
                   Usuario UsuarioEncontrado = bc.Usuarios.Find(id);
                   bc.Usuarios.Remove(UsuarioEncontrado);

                    bc.SaveChanges();
                }
            }   
            //BUSCAR ID
            public Usuario BuscarId(int id)
            {
                using (BibliotecaContext bc = new BibliotecaContext())
                {
                    return bc.Usuarios.Find(id);
                }
            } 

            public Usuario GetPostDetail(int id)
            {
                using (var context = new BibliotecaContext())
                {
                    Usuario registro = context.Usuarios.Where(p => p.ID == id).SingleOrDefault();

                    return registro;
                }
            }
    }
}