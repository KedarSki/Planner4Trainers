using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class FinalExerciseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TimeLength { get; set; }
        public string Description { get; set; }
        public int ExerciseTypeId { get; set; }
        public string ExerciseTypeName { get; set; }
    }
}
