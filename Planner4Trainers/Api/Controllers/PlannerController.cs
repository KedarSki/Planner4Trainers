using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Entities.Planners;
using Api.Entities.Plans;
using Api.Repositories.Contracts;
using Common.Dtos;
using Common.Models;
using Microsoft.AspNetCore.Mvc;
using Api.Extensions;
using Api.Entities;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlannerController : ControllerBase
    {
        private readonly IExerciseTypeRepository exerciseRepository;
        private List<int> powerTypes = new List<int> { 5, 6, 7, 8, 9, 10 };
        private int strengthType = 11;
        private int techniqueType = 12;
        private int speedType = 13;
        private int finalType = 14;

        public PlannerController(IExerciseTypeRepository exerciseTypeRepository)
        {
            this.exerciseRepository = exerciseTypeRepository;
        }

        // POST api/values
        [HttpPost]
        public async Task Add(AddPlanDto data)
        {
            List<int> selectedPowerTypes = new List<int>();
            var description = new StringBuilder();

            List<int> daysOfWeek = GetDaysOfWeek(data);      
            
            var monthInDays = 30;
            var halfMonthInDays = 15;
            var oneWeekInDays = 7;
            var monthAndHalfMonthsInDays = monthInDays + halfMonthInDays;
            var threeMonthInDays = monthInDays * 3;
            var threeWeeksInDays = oneWeekInDays * 3;
            var twoWeeksInDays = oneWeekInDays * 2;
            var startTime = data.StartTime;
            var endTime = data.EndTime;
            var trainingNumber = 0;

            // Add Plan
            var planId = await AddPlan(data);

            foreach (DateTime day in EachDay(startTime, endTime))
            {
                var daysCount = (endTime - day).TotalDays + 1;
                var dayOfWeek = day.DayOfWeek.GetHashCode();

                if (daysOfWeek.Contains(dayOfWeek) && daysCount > 1)
                {
                    var trainingName = $"Trening nr {++trainingNumber}";

                    // WarmUp
                    await PrepareWarmsUp(description);

                    if (daysCount > threeMonthInDays)
                    {
                        // Power 100%
                        await PreparePowers(selectedPowerTypes, description);
                    }
                    else if (daysCount <= threeMonthInDays && daysCount > monthAndHalfMonthsInDays)
                    {
                        // Strength 50% / Technique 50%
                        await PrepareStrengthAndTechnique(description);
                    }
                    else if (daysCount <= monthAndHalfMonthsInDays && daysCount > monthInDays)
                    {
                        // Technique 100%
                        await PrepareTechniques(description);
                    }
                    else if (daysCount <= monthInDays && daysCount > threeWeeksInDays)
                    {
                        // Technique 70% / Speed 30%
                        await PrepareTechniqueAndSpeed(description, 0.6m, 0.2m);
                    }
                    else if (daysCount <= threeWeeksInDays && daysCount > twoWeeksInDays)
                    {
                        // Technique 60% / Speed 40%
                        await PrepareTechniqueAndSpeed(description, .55m, 0.3m);
                    }
                    else if (daysCount <= twoWeeksInDays && daysCount > oneWeekInDays)
                    {
                        // Technique 50% / Speed 50%
                        await PrepareTechniqueAndSpeed(description, 0.5m, 0.45m);
                    }
                    else if (daysCount <= oneWeekInDays)
                    {
                        // Speed 100%
                        await PrepareSpeeds(description);
                    }

                    if (daysCount > oneWeekInDays)
                    {
                        // Finals
                        await PrepareFinals(description);
                    }

                    // Add Planer
                    await AddPlanner(planId, day, trainingName, description);

                    description.Clear();
                }

                if (day.DayOfWeek == DayOfWeek.Sunday)
                {
                    selectedPowerTypes.Clear();
                }
            }
        }

        // GET: api/values/8e26d067-94c0-448c-800c-2d268eacdaa2
        [HttpGet("{userId}")]
        public async Task<IEnumerable<DDFields>> GetPlans(Guid userId)
        {
            var data = await exerciseRepository.GetPlans(userId);
            return data.ConvertToDto();
        }

        // GET: api/values/6
        [HttpGet("{id}")]
        public async Task<IEnumerable<PlannerDto>> GetPlanner(int id)
        {
            var data = await exerciseRepository.GetPlanners(id);
            return data.ConvertToDto();
        }

        // PUT: api/values
        [HttpPut]
        public async Task Update(PlannerDto data)
        {
            var training = await exerciseRepository.GetPlanner(data.Id);
            training.Status = data.Status;
            await exerciseRepository.UpdatePlanner(training);
        }

        #region Private
        private IEnumerable<DateTime> EachDay(DateTimeOffset start, DateTimeOffset end)
        {
            for (var day = start.Date; day.Date <= end.Date; day = day.AddDays(1))
              yield return day;
        }

        private async Task PrepareWarmsUp(StringBuilder description)
        {
            description.AppendLine("Rozgrzewka:");
            var warmUpOnGo = await exerciseRepository.GetWarmupsOnGo();
            foreach (var item in warmUpOnGo)
            {
                description.AppendLine($"- {item.Name}, czas: {item.TimeLength}s");
            }

            var warmUpOnPlace = await exerciseRepository.GetWarmupsOnPlace();
            foreach (var item in warmUpOnPlace)
            {
                description.AppendLine($"- {item.Name}, czas: {item.TimeLength}s");
            }

            var warmUpWalk = await exerciseRepository.GetWarmupsOnWalk();
            foreach (var item in warmUpWalk)
            {
                description.AppendLine($"- {item.Name}, czas: {item.TimeLength}s");
            }

            description.AppendLine("");
        }

        private async Task PrepareFinals(StringBuilder description)
        {
            var exerciseType = await exerciseRepository.GetExerciseType(finalType);
            description.AppendLine($"{exerciseType.Name}");

            var finals = await exerciseRepository.GetFinals();
            foreach (var item in finals)
            {
                description.AppendLine($"- {item.Name}, czas: {item.TimeLength}s");
            }
        }

        private async Task PreparePowers(List<int> selectedPowerTypes, StringBuilder description)
        {
            var random = new Random();
            var uniquePowerTypes = powerTypes.Where(x => !selectedPowerTypes.Contains(x)).ToList();
            var typeId = uniquePowerTypes[random.Next(uniquePowerTypes.Count())];            

            var powerType = await exerciseRepository.GetExerciseType(typeId);
            var powers = await exerciseRepository.GetPowers();

            description.AppendLine($"{powerType.Name}:");
            foreach (var item in powers.Where(x => x.ExerciseTypeId == typeId))
            {
                description.AppendLine($"- {item.Name}, ilość: {item.Series}x{item.Repeats}");
            }
            description.AppendLine("");

            selectedPowerTypes.Add(typeId);
        }

        private async Task PrepareSpeeds(StringBuilder description)
        {
            var exerciseType = await exerciseRepository.GetExerciseType(speedType);
            description.AppendLine($"{exerciseType.Name}");

            var speeds = await exerciseRepository.GetSpeeds();
            foreach (var item in speeds)
            {
                description.AppendLine($"- {item.Name}, czas: {item.TimeLength}s");
            }

            description.AppendLine("");
        }

        private async Task PrepareStrengthAndTechnique(StringBuilder description)
        {
            var random = new Random();
            var usedStrength = new List<int>();
            var usedTechnique = new List<int>();

            var strengths = await exerciseRepository.GetStrengths();
            var techniques = await exerciseRepository.GetTechniques();

            var sum = strengths.Count() + techniques.Count();
            var strengthCount = Math.Round((decimal)(0.5 * sum), 0, MidpointRounding.ToNegativeInfinity);
            var techniqueCount = Math.Round((decimal)(0.5 * sum), 0, MidpointRounding.ToNegativeInfinity);            

            // Strength
            var exerciseType = await exerciseRepository.GetExerciseType(strengthType);
            description.AppendLine($"{exerciseType.Name}");

            for (int i = 1; i <= strengthCount; i++)
            {
                var itemIds = strengths.Where(x => !usedStrength.Contains(x.Id)).Select(x => x.Id).ToList();
                var itemId = itemIds[random.Next(itemIds.Count())];
                var item = await exerciseRepository.GetStrength(itemId);

                description.AppendLine($"- {item.Name}, czas: {item.TimeLength}s");

                usedStrength.Add(itemId);
            }

            description.AppendLine("");

            // Technique
            exerciseType = await exerciseRepository.GetExerciseType(techniqueType);
            description.AppendLine($"{exerciseType.Name}");

            for (int i = 1; i <= techniqueCount; i++)
            {
                var itemIds = techniques.Where(x => !usedTechnique.Contains(x.Id)).Select(x => x.Id).ToList();
                var itemId = itemIds[random.Next(itemIds.Count())];
                var item = await exerciseRepository.GetTechnique(itemId);

                description.AppendLine($"- {item.Name}, czas: {item.TimeLength}s");

                usedTechnique.Add(itemId);
            }

            description.AppendLine("");
        }

        private async Task PrepareTechniqueAndSpeed(StringBuilder description, decimal techniquePercent, decimal speedPercent)
        {
            var random = new Random();

            var usedTechnique = new List<int>();
            var usedSpeed = new List<int>();

            var techniques = await exerciseRepository.GetTechniques();
            var speeds = await exerciseRepository.GetSpeeds();

            var sum = techniques.Count() + speeds.Count();

            var techniqueCount = Math.Round((decimal)(techniquePercent * sum), 0, MidpointRounding.ToNegativeInfinity);
            var speedCount = Math.Round((decimal)(speedPercent * sum), 0, MidpointRounding.ToNegativeInfinity);

            // Technique
            var exerciseType = await exerciseRepository.GetExerciseType(techniqueType);
            description.AppendLine($"{exerciseType.Name}");

            for (int i = 1; i <= techniqueCount; i++)
            {
                var itemIds = techniques.Where(x => !usedTechnique.Contains(x.Id)).Select(x => x.Id).ToList();
                var itemId = itemIds[random.Next(itemIds.Count())];
                var item = await exerciseRepository.GetTechnique(itemId);

                description.AppendLine($"- {item.Name}, czas: {item.TimeLength}s");

                usedTechnique.Add(itemId);
            }

            description.AppendLine("");

            // Speed
            exerciseType = await exerciseRepository.GetExerciseType(speedType);
            description.AppendLine($"{exerciseType.Name}");

            for (int i = 1; i <= speedCount; i++)
            {
                var itemIds = speeds.Where(x => !usedSpeed.Contains(x.Id)).OrderByDescending(x => x.TimeLength).Select(x => x.Id).ToList();
                var itemId = itemIds[random.Next(itemIds.Count())];
                var item = await exerciseRepository.GetSpeed(itemId);

                description.AppendLine($"- {item.Name}, czas: {item.TimeLength}s");

                usedSpeed.Add(itemId);
            }

            description.AppendLine("");
        }

        private async Task PrepareTechniques(StringBuilder description)
        {
            var exerciseType = await exerciseRepository.GetExerciseType(techniqueType);
            description.AppendLine($"{exerciseType.Name}");

            var techniques = await exerciseRepository.GetTechniques();
            foreach (var item in techniques)
            {
                description.AppendLine($"- {item.Name}, czas: {item.TimeLength}s");
            }

            description.AppendLine("");
        }

        private async Task<int> AddPlan(AddPlanDto data)
        {
            var plan = new Plan()
            {
                Name = $"{data.Name} - {data.StartTime.Date.ToShortDateString()} do {data.EndTime.Date.ToShortDateString()}",
                UserId = data.UserId,
                StartTime = data.StartTime,
                EndTime = data.EndTime,
                CreatedTime = DateTime.Now
            };

            var planId = await exerciseRepository.AddPlan(plan);
            return planId;
        }

        private async Task AddPlanner(int planId, DateTime day, string name, StringBuilder description)
        {
            var planner = new Planner()
            {
                PlanId = planId,
                Subject = name,
                StartTime = day,
                EndTime = day,
                Status = "Planned",
                Description = description.ToString()
            };

            await exerciseRepository.AddPlanner(planner);
        }

        private List<int> GetDaysOfWeek(AddPlanDto data)
        {
            var items = new List<int>();

            if (data.Monday) items.Add(1);
            if (data.Tuesday) items.Add(2);
            if (data.Wednesday) items.Add(3);
            if (data.Thursday) items.Add(4);
            if (data.Friday) items.Add(5);
            if (data.Saturday) items.Add(6);
            if (data.Sunday) items.Add(7);

            return items;
        }
        #endregion
    }
}