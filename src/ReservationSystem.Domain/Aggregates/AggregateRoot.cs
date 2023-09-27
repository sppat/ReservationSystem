using ReservationSystem.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Domain.Aggregates
{
    public abstract class AggregateRoot
    {
        private List<BaseEvent> _events = new();

        public void AddEvent(BaseEvent @event) => _events.Add(@event);

        public IEnumerable<BaseEvent> GetEvents() => _events;

        public void ClearEvents() => _events.Clear();
    }
}
