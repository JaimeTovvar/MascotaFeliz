using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MascFelizWeb.App.Dominio;
using MascFelizWeb.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace MascFelizWeb.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioMascotas repositorioMascotas;
        public IEnumerable<Mascota> Mascotas{set;get;}

        public ListModel(IRepositorioMascotas repositorioMascotas)
        {
            this.repositorioMascotas = repositorioMascotas;
        }
        
        public void OnGet()
        {
            Mascotas = repositorioMascotas.GetAll();

        }
    }
}
