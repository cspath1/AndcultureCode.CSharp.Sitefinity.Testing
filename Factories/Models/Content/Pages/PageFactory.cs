using AndcultureCode.CSharp.Sitefinity.Testing.Enumerations;
using AndcultureCode.CSharp.Sitefinity.Testing.Models.Content.Pages;
using AndcultureCode.CSharp.Testing.Factories;
using Bogus;
using System;
using System.Collections.Generic;

namespace AndcultureCode.CSharp.Sitefinity.Testing.Factories.Models.Content.Pages
{
    public class PageFactory : Factory
    {
        public override void Define()
        {
            var faker = new Faker();
            this.DefineFactory(() => new Page
            {
                AllowParametersValidation = faker.Random.Bool(),
                AvailableLanguages = new List<string>(),
                Breadcrumb = new List<string>(),
                CodeBehindType = faker.Random.Word(),
                Crawlable = faker.Random.Bool(),
                Description = faker.Lorem.Sentence(),
                EnableViewState = faker.Random.Bool(),
                HasChildren = faker.Random.Bool(),
                HeadTagContent = faker.Lorem.Word(),
                HtmlTitle = faker.Lorem.Sentence(),
                IncludeInSearchIndex = faker.Random.Bool(),
                IncludeScriptManager = faker.Random.Bool(),
                IsHomePage = faker.Random.Bool(),
                OutputCacheProfile = faker.Lorem.Word(),
                PageType = PageType.Standard,
                RelativeUrlPath = faker.Internet.UrlWithPath(),
                RequireSsl = faker.Random.Bool(),
                ShowInNavigation = faker.Random.Bool(),
                TemplateId = Guid.NewGuid(),
                Title = faker.Lorem.Word(),
                ViewUrl = faker.Internet.UrlWithPath()
            });
        }
    }
}
