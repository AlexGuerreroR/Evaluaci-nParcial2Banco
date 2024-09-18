using EvaluaciónParcial2Banco.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EvaluaciónParcial2Banco.Models
{
    public class CuentasModel
    {
        public int ID_Cuenta { get; set; }
        public string Tipo { get; set; }
        public string ID_Cliente { get; set; }
        public string Fecha_Apertura { get; set; }
        public double Saldo { get; set; }
        public string ID_Sucursal { get; set; }

        // Constructor vacío
        public CuentasModel() { }

        // Método para insertar una nueva cuenta y retornar el registro insertado
        public static CuentasModel Insertar(CuentasModel cuenta)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO Cuentas (Tipo, ID_Cliente, Fecha_Apertura, Saldo, ID_Sucursal) " +
                                   "OUTPUT INSERTED.ID_Cuenta, INSERTED.Tipo, INSERTED.ID_Cliente, INSERTED.Fecha_Apertura, INSERTED.Saldo, INSERTED.ID_Sucursal " +
                                   "VALUES (@Tipo, @ID_Cliente, @Fecha_Apertura, @Saldo, @ID_Sucursal)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Tipo", cuenta.Tipo);
                        comando.Parameters.AddWithValue("@ID_Cliente", cuenta.ID_Cliente);
                        comando.Parameters.AddWithValue("@Fecha_Apertura", cuenta.Fecha_Apertura);
                        comando.Parameters.AddWithValue("@Saldo", cuenta.Saldo);
                        comando.Parameters.AddWithValue("@ID_Sucursal", cuenta.ID_Sucursal);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new CuentasModel
                                {
                                    ID_Cuenta = (int)lector["ID_Cuenta"],
                                    Tipo = lector["Tipo"].ToString(),
                                    ID_Cliente = lector["ID_Cliente"].ToString(),
                                    Fecha_Apertura = lector["Fecha_Apertura"].ToString(),
                                    Saldo = (double)lector["Saldo"],
                                    ID_Sucursal = lector["ID_Sucursal"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar la cuenta.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar la cuenta.");
            }
            return null;
        }

        // Método para actualizar una cuenta existente y retornar "OK"
        public static string Actualizar(CuentasModel cuenta)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE Cuentas SET Tipo = @Tipo, ID_Cliente = @ID_Cliente, Fecha_Apertura = @Fecha_Apertura, Saldo = @Saldo, ID_Sucursal = @ID_Sucursal WHERE ID_Cuenta = @ID_Cuenta";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Cuenta", cuenta.ID_Cuenta);
                        comando.Parameters.AddWithValue("@Tipo", cuenta.Tipo);
                        comando.Parameters.AddWithValue("@ID_Cliente", cuenta.ID_Cliente);
                        comando.Parameters.AddWithValue("@Fecha_Apertura", cuenta.Fecha_Apertura);
                        comando.Parameters.AddWithValue("@Saldo", cuenta.Saldo);
                        comando.Parameters.AddWithValue("@ID_Sucursal", cuenta.ID_Sucursal);

                        comando.ExecuteNonQuery();
                    }
                }
                return "ok";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar la cuenta.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar la cuenta.");
                return "Error";
            }
        }

        // Método para eliminar una cuenta y retornar "OK"
        public static string Eliminar(int idCuenta)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM Cuentas WHERE ID_Cuenta = @ID_Cuenta";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Cuenta", idCuenta);
                        comando.ExecuteNonQuery();
                    }
                }
                return "ok";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar la cuenta.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar la cuenta.");
                return "Error";
            }
        }

        // Método para obtener una cuenta por ID
        public static CuentasModel ObtenerPorId(int idCuenta)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM Cuentas WHERE ID_Cuenta = @ID_Cuenta";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Cuenta", idCuenta);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new CuentasModel
                                {
                                    ID_Cuenta = (int)lector["ID_Cuenta"],
                                    Tipo = lector["Tipo"].ToString(),
                                    ID_Cliente = lector["ID_Cliente"].ToString(),
                                    Fecha_Apertura = lector["Fecha_Apertura"].ToString(),
                                    Saldo = (double)lector["Saldo"],
                                    ID_Sucursal = lector["ID_Sucursal"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la cuenta.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la cuenta.");
            }
            return null;
        }

        // Método para obtener todas las cuentas
        public static List<CuentasModel> ObtenerTodos()
        {
            var cuentas = new List<CuentasModel>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM Cuentas";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                cuentas.Add(new CuentasModel
                                {
                                    ID_Cuenta = (int)lector["ID_Cuenta"],
                                    Tipo = lector["Tipo"].ToString(),
                                    ID_Cliente = lector["ID_Cliente"].ToString(),
                                    Fecha_Apertura = lector["Fecha_Apertura"].ToString(),
                                    Saldo = (double)lector["Saldo"],
                                    ID_Sucursal = lector["ID_Sucursal"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de cuentas.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de cuentas.");
            }

            return cuentas;
        }
    }
}
