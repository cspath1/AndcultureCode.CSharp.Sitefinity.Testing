using AndcultureCode.CSharp.Sitefinity.Testing.Interfaces;
using AndcultureCode.CSharp.Sitefinity.Testing.Models.Content.Calendars;
using AndcultureCode.CSharp.Testing.Factories;
using Bogus;
using System;
using System.Collections.Generic;

namespace AndcultureCode.CSharp.Sitefinity.Testing.Factories.Models.Content.Calendars
{
    public class EventFactory : Factory
    {
        public override void Define()
        {
            var faker = new Faker();
            this.DefineFactory(() => new Event
            {
                AllDayEvent = faker.Random.Bool(),
                AllowComments = faker.Random.Bool(),
                Category = new List<Guid>(),
                City = faker.Address.City(),
                Comments = new List<IComment>(),
                ContactCell = faker.Phone.PhoneNumber(),
                ContactEmail = faker.Internet.Email(),
                ContactName = faker.Person.FullName,
                ContactPhone = faker.Phone.PhoneNumber(),
                ContactWeb = faker.Internet.Url(),
                Content = faker.Lorem.Sentence(),
                Country = faker.Address.Country(),
                Description = faker.Lorem.Sentence(),
                IsRecurrent = faker.Random.Bool(),
                Location = faker.Lorem.Sentence(),
                State = faker.Address.State(),
                Street = faker.Address.StreetAddress(),
                Summary = faker.Lorem.Sentence(),
                Tags = new List<Guid>(),
                TimeZoneId = faker.Lorem.Word(),
                Title = faker.Lorem.Word()
            });
        }
    }
}
