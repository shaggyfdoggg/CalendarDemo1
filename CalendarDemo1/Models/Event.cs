﻿using System.ComponentModel.DataAnnotations;

namespace CalendarDemo1.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        //Relational data
        public virtual Location Location { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}
