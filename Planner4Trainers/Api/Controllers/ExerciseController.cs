using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Api.Repositories.Contracts;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IExerciseTypeRepository exerciseRepository;
        public ExerciseController(IExerciseTypeRepository exercieRepository)
        {
            this.exerciseRepository = exercieRepository;
        }

        public async Task<ActionResult<IEnumerable<Exercise>>>
    }
}
