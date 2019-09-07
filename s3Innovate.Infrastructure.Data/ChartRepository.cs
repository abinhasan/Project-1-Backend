using s3Innovate.Domain.Entities;
using s3Innovate.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace s3Innovate.Infrastructure.Data
{
    public class ChartRepository : IChartRepository
    {
        public async Task<IEnumerable<SampleChartModel>> GetSampleChart()
        {
            // Days, hours, minutes, seconds, milliseconds.

            //IList<SampleChartModel> sampleChartList = new List<SampleChartModel>() {
            //    new SampleChartModel(){ Time=new TimeSpan(12, 0, 0, 0, 0), Value=500},
            //    new SampleChartModel(){ Time=new TimeSpan(01, 15, 0, 0, 0), Value=500},
            //    new SampleChartModel(){ Time=new TimeSpan(02, 0, 0, 0, 0), Value=500},
            //    new SampleChartModel(){ Time=new TimeSpan(3, 30, 0, 0, 0), Value=700.5}
            //};


            IList<SampleChartModel> sampleChartList = new List<SampleChartModel>() {
                new SampleChartModel(){ Time=new DateTime(2012, 8, 13, 12, 00, 00).ToShortTimeString(), Value =500},
                new SampleChartModel(){ Time= new DateTime(2012, 8, 13, 01, 15, 00).ToShortTimeString(), Value =500},
                new SampleChartModel(){ Time=new DateTime(2012, 8, 13, 02, 00, 00).ToShortTimeString(), Value =500},
                new SampleChartModel(){ Time=new DateTime(2012, 8, 13, 03, 30, 00).ToShortTimeString(), Value =700.5},
                new SampleChartModel(){ Time=new DateTime(2012, 8, 13, 06, 00, 00).ToShortTimeString(), Value =900}
            };

            return await Task.FromResult(sampleChartList);
        }
    }
}
