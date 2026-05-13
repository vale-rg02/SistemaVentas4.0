namespace SistemaVentas  // ← Cambia esto al namespace de tu proyecto
{
    /// <summary>
    /// Almacena los datos del usuario activo durante la sesión.
    /// Accesible desde cualquier formulario.
    /// </summary>
    public static class SesionActual
    {
        public static int    IdUsuario       { get; set; }
        public static string NombreUsuario   { get; set; }
        public static string NombreEmpleado  { get; set; }
        public static string Acceso          { get; set; }  // Ej: "Administrador"

        public static void Limpiar()
        {
            IdUsuario      = 0;
            NombreUsuario  = string.Empty;
            NombreEmpleado = string.Empty;
            Acceso         = string.Empty;
        }
    }
}
