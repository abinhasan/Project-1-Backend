using s3Innovate.Domain.Entities;
using s3Innovate.Domain.Interfaces;
using s3Innovate.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s3Innovate.Services
{
    public class ChartService : IChartService
    {
        private readonly IChartRepository _chartRepository;
        public ChartService(IChartRepository chartRepository)
        {
            _chartRepository = chartRepository;

        }

        public async Task<SampleChartViewModel> GetSampleChart()
        {
            var sampleChart = new SampleChartViewModel();

            var data =  await _chartRepository.GetSampleChart();

            sampleChart.Time = (from d in data
                         select d.Time).ToArray();

            sampleChart.Value = (from d in data
                         select d.Value).ToArray();

            return sampleChart;
        }
    }
}
