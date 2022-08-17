using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class PowerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Repeats { get; set; }
        public int Series { get; set; }
        public string Description { get; set; }
        public int ExerciseTypeId { get; set; }
    }
}
