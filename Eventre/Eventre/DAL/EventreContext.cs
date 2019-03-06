using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Eventre.Models;

namespace Eventre.DAL
{
    public class EventreContext : DbContext
    {
        public DbSet<Header> Headers { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Talk> Talks { get; set; }
        public DbSet<EventDay> EventDays { get; set; }
    }
}