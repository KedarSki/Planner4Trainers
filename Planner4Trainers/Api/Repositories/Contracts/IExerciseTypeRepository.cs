using System.Numerics;
using Api.Entities.Planners;
using Api.Entities.Plans;
using Api.Entities.Trainings;
using Api.Entities.Trainings.Finals;
using Api.Entities.Trainings.Mains;
using Api.Entities.Trainings.Warmups;
using Common.Dtos;

namespace Api.Repositories.Contracts
{
    public interface IExerciseTypeRepository
    {
        Task<IEnumerable<WarmupOnGo>> GetWarmupsOnGo();
        Task<IEnumerable<WarmupOnWalk>> GetWarmupsOnWalk();
        Task<IEnumerable<WarmupOnPlace>> GetWarmupsOnPlace();
        Task<IEnumerable<Power>> GetPowers();
        Task<IEnumerable<Speed>> GetSpeeds();
        Task<IEnumerable<Strength>> GetStrengths();
        Task<IEnumerable<Technique>> GetTechniques();
        Task<IEnumerable<FinalExercise>> GetFinals();
        Task<IEnumerable<ExerciseType>> GetExerciseTypes();
        Task<IEnumerable<Plan>> GetPlans(Guid userId);
        Task<IEnumerable<Planner>> GetPlanners(int planId);

        Task<WarmupOnGo> GetWarmupOnGo(int id);
        Task<WarmupOnWalk> GetWarmupOnWalk(int id);
        Task<WarmupOnPlace> GetWarmupOnPlace (int id);
        Task<Power> GetPower (int id);
        Task<Speed> GetSpeed (int id);
        Task<Strength> GetStrength (int id);
        Task<Technique> GetTechnique (int id);
        Task<FinalExercise> GetFinal(int id);
        Task<ExerciseType> GetExerciseType(int id);

        Task<int> AddPlan(Plan data);
        Task AddPlanner(Planner data);
        Task<Planner> GetPlanner(int id);
        Task UpdatePlanner(Planner data);

        Task<int> SaveChanges();
    }
}
