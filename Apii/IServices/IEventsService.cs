using Entities.Entities;

namespace API.IServices
{
    public interface IEventsService
    {
        int InsertEvents(Events events);

        List<Events> GetAll();
    }
}
