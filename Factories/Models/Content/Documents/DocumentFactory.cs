using AndcultureCode.CSharp.Sitefinity.Testing.Models.Content.Documents;
using AndcultureCode.CSharp.Testing.Factories;
using Bogus;
using System;
using System.Collections.Generic;

namespace AndcultureCode.CSharp.Sitefinity.Testing.Factories.Models.Content
{
    public class DocumentFactory : Factory
    {
        public override void Define()
        {
            var faker = new Faker();
            this.DefineFactory(() => new Document
            {
                Author = faker.Person.FullName,
                Category = new List<Guid>(),
                Description = faker.Lorem.Sentence(),
                Extension = ".pdf",
                MimeType = "application/pdf",
                Ordinal = 90,
                Tags = new List<Guid>(),
                ThumbnailUrl = faker.Internet.Url(),
                TotalSize = faker.Random.Long(),
                Title = faker.Random.Word(),
                Url = faker.Internet.Url()
            });
        }
    }
}
