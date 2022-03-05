using app.core.entidades;
using app.core.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.infraestructure.repositorio
{
    public class UsuarioRepositorio : IPostRepositorio
    {
        public async Task<IEnumerable<EUsuario>> getUsuarios()
        {
            var usuario = Enumerable.Range(1, 20).Select(x => new EUsuario
            {
                IdUsuario = x,
                Nombres = $"Juanito{x}",
                Apellido = $"Montes{x}",
                Email = $"montes@gmail.com{x}",
                Fecha_Naci = DateTime.Now,
                Telefono = $"982345672{x}",
                Estado = $"Activo{x}",
                Imagen = $"https://misapis.com/{x}"


            });
            await Task.Delay(10);
            return usuario;
        }

    
    }
}
