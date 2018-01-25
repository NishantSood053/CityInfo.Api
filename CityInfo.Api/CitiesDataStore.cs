using System;
using System.Collections.Generic;
using CityInfo.Api.Models;

namespace CityInfo.Api
{
    public class CitiesDataStore
    {
        //Auto property initialization
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities
        {
            get;
            set;
        }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    CityId = 1,
                    Name = "Ottawa",
                    Description = "Capital City of Canada"
                },
                new CityDto()
                {
                    CityId = 2,
                    Name = "Toronto",
                    Description = "Largest City of Canada"
                }
            };
        }
    }
}
