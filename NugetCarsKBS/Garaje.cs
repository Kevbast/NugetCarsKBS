using System;
using System.Collections.Generic;
using System.Text;

namespace NugetCarsKBS
{
    public class Garaje
    {
        public List<Coche> coches;

    public Garaje()
        {
            this.coches = new List<Coche>();
            Coche c = new Coche

            {

                IdCoche = 0,

                Marca = "DMG",

                Modelo = "Delorian",

                Imagen = "https://static.motor.es/fotos-noticias/2015/10/min652x435/curiosidades-delorean-regreso-al-futuro-201523728_4.jpg"

            };

            coches.Add(c);

            c = new Coche

            {

                IdCoche = 1,

                Marca = "PONTIAC"

                ,

                Modelo = "FireBird"

                ,

                Imagen = "https://i.ytimg.com/vi/UJFwmjfTSJw/hqdefault.jpg"

            };

            coches.Add(c);

            c = new Coche

            {

                IdCoche = 2

                ,

                Marca = "Volkswagen"

                ,

                Modelo = "Escarabajo"

                ,

                Imagen = "https://i.ytimg.com/vi/AP-HLHi0HUw/maxresdefault.jpg"

            };

            coches.Add(c);

            c = new Coche

            {

                IdCoche = 3

                ,

                Marca = "Citroen"

                ,

                Modelo = "2 CV"

                ,

                Imagen = "http://iconroad.es/onewebmedia/Iconos%20Citro%C3%ABn%202CV%20En%20el%20cine%204.png"

            };
            this.coches.Add(c);
            c = new Coche

            {

                IdCoche = 4

                ,

                Marca = "Hyundai"

                ,

                Modelo = "4 v2"

                ,

                Imagen = "http://iconroad.es/onewebmedia/Iconos%20hyundai%C3%ABn%202CV%20En%20el%20cine%204.png"

            };
            this.coches.Add(c);
            c = new Coche

            {

                IdCoche = 4

                ,

                Marca = "aaaa"

                ,

                Modelo = "2 CV"

                ,

                Imagen = "http://iconroad.es/onewebmedia/Iconos%20Citro%C3%ABn%202CV%20En%20el%20cine%204.png"

            };
            this.coches.Add(c);

        }

        public List<Coche> GetCoches()
        {
            return this.coches;
        }

        public Coche FindCoche(int idcoche)
        {
            return this.coches.FirstOrDefault(x => x.IdCoche == idcoche);
        }

    }
}
