using s3Innovate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace s3Innovate.Services.Interfaces
{
    public interface IChartService
    {
        //Task<IEnumerable<SampleChartModel>> GetSampleChart();
        Task<SampleChartViewModel> GetSampleChart();
    }
}
