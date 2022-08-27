using System.Collections.Generic;

namespace ADHD.Configuration.Chart
{
    public class ChartVisit
    {
        public string ChartTitle { get; set; }
        public List<ChartItem> Visits { get; set; }
        public List<short> VisitedMonths { get; set; }
    }
}
