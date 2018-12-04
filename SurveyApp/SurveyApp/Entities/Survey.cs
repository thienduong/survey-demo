using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyApp.Entities
{
    public class Survey : BaseEntity
    {
        public string CompanyName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool TrackAndTraceModules { get; set; }
        public bool WarehouseModules { get; set; }
        public bool DataAnalytics { get; set; }
    }
}
