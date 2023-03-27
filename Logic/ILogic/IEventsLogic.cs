using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IEventsLogic
    {
        int InsertEvents(Events events);

        //void DeleteEvents(int id);

        //void UpdateEvents(Events events);

        List<Events> GetAll();



    }
}
