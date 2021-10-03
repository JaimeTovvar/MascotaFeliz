using System;
namespace MascFeliz.App.Dominio {

    public class Visita {
      
       public int Id        { get; set;}
       public string Fecha {get;set;}

       public string Recomendacion {get;set;}

       public Veterinario Veterinario{get;set;}

       public Mascota Mascota{get;set;}
 
        
    }
}