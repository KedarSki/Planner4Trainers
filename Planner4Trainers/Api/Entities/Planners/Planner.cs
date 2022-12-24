using System;
using Api.Entities.Plans;

namespace Api.Entities.Planners
{
    public class Planner
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int PlanId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public virtual Plan Plan { get; set; }
    }
}

