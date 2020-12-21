using AndcultureCode.CSharp.Sitefinity.Testing.Models.Content.Blogs;
using AndcultureCode.CSharp.Testing.Factories;
using Bogus;

namespace AndcultureCode.CSharp.Sitefinity.Testing.Factories.Models.Content.Blogs
{
    public class BlogFactory : Factory
    {
        public override void Define()
        {
            var faker = new Faker();
            this.DefineFactory(() => new Blog
            {
                Description = faker.Lorem.Sentence(),
                Title = faker.Lorem.Sentence()
            });
        }
    }
}
