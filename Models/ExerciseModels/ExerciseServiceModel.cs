using System.ComponentModel;

namespace DevBoost.Models.ExerciseModels
{
    public class ExerciseServiceModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Task { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
    }
}
