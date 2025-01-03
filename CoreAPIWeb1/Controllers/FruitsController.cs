using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPIWeb1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        public List<string> Fruits = new List<string>()
        {
           "Apple",
           "Banana",
           "Orange",
           "Pineapple",
           "Coconut",
           "Grapes",
           "Gwava"
        };

        [HttpGet]
        public List<string> GetFruits()
        {
            return Fruits;
        }
        [HttpGet("{id}")]
        public string GetFruits(int id)
        {
            return Fruits.ElementAt(id);
        }
    }
}
