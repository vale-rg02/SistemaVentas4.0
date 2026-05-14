// CapaNegocio
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNReporte
    {
        private CDReporte cd = new CDReporte();

        public DataTable ObtenerCabeceraFactura(int idventa)
            => cd.ObtenerCabeceraFactura(idventa);

        public DataTable ObtenerDetalleFactura(int idventa)
            => cd.ObtenerDetalleFactura(idventa);

        public DataTable ObtenerFacturasPorProducto(int idproducto)
            => cd.ObtenerFacturasPorProducto(idproducto);
    }
}