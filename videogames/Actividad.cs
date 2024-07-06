using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace videogames
{
    public class Actividad
    {

        // Clase en donde guardaremos la lista de todos los videojuegos ingresados
        public List<Videojuego> Videojuegos {  get; set; }

        // Instanciar la lista
        public Actividad() { 
            Videojuegos = new List<Videojuego>();
        }

        // Añadir a lista de videojuegos

        public void AgregarVideojuego(Videojuego videojuegos)
        {
            if (Videojuegos.FirstOrDefault(el => el.Nombre == videojuegos.Nombre) == null) 
            {                
                Videojuegos.Add(videojuegos);
            }
        }
        
        // Usar esta función para generar un resultado a la partida, un random para ver si será verdadero o falso
        public void RegistrarPartida(string nombre, bool gano) {

            var videojuego = Videojuegos.FirstOrDefault(el => el.Nombre == nombre);
            if (videojuego != null)
            {
                // Sacar esta logica
                videojuego.RegistrarResultado(gano);
            }
        }

        public int PuntosTotales
        {
            get { return Videojuegos.Sum(v => v.Puntaje); }
        }
    }
}
