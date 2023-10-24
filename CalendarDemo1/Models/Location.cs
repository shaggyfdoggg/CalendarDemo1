using System.ComponentModel.DataAnnotations;

namespace CalendarDemo1.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //Relational data
        public virtual ICollection<Event> Events { get; set; }


    }
}
