using System;
using Common.Dtos;
using Common.Models;

namespace Client.Services.Contracts
{
    public interface IPlannerService
    {
        /// <summary>
        /// Add new planner
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Task<bool> Add(AddPlanDto data);

        /// <summary>
        /// Get plans by User
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <returns></returns>
        public Task<IEnumerable<DDFields>> GetPlans(Guid userId);

        /// <summary>
        /// Get specific planner
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Task<IEnumerable<PlannerDto>> GetPlanner(int planId);

        /// <summary>
        /// Update specific training
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Task Update(PlannerDto data);
    }
}