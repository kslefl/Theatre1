using TheatresSystem.Staff; // заменить TheatresSystem на TheatreSystem
using TheatresSystem.Theatre; // заменить TheatresSystem на TheatreSystem

namespace TheatreSystem.Theatres
{
    public class Cinema : Theatre
    {
        public Projectionist Projectionist { get; set; }

        public Cinema(int seats, int rows, bool hasPit, double length, double width, Projectionist projectionist)
        {
            NumberOfSeats = seats;
            NumberOfRows = rows;
            HasOrchestraPit = hasPit;
            StageLength = length;
            StageWidth = width;
            Projectionist = projectionist;
        }

        public override string GetInfo()
        {
            return $"Кинотеатр:\nМест: {NumberOfSeats}, Рядов: {NumberOfRows}, Оркестровая яма: {HasOrchestraPit}, Размер сцены: {StageLength}x{StageWidth}\n{Projectionist.GetRole()}";
        }
    }
}
