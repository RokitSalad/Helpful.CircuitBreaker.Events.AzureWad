using System;
using System.Diagnostics.Tracing;

namespace Helpful.CircuitBreaker.Events.AzureWad
{
    internal class CircuitBreakerEventSource : EventSource
    {
        internal static CircuitBreakerEventSource Log = new CircuitBreakerEventSource();

        internal void RaiseOpenedEvent(ICircuitBreakerDefinition breakerDefinition, BreakerOpenReason reason,
            Exception exception)
        {
            WriteEvent(1, breakerDefinition, reason, exception);
        }

        internal void RaiseClosedEvent(ICircuitBreakerDefinition breakerDefinition)
        {
            WriteEvent(2, breakerDefinition);
        }

        internal void RaiseTriedToCloseEvent(ICircuitBreakerDefinition breakerDefinition)
        {
            WriteEvent(3, breakerDefinition);
        }

        internal void RaiseUnregisterBreakerEvent(ICircuitBreakerDefinition breakerDefinition)
        {
            WriteEvent(4, breakerDefinition);
        }

        internal void RaiseRegisterBreakerEvent(ICircuitBreakerDefinition breakerDefinition)
        {
            WriteEvent(5, breakerDefinition);
        }

        public void RaiseTolleratedOpenEvent(short tolleratedOpenEventCount, ICircuitBreakerDefinition breakerDefinition, BreakerOpenReason reason, Exception thrownException)
        {
            WriteEvent(6, tolleratedOpenEventCount, breakerDefinition, reason, thrownException);
        }
    }
}
