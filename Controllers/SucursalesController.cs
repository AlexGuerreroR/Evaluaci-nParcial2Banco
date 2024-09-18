using System;
using System.Collections.Generic;
using EvaluaciónParcial2Banco.Models;

namespace EvaluaciónParcial2Banco.Controllers
{
    public class SucursalesController
    {
        // Método para insertar una sucursal
        public SucursalesModel InsertarSucursal(SucursalesModel sucursal)
        {
            return SucursalesModel.Insertar(sucursal);
        }

        // Método para actualizar una sucursal
        public string ActualizarSucursal(SucursalesModel sucursal)
        {
            return SucursalesModel.Actualizar(sucursal);
        }

        // Método para eliminar una sucursal
        public string EliminarSucursal(int idSucursal)
        {
            return SucursalesModel.Eliminar(idSucursal);
        }

        // Método para obtener una sucursal por ID
        public SucursalesModel ObtenerSucursalPorId(int idSucursal)
        {
            return SucursalesModel.ObtenerPorId(idSucursal);
        }

        // Método para obtener todas las sucursales
        public List<SucursalesModel> ObtenerTodasLasSucursales()
        {
            return SucursalesModel.ObtenerTodos();
        }
    }
}

