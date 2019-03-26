using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeri.Gruplar
{
    struct Country
    {
        public string CountryName { get; set; }
        public string[] Cities { get; set; }
}
     public  class AdresUretim
    {
        private Random _random;

        private Country[] countries =
        {
            new Country {CountryName = "Turkey", Cities = new[] {"Ankara", "İstanbul", "Samsun", "Kayseri", "Kastamonu"}},
            new Country {CountryName = "France", Cities = new[] {"Paris", "Marsilya", "Nantes"}},
            new Country {CountryName = "Japan", Cities = new[] {"Tokyo", "Hiroşima"}},
            new Country {CountryName = "Russia", Cities = new[] {"Moskova"}},
            new Country {CountryName = "England", Cities = new[] {"Mençistır", "Londra"}}
        };

        public AdresUretim()
        {
            _random = new Random();
        }

        public string UlkeGonder()
        {
           int randNumbew = _random.Next(countries.Length);
            return countries[randNumbew].CountryName;
    }

        public string SehirGonder(string countryName)
        {
            foreach (Country country in countries)
            {
                if (countryName == country.CountryName)
                {
                    int randNumbew = _random.Next(country.Cities.Length);
                    return country.Cities[randNumbew];

                }
            }

            return null;
        }

    }
}
