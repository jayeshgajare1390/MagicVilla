using MagicVilla_VillaAPI.Models.VillaDTO;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO { Id = 1, Name = "Ocean View Villa", occupancy=5,sqft=500 },
                new VillaDTO { Id = 2, Name = "Mountain Retreat", occupancy=3,sqft=200 }
            };
    }
}
