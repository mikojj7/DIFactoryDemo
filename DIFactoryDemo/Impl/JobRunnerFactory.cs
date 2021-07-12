using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DIFactoryDemo.Impl
{
    public class JobRunnerFactory : IJobRunnerFactory
    {
        private readonly IWebHostEnvironment _env;
        private readonly ILoggerFactory _loggerFactory;

        public JobRunnerFactory(IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            _env = env;
            _loggerFactory = loggerFactory;
        }

        public IJobRunner CreateJobRunner()
        {
            if (_env.IsDevelopment())
            {
                return new JobRunnerLocal(_loggerFactory);
            }
            return new JobRunner(_loggerFactory);
        }
    }
}
