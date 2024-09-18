using EvaluaciónParcial2Banco.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EvaluaciónParcial2Banco.Models
{
    public class ClientesModel
    {
        public int ID_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string NombreCompleto { get; set; }

        // Constructor vacío
        public ClientesModel() { }

        // Método para insertar un nuevo cliente y retornar el registro insertado
        public static ClientesModel Insertar(ClientesModel cliente)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO Clientes ( Nombre,Cedula, Direccion, Telefono, Correo) " +
                                   "OUTPUT  INSERTED.ID_Cliente, INSERTED.Nombre,INSERTED.Cedula, INSERTED.Direccion, INSERTED.Telefono, INSERTED.Correo " +
                                   "VALUES ( @Nombre, @Cedula, @Direccion, @Telefono, @Correo)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        
                        comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                        comando.Parameters.AddWithValue("@Cedula", cliente.Cedula);
                        comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                        comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                        comando.Parameters.AddWithValue("@Correo", cliente.Correo);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new ClientesModel
                                {
                                    ID_Cliente = (int)lector["ID_Cliente"],
                                    Nombre = lector["Nombre"].ToString(),
                                    Cedula = lector["Cedula"].ToString(),
                                    Direccion = lector["Direccion"].ToString(),
                                    Telefono = lector["Telefono"].ToString(),
                                    Correo = lector["Correo"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar el cliente.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el cliente.");
            }
            return null;
        }

        // Método para actualizar un cliente existente y retornar "OK"
        public static string Actualizar(ClientesModel cliente)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE Clientes SET Nombre = @Nombre, Cedula = @Cedula, Direccion = @Direccion, Telefono = @Telefono, Correo = @Correo WHERE ID_Cliente = @ID_Cliente";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Cliente", cliente.ID_Cliente);
                        comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                        comando.Parameters.AddWithValue("@Cedula", cliente.Cedula);
                        comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                        comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                        comando.Parameters.AddWithValue("@Correo", cliente.Correo);

                        comando.ExecuteNonQuery();
                    }
                }
                return "ok";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar el cliente.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar el cliente.");
                return "Error";
            }
        }

        // Método para eliminar un cliente y retornar "OK"
        public static string Eliminar(int idCliente)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM clientes WHERE ID_Cliente = @ID_Cliente";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Cliente", idCliente);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar el cliente.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar el cliente.");
                return "Error";
            }
        }

        // Método para obtener un cliente por ID
        public static ClientesModel ObtenerPorId(int idCliente)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM clientes WHERE ID_Cliente = @ID_Cliente";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Cliente", idCliente);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new ClientesModel
                                {
                                    ID_Cliente = (int)lector["ID_Cliente"],
                                    Nombre = lector["Nombre"].ToString(),
                                    Cedula = lector["Cedula"].ToString(),
                                    Direccion = lector["Direccion"].ToString(),
                                    Telefono = lector["Telefono"].ToString(),
                                    Correo = lector["Correo"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener el cliente.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener el cliente.");
            }
            return null;
        }

        // Método para obtener todos los clientes
        public static List<ClientesModel> ObtenerTodos()
        {
            var clientes = new List<ClientesModel>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM Clientes";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                clientes.Add(new ClientesModel
                                {
                                    ID_Cliente = (int)lector["ID_Cliente"],
                                    Nombre = lector["Nombre"].ToString(),
                                    Cedula = lector["Cedula"].ToString(),
                                    Direccion = lector["Direccion"].ToString(),
                                    Telefono = lector["Telefono"].ToString(),
                                    Correo = lector["Correo"].ToString(),
                                    NombreCompleto = lector["Nombre"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de clientes.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de clientes.");
            }

            return clientes;
        }
    }
}
