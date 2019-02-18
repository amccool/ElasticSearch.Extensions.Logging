using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using AM.Extensions.Logging.ElasticSearch;
using Elasticsearch.Net;
using ElasticsearchInside;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;
using Newtonsoft.Json;
using Xunit;

namespace ElasticLogger.Test
{
    public class ESLoggerTests
    {
        [Fact(Skip = "Skipping because the factory extensions have been removed")]
        public async Task Test1()
        {
            //using (var elasticsearch = new ElasticsearchInside.Elasticsearch())
            //{
            //    ////Arrange
            //    await elasticsearch.Ready();
            //    //var client = new ElasticClient(new ConnectionSettings(elasticsearch.Url));

            //    ILoggerFactory loggerFactory = new LoggerFactory()
            //        .AddElasticSearch(elasticsearch.Url,
            //            LogLevel.Trace);


            //    var logger = loggerFactory.CreateLogger("xxxxxxx");

            //    var circularRefObj = new Circle();
            //    circularRefObj.me = circularRefObj;


            //    logger.Log(LogLevel.Critical, new EventId(), circularRefObj, null, (circle, exception) => "");

            //}

        }

        [Fact]
        public void Test2()
        {
            bool on = true;

            Assert.True(on);

        }

        [Fact]
        public async Task TryingToBreakThisThing()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
            };

            Circle sillyCircle = new Circle{me = null};
            sillyCircle.me = sillyCircle;

            ElasticsearchJsonNetSerializer serializer = new ElasticsearchJsonNetSerializer();

            MemoryStream stream = new MemoryStream();

            serializer.Serialize(sillyCircle, stream);

            var reader = new StreamReader(stream);

            var huh = await reader.ReadToEndAsync();
        }

        [Fact]
        public async Task LoggingThing()
        {
            var factory = new CustomWebApplicationFactory<Startup>();

            var client = factory.CreateClient();

            await client.GetAsync("/");
        }

    }

    public class Circle
    {
        public Circle me { get; set; }
    }
}
