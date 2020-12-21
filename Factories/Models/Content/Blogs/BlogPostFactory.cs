using AndcultureCode.CSharp.Sitefinity.Testing.Interfaces;
using AndcultureCode.CSharp.Sitefinity.Testing.Models.Content.Blogs;
using AndcultureCode.CSharp.Testing.Factories;
using Bogus;
using System;
using System.Collections.Generic;

namespace AndcultureCode.CSharp.Sitefinity.Testing.Factories.Models.Content.Blogs
{
    public class BlogPostFactory : Factory
    {
        public override void Define()
        {
            var faker = new Faker();
            this.DefineFactory(() => new BlogPost
            {
                AllowComments = true,
                Category = new List<Guid>(),
                Comments = new List<IComment>(),
                Content = faker.Lorem.Sentences(),
                Description = faker.Lorem.Sentence(),
                Summary = faker.Lorem.Sentence(),
                Tags = new List<Guid>(),
                Title = faker.Lorem.Sentence()
            });
        }
    }
}
