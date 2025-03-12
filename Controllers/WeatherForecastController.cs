using Microsoft.AspNetCore.Mvc;

namespace week1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        List<string> stringData = new List<string> { "Ram", "Shyam", "Hari" };
        [HttpGet("name")]
        public List<string> GetList()
        {
            return stringData;
        }

        [HttpPost("name")]
        public List<string> PostName()
        {
            stringData.Add("Sampanna");
            return stringData;
        }

        [HttpPut("name")]
        public List<string> PutName()
        {
            if (stringData.FirstOrDefault(p => p == "Ram") != null)
            {
                stringData.Remove("Ram");
                stringData.Add("Rum");

            }
            return stringData;
        }

        [HttpPatch("name")]
        public string PatchName()
        {
            return "Drishya";
        }

        [HttpDelete("remove-data")]
        public List<string> DeleteName()
        {
            stringData.Remove("Sampanna");
            return stringData;
        }
    }
}
