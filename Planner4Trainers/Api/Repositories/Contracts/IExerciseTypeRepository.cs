using Api.Entities.Trainings;
using Api.Entities.Trainings.Finals;
using Api.Entities.Trainings.Mains;
using Api.Entities.Trainings.Warmups;

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
        Task<IEnumerable<FinalExercise>> GetFinalExercises();
        Task<IEnumerable<ExerciseType>> GetExerciseTypes();


        Task<WarmupOnGo> GetWarmupOnGo(int id);
        Task<WarmupOnWalk> GetWarmupOnWalk(int id);
        Task<WarmupOnPlace> GetWarmupOnPlace (int id);
        Task<Power> GetPower (int id);
        Task<Speed> GetSpeed (int id);
        Task<Strength> GetStrength (int id);
        Task<Technique> GetTechnique (int id);
        Task<FinalExercise> GetFinal(int id);
        Task<ExerciseType> GetExerciseType(int id);


    }
}
