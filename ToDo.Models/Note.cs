using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Models
{
   public class Note
    {
        public int id { get; set; }
        public string description { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public string Details { get; set; }
        public bool done { get; set; }
    }
}
