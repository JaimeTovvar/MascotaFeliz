using System;
using MascFeliz.App.Dominio;
using MascFeliz.App.Persistencia;





namespace MascFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddMascota();
           // BuscarMascota(1);
            
        }

        private static void AddMascota()
        {
            var mascota = new Mascota {

                Nombre="Rex",
                Edad="5 años",
                Peso="15kg",
             //  Propietario=new Propietario();
                Tipo="Canino",
                Temperatura="36 ",
                Frec_Cardiaca="90 ",
                Frec_Respiratoria="40 ",
                Recomendacion="Desparasitar"
          
            };
             object p = _repoMascota.AddMascota(mascota);



        }

        //private static void BuscarMascota(int idMascota)
       // {

         //   var mascota = _repoMascota.GetMascota(idMascota);
         //   Console.WriteLine(mascota.Nombre+" "+mascota.Edad);

       // }
    }
}
