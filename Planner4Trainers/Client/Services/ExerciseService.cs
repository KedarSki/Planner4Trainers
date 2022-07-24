using Client.Services.Contracts;
using Common.Dtos;
using System.Net.Http.Json;

namespace Client.Services
{
    public class ExerciseService : IExerciseTypeService
    {
        private readonly HttpClient httpClient;

        public ExerciseService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ExerciseTypeDto>> GetExerciseTypes()
        {
           try
            {
                var exerciseTypes = await this.httpClient.GetFromJsonAsync<IEnumerable<ExerciseTypeDto>>("api/Exercise/GetExerciseTypes");
                return exerciseTypes;
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
