using Common.Dtos;

namespace Client.Services.Contracts
{
    public interface IExerciseTypeService
    {
        Task<IEnumerable<ExerciseTypeDto>> GetExerciseTypes();
        Task<IEnumerable<WarmupOnGoDto>> GetWarmupsOnGo();
        Task<IEnumerable<WarmupOnWalkDto>> GetWarmupsOnWalk();
        Task<IEnumerable<WarmupOnPlaceDto>> GetWarmupsOnPlace();
        Task<IEnumerable<PowerDto>> GetPowers();
        Task<IEnumerable<StrengthDto>> GetStrengths();
        Task<IEnumerable<SpeedDto>> GetSpeeds();
        Task<IEnumerable<TechniqueDto>> GetTechniques();
        Task<IEnumerable<FinalExerciseDto>> GetFinalExercises();



    }
}
