using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Areas.Manage.ViewModels
{
    public class DashboardViewModel
    {
        public int OrderCount { get; set; }
        public int PendingCount { get; set; }
        public int UserCount { get; set; }
        public int PendingPercent { get; set; }
        public decimal TotalProfit { get; set; }
    }
}
