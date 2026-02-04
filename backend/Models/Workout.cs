namespace backend.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan? Duration { get; set; }
        public string? Notes { get; set; }

        public User User { get; set; } = null!;
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; } = new List<WorkoutExercise>();
    }
}