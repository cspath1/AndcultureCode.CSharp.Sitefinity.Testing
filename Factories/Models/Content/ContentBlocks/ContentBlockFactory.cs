using AndcultureCode.CSharp.Sitefinity.Testing.Models.Content.ContentBlocks;
using AndcultureCode.CSharp.Testing.Factories;
using Bogus;

namespace AndcultureCode.CSharp.Sitefinity.Testing.Factories.Models.Content.ContentBlocks
{
    public class ContentBlockFactory : Factory
    {
        public override void Define()
        {
            var faker = new Faker();
            this.DefineFactory(() => new ContentBlock
            {
                Content = faker.Lorem.Paragraph(),
                Description = faker.Lorem.Sentence(),
                Title = faker.Lorem.Word()
            });
        }
    }
}
