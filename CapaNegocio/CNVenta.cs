// CapaNegocio
using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNVenta
    {
        private CDVenta cd = new CDVenta();

        public DataTable ListarPorFecha(DateTime fechaInicio, DateTime fechaFin)
            => cd.ListarPorFecha(fechaInicio, fechaFin);

        public DataTable ObtenerDetalle(int idventa)
            => cd.ObtenerDetalle(idventa);

        public bool Anular(int idventa)
            => cd.Anular(idventa);
    }
}