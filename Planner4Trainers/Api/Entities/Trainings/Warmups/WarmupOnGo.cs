namespace Api.Entities.Trainings.Warmups
{
    public class WarmupOnGo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal TimeLength { get; set; }
        public int ExerciseTypeId { get; set; }
    }
}
