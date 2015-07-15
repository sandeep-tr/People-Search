namespace PeopleSearch.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PeopleSearch.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<PeopleSearch.Models.PeopleSearchDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PeopleSearch.Models.PeopleSearchDb";
        }

        protected override void Seed(PeopleSearch.Models.PeopleSearchDb context)
        {
            context.People.AddOrUpdate(r => r.FirstName,
                new Person
                {
                    FirstName = "Thomas",
                    LastName = "Baker",
                    Age = 40,
                    Address = new PersonAddress { Street = "918 Overlook Circle", City = "Deer Park", State = "NY" },
                    Interests = new List<PersonInterest>{
                        new PersonInterest{  Interest="Football" },
                        new PersonInterest{  Interest="Movies" }
                    }
                },
                new Person
                {
                    FirstName = "Sophie",
                    LastName = "Ross",
                    Age = 55,
                    ImageId = 2,
                    ImageExtension = "png",
                    Address = new PersonAddress { Street = "910 Euclid Avenue", City = "Woonsocket", State = "RI" },
                    Interests = new List<PersonInterest>{
                        new PersonInterest{  Interest="Baseball" }
                    }
                },
                new Person
                {
                    FirstName = "Leonard",
                    LastName = "Baker",
                    Age = 22,
                    ImageId = 1,
                    ImageExtension = "jpg",
                    Address = new PersonAddress { Street = "777 Front Street North", City = "Chapel Hill", State = "NC" },
                    Interests = new List<PersonInterest>{
                        new PersonInterest{  Interest="Live-action roleplaying" }
                    }
                },
                new Person
                {
                    FirstName = "Thomas",
                    LastName = "Dyer",
                    Age = 28,
                    Address = new PersonAddress { Street = "66 Route 4", City = "Apex", State = "NC" },
                    Interests = new List<PersonInterest>{
                        new PersonInterest{  Interest="Bowling" },
                        new PersonInterest{  Interest="Movies" }
                    }
                },
                new Person
                {
                    FirstName = "Kevin",
                    LastName = "Gill",
                    Age = 28,
                    ImageId = 1,
                    ImageExtension = "jpg",
                    Address = new PersonAddress { Street = "718 Redwood Drive", City = "East Orange", State = "NJ" },
                    Interests = new List<PersonInterest>{
                        new PersonInterest{  Interest="Treasure hunting" }
                    }
                },
                new Person
                {
                    FirstName = "Una",
                    LastName = "Martin",
                    Age = 35,
                    ImageId = 2,
                    ImageExtension = "png",
                    Address = new PersonAddress { Street = "83 Main Street South", City = "Macungie", State = "PA" },
                    Interests = new List<PersonInterest>{
                        new PersonInterest{  Interest="Shakespeare" },
                        new PersonInterest{  Interest="Movies" }
                    }
                },
                new Person
                {
                    FirstName = "Harry",
                    LastName = "Langdon",
                    Age = 30,
                    Address = new PersonAddress { },
                    Interests = new List<PersonInterest>{
                        new PersonInterest{  Interest="Ancient China" }
                    }
                },
                new Person
                {
                    FirstName = "Lauren",
                    LastName = "Piper",
                    Age = 28,
                    Address = new PersonAddress { },
                    Interests = new List<PersonInterest> { }
                },
                new Person
                {
                    FirstName = "Boris",
                    LastName = "Tucker",
                    Age = 45,
                    Address = new PersonAddress { Street = "676 Oxford Road", City = "Hattiesburg", State = "MS" },
                    Interests = new List<PersonInterest>{new PersonInterest{  Interest="Movies" }
                    }
                },
                new Person
                {
                    FirstName = "Jane",
                    LastName = "Ellison",
                    Age = 18,
                    Address = new PersonAddress { Street = "73 Fawn Court", City = "Burbank", State = "IL" },
                    Interests = new List<PersonInterest> { }
                }
            );
        }
    }
}