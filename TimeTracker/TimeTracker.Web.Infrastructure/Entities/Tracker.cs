using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Core.Framework;

namespace TimeTracker.Infrastructure.Entities
{
    public class Tracker : IEntity
    {
        public Tracker()
        {
            TrackerHistory = new List<TrackerHistory>();
        }

        public DateTime Date { get; set; }

        public string UserName { get; set; }

        public int MeetingMinutes { get; set; }

        public int ActiveMinutes { get; set; }

        public bool IsWorkingDay { get; set; }

        public DateTime StartTime { get; set; }

        public ICollection<TrackerHistory> TrackerHistory { get; set; }

        public int Id { get; set; }

        public DateTime LastUpdate { get; set; }

        public int SyncRoot { get; set; }

        public DateTime DateCreated { get { return Date; } set { Date = value; } }

        public DateTime DateModified { get { return LastUpdate; } set { LastUpdate = value; } }
    }
}
