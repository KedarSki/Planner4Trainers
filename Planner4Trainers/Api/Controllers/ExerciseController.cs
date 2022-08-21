using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Api.Repositories.Contracts;
using Api.Entities.Trainings;
using Common.Dtos;
using System;
using Api.Extensions;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        
        private readonly IExerciseTypeRepository exerciseRepository;
       
        public ExerciseController(IExerciseTypeRepository exerciseTypeRepository)
        {
            this.exerciseRepository = exerciseTypeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExerciseTypeDto>>> GetExerciseTypes()
        {
            try
            {
               
                var exerciseTypes = await this.exerciseRepository.GetExerciseTypes();

                if (exerciseTypes == null)
                {
                    return NotFound();
                }

                else
                {
                    var exerciseTypesDto = exerciseTypes.ConvertToDto();
                    return Ok(exerciseTypesDto);
                }

            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<WarmupOnGoDto>>> GetWarmupsOnGo()
        {
            try
            {
                var warmupsOnGo = await this.exerciseRepository.GetWarmupsOnGo();
                var exerciseTypes = await this.exerciseRepository.GetExerciseTypes();

                if (exerciseTypes == null || warmupsOnGo == null)
                {
                    return NotFound();
                }

                else
                {
                    var exerciseTypesDto = exerciseTypes.ConvertToDto(warmupsOnGo);
                    return Ok(exerciseTypesDto);
                }

            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<WarmupOnWalkDto>>> GetWarmupsOnWalk()
        {
            try
            {
                var warmupsOnWalk = await this.exerciseRepository.GetWarmupsOnWalk();
                var exerciseTypes = await this.exerciseRepository.GetExerciseTypes();

                if (exerciseTypes == null || warmupsOnWalk == null)
                {
                    return NotFound();
                }

                else
                {
                    var exerciseTypesDto = exerciseTypes.ConvertToDto(warmupsOnWalk);
                    return Ok(exerciseTypesDto);
                }

            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<WarmupOnPlaceDto>>> GetWarmupsOnPlace()
        {
            try
            {
                var warmupsOnPlace = await this.exerciseRepository.GetWarmupsOnPlace();
                var exerciseTypes = await this.exerciseRepository.GetExerciseTypes();

                if (exerciseTypes == null || warmupsOnPlace == null)
                {
                    return NotFound();
                }

                else
                {
                    var exerciseTypesDto = exerciseTypes.ConvertToDto(warmupsOnPlace);
                    return Ok(exerciseTypesDto);
                }

            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PowerDto>>> GetPowers()
        {
            try
            {
                var power = await this.exerciseRepository.GetPowers();
                var exerciseTypes = await this.exerciseRepository.GetExerciseTypes();

                if (exerciseTypes == null || power == null)
                {
                    return NotFound();
                }

                else
                {
                    var exerciseTypesDto = exerciseTypes.ConvertToDto(power);
                    return Ok(exerciseTypesDto);
                }

            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StrengthDto>>> GetStrengths()
        {
            try
            {
                var strength = await this.exerciseRepository.GetStrengths();
                var exerciseTypes = await this.exerciseRepository.GetExerciseTypes();

                if (exerciseTypes == null || strength == null)
                {
                    return NotFound();
                }

                else
                {
                    var exerciseTypesDto = exerciseTypes.ConvertToDto(strength);
                    return Ok(exerciseTypesDto);
                }

            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TechniqueDto>>> GetTechniques()
        {
            try
            {
                var technique = await this.exerciseRepository.GetTechniques();
                var exerciseTypes = await this.exerciseRepository.GetExerciseTypes();

                if (exerciseTypes == null || technique == null)
                {
                    return NotFound();
                }

                else
                {
                    var exerciseTypesDto = exerciseTypes.ConvertToDto(technique);
                    return Ok(exerciseTypesDto);
                }

            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SpeedDto>>> GetSpeeds()
        {
            try
            {
                var speed = await this.exerciseRepository.GetSpeeds();
                var exerciseTypes = await this.exerciseRepository.GetExerciseTypes();

                if (exerciseTypes == null || speed == null)
                {
                    return NotFound();
                }

                else
                {
                    var exerciseTypesDto = exerciseTypes.ConvertToDto(speed);
                    return Ok(exerciseTypesDto);
                }

            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FinalExerciseDto>>> GetFinalExercises()
        {
            try
            {
                var final = await this.exerciseRepository.GetFinalExercises();
                var exerciseTypes = await this.exerciseRepository.GetExerciseTypes();

                if (exerciseTypes == null || final == null)
                {
                    return NotFound();
                }

                else
                {
                    var exerciseTypesDto = exerciseTypes.ConvertToDto(final);
                    return Ok(exerciseTypesDto);
                }

            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

    }
}