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

        protected override async Task OnInitializedAsync()
        {
            ExerciseTypes = await ExerciseTypeService.GetExerciseTypes();
        }
    }
}
