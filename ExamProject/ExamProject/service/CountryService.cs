using ExamProject.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProject.service
{
    public class CountryService: ICountryService
    {
        HRContext context;
        public CountryService(HRContext _context)
        {
            context = _context;
        }
        public List<Country> GetCountries()
        {
            List<Country> countries = context.countries.ToList();
            return countries;
        }
    }
}
