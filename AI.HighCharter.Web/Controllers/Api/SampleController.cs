using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AI.HighCharter.Web.Models;

namespace AI.HighCharter.Web.Controllers.Api
{
    public class SampleController : ApiController
    {
        public HighchartsModel Get()
        {
            var rand = new Random();
            return new HighchartsModel()
            {
                Categories = CreateCategories(10).ToList(),
                Series = new List<HighchartsSeries>()
                {
                    CreateSeries("Series 0", 10, rand, HighchartsSeries.ChartTypes.areaspline),
                    CreateSeries("Series 1", 10, rand),
                    CreateSeries("Series 2", 10, rand),
                }
            };
        }

        private HighchartsSeries CreateSeries(string name, int length, Random rand, HighchartsSeries.ChartTypes type)
        {
            var series = CreateSeries(name, length, rand);
            series.type = type.ToString();
            return series;
        }

        private IEnumerable<string> CreateCategories(int length)
        {
            var cats = new List<string>();
            for (int i = 0; i < length; i++)
            {
                cats.Add("T" + i.ToString());
            }

            return cats;
        }

        private HighchartsSeries CreateSeries(string name, int length, Random rand)
        {
            var data = new List<decimal>();
            for (int i = 0; i < length; i++)
            {
                data.Add(Convert.ToDecimal(rand.NextDouble()));
            }

            return new HighchartsSeries()
            {
                name = name,
                data = data
            };
        }
    }
}