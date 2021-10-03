using System.Collections.Generic;
using MascFelizWeb.App.Dominio;

namespace MascFelizWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioMascotasMemoria : IRepositorioMascotas

    {
        List<Mascota> mascotas;
        public RepositorioMascotasMemoria()
        {
            mascotas= new List<Mascota>()
            {
                // llamando al constructor
                new Mascota{Id=1,Nombre="Koler",Edad="7 años",Peso="22kg",
                Tipo="canino",Temperatura="37c",Frec_Cardiaca="102",
                Frec_Respiratoria="70",Recomendacion="ok"
                },

                new Mascota{Id=2,Nombre="Tom",Edad="7 años",Peso="12kg",
                Tipo="felino",Temperatura="32c",Frec_Cardiaca="112",
                Frec_Respiratoria="90",Recomendacion="control proximo mes"
                },

                new Mascota{Id=3,Nombre="Ragnar",Edad="2 años",Peso="14kg",
                Tipo="canino",Temperatura="38c",Frec_Cardiaca="100",
                Frec_Respiratoria="80",Recomendacion="desparasitar"
                }




            };
        }
        public IEnumerable<Mascota> GetAll()
        {
            return mascotas;
        }
    }
}