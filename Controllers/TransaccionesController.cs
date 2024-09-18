using System;
using System.Collections.Generic;
using EvaluaciónParcial2Banco.Models;

namespace EvaluaciónParcial2Banco.Controllers
{
    public class TransaccionesController
    {
        // Método para insertar una transacción
        public TransaccionesModel InsertarTransaccion(TransaccionesModel transaccion)
        {
            return TransaccionesModel.Insertar(transaccion);
        }

        // Método para actualizar una transacción
        public string ActualizarTransaccion(TransaccionesModel transaccion)
        {
            return TransaccionesModel.Actualizar(transaccion);
        }

        // Método para eliminar una transacción
        public string EliminarTransaccion(int idTransaccion)
        {
            return TransaccionesModel.Eliminar(idTransaccion);
        }

        // Método para obtener una transacción por ID
        public TransaccionesModel ObtenerTransaccionPorId(int idTransaccion)
        {
            return TransaccionesModel.ObtenerPorId(idTransaccion);
        }

        // Método para obtener todas las transacciones
        public List<TransaccionesModel> ObtenerTodasLasTransacciones()
        {
            return TransaccionesModel.ObtenerTodos();
        }
    }
}
