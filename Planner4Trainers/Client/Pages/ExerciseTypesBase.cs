using Client.Services.Contracts;
using Common.Dtos;
using Microsoft.AspNetCore.Components;

namespace Client.Pages
{
    public class ExerciseTypesBase:ComponentBase
    {

        [Inject]
        public IExerciseTypeService ExerciseTypeService { get; set; }
        public IEnumerable<ExerciseTypeDto> ExerciseTypes { get; set; }
        public IEnumerable<WarmupOnGoDto> WarmupsOnGo { get; set; }
        public IEnumerable<WarmupOnWalkDto> WarmupsOnWalk { get; set; }
        public IEnumerable<WarmupOnPlaceDto> WarmupsOnPlace { get; set; }
        public IEnumerable<PowerDto> Powers { get; set; }
        public IEnumerable<StrengthDto> Strengths { get; set; }
        public IEnumerable<TechniqueDto> Techniques { get; set; }
        public IEnumerable<SpeedDto> Speeds { get; set; }
        public IEnumerable<FinalExerciseDto> FinalExercises { get; set; }


        protected override async Task OnInitializedAsync()
        {
            ExerciseTypes = await ExerciseTypeService.GetExerciseTypes();

            WarmupsOnGo = await ExerciseTypeService.GetWarmupsOnGo();

            WarmupsOnWalk = await ExerciseTypeService.GetWarmupsOnWalk();

            WarmupsOnPlace = await ExerciseTypeService.GetWarmupsOnPlace();

            Powers = await ExerciseTypeService.GetPowers();

            Strengths = await ExerciseTypeService.GetStrengths();

            Techniques = await ExerciseTypeService.GetTechniques();

            Speeds = await ExerciseTypeService.GetSpeeds();

            FinalExercises = await ExerciseTypeService.GetFinalExercises();
        }
    }
}
