namespace Api.Entities.Trainings.Finals
{
    public class FinalExercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TimeLength { get; set; }
        public string Description { get; set; }
        public int  ExerciseTypeId { get; set; }
    }

}
