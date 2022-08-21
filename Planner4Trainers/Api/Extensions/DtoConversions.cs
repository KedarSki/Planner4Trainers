using Api.Entities.Trainings;
using Api.Entities.Trainings.Finals;
using Api.Entities.Trainings.Mains;
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

        public static IEnumerable<PowerDto> ConvertToDto(this IEnumerable<ExerciseType> exerciseTypes,
            IEnumerable<Power> powers)
        {
            return (from power in powers
                    join exerciseType in exerciseTypes
                    on power.ExerciseTypeId equals exerciseType.Id
                    select new PowerDto
                    {
                        Id = power.Id,
                        Name = power.Name,
                        Description = power.Description,
                        Repeats = power.Repeats,
                        Series = power.Series,
                        ExerciseTypeId = exerciseType.Id,
                        ExerciseTypeName = exerciseType.Name
                    }).ToList();
        }

        public static IEnumerable<StrengthDto> ConvertToDto(this IEnumerable<ExerciseType> exerciseTypes,
            IEnumerable<Strength> strengths)
        {
            return (from strength in strengths
                    join exerciseType in exerciseTypes
                    on strength.ExerciseTypeId equals exerciseType.Id
                    select new StrengthDto
                    {
                        Id = strength.Id,
                        Name = strength.Name,
                        Description = strength.Description,
                        TimeLength = strength.TimeLength,
                        ExerciseTypeId = exerciseType.Id,
                        ExerciseTypeName = exerciseType.Name
                    }).ToList();
        }
        
        public static IEnumerable<TechniqueDto> ConvertToDto(this IEnumerable<ExerciseType> exerciseTypes,
            IEnumerable<Technique> technique)
        {
            return (from techniques in technique
                    join exerciseType in exerciseTypes
                    on techniques.ExerciseTypeId equals exerciseType.Id
                    select new TechniqueDto
                    {
                        Id = techniques.Id,
                        Name = techniques.Name,
                        Description = techniques.Description,
                        TimeLength = techniques.TimeLength,
                        ExerciseTypeId = exerciseType.Id,
                        ExerciseTypeName = exerciseType.Name
                    }).ToList();
        }
        
        public static IEnumerable<SpeedDto> ConvertToDto(this IEnumerable<ExerciseType> exerciseTypes,
            IEnumerable<Speed> speeds)
        {
            return (from speed in speeds
                    join exerciseType in exerciseTypes
                    on speed.ExerciseTypeId equals exerciseType.Id
                    select new SpeedDto
                    {
                        Id = speed.Id,
                        Name = speed.Name,
                        Description = speed.Description,
                        TimeLength = speed.TimeLength,
                        Rounds = speed.Rounds,
                        ExerciseTypeId = exerciseType.Id,
                        ExerciseTypeName = exerciseType.Name
                    }).ToList();
        }
        
        public static IEnumerable<FinalExerciseDto> ConvertToDto(this IEnumerable<ExerciseType> exerciseTypes,
            IEnumerable<FinalExercise> finals)
        {
            return (from final in finals
                    join exerciseType in exerciseTypes
                    on final.ExerciseTypeId equals exerciseType.Id
                    select new FinalExerciseDto
                    {
                        Id = final.Id,
                        Name = final.Name,
                        Description = final.Description,
                        TimeLength = final.TimeLength,
                        ExerciseTypeId = exerciseType.Id,
                        ExerciseTypeName = exerciseType.Name
                    }).ToList();
        }



    }
}
