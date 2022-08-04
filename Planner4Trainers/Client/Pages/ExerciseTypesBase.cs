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


        protected override async Task OnInitializedAsync()
        {
            ExerciseTypes = await ExerciseTypeService.GetExerciseTypes();
            WarmupsOnGo = await ExerciseTypeService.GetWarmupsOnGo();
            WarmupsOnWalk = await ExerciseTypeService.GetWarmupsOnWalk();
            WarmupsOnPlace = await ExerciseTypeService.GetWarmupsOnPlace();
        }
    }
}
