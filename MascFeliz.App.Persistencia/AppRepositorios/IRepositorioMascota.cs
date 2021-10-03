using System;
using System.Collections.Generic;
using MascFeliz.App.Dominio;



namespace MascFeliz.App.Persistencia{

    public interface IRepositorioMascota{

        IEnumerable<Mascota> GetAllMascotas();

        Mascota AddMascota(Mascota mascota);

        Mascota UpdateMascota(Mascota mascota);

        void deleteMascota(int idMascota);

        Mascota GetMascota(int idMascota);
        void DeleteMascota(int idMascota);
    }
    
        
    }




