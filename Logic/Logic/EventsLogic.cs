using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class EventsLogic : BaseContextLogic, IEventsLogic
    {
        public EventsLogic(ServiceContext serviceContext) : base(serviceContext) { }

        //void IEventsLogic.DeleteEvents(int Id) 
        //{
        //    _serviceContext.Events.Remove(_serviceContext.Set<Events>().Where(e => e.Id)..FirstOrDefault());
        //    _serviceContext.SaveChanges();
        //}

        public int InsertEvents(Events events) 
        {
            _serviceContext.Events.Add(events);
            _serviceContext.SaveChanges();
            return events.Id;
        
        }

        //public void UpdateEvents(Events events)
        //{
        //    _serviceContext.Events.Update(events); 
        //    _serviceContext.SaveChanges();
        //}

        List<Events> IEventsLogic.GetAll()
        {
            var allEvents = _serviceContext.Set<Events>().ToList();
            return allEvents;
        }
    }
}
