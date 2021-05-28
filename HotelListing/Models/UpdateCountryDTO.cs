using System.Collections.Generic;

namespace HotelListing.Models
{
    public class UpdateCountryDTO : CreateCountryDTO
    {
        public IList<CreateHotelDTO> Hotels { get; set; }
    }
}