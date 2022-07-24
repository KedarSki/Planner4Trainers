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


    }
}