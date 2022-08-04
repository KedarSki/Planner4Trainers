using Api.Entities.Trainings;
using Api.Entities.Trainings.Warmups;
using Common.Dtos;

namespace Api.Extensions
{
    public static class DtoConversions
    {

        public static IEnumerable<ExerciseTypeDto> ConvertToDto(this IEnumerable<ExerciseType> exerciseTypes)
        {
            return (from exerciseType in exerciseTypes
                    select new ExerciseTypeDto
                    {
                       Id = exerciseType.Id,
                       Name = exerciseType.Name,
                       Description = exerciseType.Description

                    }).ToList();
        }

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
        public static IEnumerable<WarmupOnWalkDto> ConvertToDto(this IEnumerable<ExerciseType> exerciseTypes,
            IEnumerable<WarmupOnWalk> warmupsOnWalk)
        {
            return (from warmupOnWalk in warmupsOnWalk
                    join exerciseType in exerciseTypes
                    on warmupOnWalk.ExerciseTypeId equals exerciseType.Id
                    select new WarmupOnWalkDto
                    {
                        Id = warmupOnWalk.Id,
                        Name = warmupOnWalk.Name,
                        Description = warmupOnWalk.Description,
                        TimeLength = warmupOnWalk.TimeLength,
                        ExerciseTypeId = exerciseType.Id,
                        ExerciseTypeName = exerciseType.Name
                    }).ToList();
        }

        public static IEnumerable<WarmupOnPlaceDto> ConvertToDto(this IEnumerable<ExerciseType> exerciseTypes,
            IEnumerable<WarmupOnPlace> warmupsOnPlace)
        {
            return (from warmupOnPlace in warmupsOnPlace
                    join exerciseType in exerciseTypes
                    on warmupOnPlace.ExerciseTypeId equals exerciseType.Id
                    select new WarmupOnPlaceDto
                    {
                        Id = warmupOnPlace.Id,
                        Name = warmupOnPlace.Name,
                        Description = warmupOnPlace.Description,
                        TimeLength = warmupOnPlace.TimeLength,
                        ExerciseTypeId = exerciseType.Id,
                        ExerciseTypeName = exerciseType.Name
                    }).ToList();
        }

    }
}
