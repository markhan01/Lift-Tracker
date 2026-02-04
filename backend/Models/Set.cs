namespace backend.Models
{
    public class Set
    {
        public int Id { get; set; }
        public int WorkoutExerciseId { get; set; }
        public int SetNumber { get; set; }
        public int Reps { get; set; }
        public decimal Weight { get; set; }
        public int? RPE { get; set; } 

        public WorkoutExercise WorkoutExercise { get; set; } = null!;
    }
}