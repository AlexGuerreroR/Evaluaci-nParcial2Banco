using EvaluaciónParcial2Banco.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Xml;

namespace EvaluaciónParcial2Banco.Models
{
    public class TransaccionesModel
    {
        public int ID_Transaccion { get; set; }
        public int ID_Cuenta { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }

        // Constructor vacío
        public TransaccionesModel() { }

        // Método para insertar una nueva transacción y retornar el registro insertado
        public static TransaccionesModel Insertar(TransaccionesModel transaccion)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO Transacciones (ID_Cuenta, Fecha, Monto) " +
                                   "OUTPUT INSERTED.ID_Transaccion, INSERTED.ID_Cuenta, INSERTED.Fecha, INSERTED.Monto " +
                                   "VALUES (@ID_Cuenta, @Fecha, @Monto)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Cuenta", transaccion.ID_Cuenta);
                        comando.Parameters.AddWithValue("@Fecha", transaccion.Fecha);
                        comando.Parameters.AddWithValue("@Monto", transaccion.Monto);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new TransaccionesModel
                                {
                                    ID_Transaccion = (int)lector["ID_Transaccion"],
                                    ID_Cuenta = (int)lector["ID_Cuenta"],
                                    Fecha = Convert.ToDateTime(lector["Fecha"]),
                                    Monto = Convert.ToDecimal(lector["Monto"])
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar la transacción.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar la transacción.");
            }
            return null;
        }

        // Método para actualizar una transacción existente y retornar "OK"
        public static string Actualizar(TransaccionesModel transaccion)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE Transacciones SET ID_Cuenta = @ID_Cuenta, Fecha = @Fecha, Monto = @Monto WHERE ID_Transaccion = @ID_Transaccion";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Transaccion", transaccion.ID_Transaccion);
                        comando.Parameters.AddWithValue("@ID_Cuenta", transaccion.ID_Cuenta);
                        comando.Parameters.AddWithValue("@Fecha", transaccion.Fecha);
                        comando.Parameters.AddWithValue("@Monto", transaccion.Monto);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar la transacción.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar la transacción.");
                return "Error";
            }
        }

        // Método para eliminar una transacción y retornar "OK"
        public static string Eliminar(int idTransaccion)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM Transacciones WHERE ID_Transaccion = @ID_Transaccion";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Transaccion", idTransaccion);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar la transacción.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar la transacción.");
                return "Error";
            }
        }

        // Método para obtener una transacción por ID
        public static TransaccionesModel ObtenerPorId(int idTransaccion)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM Transacciones WHERE ID_Transaccion = @ID_Transaccion";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Transaccion", idTransaccion);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new TransaccionesModel
                                {
                                    ID_Transaccion = (int)lector["ID_Transaccion"],
                                    ID_Cuenta = (int)lector["ID_Cuenta"],
                                    Fecha = Convert.ToDateTime(lector["Fecha"]),
                                    Monto = Convert.ToDecimal(lector["Monto"])
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la transacción.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la transacción.");
            }
            return null;
        }

        // Método para obtener todas las transacciones
        public static List<TransaccionesModel> ObtenerTodos()
        {
            var transacciones = new List<TransaccionesModel>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM Transacciones";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                transacciones.Add(new TransaccionesModel
                                {
                                    ID_Transaccion = (int)lector["ID_Transaccion"],
                                    ID_Cuenta = (int)lector["ID_Cuenta"],
                                    Fecha = Convert.ToDateTime(lector["Fecha"]),
                                    Monto = Convert.ToDecimal(lector["Monto"])
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de transacciones.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de transacciones.");
            }

            return transacciones;
        }
    }
}
