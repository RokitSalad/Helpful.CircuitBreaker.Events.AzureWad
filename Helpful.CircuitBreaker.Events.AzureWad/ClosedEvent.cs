namespace Helpful.CircuitBreaker.Events.AzureWad
{
    public class ClosedEvent : IClosedEvent
    {
        public void RaiseEvent(ICircuitBreakerDefinition breakerDefinition)
        {
            CircuitBreakerEventSource.Log.RaiseClosedEvent(breakerDefinition);
        }
    }
}