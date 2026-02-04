using System.Collections.Generic;

namespace backend.Models
{
    public class WorkoutExercise
    {
        public int Id { get; set; }
        public int WorkoutId { get; set; }
        public int ExerciseId { get; set; }
        public int Order { get; set; }

        public Workout Workout { get; set; } = null!;
        public Exercise Exercise { get; set; } = null!;
        public ICollection<Set> Sets { get; set; } = new List<Set>();
    }
}