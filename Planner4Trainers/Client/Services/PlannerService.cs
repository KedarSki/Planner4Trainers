using System;
using System.Net.Http.Json;
using Client.Services.Contracts;
using Common.Dtos;
using Common.Models;

namespace Client.Services
{
    public class PlannerService : IPlannerService
    {
        private readonly HttpClient httpClient;

        public PlannerService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<bool> Add(AddPlanDto data)
        {
            try
            {
                await this.httpClient.PostAsJsonAsync("api/Planner/Add", data);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<DDFields>> GetPlans(Guid userId)
        {
            try
            {
                var plans = await this.httpClient.GetFromJsonAsync<IEnumerable<DDFields>>($"api/Planner/GetPlans/{userId}");
                return plans;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<PlannerDto>> GetPlanner(int planId)
        {
            try
            {
                var planners = await this.httpClient.GetFromJsonAsync<IEnumerable<PlannerDto>>($"api/Planner/GetPlanner/{planId}");
                return planners;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task Update(PlannerDto data)
        {
            try
            {
                await this.httpClient.PutAsJsonAsync("api/Planner/Update", data);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

