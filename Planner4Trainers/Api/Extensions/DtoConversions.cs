using Api.Entities.Trainings;
using Api.Entities.Trainings.Warmups;
using Common.Dtos;

namespace Api.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<WarmupOnGoDto> ConvertToDto(this IEnumerable<ExerciseType> exerciseTypes,
            IEnumerable<WarmupOnGo> warmupsOnGo)
        {
            return (from warmupOnGo in warmupsOnGo
                    join exerciseType in exerciseTypes
                    on warmupOnGo.ExerciseTypeId equals exerciseType.Id
                    select new WarmupOnGoDto
                    { 
                        Id = warmupOnGo.Id,
                        Name = warmupOnGo.Name,
                        Description = warmupOnGo.Description,
                        TimeLength = warmupOnGo.TimeLength,
                        ExerciseTypeId = exerciseType.Id,
                        ExerciseTypeName = exerciseType.Name
                    }).ToList();
        }
    }
}
