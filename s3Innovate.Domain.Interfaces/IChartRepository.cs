using s3Innovate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace s3Innovate.Domain.Interfaces
{
    public interface IChartRepository
    {
        Task<IEnumerable<SampleChartModel>> GetSampleChart();
    }
}
