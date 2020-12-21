using AndcultureCode.CSharp.Sitefinity.Testing.Models.Content.Images;
using AndcultureCode.CSharp.Testing.Factories;
using Bogus;
using System;
using System.Collections.Generic;

namespace AndcultureCode.CSharp.Sitefinity.Testing.Factories.Models.Content.Images
{
    public class ImageFactory : Factory
    {
        public override void Define()
        {
            var faker = new Faker();
            this.DefineFactory(() => new Image
            {
                AlternativeText = faker.Lorem.Sentence(),
                Author = faker.Person.FullName,
                Category = new List<Guid>(),
                Description = faker.Lorem.Sentence(),
                Extension = ".jpg",
                Height = faker.Random.Int(),
                MimeType = "image/jpeg",
                Ordinal = faker.Random.Float(),
                ThumbnailUrl = faker.Internet.Url(),
                Title = faker.Random.Word(),
                TotalSize = faker.Random.Long(),
                Width = faker.Random.Int(),
                Url = faker.Internet.Url()
            });
        }
    }
}
