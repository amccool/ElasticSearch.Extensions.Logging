# AM.Extensions.Logging.ElasticSearch
Microsoft.Extensions.Logging compatible logger posting to ElasticSearch

![.NET Core](https://github.com/amccool/AM.Extensions.Logging.ElasticSearch/workflows/.NET%20Core/badge.svg?branch=master)  - master


ElasticSearch Logger is a ILogger based logger which submits events and data to ElasticSearch making them viewable with Kibana


[![nuget downloads](https://img.shields.io/nuget/dt/AM.Extensions.Logging.ElasticSearch.svg)](https://www.nuget.org/packages/AM.Extensions.Logging.ElasticSearch/)
[![nuget version](https://img.shields.io/nuget/v/AM.Extensions.Logging.ElasticSearch.svg)](https://www.nuget.org/packages/AM.Extensions.Logging.ElasticSearch/)


## Getting Started

Install the package from nuget.org https://www.nuget.org/packages/AM.Extensions.Logging.ElasticSearch

```ps
Install-Package AM.Extensions.Logging.ElasticSearch
```

```
 .AddLogging(builder =>
                {
                    builder
                        .AddConfiguration(loggingConfiguration.GetSection("Logging"))
                        .AddElasticSearch(options =>
                        {
                            options.ElasticsearchEndpoint = new Uri(@"http://localhost:9200/");
                            //options.IndexName = "trace";
                        });
```




Elasticsearch logging posting using a configurable index prefix
<your chosen prefix>-YYYY-MM-DD-HH
the default prefix is "trace"

see <https://github.com/amccool/AM.Elasticsearch.TraceListener>  for setup of Elasticsearch index via kibana

PR's welcome
