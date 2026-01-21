using CountryWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CountryWebApi.Controllers
{
    public class CountryController : ApiController
    {
        static List<Country> countries = new List<Country>()
        {
            new Country { ID = 1, CountryName = "India", Capital = "Delhi" },
            new Country { ID = 2, CountryName = "Japan", Capital = "Tokyo" },
            new Country { ID = 3, CountryName = "Australia", Capital = "Canberra"}
        };

        // For displaying All the Countries
        public IHttpActionResult Get()
        {
            return Ok(countries);
        }

        public IHttpActionResult Get(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        // Adding new  Country 
        public IHttpActionResult Post(Country country)
        {
            countries.Add(country);
            return Ok(country);
        }


        // Updating The  Country Details
        public IHttpActionResult Put(int id, Country country)
        {
            var coun = countries.FirstOrDefault(c => c.ID == id);
            if (coun == null)
                return NotFound();

            coun.CountryName = country.CountryName;
            coun.Capital = country.Capital;
            return Ok(coun);
        }

        // Deleting any country by ID
        public IHttpActionResult Delete(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            countries.Remove(country);
            return Ok("Country Removed Successfully");
        }
    }
}
  