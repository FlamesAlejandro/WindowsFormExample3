using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videogames
{
    public class Videojuego
    {
        public string Nombre { get; set; }
        public int Victorias { get; set; }
        public int Derrotas { get; set; }
        public int Puntaje { get; set; }

        // Crear videojuego con sus variables inicializadas en 0
        public Videojuego(string nombre) {
            
            Nombre = nombre;
            Victorias = 0;
            Derrotas = 0;
            Puntaje = 0;
        }

        // Función para registrar victorias y derrotas con sus puntajes

        public void RegistrarResultado(bool gano)
        {
            if (gano)
            {
                Victorias++;
                Puntaje += 100;
            }
            else
            {
                Derrotas++;
                Puntaje -= 20;
            }
        }
    }
}
