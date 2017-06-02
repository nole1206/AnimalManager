using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace AnimalManager
{
    public class SheepController : ApiController
    {
        [HttpGet]
        [Route("sheep")]
        public string Index()
        {
            return "Welcome to Sheepishly 1.0.0 - The Combleat Sheep Tracking Suite";
        }

        [HttpPost]
        [Route("sheep/locations")]
        public async Task<bool> Log(Object location)
        {
            return true;
        }

        [HttpGet]
        [Route("sheep/{sheepId}/lastseen")]
        public async Task<DateTime?> LastSeen(int sheepId)
        {
            return DateTime.Now;
        }

        [HttpGet]
        [Route("sheep/{sheepId}/lastlocation")]
        public async Task<object> LastLocation(int sheepId)
        {
            var sheep = new Sheep();
            sheep.Id = 1;
            sheep.Name = "Sheepy";
            sheep.Age = 3;
            sheep.Sheared = true;
            return sheep;
        }
    }
}
