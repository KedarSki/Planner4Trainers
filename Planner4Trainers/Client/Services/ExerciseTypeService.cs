using Client.Services.Contracts;
using Common.Dtos;
using System.Net.Http.Json;

namespace Client.Services
{
    public class ExerciseTypeService : IExerciseTypeService 
    {
        private readonly HttpClient httpClient;

        public ExerciseTypeService(HttpClient httpClient)
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

        public async Task<IEnumerable<WarmupOnGoDto>> GetWarmupsOnGo()
        {
            try
            {
                var warmupsOnGo = await this.httpClient.GetFromJsonAsync<IEnumerable<WarmupOnGoDto>>("api/Exercise/GetWarmupsOnGo");
                return warmupsOnGo;
            }

            catch (Exception)
            {
                throw;
            }
        }


        public async Task<IEnumerable<WarmupOnWalkDto>> GetWarmupsOnWalk()
        {
            try
            {
                var warmupsOnWalk = await this.httpClient.GetFromJsonAsync<IEnumerable<WarmupOnWalkDto>>("api/Exercise/GetWarmupsOnWalk");
                return warmupsOnWalk;
            }

            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<WarmupOnPlaceDto>> GetWarmupsOnPlace()
        {
            try
            {
                var warmupsOnPlace = await this.httpClient.GetFromJsonAsync<IEnumerable<WarmupOnPlaceDto>>("api/Exercise/GetWarmupsOnPlace");
                return warmupsOnPlace;
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
