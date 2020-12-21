using AndcultureCode.CSharp.Sitefinity.Testing.Interfaces;
using AndcultureCode.CSharp.Sitefinity.Testing.Models.Content.News;
using AndcultureCode.CSharp.Testing.Factories;
using Bogus;
using System;
using System.Collections.Generic;

namespace AndcultureCode.CSharp.Sitefinity.Testing.Factories.Models.Content.News
{
    public class NewsItemFactory : Factory
    {
        public override void Define()
        {
            var faker = new Faker();
            this.DefineFactory(() => new NewsItem
            {
                AllowComments = faker.Random.Bool(),
                Author = faker.Person.FullName,
                Category = new List<Guid>(),
                Comments = new List<IComment>(),
                Description = faker.Lorem.Sentence(),
                Tags = new List<Guid>(),
                SourceName = faker.Random.Word(),
                SourceSite = faker.Internet.Url(),
                Title = faker.Random.Word()
            });
        }
    }
}
