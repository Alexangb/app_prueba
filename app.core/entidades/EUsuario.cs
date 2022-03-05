using System;
namespace app.core.entidades
{
    public class EUsuario
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime Fecha_Naci { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }
       public string Imagen { get; set; }
   
    }
}
