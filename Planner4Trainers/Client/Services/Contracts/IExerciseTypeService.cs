using Common.Dtos;

namespace Client.Services.Contracts
{
    public interface IExerciseTypeService
    {
        Task<IEnumerable<ExerciseTypeDto>> GetExerciseTypes();
        Task<IEnumerable<WarmupOnGoDto>> GetWarmupsOnGo();
        Task<IEnumerable<WarmupOnWalkDto>> GetWarmupsOnWalk();
        Task<IEnumerable<WarmupOnPlaceDto>> GetWarmupsOnPlace();

    }
}
