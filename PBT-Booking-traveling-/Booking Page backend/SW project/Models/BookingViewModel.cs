using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SW_project.Models
{
     public class BookingViewModel
     {
          public string CountryFromErrorMessage { get; set; }
          public string CountryToErrorMessage { get; set; }
          public string CityFromErrorMessage { get; set; }
          public string CityToErrorMessage { get; set; }
          public string SelectedCountryFrom { get; set; }
          public string SelectedCityFrom { get; set; }

          public MvcHtmlString script = MvcHtmlString.Empty;
          public bool IsValid { get; set; }

          public EFBookingContext db = new EFBookingContext();

          public List<string> GetCountry(string name)
          {
              return db.BookingInfo.Where(x => x.Country.StartsWith(name) )
                    .Select(x => x.Country).Distinct().ToList();
          }
          public List<string> GetCity(string name)
          {
               return db.BookingInfo.Where(x => x.City.StartsWith(name))
                     .Select(x => x.City).Distinct().ToList();
          }
          public void CheckCountryFrom(string countryParam)
          {
               string[] b = db.BookingInfo.Where(x => x.Country == countryParam)
                              .Select(x => x.Country).Distinct().ToArray();

               if (b.Length == 0)
                    CountryFromErrorMessage = "Invalid Country Name";
               else
                    SelectedCountryFrom = b[0];
          }
          public void CheckCountryTo(string countryParam)
          {
               string[] b = db.BookingInfo.Where(x => x.Country == countryParam)
                              .Select(x => x.Country).Distinct().ToArray();

               if (b.Length == 0 || b[0] != SelectedCountryFrom)
                    CountryToErrorMessage = "Invalid Country Name";
          }
          public void CheckCityFrom(string Country, string City)
          {
               string[] b = db.BookingInfo.Where(x => x.City == City)
                              .Select(x => x.City).Distinct().ToArray();
               if (b.Length == 0)
                    CityFromErrorMessage = "Invalid City Name";
               else
               {
                    string result = db.BookingInfo.Where(x => x.City == City)
                                   .Select(x => x.Country)
                                   .Distinct()
                                   .ToArray()[0];

                    if (result != Country)
                         CityFromErrorMessage = "City Doesn't Exists in This Country";
                    else
                         SelectedCityFrom = City;
               }
          }
          public void CheckCityTo(string Country, string City)
          {
               string[] b = db.BookingInfo.Where(x => x.City == City)
                              .Select(x => x.City).Distinct().ToArray();
               if (b.Length == 0 || b[0] == SelectedCityFrom)
                    CityToErrorMessage = "Invalid City Name";
               else
               {
                    string result = db.BookingInfo.Where(x => x.City == City)
                                   .Select(x => x.Country)
                                   .Distinct()
                                   .ToArray()[0];

                    if (result != Country)
                         CityToErrorMessage = "City Doesn't Exists in This Country";
               }
          }
          public void Isvalid()
          {
               if (CountryFromErrorMessage == null &&
                    CityFromErrorMessage == null &&
                    CountryToErrorMessage == null &&
                    CityToErrorMessage == null)

                    IsValid = true;
               else
                    IsValid =  false;
          }
     }
}