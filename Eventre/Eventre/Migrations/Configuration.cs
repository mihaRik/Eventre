namespace Eventre.Migrations
{
    using Eventre.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Eventre.DAL.EventreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Eventre.DAL.EventreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Headers.AddOrUpdate(h => new { h.SubTitle, h.Title, h.DatePlace },
                new Header
                {
                    SubTitle = "The countdown is finished",
                    Title = "<h1>Business</h1><h2>Conference 2017</h2>",
                    DatePlace = "02-05 July 2017 California",
                    Image = "background/homepage-one-banner.jpg"
                });

            context.About.AddOrUpdate(a => new { a.Title, a.ContentUp, a.ContentDown },
                new About
                {
                    Title = "<h2>About The <span class=\"alternate\">Eventre</span></h2>",
                    ContentUp = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusm tempor incididunt ut labore dolore magna aliqua enim ad minim veniam quis nostrud exercitation ullamco.",
                    ContentDown = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmtempor incididunt ut labore et dolore magna aliq enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea.",
                    Image = "speakers/featured-speaker.jpg"
                });

            context.Speakers.AddOrUpdate(s => new { s.Fullname, s.Profession },
                new Speaker
                {
                    Fullname = "Rahim Teymurov",
                    Profession = "Student",
                    Image = "speakers/speaker-one.jpg",
                    Facebook = "asdf",
                    Twitter = "asdf",
                    LinkedIn = "asdf",
                    Pinterest = "asdf"
                },
                new Speaker
                {
                    Fullname = "Rahim Teymurov",
                    Profession = "Student",
                    Image = "speakers/speaker-two.jpg",
                    Facebook = "asdf",
                    Twitter = "asdf",
                    LinkedIn = "asdf",
                    Pinterest = "asdf"
                },
                new Speaker
                {
                    Fullname = "Rahim Teymurov",
                    Profession = "Student",
                    Image = "speakers/speaker-three.jpg",
                    Facebook = "asdf",
                    Twitter = "asdf",
                    LinkedIn = "asdf",
                    Pinterest = "asdf"
                },
                new Speaker
                {
                    Fullname = "Rahim Teymurov",
                    Profession = "Student",
                    Image = "speakers/speaker-four.jpg",
                    Facebook = "asdf",
                    Twitter = "asdf",
                    LinkedIn = "asdf",
                    Pinterest = "asdf"
                },
                new Speaker
                {
                    Fullname = "Rahim Teymurov",
                    Profession = "Student",
                    Image = "speakers/speaker-five.jpg",
                    Facebook = "asdf",
                    Twitter = "asdf",
                    LinkedIn = "asdf",
                    Pinterest = "asdf"
                },
                new Speaker
                {
                    Fullname = "Rahim Teymurov",
                    Profession = "Student",
                    Image = "speakers/speaker-six.jpg",
                    Facebook = "asdf",
                    Twitter = "asdf",
                    LinkedIn = "asdf",
                    Pinterest = "asdf"
                });

            //context.EventDays.AddOrUpdate(
            //    new EventDay
            //    {
            //        Date = DateTime.Now
            //    },
            //    new EventDay
            //    {
            //        Date = DateTime.Now.AddDays(-1)
            //    });

            //context.Talks.AddOrUpdate(t => new { t.EventDayId, t.SpeakerId, t.Subject },
            //    new Talk { Time = new DateTime(2019, 03, 20, 9, 00, 00), Subject = "Introduction WP", SpeakerId = 1, EventDayId = 1, Venue = "Aditorium A" },
            //    new Talk { Time = new DateTime(2019, 03, 20, 11, 45, 00), Subject = "Principle of WP", SpeakerId = 2, EventDayId = 1, Venue = "Aditorium B" },
            //    new Talk { Time = new DateTime(2019, 03, 20, 15, 00, 00), Subject = "Reqiurmnet of WP", SpeakerId = 3, EventDayId = 1, Venue = "Aditorium C" },
            //    new Talk { Time = new DateTime(2019, 03, 20, 16, 30, 00), Subject = "Usefull tips for WP", SpeakerId = 4, EventDayId = 1, Venue = "Aditorium D" },
            //    new Talk { Time = new DateTime(2019, 03, 20, 20, 00, 00), Subject = "Reqiurmnet WP", SpeakerId = 5, EventDayId = 2, Venue = "Aditorium A" },
            //    new Talk { Time = new DateTime(2019, 03, 20, 12, 30, 00), Subject = "Introduction WP", SpeakerId = 6, EventDayId = 2, Venue = "Aditorium B" },
            //    new Talk { Time = new DateTime(2019, 03, 20, 9, 00, 00), Subject = "Principle WP", SpeakerId = 3, EventDayId = 2, Venue = "Aditorium C" },
            //    new Talk { Time = new DateTime(2019, 03, 20, 10, 15, 00), Subject = "Usefull tips for WP", SpeakerId = 2, EventDayId = 2, Venue = "Aditorium D" });
        }
    }
}
