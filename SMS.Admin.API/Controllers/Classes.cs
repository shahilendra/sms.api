using Microsoft.AspNetCore.Mvc;
using SMS.Admin.Application.Classes.Command.CreateClasses;
using SMS.Admin.Application.Classes.Command.DeleteClasses;
using SMS.Admin.Application.Classes.Command.UpdateClasses;
using SMS.Admin.Application.Classes.Queries.GetClasses;
using SMS.Domain.EntityHelpers;

namespace SMS.Admin.API.Controllers
{
    public class Classes : ApiControllerBase
    {
        private readonly ILogger<Classes> _logger;
        public Classes(ILogger<Classes> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get All classes
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public async Task<IActionResult> Index([FromQuery]PageQuery pageQuery)
        {
            _logger.LogInformation($"{nameof(Classes)}.{Index} Started!");
            var result = await Mediator.Send(new GetClassesQuery(pageQuery));
            return Ok(result);
        }

        /// <summary>
        /// Add new class
        /// </summary>
        /// <returns></returns>
        [HttpPost()]
        public async Task<IActionResult> Add([FromBody] CreateClassesCommand createClassesCommand)
        {
            _logger.LogInformation($"{nameof(Classes)}.{Add} Started!");
            var result = await Mediator.Send(createClassesCommand);
            return Ok(result);
        }

        /// <summary>
        /// Update class
        /// </summary>
        /// <returns></returns>
        [HttpPut()]
        public async Task<IActionResult> Update([FromBody] UpdateClassesCommand updateClassesCommand)
        {
            _logger.LogInformation($"{nameof(Classes)}.{Update} Started!");
            var result = await Mediator.Send(updateClassesCommand);
            return Ok(result);
        }

        /// <summary>
        /// Delete a class
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteClassesCommad deleteClassesCommad)
        {
            _logger.LogInformation($"{nameof(Classes)}.{Delete} Started!");
            var result = await Mediator.Send(deleteClassesCommad);
            return Ok(result);
        }
    }
}
