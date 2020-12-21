using AndcultureCode.CSharp.Sitefinity.Testing.Models.Content.Documents;
using AndcultureCode.CSharp.Testing.Factories;
using Bogus;
using System;

namespace AndcultureCode.CSharp.Sitefinity.Testing.Factories.Models.Content
{
    public class DocumentLibraryFactory : Factory
    {
        public override void Define()
        {
            var faker = new Faker();
            this.DefineFactory(() => new DocumentLibrary
            {
                BlobStorageProvider = faker.Lorem.Word(),
                ChildrenCount = faker.Random.Int(),
                ClientCacheProfile = faker.Lorem.Word(),
                CoverId = Guid.NewGuid(),
                Description = faker.Lorem.Sentence(),
                MaxSize = faker.Random.Long(),
                MaxItemSize = faker.Random.Long(),
                OutputCacheProfile = faker.Lorem.Word(),
                Title = faker.Random.Word()
            });
        }
    }
}
