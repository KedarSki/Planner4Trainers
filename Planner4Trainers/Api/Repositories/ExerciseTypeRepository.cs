using Api.Data;
using Api.Entities.Planners;
using Api.Entities.Plans;
using Api.Entities.Trainings;
using Api.Entities.Trainings.Finals;
using Api.Entities.Trainings.Mains;
using Api.Entities.Trainings.Warmups;
using Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class ExerciseTypeRepository : IExerciseTypeRepository
    {
        private readonly Planner4TrainersDbContext planner4TrainersDbContext;

        public ExerciseTypeRepository(Planner4TrainersDbContext planner4TrainersDbContext)
        {
            this.planner4TrainersDbContext = planner4TrainersDbContext;
        }

        public async Task<int> AddPlan(Plan data)
        {
            await this.planner4TrainersDbContext.Plans.AddAsync(data);
            await this.planner4TrainersDbContext.SaveChangesAsync();
            return data.Id;
        }

        public async Task AddPlanner(Planner data)
        {
            await this.planner4TrainersDbContext.Planners.AddAsync(data);
            await this.planner4TrainersDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Plan>> GetPlans(Guid userId)
        {
            var plans = await this.planner4TrainersDbContext.Plans.Where(x => x.UserId == userId).ToListAsync();

            return plans;
        }

        public async Task<IEnumerable<Planner>> GetPlanners(int planId)
        {
            var planner = await this.planner4TrainersDbContext.Planners.Where(x => x.PlanId == planId).ToListAsync();

            return planner;
        }

        public async Task<ExerciseType> GetExerciseType(int id)
        {
            var exerciseTypes = await this.planner4TrainersDbContext.ExerciseType.SingleAsync(x => x.Id == id);

            return exerciseTypes;
        }

        public async Task<IEnumerable<ExerciseType>> GetExerciseTypes()
        {
            var exerciseTypes = await this.planner4TrainersDbContext.ExerciseType.ToListAsync();

            return exerciseTypes;
        }

        public Task<FinalExercise> GetFinal(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<FinalExercise>> GetFinals()
        {
            var finals = await this.planner4TrainersDbContext.Finals.ToListAsync();

            return finals;
        }

        public Task<Power> GetPower(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Power>> GetPowers()
        {
            var powers = await this.planner4TrainersDbContext.Power.ToListAsync();

            return powers;
        }

        public async Task<Speed> GetSpeed(int id)
        {
            var speed = await this.planner4TrainersDbContext.Speed.SingleAsync(x => x.Id == id);

            return speed;
        }

        public async Task<IEnumerable<Speed>> GetSpeeds()
        {
           var speeds = await this.planner4TrainersDbContext.Speed.ToListAsync();
           return speeds;
        }

        public async Task<Strength> GetStrength(int id)
        {
            var strength = await this.planner4TrainersDbContext.Strength.SingleAsync(x => x.Id == id);

            return strength;
        }

        public async Task<IEnumerable<Strength>> GetStrengths()
        {
            var strengths = await this.planner4TrainersDbContext.Strength.ToListAsync();
            return strengths;
        }

        public async Task<Technique> GetTechnique(int id)
        {
            var technique = await this.planner4TrainersDbContext.Technique.SingleAsync(x => x.Id == id);

            return technique;
        }

        public async Task<IEnumerable<Technique>> GetTechniques()
        {
           var techniques = await this.planner4TrainersDbContext.Technique.ToListAsync();
           
           return techniques;
        }

        public Task<WarmupOnGo> GetWarmupOnGo(int id)
        {
            throw new NotImplementedException();
        }

        public Task<WarmupOnPlace> GetWarmupOnPlace(int id)
        {
            throw new NotImplementedException();
        }

        public Task<WarmupOnWalk> GetWarmupOnWalk(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<WarmupOnGo>> GetWarmupsOnGo()
        {
            var warmupsOnGo = await this.planner4TrainersDbContext.WarmupOnGo.ToListAsync();

            return warmupsOnGo;
        }

        public async Task<IEnumerable<WarmupOnPlace>> GetWarmupsOnPlace()
        {
            var warmupsOnPlace = await this.planner4TrainersDbContext.WarmupOnPlace.ToListAsync();
           
            return warmupsOnPlace;
        }

        public async Task<IEnumerable<WarmupOnWalk>> GetWarmupsOnWalk()
        {
            var warmupsOnWalk = await this.planner4TrainersDbContext.WarmupOnWalk.ToListAsync();

            return warmupsOnWalk;
        }

        public async Task<int> SaveChanges()
        {
            return await this.planner4TrainersDbContext.SaveChangesAsync();
        }

        public async Task UpdatePlanner(Planner data)
        {
            this.planner4TrainersDbContext.Planners.Update(data);
            await this.planner4TrainersDbContext.SaveChangesAsync();
        }

        public async Task<Planner> GetPlanner(int id)
        {
            var planner = await this.planner4TrainersDbContext.Planners.SingleAsync(x => x.Id == id);
            return planner;
        }
    }
}
