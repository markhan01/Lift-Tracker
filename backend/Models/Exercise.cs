namespace backend.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? MuscleGroup { get; set; }
        public string? Equipment { get; set; }
        public bool IsCustom { get; set; }
        public int? UserId { get; set; }  

        public User? User { get; set; }
    }
}
