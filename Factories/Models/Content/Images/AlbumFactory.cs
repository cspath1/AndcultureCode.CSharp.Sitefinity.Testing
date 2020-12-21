using AndcultureCode.CSharp.Sitefinity.Testing.Models.Content.Images;
using AndcultureCode.CSharp.Testing.Factories;
using Bogus;
using System;

namespace AndcultureCode.CSharp.Sitefinity.Testing.Factories.Models.Content.Images
{
    public class AlbumFactory : Factory
    {
        public override void Define()
        {
            var faker = new Faker();
            this.DefineFactory(() => new Album
            {
                BlobStorageProvider = faker.Lorem.Word(),
                ClientCacheProfile = faker.Lorem.Word(),
                ChildrenCount = faker.Random.Int(),
                CoverId = Guid.NewGuid(),
                Description = faker.Lorem.Sentence(),
                MaxSize = faker.Random.Long(),
                MaxItemSize = faker.Random.Long(),
                NewSize = faker.Lorem.Word(),
                OutputCacheProfile = faker.Lorem.Word(),
                ResizeOnUpload = faker.Random.Bool(),
                Title = faker.Lorem.Word()
            });
        }
    }
}
