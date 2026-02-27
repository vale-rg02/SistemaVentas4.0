using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Rfc { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }
        public string Buscar { get; set; }

        public DataTable Listar()
        {
            DataTable resul = new DataTable("cliente");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("spListar_cliente", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);
            }
            catch
            {
                resul = null;
                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return resul;
        }

        public string Guardar(CDCliente cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("spguardar_cliente", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idcliente", SqlDbType.Int).Direction = ParameterDirection.Output;
                Cmd.Parameters.AddWithValue("@nombre", cli.Nombre);
                Cmd.Parameters.AddWithValue("@apellidos", cli.Apellidos);
                Cmd.Parameters.AddWithValue("@dni", cli.Dni);
                Cmd.Parameters.AddWithValue("@rfc", cli.Rfc);
                Cmd.Parameters.AddWithValue("@telefono", cli.Telefono);
                Cmd.Parameters.AddWithValue("@estado", cli.Estado);

                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }

        public DataTable BuscarNombre(CDCliente datos)
        {
            throw new NotImplementedException();
        }

        public string Eliminar(CDCliente datos)
        {
            throw new NotImplementedException();
        }

        public string Editar(CDCliente datos)
        {
            throw new NotImplementedException();
        }

        public DataTable BuscarDni(CDCliente datos)
        {
            throw new NotImplementedException();
        }
    }
}
