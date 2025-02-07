using Microsoft.Extensions.Logging.Debug;

namespace SampleClient2.Pages
{
    
    public class Class
    {
        private readonly ILogger<Class> logger;

        public Class(ILogger<Class> logger)
        {
            this.logger = logger;
        }

      
    }
}
