using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    public class Event
    {
        internal static Event EventInstance
        {
            get
            {
                return eventInstance;
            }
        }
        internal IEventAggregator EventAggregator
        {
            get
            {
                if (eventAggregator == null)
                {
                    eventAggregator = new EventAggregator();
                }

                return eventAggregator;
            }
        }
        private Event()
        {
        }
        private static readonly Event eventInstance = new Event();
        private IEventAggregator eventAggregator;
    }
}
