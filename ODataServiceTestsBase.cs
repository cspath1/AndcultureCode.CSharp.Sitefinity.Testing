using AndcultureCode.CSharp.Sitefinity.Testing.Models.Configuration;
using AndcultureCode.CSharp.Sitefinity.Testing.Models.Content;
using AndcultureCode.CSharp.Testing.Factories;
using AndcultureCode.CSharp.Testing.Tests;
using System;
using System.Reflection;
using Xunit.Abstractions;

namespace AndcultureCode.CSharp.Sitefinity.Testing
{
    public class ODataServiceTestsBase<TService, TModel> : BaseTest where TModel : Content, new()
    {

        #region Members

        public static string SF_TEST_PREFIX = "sf_test_";

        public string AccessToken { get { return Fixture.Session.AccessToken; } }
        public ODataSessionFixture Fixture { get; }
        public TModel Model { get; set; }
        public TestingSettings ODataTestSettings { get { return Fixture.Session.ODataTestSettings; } }
        public TService Sut { get; set; }

        #endregion Members

        static ODataServiceTestsBase()
        {
            // Clear all factories
            FactoryExtensions.ClearFactoryDefinitions();

            // Load factories
            LoadFactories(typeof(ODataServiceTestsBase<TService, TModel>).GetTypeInfo().Assembly);
        }

        public ODataServiceTestsBase(
            ODataSessionFixture fixture,
            ITestOutputHelper output
        ) : base(output)
        {
            Fixture = fixture;
        }

        #region Public Methods

        public string GetRandomString(string fieldName)
        {
            return $"{SF_TEST_PREFIX}_{fieldName}_{Guid.NewGuid()}";
        }

        public void StartNewSession()
        {
            this.Fixture.Session.Authenticate();
        }

        #endregion Public Methods
    }
}
