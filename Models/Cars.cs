namespace CarApp.Models
{
    public class Cars
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription {get; set;}
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public int EngineId{get;set;}
    }
}