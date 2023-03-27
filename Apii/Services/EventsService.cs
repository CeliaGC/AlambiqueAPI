using API.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace API.Services
{
    public class EventsService : IEventsService
    {
        private readonly IEventsLogic _eventsLogic;
        public EventsService(IEventsLogic eventsLogic)
        {
            _eventsLogic = eventsLogic;
        }

        public int InsertEvents(Events events)
        {
            _eventsLogic.InsertEvents(events);
            return events.Id;
        }

        List<Events> IEventsService.GetAll()
        {
            return _eventsLogic.GetAll();
        }
    }
}
