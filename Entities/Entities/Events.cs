﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Events
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public TimeOnly Hour { get; set; }
        public string Description { get; set; }
        public byte[] ImageData { get; set; }
        public Guid IdWeb { get; set; }

    }
}