using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DIFactoryDemo.Impl
{
    public class JobRunnerLocal : IJobRunner
    {
        private readonly ILogger<JobRunnerLocal> _logger;

        public JobRunnerLocal(ILoggerFactory factory)
        {
            _logger = factory.CreateLogger<JobRunnerLocal>();
        }

        public Task RunAsync()
        {
            _logger.LogInformation($"{nameof(JobRunnerLocal)} has been run");
            return Task.CompletedTask;
        }
    }
}
