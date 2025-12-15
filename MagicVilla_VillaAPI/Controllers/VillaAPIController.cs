using MagicVilla_VillaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("API/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            var villas = new List<Villa>
            {
                new Villa { Id = 1, Name = "Ocean View Villa" },
                new Villa { Id = 2, Name = "Mountain Retreat" }
            };
            return villas;
        }
    }
}
