// CapaDatos
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDReporte
    {
        // ── Cabecera de una factura por idventa ───────────────────────────────
        public DataTable ObtenerCabeceraFactura(int idventa)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT  v.idventa,
                        v.serie,
                        v.num_documento,
                        v.tipo_documento,
                        v.fecha,
                        v.subtotal,
                        v.iva,
                        v.total,
                        v.estado,
                        c.nombre + ' ' + c.apellidos  AS cliente,
                        c.dni                          AS documento,
                        c.telefono,
                        e.nombre + ' ' + e.apellidos  AS trabajador
                FROM    dbo.venta    v
                INNER JOIN dbo.cliente  c ON v.idcliente  = c.idcliente
                INNER JOIN dbo.usuario  u ON v.idusuario  = u.idusuario
                INNER JOIN dbo.empleado e ON u.idempleado = e.idempleado
                WHERE   v.idventa = @idventa";

            using (var conn = new SqlConnection(Conexion.Conn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idventa", idventa);
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;
        }

        // ── Detalle de una factura por idventa ────────────────────────────────
        public DataTable ObtenerDetalleFactura(int idventa)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT  dv.iddetalleventa,
                        p.nombre  AS descripcion,
                        dv.precio,
                        dv.cantidad,
                        dv.total
                FROM    dbo.detalleventa dv
                INNER JOIN dbo.producto p ON dv.idproducto = p.idproducto
                WHERE   dv.idventa = @idventa";

            using (var conn = new SqlConnection(Conexion.Conn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idventa", idventa);
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;
        }

        // ── Facturas que contienen un producto específico ─────────────────────
        public DataTable ObtenerFacturasPorProducto(int idproducto)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT  v.idventa                         AS [N° Factura],
                        v.serie + '-' + v.num_documento   AS [Serie],
                        v.tipo_documento                  AS [Tipo],
                        CONVERT(varchar,v.fecha,103)      AS [Fecha],
                        c.nombre + ' ' + c.apellidos      AS [Cliente],
                        dv.cantidad                       AS [Cantidad],
                        dv.precio                         AS [Precio Unit.],
                        dv.total                          AS [Total]
                FROM    dbo.detalleventa dv
                INNER JOIN dbo.venta   v ON dv.idventa   = v.idventa
                INNER JOIN dbo.cliente c ON v.idcliente  = c.idcliente
                WHERE   dv.idproducto = @idproducto
                ORDER BY v.fecha DESC";

            using (var conn = new SqlConnection(Conexion.Conn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;
        }
    }
}