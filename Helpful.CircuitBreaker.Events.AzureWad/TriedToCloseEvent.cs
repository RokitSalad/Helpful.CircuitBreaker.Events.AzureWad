namespace Helpful.CircuitBreaker.Events.AzureWad
{
    public class TriedToCloseEvent : ITryingToCloseEvent
    {
        public void RaiseEvent(ICircuitBreakerDefinition breakerDefinition)
        {
            CircuitBreakerEventSource.Log.RaiseTriedToCloseEvent(breakerDefinition);
        }
    }
}