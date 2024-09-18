using System;
using System.Collections.Generic;
using EvaluaciónParcial2Banco.Models;

namespace EvaluaciónParcial2Banco.Controllers
{
    public class CuentasController
    {
        // Método para insertar una cuenta
        public CuentasModel InsertarCuenta(CuentasModel cuenta)
        {
            return CuentasModel.Insertar(cuenta);
        }

        // Método para actualizar una cuenta
        public string ActualizarCuenta(CuentasModel cuenta)
        {
            return CuentasModel.Actualizar(cuenta);
        }

        // Método para eliminar una cuenta
        public string EliminarCuenta(int idCuenta)
        {
            return CuentasModel.Eliminar(idCuenta);
        }

        // Método para obtener una cuenta por ID
        public CuentasModel ObtenerCuentaPorId(int idCuenta)
        {
            return CuentasModel.ObtenerPorId(idCuenta);
        }

        // Método para obtener todas las cuentas
        public List<CuentasModel> ObtenerTodasLasCuentas()
        {
            return CuentasModel.ObtenerTodos();
        }
    }
}
