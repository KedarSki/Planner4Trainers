using System;
using Api.Entities.Planners;

namespace Api.Entities.Plans
{
    public class Plan
    {
        public Plan()
        {
            this.Planners = new HashSet<Planner>();
        }

        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreatedTime { get; set; }
        public virtual ICollection<Planner> Planners { get; set; }
    }
}

