using System;

namespace Helpful.CircuitBreaker.Events.AzureWad
{
    public class EventFactory : IEventFactory
    {

        public IClosedEvent GetClosedEvent()
        {
            return new ClosedEvent();
        }

        public IOpenedEvent GetOpenedEvent()
        {
            return new OpenedEvent();
        }

        public ITryingToCloseEvent GetTriedToCloseEvent()
        {
            return new TriedToCloseEvent();
        }

        public IUnregisterBreakerEvent GetUnregisterBreakerEvent()
        {
            return new UnregisterBreakerEvent();
        }

        public IRegisterBreakerEvent GetRegisterBreakerEvent()
        {
            return new RegisterBreakerEvent();
        }

        public ITolleratedOpenEvent GetTolleratedOpenEvent()
        {
            return new TolleratedOpenEvent();
        }
    }

    public class TolleratedOpenEvent : ITolleratedOpenEvent
    {
        public void RaiseEvent(short tolleratedOpenEventCount, ICircuitBreakerDefinition breakerDefinition, BreakerOpenReason reason,
            Exception thrownException)
        {
            CircuitBreakerEventSource.Log.RaiseTolleratedOpenEvent(tolleratedOpenEventCount, breakerDefinition, reason,
                thrownException);
        }
    }
}
