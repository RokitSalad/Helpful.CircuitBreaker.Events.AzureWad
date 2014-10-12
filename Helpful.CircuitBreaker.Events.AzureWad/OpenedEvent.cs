using System;

namespace Helpful.CircuitBreaker.Events.AzureWad
{
    public class OpenedEvent : IOpenedEvent
    {
        public void RaiseEvent(ICircuitBreakerDefinition breakerDefinition, BreakerOpenReason reason, Exception thrownException)
        {
            CircuitBreakerEventSource.Log.RaiseOpenedEvent(breakerDefinition, reason, thrownException);
        }
    }
}