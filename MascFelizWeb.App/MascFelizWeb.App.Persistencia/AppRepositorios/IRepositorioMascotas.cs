using System.Collections.Generic;
using MascFelizWeb.App.Dominio;

namespace MascFelizWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMascotas
    {
        // Aca se van a hacer las interfases

        IEnumerable<Mascota> GetAll();
        



    }
}