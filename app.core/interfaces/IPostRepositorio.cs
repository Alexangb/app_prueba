using app.core.entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace app.core.interfaces
{
    public interface IPostRepositorio
    {
        Task<IEnumerable<EUsuario>> getUsuarios();
    }
}
