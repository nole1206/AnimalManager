using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace AnimalManager
{
    public class CowController : ApiController
    {
        [HttpGet]
        [Route("cow")]
        public string Index()
        {
            return "Welcome to Cow 1.0.0 - The Beefiest Cow Tracking Suite";
        }

        [HttpPost]
        [Route("cow/locations")]
        public async Task<bool> Log(Object location)
        {
            return true;
        }

        [HttpGet]
        [Route("cow/{cowId}/lastseen")]
        public async Task<DateTime?> LastSeen(int cowId)
        {
            return DateTime.Now;
        }

        [HttpGet]
        [Route("cow/{cowId}/lastlocation")]
        public async Task<object> LastLocation(int cowId)
        {
            var cow = new Cow();
            cow.Id = 2;
            cow.Name = "Cowy";
            cow.Age = 5;
            cow.Milked = false;
            return cow;
        }
    }
}
