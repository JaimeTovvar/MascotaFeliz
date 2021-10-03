using System;

namespace MascFelizWeb.App.Dominio
{
    public class Mascota
    {
        // Llave primaria
        public int  Id {set;get;}

         public string Nombre { get; set; }
         public string Edad { get; set; }
         
          public string Peso { get; set; }

          public string Tipo {get;set;}

        public string Temperatura{get;set;}

        public string Frec_Cardiaca {get;set;}

        public string Frec_Respiratoria {get;set;}


        public string Recomendacion {get;set;}

       // public Propietario Propietario { set; get;}





             
        
    }
}
