using Api.Entities.Trainings;
using Api.Entities.Trainings.Warmups;

namespace Api.Repositories.Contracts
{
    public interface IExerciseTypeRepository
    {
        Task<IEnumerable<WarmupOnGo>> GetWarmupsOnGo();
        Task<IEnumerable<WarmupOnWalk>> GetWarmupsOnWalk();
        Task<IEnumerable<WarmupOnPlace>> GetWarmupsOnPlace();
        Task<IEnumerable<ExerciseType>> GetExerciseTypes();
        Task<WarmupOnGo> GetWarmupOnGo(int id);
        Task<WarmupOnWalk> GetWarmupOnWalk(int id);
        Task<WarmupOnPlace> GetWarmupOnPlace (int id);

        Task<ExerciseType> GetExerciseType(int id);


    }
}
