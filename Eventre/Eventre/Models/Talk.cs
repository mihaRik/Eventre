using System;
using System.Linq;
using System.Web;

namespace Eventre.Models
{
    public class Talk
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }

        public string Subject { get; set; }
        public string Venue { get; set; }

        public int EventDayId { get; set; }
        public EventDay EventDay { get; set; }

        public int SpeakerId { get; set; }
        public Speaker Speaker { get; set; }
    }
}