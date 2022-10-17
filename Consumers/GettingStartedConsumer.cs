using System.Threading.Tasks;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace GettingStarted.Consumers
{
    public class GettingStartedConsumer :
        // IConsumer<GettingStarted.Contracts.GettingStarted>,
        IConsumer<GettingStarted.Contracts.HelloMessage>
    {
        readonly ILogger<GettingStartedConsumer> _logger;

        public GettingStartedConsumer(ILogger<GettingStartedConsumer> logger)
        {
            _logger = logger;
        }

        // public Task Consume(ConsumeContext<Contracts.GettingStarted> context)
        // {
        //     _logger.LogInformation("Received Text: {Text}", context.Message.Value);
        //     return Task.CompletedTask;
        // }

        public Task Consume(ConsumeContext<Contracts.HelloMessage> context)
        {
            
            return Task.CompletedTask;
        }
    }
}