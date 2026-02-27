using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;
using System.Net.NetworkInformation;

namespace CapaNegocio
{
    public class CNCliente
    {
        public static DataTable Listar()
        {
            CDCliente Datos = new CDCliente();
            return Datos.Listar();
        }

        public static string Guardar(string nombre, string apellidos, string rfc, string dni, string telefono, string estado)
        {
            CDCliente Datos = new CDCliente();
            Datos.Nombre = nombre;
            Datos.Apellidos = apellidos;
            Datos.Dni = dni;
            Datos.Rfc = rfc;
            Datos.Telefono = telefono;
            Datos.Estado = estado;
            return Datos.Guardar(Datos);
        }

        public static string Editar(int idcliente, string nombre, string apellidos, string rfc, string dni, string telefono, string estado)
        {
            CDCliente Datos = new CDCliente();
            Datos.IdCliente = idcliente;
            Datos.Nombre = nombre;
            Datos.Apellidos = apellidos;
            Datos.Dni = dni;
            Datos.Rfc = rfc;
            Datos.Telefono = telefono;
            Datos.Estado = estado;
            return Datos.Editar(Datos);
        }

        public static string Eliminar(int idcliente)
        {
            CDCliente Datos = new CDCliente();
            Datos.IdCliente = idcliente;
            return Datos.Eliminar(Datos);
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            CDCliente Datos = new CDCliente();
            Datos.Buscar = textobuscar;
            return Datos.BuscarNombre(Datos);
        }

        public static DataTable BuscarDni(string textobuscar)
        {
            CDCliente Datos = new CDCliente();
            Datos.Buscar = textobuscar;
            return Datos.BuscarDni(Datos);
        }

        public static void Editar(string text1, string text2, string text3, string text4, string text5, string estado)
        {
            throw new NotImplementedException();
        }
    }
}