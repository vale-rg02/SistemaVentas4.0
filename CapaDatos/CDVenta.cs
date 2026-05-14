// CapaDatos
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDVenta
    {
        // ── Listar ventas por rango de fechas ─────────────────────────────────
        public DataTable ListarPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT  v.idventa,
                        c.nombre + ' ' + c.apellidos      AS cliente,
                        CONVERT(varchar, v.fecha, 103)    AS fecha,
                        e.nombre + ' ' + e.apellidos      AS empleado,
                        v.tipo_documento,
                        v.serie,
                        v.num_documento,
                        v.subtotal,
                        v.iva,
                        v.total,
                        v.estado
                FROM    dbo.venta    v
                INNER JOIN dbo.cliente  c ON v.idcliente  = c.idcliente
                INNER JOIN dbo.usuario  u ON v.idusuario  = u.idusuario
                INNER JOIN dbo.empleado e ON u.idempleado = e.idempleado
                WHERE   CAST(v.fecha AS DATE) BETWEEN @fechainicio AND @fechafin
                ORDER BY v.fecha DESC";

            using (SqlConnection conn = new SqlConnection(Conexion.Conn))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fechainicio", fechaInicio.Date);
                    cmd.Parameters.AddWithValue("@fechafin", fechaFin.Date);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // ── Obtener detalle de una venta ──────────────────────────────────────
        public DataTable ObtenerDetalle(int idventa)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT  dv.iddetalleventa,
                        p.nombre   AS producto,
                        dv.cantidad,
                        dv.precio,
                        dv.total
                FROM    dbo.detalleventa dv
                INNER JOIN dbo.producto p ON dv.idproducto = p.idproducto
                WHERE   dv.idventa = @idventa";

            using (SqlConnection conn = new SqlConnection(Conexion.Conn))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idventa", idventa);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // ── Anular una venta ──────────────────────────────────────────────────
        public bool Anular(int idventa)
        {
            string query = "UPDATE dbo.venta SET estado = 'ANULADO' WHERE idventa = @idventa";

            using (SqlConnection conn = new SqlConnection(Conexion.Conn))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idventa", idventa);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}