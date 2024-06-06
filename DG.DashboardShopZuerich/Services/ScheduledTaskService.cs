using DG.DashboardShopZuerich.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG.DashboardShopZuerich.Services
{
    internal class ScheduledTaskService
    {
        private Timer _timer;

        public ScheduledTaskService()
        {
            var currentTime = DateTime.Now;
            var timeToMidnight = TimeSpan.FromDays(1) - currentTime.TimeOfDay;
            _timer = new Timer(ResetLunchPlan, null, timeToMidnight, TimeSpan.FromDays(1));
        }

        private void ResetLunchPlan(object state)
        {
            var jsonDataService = new JsonDataService();
            jsonDataService.SavePersonToLuchPlan(new List<LunchPlan>());
        }
    }
}

