using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DIFactoryDemo.Impl
{
    public class JobRunner : IJobRunner
    {
        private readonly ILogger<JobRunner> _logger;

        public JobRunner(ILoggerFactory factory)
        {
            _logger = factory.CreateLogger<JobRunner>();
        }

        public Task RunAsync()
        {
            // call external API here                 
            _logger.LogInformation($"{nameof(JobRunner)} has been run");

            return Task.CompletedTask;
        }
    }
}
