namespace Helpful.CircuitBreaker.Events.AzureWad
{
    public class RegisterBreakerEvent : IRegisterBreakerEvent
    {
        public void RaiseEvent(ICircuitBreakerDefinition breakerDefinition)
        {
            CircuitBreakerEventSource.Log.RaiseRegisterBreakerEvent(breakerDefinition);
        }
    }
}