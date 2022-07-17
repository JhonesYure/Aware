using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Aware.Models
{
    public class UsuarioService
    {
        //LISTAR 
        public List<Usuario> Listar()
        {
            using(AwareContext ac = new AwareContext())
            {
                return ac.Usuarios.ToList();
            }
        }
        public Usuario Lista(int id)
        {
            using(AwareContext ac = new AwareContext())
            {
                return ac.Usuarios.Find(id);
            }
        }
        //INSERIR USUARIO
        public void Inserir(Usuario novoUser)
        {
            using(AwareContext ac = new AwareContext())
            {
                ac.Usuarios.Add(novoUser);
                ac.SaveChanges();
            }
        }
        //EDITAR
        public void EditarUsuario(Usuario editaUser)
        {
            using(AwareContext ac = new AwareContext())
            {
                Usuario u = ac.Usuarios.Find(editaUser.Id);
                u.Nome = editaUser.Nome;
                u.Login = editaUser.Login;
                u.Email = editaUser.Email;
                u.Senha = editaUser.Senha;
                u.Tipo = editaUser.Tipo;

                ac.SaveChanges();
            }
        }
        //EXCLUIR USUARIO
        public void Excluir(int id)
        {
            using(AwareContext ac = new AwareContext())
            {
                Usuario UserEncontrado = ac.Usuarios.Find(id);
                ac.Usuarios.Remove(UserEncontrado);

                ac.SaveChanges();
            }
        }
        //BUSCAR POR ID
        public Usuario BuscarId (int id)
        {
            using(AwareContext ac = new AwareContext())
            {
                return ac.Usuarios.Find(id);
            }
        }

        public Usuario GetPostDetail(int id)
        {
            using(var context = new AwareContext())
            {
                Usuario registro = context.Usuarios.Where( p => p.Id == id).SingleOrDefault();

                return registro;
            }
        }
    }
}