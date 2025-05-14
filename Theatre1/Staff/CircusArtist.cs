namespace TheatreSystem.Staff
{
    public class CircusArtist
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public CircusArtist(string name)
        {
            this.Name = name;
            this.Role = name; // поменять имя на роль
        }

        public string GetRole()
        {
            return $"Артист цирка: {Role}";
        }
    }
}
