using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TimeTracker.Infrastructure;
using TimeTracker.Infrastructure.Dto;
using TimeTracker.Infrastructure.DtoMapper;
using TimeTracker.Infrastructure.Entities;
using TimeTracker.Infrastructure.Repository;

namespace TimeTracker.Web.Api.Controllers
{
    [RouteAccept(TrackerApiStem, "application/json")]
    [RouteAccept(TrackerApiStem + "/{id}", "application/json")]
    public class TimeTrackerController : ApiController
    {
        private const string RootUrl = "http://localhost:50040/";
        private const string TrackerApiStem = "api" + "/" + "tracker";
        private readonly IRepository<Tracker> _trackerRepository;
        private readonly IMapper<Tracker, TrackerDto> _trackerMapper;

        public TimeTrackerController()
        {
            _trackerRepository = new EFRepository<Tracker>();
            _trackerMapper = new TrackerEntityToDtoMapper();
        }

        public IEnumerable<TrackerDto> Get()
        {
            return _trackerRepository.GetAll().ToList().Select(x => _trackerMapper.MapFrom(x, RootUrl));
        }
        
        public IHttpActionResult Get([FromUri] int id)
        {
            var rootLocation = HttpContext.Current;
            var tracker = _trackerRepository.FindBy(x => x.Id == id).FirstOrDefault();
            if(tracker != null)
            {
                var dto = _trackerMapper.MapFrom(tracker, RootUrl);
                return Ok(dto);
            }

            return NotFound();
        }
    }
}