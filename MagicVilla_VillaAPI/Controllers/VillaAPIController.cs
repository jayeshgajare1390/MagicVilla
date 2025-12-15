using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.VillaDTO;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    //[Route("API/VillaAPI")]
    [Route("API/[Controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            var villas = new List<VillaDTO>
            {
                new VillaDTO { Id = 1, Name = "Ocean View Villa" },
                new VillaDTO { Id = 2, Name = "Mountain Retreat" }
            };
            return villas;
        }
    }
}
