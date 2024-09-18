using System;
using System.Collections.Generic;
using EvaluaciónParcial2Banco.Models;

namespace EvaluaciónParcial2Banco.Controllers
{
    public class ClientesController
    {
        // Método para insertar un cliente
        public ClientesModel InsertarCliente(ClientesModel cliente)
        {
            return ClientesModel.Insertar(cliente);
        }

        // Método para actualizar un cliente
        public string ActualizarCliente(ClientesModel cliente)
        {
            return ClientesModel.Actualizar(cliente);
        }

        // Método para eliminar un cliente
        public string EliminarCliente(int idCliente)
        {
            return ClientesModel.Eliminar(idCliente);
        }

        // Método para obtener un cliente por ID
        public ClientesModel ObtenerClientePorId(int idCliente)
        {
            return ClientesModel.ObtenerPorId(idCliente);
        }

        // Método para obtener todos los clientes
        public List<ClientesModel> ObtenerTodosLosClientes()
        {
            return ClientesModel.ObtenerTodos();
        }
    }
}
