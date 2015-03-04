using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TimeTracker.Infrastructure;

namespace TimeTracker.Web.Api.Controllers
{
    [RouteAccept(TrackerApiStem, "application/json")]
    [RouteAccept(TrackerApiStem + "/id", "application/json")]
    public class TimeTrackerController : ApiController
    {
        private const string TrackerApiStem = "api" + "/" + "tracker";
    }
}