
using System.Collections.Generic;
using EvaluaciónParcial2Banco.Models;

namespace EvaluaciónParcial2Banco.Controllers
{
    internal class UsuariosController
    {

      
        public UsuariosModel InsertarUsuario(UsuariosModel usuario)
        {
            return UsuariosModel.Insertar(usuario);
        }

        public string ActualizarUsuario(UsuariosModel usuario)
        {
            return UsuariosModel.Actualizar(usuario);
        }

        public string EliminarUsuario(int idUsuario)
        {
            return UsuariosModel.Eliminar(idUsuario);
        }

        public UsuariosModel ObtenerUsuarioPorId(int idUsuario)
        {
            return UsuariosModel.ObtenerPorId(idUsuario);
        }

        public List<UsuariosModel> ObtenerUsuarios()
        {
            return UsuariosModel.ObtenerTodos();
        }

        public UsuariosModel AutenticarUsuario(string nombreUsuario, string password)
        {
            return UsuariosModel.Autenticar(nombreUsuario, password);
        }
    }
}
