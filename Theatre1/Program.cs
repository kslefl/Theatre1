using TheatresSystem.Staff;
using TheatreSystem.Theatres;

namespace TheatreSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CircusArtist artist = null; // CircusArtist не должен быть равен null

            var circusArena = new CircusArena
            {
                NumberOfSeats = 500,
                NumberOfRows = 20,
                StageLength = 15.5,
                StageWidth = 12.0,
                Artist = artist // Ошибка: artist равно null.
            };

            Console.WriteLine(circusArena.GetInfo()); 
        }
    }
}
