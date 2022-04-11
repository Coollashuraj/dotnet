namespace dotnet.Services.Service
{
    public class UpdateCharacterDto
    {
        public int Id { get; set; } = 0;
        public String Name { get; set; } = "GameCharac†er1";
        public int Points { get; set; } = 10;
        public Rpg Class { get; set; } = Rpg.Knights;
    }
}