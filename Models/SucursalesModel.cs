using EvaluaciónParcial2Banco.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EvaluaciónParcial2Banco.Models
{
    public class SucursalesModel
    {
        public int ID_Sucursal { get; set; }
        public string Nombre_Sucursal { get; set; }
        public string Direccion { get; set; }

        // Constructor vacío
        public SucursalesModel() { }

        // Método para insertar una nueva sucursal y retornar el registro insertado
        public static SucursalesModel Insertar(SucursalesModel sucursal)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO Sucursales (Nombre_Sucursal, Direccion) " +
                                   "OUTPUT INSERTED.ID_Sucursal, INSERTED.Nombre_Sucursal, INSERTED.Direccion " +
                                   "VALUES (@Nombre_Sucursal, @Direccion)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre_Sucursal", sucursal.Nombre_Sucursal);
                        comando.Parameters.AddWithValue("@Direccion", sucursal.Direccion);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new SucursalesModel
                                {
                                    ID_Sucursal = (int)lector["ID_Sucursal"],
                                    Nombre_Sucursal = lector["Nombre_Sucursal"].ToString(),
                                    Direccion = lector["Direccion"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar la sucursal.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar la sucursal.");
            }
            return null;
        }

        // Método para actualizar una sucursal existente y retornar "OK"
        public static string Actualizar(SucursalesModel sucursal)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE Sucursales SET Nombre_Sucursal = @Nombre_Sucursal, Direccion = @Direccion WHERE ID_Sucursal = @ID_Sucursal";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Sucursal", sucursal.ID_Sucursal);
                        comando.Parameters.AddWithValue("@Nombre_Sucursal", sucursal.Nombre_Sucursal);
                        comando.Parameters.AddWithValue("@Direccion", sucursal.Direccion);

                        comando.ExecuteNonQuery();
                    }
                }
                return "ok";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar la sucursal.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar la sucursal.");
                return "Error";
            }
        }

        // Método para eliminar una sucursal y retornar "OK"
        public static string Eliminar(int idSucursal)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM Sucursales WHERE ID_Sucursal = @ID_Sucursal";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Sucursal", idSucursal);
                        comando.ExecuteNonQuery();
                    }
                }
                return "ok";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar la sucursal.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar la sucursal.");
                return "Error";
            }
        }

        // Método para obtener una sucursal por ID
        public static SucursalesModel ObtenerPorId(int idSucursal)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM Sucursales WHERE ID_Sucursal = @ID_Sucursal";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Sucursal", idSucursal);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new SucursalesModel
                                {
                                    ID_Sucursal = (int)lector["ID_Sucursal"],
                                    Nombre_Sucursal = lector["Nombre_Sucursal"].ToString(),
                                    Direccion = lector["Direccion"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la sucursal.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la sucursal.");
            }
            return null;
        }

        // Método para obtener todas las sucursales
        public static List<SucursalesModel> ObtenerTodos()
        {
            var sucursales = new List<SucursalesModel>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM Sucursales";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                sucursales.Add(new SucursalesModel
                                {
                                    ID_Sucursal = (int)lector["ID_Sucursal"],
                                    Nombre_Sucursal = lector["Nombre_Sucursal"].ToString(),
                                    Direccion = lector["Direccion"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de sucursales.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de sucursales.");
            }

            return sucursales;
        }
    }
}
