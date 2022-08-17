using Api.Data;
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
        public Task<ExerciseType> GetExerciseType(int id)
        {
            throw new NotImplementedException();
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

        public async Task<IEnumerable<FinalExercise>> GetFinalExercises()
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

        public Task<Speed> GetSpeed(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Speed>> GetSpeeds()
        {
           var speeds = await this.planner4TrainersDbContext.Speed.ToListAsync();
           return speeds;
        }

        public Task<Strength> GetStrength(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Strength>> GetStrengths()
        {
            var strengths = await this.planner4TrainersDbContext.Strength.ToListAsync();
            return strengths;
        }

        public Task<Technique> GetTechnique(int id)
        {
            throw new NotImplementedException();
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
    }
}
