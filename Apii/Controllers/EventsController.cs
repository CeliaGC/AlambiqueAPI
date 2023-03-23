using API.IServices;
using API.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Data;
using System.Web.Http.Cors;
using EnableCorsAttribute = System.Web.Http.Cors.EnableCorsAttribute;
using Logic.Logic;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace API.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]

    [Route("[controller]/[action]")]
    public class EventsController : ControllerBase
    {
        private readonly ServiceContext _serviceContext;
        private readonly IEventsService _eventsService;
        public EventsController(ServiceContext serviceContext, IEventsService eventsService) 
        {
            _serviceContext = serviceContext;
            _eventsService = eventsService;
        }
        [HttpPost(Name = "InsertEvent")]
        public int Post([FromBody] Events events)
        {
            return _eventsService.InsertEvents(events);
        }

        [HttpGet(Name = "events")]

        public List<Events> GetAll()
        {
            return _eventsService.GetAll();
        }



    }
    
}
