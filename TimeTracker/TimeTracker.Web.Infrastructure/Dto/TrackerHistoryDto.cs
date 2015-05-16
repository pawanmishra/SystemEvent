using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Infrastructure.Dto
{
    public class TrackerHistoryDto
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public DateTime date { get; set; }
        public string user_name { get; set; }
        public int meeting_minutes { get; set; }
        public int active_minutes { get; set; }
        public DateTime last_update { get; set; }
    }
}
