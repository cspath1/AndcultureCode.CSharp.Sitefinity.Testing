using AndcultureCode.CSharp.Sitefinity.Testing.Models.Content.Calendars;
using AndcultureCode.CSharp.Testing.Factories;
using Bogus;

namespace AndcultureCode.CSharp.Sitefinity.Testing.Factories.Models.Content.Calendars
{
    public class CalendarFactory : Factory
    {
        public override void Define()
        {
            var faker = new Faker();
            this.DefineFactory(() => new Calendar
            {
                Color = "#FFFFFF",
                Description = faker.Lorem.Sentence(),
                Title = faker.Lorem.Word()
            });
        }
    }
}
