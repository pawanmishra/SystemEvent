using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Infrastructure.Dto;
using TimeTracker.Infrastructure.Entities;

namespace TimeTracker.Infrastructure.DtoMapper
{
    public class TrackerEntityToDtoMapper : IMapper<Tracker, TrackerDto>
    {
        public TrackerDto MapFrom(Tracker source)
        {
            TrackerDto tracker = new TrackerDto();
            tracker.id = source.Id;
            tracker.user_name = source.UserName;
            tracker.date = source.DateCreated;
            tracker.is_working_day = source.IsWorkingDay;
            tracker.active_minutes = source.ActiveMinutes;
            tracker.meeting_minutes = source.MeetingMinutes;
            tracker.start_time = source.StartTime;
            tracker.last_update = source.DateModified;
            tracker.tracker_history = new TrackerHistoryDto[source.TrackerHistory.Count];
            for(int i = 0; i < source.TrackerHistory.Count; i++)
            {
                var item = source.TrackerHistory[i];
                TrackerHistoryDto dto = new TrackerHistoryDto();
                dto.id = item.Id;
                dto.parent_id = item.ParentId;
                dto.user_name = source.UserName;
                dto.date = source.DateCreated;
                dto.active_minutes = source.ActiveMinutes;
                dto.meeting_minutes = source.MeetingMinutes;
                dto.last_update = source.DateModified;
                tracker.tracker_history[i] = dto;
            }

            return tracker;
        }
    }
}
