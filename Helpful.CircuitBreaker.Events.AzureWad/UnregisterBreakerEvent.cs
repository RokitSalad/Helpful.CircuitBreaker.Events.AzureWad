namespace Helpful.CircuitBreaker.Events.AzureWad
{
    public class UnregisterBreakerEvent : IUnregisterBreakerEvent
    {
        public void RaiseEvent(ICircuitBreakerDefinition breakerDefinition)
        {
            CircuitBreakerEventSource.Log.RaiseUnregisterBreakerEvent(breakerDefinition);
        }
    }
}