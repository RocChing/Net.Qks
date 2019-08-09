using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Net.Qks.MultiTenancy.HostDashboard.Dto;

namespace Net.Qks.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}