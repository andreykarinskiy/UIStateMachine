using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIStateMachine.Core
{
    using Prism.Events;

    public static class EventAggregatorExtension
    {
        public static void Publish<TEvent>(this IEventAggregator eventAggregator, TEvent domaunEvent)
        {
            eventAggregator.GetEvent<PubSubEvent<TEvent>>().Publish(domaunEvent);
        }

        public static void Subscribe<TEvent>(this IEventAggregator eventAggregator, Action<TEvent> subscriber)
        {
            eventAggregator.GetEvent<PubSubEvent<TEvent>>().Subscribe(subscriber);
        }
    }
}
