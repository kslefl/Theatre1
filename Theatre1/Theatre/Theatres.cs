namespace TheatreSystem
{
    public abstract class Theatre
    {
        public int NumberOfSeats { get; set; }
        public int NumberOfRows { get; set; }
        public bool HasOrchestraPit { get; set; }
        public double StageLength { get; set; }
        public double StageWidth { get; set; }

        public abstract string GetInfo()  //метод в абстрактном классе должен быть абстрактным, а не виртуальным
        {
            return $"Театр: Мест - {NumberOfSeats}, Рядов - {NumberOfRows}, Сцена: {StageLength}x{StageWidth}, Оркестровая яма: {HasOrchestraPit}";
        }
    }
}
