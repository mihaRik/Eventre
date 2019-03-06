using System;
using System.Collections.Generic;

namespace Eventre.Models
{
    public class EventDay
    {
        public EventDay()
        {
            Talks = new HashSet<Talk>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<Talk> Talks { get; set; }
    }
}