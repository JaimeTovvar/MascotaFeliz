


using System;
using System.Collections.Generic;
using System.Linq;
using MascFeliz.App.Dominio;

namespace MascFeliz.App.Persistencia{


    public class RepositorioMascota:IRepositorioMascota
    {

        private readonly AppContext _appContext;

        public RepositorioMascota(AppContext appContext){
            _appContext=appContext;
        }

        public Mascota AddMascota(Mascota mascota)
        {
            throw new System.NotImplementedException();
        }

        public void deleteMascota(int idMascota)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Mascota> GetAllMascotas()
        {
            throw new System.NotImplementedException();
        }

        public Mascota GetMascota(int idMascota)
        {
            throw new System.NotImplementedException();
        }

        public Mascota UpdateMascota(Mascota mascota)
        {
            throw new System.NotImplementedException();
        }

        Mascota IRepositorioMascota.AddMascota(Mascota mascota){

            var mascotaAdicionada= _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionada.Entity;
        }

        void IRepositorioMascota.DeleteMascota(int idMascota){

             var mascotaEncontrada=_appContext.Mascotas.FirstOrDefault(m =>m.Id==idMascota);
             if(mascotaEncontrada==null)
                return;
             _appContext.Mascotas.Remove(mascotaEncontrada);
             _appContext.SaveChanges();
        }

        void IRepositorioMascota.deleteMascota(int idMascota)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas()
        {

            return _appContext.Mascotas;
        }

        Mascota IRepositorioMascota.GetMascota(int idMascota){

            return _appContext.Mascotas.FirstOrDefault(m =>m.Id==idMascota);
        }

        Mascota IRepositorioMascota.UpdateMascota(Mascota mascota){

            var mascotaEncontrada=_appContext.Mascotas.FirstOrDefault(m =>m.Id==mascota.Id);
            if(mascotaEncontrada!=null){
                
                mascotaEncontrada.Nombre=mascota.Nombre;
                mascotaEncontrada.Edad=mascota.Edad;
                mascotaEncontrada.Peso=mascota.Peso;
                mascotaEncontrada.Tipo=mascota.Tipo;
                mascotaEncontrada.Temperatura=mascota.Temperatura;
                mascotaEncontrada.Frec_Cardiaca=mascota.Frec_Cardiaca;
                mascotaEncontrada.Frec_Respiratoria=mascota.Frec_Respiratoria;
                mascotaEncontrada.Recomendacion=mascota.Recomendacion;
                mascotaEncontrada.Propietario=mascota.Propietario;
            //    mascotaEncontrada.Veterinario=mascota.Veterinario;
             //   mascotaEncontrada.Visita=mascota.Visita;

                _appContext.SaveChanges();
            }

            return mascotaEncontrada;



        }

    }

    internal class mascota
    {
    }
}

