using DIFactoryDemo.Impl;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DIFactoryDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly IJobRunner _jobRunner;
        private readonly IJobRunnerFactory _jobRunnerFactory;

        public JobsController(IJobRunner jobRunner, IJobRunnerFactory jobRunnerFactory)
        {
            _jobRunner = jobRunner;
            _jobRunnerFactory = jobRunnerFactory;
        }

        [HttpGet("run")]
        public async Task<IActionResult> RunJob()
        {
            await _jobRunner.RunAsync();
            return Ok();
        }

        [HttpGet("factory")]
        public async Task<IActionResult> RunJobFactory()
        {
            var jobRunner = _jobRunnerFactory.CreateJobRunner();
            await jobRunner.RunAsync();
            return Ok();
        }
    }
}
