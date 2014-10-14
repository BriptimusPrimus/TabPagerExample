using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TabPagerExample
{
    public class DataManager
    {
        public List<Country> AllItems()
        {
            return CreateData(); 
        }

        public int HowManyCountries()
        {
            return CreateData().Count;        
        }

        public List<Country> GetPage(int page = 1, int recordsNumber = 20)
        {
            page--;
            int first = page * recordsNumber;
            List<Country> All = CreateData();
            return GetRange(All, first, recordsNumber);            
        }

        private List<Country> GetRange(List<Country> All, int first, int recordsNumber)
        {
            if (first >= All.Count)
            {
                //return empty list
                return new List<Country>();
            }

            int last = first + recordsNumber;
            if (last > All.Count)
            {
                int dif = last - All.Count;
                //decrement the number of records in order to 
                //keep it in the range of the list
                recordsNumber -= dif;
            }

            return All.GetRange(first, recordsNumber);
        }

        private List<Country> CreateData()
        {
            List<Country> dataList = new List<Country>(); 

            Country country;

            country = new Country
            {
                Region = "Afghanistan",
                Symbol = "AF",
                Size = 645807,
                Population = 30419928,
                InternetUsers = 1520996,
                InternetPenetration = 0.05
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Albania",
                Symbol = "AL",
                Size = 28748,
                Population = 2986952,
                InternetUsers = 1441928,
                InternetPenetration = 0.48
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Algeria",
                Symbol = "DZ",
                Size = 2381741,
                Population = 34586184,
                InternetUsers = 4700000,
                InternetPenetration = 0.14
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "American Samoa",
                Symbol = "AS",
                Size = 197,
                Population = 67242,
                InternetUsers = 3040,
                InternetPenetration = 0.04
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Andorra",
                Symbol = "AD",
                Size = 464,
                Population = 84525,
                InternetUsers = 68740,
                InternetPenetration = 0.81
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Angola",
                Symbol = "AO",
                Size = 1246700,
                Population = 13068161,
                InternetUsers = 744195,
                InternetPenetration = 0.06
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Anguilla",
                Symbol = "AI",
                Size = 96,
                Population = 15094,
                InternetUsers = 6940,
                InternetPenetration = 0.46
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Antarctica",
                Symbol = "AQ",
                Size = 13209000,
                Population = 1169,
                InternetUsers = -1,
                InternetPenetration = 0.00
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Antigua & Barbuda",
                Symbol = "AG",
                Size = 442,
                Population = 87884,
                InternetUsers = 70968,
                InternetPenetration = 0.81
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Antilles, Netherlands",
                Symbol = "AN",
                Size = 800,
                Population = 199800,
                InternetUsers = 92500,
                InternetPenetration = 0.46
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Arabia, Saudi",
                Symbol = "SA",
                Size = 2149690,
                Population = 26161703,
                InternetUsers = 11400000,
                InternetPenetration = 0.44
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Argentina",
                Symbol = "AR",
                Size = 2777409,
                Population = 41769726,
                InternetUsers = 28000000,
                InternetPenetration = 0.67
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Armenia",
                Symbol = "AM",
                Size = 29743,
                Population = 2967975,
                InternetUsers = 1396550,
                InternetPenetration = 0.47
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Aruba",
                Symbol = "AW",
                Size = 193,
                Population = 106113,
                InternetUsers = 51280,
                InternetPenetration = 0.48
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Australia",
                Symbol = "AU",
                Size = 7682557,
                Population = 21766711,
                InternetUsers = 19554832,
                InternetPenetration = 0.90
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Austria",
                Symbol = "AT",
                Size = 83858,
                Population = 8217280,
                InternetUsers = 6143600,
                InternetPenetration = 0.75
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Azerbaijan",
                Symbol = "AZ",
                Size = 86530,
                Population = 8372373,
                InternetUsers = 3689000,
                InternetPenetration = 0.44
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Bahamas, The",
                Symbol = "BS",
                Size = 13962,
                Population = 313312,
                InternetUsers = 158700,
                InternetPenetration = 0.51
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Bahrain",
                Symbol = "BH",
                Size = 694,
                Population = 1214705,
                InternetUsers = 694009,
                InternetPenetration = 0.57
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Bangladesh",
                Symbol = "BD",
                Size = 142615,
                Population = 158570535,
                InternetUsers = 5501609,
                InternetPenetration = 0.04
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Barbados",
                Symbol = "BB",
                Size = 431,
                Population = 286705,
                InternetUsers = 191878,
                InternetPenetration = 0.67
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Belarus",
                Symbol = "BY",
                Size = 207600,
                Population = 9577552,
                InternetUsers = 4436800,
                InternetPenetration = 0.46
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Belgium",
                Symbol = "BE",
                Size = 30518,
                Population = 10431477,
                InternetUsers = 8489901,
                InternetPenetration = 0.81
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Belize",
                Symbol = "BZ",
                Size = 22966,
                Population = 321115,
                InternetUsers = 63580,
                InternetPenetration = 0.20
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Benin",
                Symbol = "BJ",
                Size = 112622,
                Population = 9325032,
                InternetUsers = 277002,
                InternetPenetration = 0.03
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Bermuda",
                Symbol = "BM",
                Size = 53,
                Population = 68679,
                InternetUsers = 54687,
                InternetPenetration = 0.80
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Bhutan",
                Symbol = "BT",
                Size = 46650,
                Population = 708427,
                InternetUsers = 98728,
                InternetPenetration = 0.14
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Bolivia",
                Symbol = "BO",
                Size = 1098581,
                Population = 10118683,
                InternetUsers = 1985970,
                InternetPenetration = 0.20
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Bosnia and Herzegovina",
                Symbol = "BA",
                Size = 51129,
                Population = 4622163,
                InternetUsers = 1955277,
                InternetPenetration = 0.42
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Botswana",
                Symbol = "BW",
                Size = 581730,
                Population = 2065398,
                InternetUsers = 167180,
                InternetPenetration = 0.08
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Bouvet Island",
                Symbol = "BV",
                Size = 49,
                Population = 0,
                InternetUsers = 0,
                InternetPenetration = -1
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Brazil",
                Symbol = "BR",
                Size = 8544418,
                Population = 194037075,
                InternetUsers = 81798000,
                InternetPenetration = 0.42
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "British Indian Ocean T.",
                Symbol = "IO",
                Size = -1,
                Population = -1,
                InternetUsers = -1,
                InternetPenetration = -1
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "British Virgin Islands",
                Symbol = "VG",
                Size = 151,
                Population = 25383,
                InternetUsers = 14620,
                InternetPenetration = 0.58
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Brunei Darussalam",
                Symbol = "BN",
                Size = 5765,
                Population = 401890,
                InternetUsers = 318900,
                InternetPenetration = 0.79
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Bulgaria",
                Symbol = "BG",
                Size = 110994,
                Population = 7093635,
                InternetUsers = 3646287,
                InternetPenetration = 0.49
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Burkina Faso",
                Symbol = "BF",
                Size = 267950,
                Population = 16751455,
                InternetUsers = 230562,
                InternetPenetration = 0.01
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Burundi",
                Symbol = "BI",
                Size = 27834,
                Population = 10216190,
                InternetUsers = 176040,
                InternetPenetration = 0.02
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Cambodia",
                Symbol = "KH",
                Size = 181035,
                Population = 14701717,
                InternetUsers = 449160,
                InternetPenetration = 0.03
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Cameroon",
                Symbol = "CM",
                Size = 475442,
                Population = 19711291,
                InternetUsers = 783956,
                InternetPenetration = 0.04
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Canada",
                Symbol = "CA",
                Size = 9976137,
                Population = 34030586,
                InternetUsers = 27757540,
                InternetPenetration = 0.82
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Cape Verde",
                Symbol = "CV",
                Size = 4033,
                Population = 516100,
                InternetUsers = 148800,
                InternetPenetration = 0.29
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Cayman Islands",
                Symbol = "KY",
                Size = 259,
                Population = 51384,
                InternetUsers = 37112,
                InternetPenetration = 0.72
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Central African Republic",
                Symbol = "CF",
                Size = 622436,
                Population = 4950027,
                InternetUsers = 123800,
                InternetPenetration = 0.03
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Chad",
                Symbol = "TD",
                Size = 1284000,
                Population = 10758945,
                InternetUsers = 190863,
                InternetPenetration = 0.02
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Chile",
                Symbol = "CL",
                Size = 755482,
                Population = 16888760,
                InternetUsers = 10000000,
                InternetPenetration = 0.59
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "China",
                Symbol = "CN",
                Size = 9806391,
                Population = 1336718015,
                InternetUsers = 564000000,
                InternetPenetration = 0.42
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Christmas Island",
                Symbol = "CX",
                Size = 135,
                Population = 1402,
                InternetUsers = 464,
                InternetPenetration = 0.33
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Cocos (Keeling) Islands",
                Symbol = "CC",
                Size = 14,
                Population = 596,
                InternetUsers = -1,
                InternetPenetration = -1
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Colombia",
                Symbol = "CO",
                Size = 1141748,
                Population = 44725543,
                InternetUsers = 25000000,
                InternetPenetration = 0.56
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Comoros",
                Symbol = "KM",
                Size = 1862,
                Population = 794683,
                InternetUsers = 37472,
                InternetPenetration = 0.05
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Congo",
                Symbol = "CG",
                Size = 342000,
                Population = 4243929,
                InternetUsers = 295132,
                InternetPenetration = 0.07
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Congo, Dem. Rep. of the",
                Symbol = "CD",
                Size = 2344798,
                Population = 71712867,
                InternetUsers = 915400,
                InternetPenetration = 0.01
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Cook Islands",
                Symbol = "CK",
                Size = 237,
                Population = 11124,
                InternetUsers = 6000,
                InternetPenetration = 0.54
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Costa Rica",
                Symbol = "CR",
                Size = 51090,
                Population = 4576562,
                InternetUsers = 2000000,
                InternetPenetration = 0.44
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Cote D'Ivoire",
                Symbol = "CI",
                Size = 322461,
                Population = 21504162,
                InternetUsers = 968000,
                InternetPenetration = 0.04
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Croatia",
                Symbol = "HR",
                Size = 56542,
                Population = 4483804,
                InternetUsers = 2656089,
                InternetPenetration = 0.59
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Cuba",
                Symbol = "CU",
                Size = 114525,
                Population = 11087330,
                InternetUsers = 1702206,
                InternetPenetration = 0.15
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Cyprus",
                Symbol = "CY",
                Size = 9251,
                Population = 1120489,
                InternetUsers = 584863,
                InternetPenetration = 0.52
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Czech Republic",
                Symbol = "CZ",
                Size = 78866,
                Population = 10190213,
                InternetUsers = 7220732,
                InternetPenetration = 0.71
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Denmark",
                Symbol = "DK",
                Size = 43093,
                Population = 5529888,
                InternetUsers = 4923824,
                InternetPenetration = 0.89
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Djibouti",
                Symbol = "DJ",
                Size = 23200,
                Population = 757074,
                InternetUsers = 61320,
                InternetPenetration = 0.08
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Dominica",
                Symbol = "DM",
                Size = 751,
                Population = 72969,
                InternetUsers = 32151,
                InternetPenetration = 0.44
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Dominican Republic",
                Symbol = "DO",
                Size = 48734,
                Population = 9956648,
                InternetUsers = 4643393,
                InternetPenetration = 0.47
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "East Timor (Timor-Leste)",
                Symbol = "TP",
                Size = 14604,
                Population = 1177834,
                InternetUsers = 2361,
                InternetPenetration = 0.00
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Ecuador",
                Symbol = "EC",
                Size = 272046,
                Population = 15007343,
                InternetUsers = 4075500,
                InternetPenetration = 0.27
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Egypt",
                Symbol = "EG",
                Size = 1001450,
                Population = 82079636,
                InternetUsers = 21691776,
                InternetPenetration = 0.26
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "El Salvador",
                Symbol = "SV",
                Size = 21041,
                Population = 6071774,
                InternetUsers = 1257380,
                InternetPenetration = 0.21
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Equatorial Guinea",
                Symbol = "GQ",
                Size = 28051,
                Population = 668225,
                InternetUsers = 42024,
                InternetPenetration = 0.06
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Eritrea",
                Symbol = "ER",
                Size = 121100,
                Population = 5939484,
                InternetUsers = 283699,
                InternetPenetration = 0.05
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Estonia",
                Symbol = "EE",
                Size = 45226,
                Population = 1282963,
                InternetUsers = 993785,
                InternetPenetration = 0.78
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Ethiopia",
                Symbol = "ET",
                Size = 1127127,
                Population = 90873739,
                InternetUsers = 622122,
                InternetPenetration = 0.01
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Falkland Islands (Malvinas)",
                Symbol = "FK",
                Size = 16076,
                Population = 3140,
                InternetUsers = 2900,
                InternetPenetration = 0.92
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Faroe Islands",
                Symbol = "FO",
                Size = 1414,
                Population = 49057,
                InternetUsers = 37500,
                InternetPenetration = 0.76
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Fiji",
                Symbol = "FJ",
                Size = 18274,
                Population = 883125,
                InternetUsers = 162880,
                InternetPenetration = 0.18
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Finland",
                Symbol = "FI",
                Size = 338145,
                Population = 5259250,
                InternetUsers = 4661265,
                InternetPenetration = 0.89
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "France",
                Symbol = "FR",
                Size = 547030,
                Population = 65102719,
                InternetUsers = 50290226,
                InternetPenetration = 0.77
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "French Guiana",
                Symbol = "GF",
                Size = 83534,
                Population = 235690,
                InternetUsers = 61480,
                InternetPenetration = 0.26
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "French Polynesia",
                Symbol = "PF",
                Size = 3894,
                Population = 294935,
                InternetUsers = 132674,
                InternetPenetration = 0.45
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "French Southern Terr.",
                Symbol = "TF",
                Size = 7781,
                Population = 120,
                InternetUsers = -1,
                InternetPenetration = 0.00
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Gabon",
                Symbol = "GA",
                Size = 267667,
                Population = 1576665,
                InternetUsers = 108845,
                InternetPenetration = 0.07
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Gambia, the",
                Symbol = "GM",
                Size = 10689,
                Population = 1797860,
                InternetUsers = 159012,
                InternetPenetration = 0.09
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Georgia",
                Symbol = "GE",
                Size = 69700,
                Population = 4585874,
                InternetUsers = 1300000,
                InternetPenetration = 0.28
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Germany",
                Symbol = "DE",
                Size = 357021,
                Population = 81471834,
                InternetUsers = 67364898,
                InternetPenetration = 0.83
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Ghana",
                Symbol = "GH",
                Size = 238538,
                Population = 24791073,
                InternetUsers = 2085501,
                InternetPenetration = 0.08
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Gibraltar",
                Symbol = "GI",
                Size = 7,
                Population = 28956,
                InternetUsers = 20200,
                InternetPenetration = 0.70
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Greece",
                Symbol = "GR",
                Size = 131957,
                Population = 10760136,
                InternetUsers = 5043550,
                InternetPenetration = 0.47
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Greenland",
                Symbol = "GL",
                Size = 2175600,
                Population = 57670,
                InternetUsers = 52000,
                InternetPenetration = 0.90
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Grenada",
                Symbol = "GD",
                Size = 345,
                Population = 108419,
                InternetUsers = 34961,
                InternetPenetration = 0.32
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Guadeloupe",
                Symbol = "GP",
                Size = 1780,
                Population = 405500,
                InternetUsers = 155740,
                InternetPenetration = 0.38
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Guam",
                Symbol = "GU",
                Size = 545,
                Population = 183286,
                InternetUsers = 90000,
                InternetPenetration = 0.49
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Guatemala",
                Symbol = "GT",
                Size = 108894,
                Population = 13824463,
                InternetUsers = 2280000,
                InternetPenetration = 0.17
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Guernsey and Alderney",
                Symbol = "GG",
                Size = 91,
                Population = 65068,
                InternetUsers = 48300,
                InternetPenetration = 0.74
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Guiana, French",
                Symbol = "GF",
                Size = 83534,
                Population = 235690,
                InternetUsers = 61480,
                InternetPenetration = 0.26
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Guinea",
                Symbol = "GN",
                Size = 245857,
                Population = 10601003,
                InternetUsers = 95823,
                InternetPenetration = 0.01
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Guinea-Bissau",
                Symbol = "GW",
                Size = 36123,
                Population = 1596677,
                InternetUsers = 37123,
                InternetPenetration = 0.02
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Guinea, Equatorial",
                Symbol = "GP",
                Size = 28051,
                Population = 668225,
                InternetUsers = 42024,
                InternetPenetration = 0.06
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Guyana",
                Symbol = "GY",
                Size = 215083,
                Population = 744768,
                InternetUsers = 225593,
                InternetPenetration = 0.30
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Haiti",
                Symbol = "HT",
                Size = 27748,
                Population = 9719932,
                InternetUsers = 836435,
                InternetPenetration = 0.09
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Heard & McDonald Is.(AU)",
                Symbol = "HM",
                Size = -1,
                Population = -1,
                InternetUsers = -1,
                InternetPenetration = -1
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Honduras",
                Symbol = "HN",
                Size = 112088,
                Population = 8143564,
                InternetUsers = 1067560,
                InternetPenetration = 0.13
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Hong Kong, (China)",
                Symbol = "HK",
                Size = 1085,
                Population = 7122508,
                InternetUsers = 4894913,
                InternetPenetration = 0.69
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Hungary",
                Symbol = "HU",
                Size = 92966,
                Population = 97976062,
                InternetUsers = 6516627,
                InternetPenetration = 0.65
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Iceland",
                Symbol = "IS",
                Size = 102928,
                Population = 311058,
                InternetUsers = 304129,
                InternetPenetration = 0.98
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "India",
                Symbol = "IN",
                Size = 3166944,
                Population = 1189172906,
                InternetUsers = 121000000,
                InternetPenetration = 0.10
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Indonesia",
                Symbol = "ID",
                Size = 1904443,
                Population = 245613043,
                InternetUsers = 55000000,
                InternetPenetration = 0.22
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Iran, Islamic Republic of",
                Symbol = "IR",
                Size = 1648195,
                Population = 77891220,
                InternetUsers = 36500000,
                InternetPenetration = 0.47
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Iraq",
                Symbol = "IQ",
                Size = 434128,
                Population = 30399572,
                InternetUsers = 1303760,
                InternetPenetration = 0.04
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Ireland",
                Symbol = "IE",
                Size = 70273,
                Population = 4670976,
                InternetUsers = 3122358,
                InternetPenetration = 0.67
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Israel",
                Symbol = "IL",
                Size = 20991,
                Population = 7473052,
                InternetUsers = 5263146,
                InternetPenetration = 0.70
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Italy",
                Symbol = "IT",
                Size = 301323,
                Population = 61016804,
                InternetUsers = 35800000,
                InternetPenetration = 0.59
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Ivory Coast (Cote d'Ivoire)",
                Symbol = "CI",
                Size = 322461,
                Population = 21504162,
                InternetUsers = 968000,
                InternetPenetration = 0.05
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Jamaica",
                Symbol = "JM",
                Size = 10991,
                Population = 2868380,
                InternetUsers = 1581100,
                InternetPenetration = 0.55
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Japan",
                Symbol = "JP",
                Size = 377812,
                Population = 126475664,
                InternetUsers = 101228736,
                InternetPenetration = 0.80
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Jersey",
                Symbol = "JE",
                Size = 116,
                Population = 94161,
                InternetUsers = 45800,
                InternetPenetration = 0.49
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Jordan",
                Symbol = "JO",
                Size = 89342,
                Population = 6508271,
                InternetUsers = 1987400,
                InternetPenetration = 0.30
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Kazakhstan",
                Symbol = "KZ",
                Size = 2715900,
                Population = 15522373,
                InternetUsers = 5448965,
                InternetPenetration = 0.35
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Kenya",
                Symbol = "KE",
                Size = 581787,
                Population = 40070934,
                InternetUsers = 10492785,
                InternetPenetration = 0.26
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Kiribati",
                Symbol = "KI",
                Size = 832,
                Population = 100743,
                InternetUsers = 8959,
                InternetPenetration = 0.09
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Korea Dem. People's Rep.",
                Symbol = "KP",
                Size = 122762,
                Population = 22757275,
                InternetUsers = -1,
                InternetPenetration = -1
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Korea, (South) Republic of",
                Symbol = "KR",
                Size = 99268,
                Population = 48754657,
                InternetUsers = 40329660,
                InternetPenetration = 0.83
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Kosovo",
                Symbol = "KV",
                Size = 10908,
                Population = 1825632,
                InternetUsers = 377000,
                InternetPenetration = 0.21
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Kuwait",
                Symbol = "KW",
                Size = 17818,
                Population = 2595628,
                InternetUsers = 1100000,
                InternetPenetration = 0.42
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Kyrgyzstan",
                Symbol = "KG",
                Size = 199900,
                Population = 5587443,
                InternetUsers = 2194400,
                InternetPenetration = 0.39
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Lao People's Democ. Rep.",
                Symbol = "LA",
                Size = 236800,
                Population = 6477211,
                InternetUsers = 527400,
                InternetPenetration = 0.08
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Latvia",
                Symbol = "LV",
                Size = 64598,
                Population = 2204708,
                InternetUsers = 1540859,
                InternetPenetration = 0.70
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Lebanon",
                Symbol = "LB",
                Size = 10452,
                Population = 4143101,
                InternetUsers = 1367220,
                InternetPenetration = 0.33
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Lesotho",
                Symbol = "LS",
                Size = 30355,
                Population = 1924886,
                InternetUsers = 83813,
                InternetPenetration = 0.04
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Liberia",
                Symbol = "LR",
                Size = 99065,
                Population = 3786764,
                InternetUsers = 20000,
                InternetPenetration = 0.01
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Libyan Arab Jamahiriya",
                Symbol = "LY",
                Size = 1777060,
                Population = 6597960,
                InternetUsers = 391880,
                InternetPenetration = 0.06
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Liechtenstein",
                Symbol = "LI",
                Size = 160,
                Population = 35236,
                InternetUsers = 28826,
                InternetPenetration = 0.82
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Lithuania",
                Symbol = "LT",
                Size = 65300,
                Population = 3535547,
                InternetUsers = 2103471,
                InternetPenetration = 0.59
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Luxembourg",
                Symbol = "LU",
                Size = 2586,
                Population = 503302,
                InternetUsers = 459833,
                InternetPenetration = 0.91
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Macao, (China)",
                Symbol = "MO",
                Size = 25,
                Population = 573003,
                InternetUsers = 308797,
                InternetPenetration = 0.54
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Macedonia, TFYR",
                Symbol = "MK",
                Size = 25433,
                Population = 2077328,
                InternetUsers = 1069432,
                InternetPenetration = 0.52
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Madagascar",
                Symbol = "MG",
                Size = 587041,
                Population = 21926221,
                InternetUsers = 352135,
                InternetPenetration = 0.02
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Malawi",
                Symbol = "MW",
                Size = 118480,
                Population = 15879252,
                InternetUsers = 716400,
                InternetPenetration = 0.04
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Malaysia",
                Symbol = "MY",
                Size = 329758,
                Population = 28728607,
                InternetUsers = 17723000,
                InternetPenetration = 0.62
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Maldives",
                Symbol = "MV",
                Size = 298,
                Population = 394999,
                InternetUsers = 114100,
                InternetPenetration = 0.29
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Mali",
                Symbol = "ML",
                Size = 1240198,
                Population = 14159904,
                InternetUsers = 414985,
                InternetPenetration = 0.03
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Malta",
                Symbol = "MT",
                Size = 315,
                Population = 408333,
                InternetUsers = 262404,
                InternetPenetration = 0.64
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Man, Isle of",
                Symbol = "IM",
                Size = 572,
                Population = 84655,
                InternetUsers = 35600,
                InternetPenetration = 0.42
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Marshall Islands",
                Symbol = "MH",
                Size = 181,
                Population = 67182,
                InternetUsers = 6540,
                InternetPenetration = 0.10
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Martinique (FR)",
                Symbol = "MQ",
                Size = 1128,
                Population = 397166,
                InternetUsers = 170000,
                InternetPenetration = 0.43
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Mauritania",
                Symbol = "MR",
                Size = 1035000,
                Population = 3281634,
                InternetUsers = 100333,
                InternetPenetration = 0.03
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Mauritius",
                Symbol = "MU",
                Size = 2040,
                Population = 1303717,
                InternetUsers = 323494,
                InternetPenetration = 0.25
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Mayotte (FR)",
                Symbol = "YT",
                Size = 373,
                Population = 209530,
                InternetUsers = 10620,
                InternetPenetration = 0.05
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Mexico",
                Symbol = "MX",
                Size = 1967138,
                Population = 115017631,
                InternetUsers = 42000000,
                InternetPenetration = 0.36
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Micronesia, Fed. States of",
                Symbol = "FM",
                Size = 721,
                Population = 106836,
                InternetUsers = 22213,
                InternetPenetration = 0.21
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Moldova, Republic of",
                Symbol = "MD",
                Size = 33843,
                Population = 4314377,
                InternetUsers = 1429154,
                InternetPenetration = 0.33
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Monaco",
                Symbol = "MC",
                Size = 2,
                Population = 30539,
                InternetUsers = 23000,
                InternetPenetration = 0.75
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Mongolia",
                Symbol = "MN",
                Size = 1564160,
                Population = 3133318,
                InternetUsers = 355524,
                InternetPenetration = 0.11
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Montenegro",
                Symbol = "CS",
                Size = 14026,
                Population = 661807,
                InternetUsers = 328375,
                InternetPenetration = 0.50
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Montserrat",
                Symbol = "MS",
                Size = 102,
                Population = 5140,
                InternetUsers = 1200,
                InternetPenetration = 0.23
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Morocco",
                Symbol = "MA",
                Size = 6600000,
                Population = 31968361,
                InternetUsers = 15656192,
                InternetPenetration = 0.49
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Mozambique",
                Symbol = "MZ",
                Size = 799380,
                Population = 22948858,
                InternetUsers = 975395,
                InternetPenetration = 0.04
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Myanmar (ex-Burma)",
                Symbol = "MM",
                Size = 676577,
                Population = 53999804,
                InternetUsers = 110000,
                InternetPenetration = 0.00
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Namibia",
                Symbol = "NA",
                Size = 825112,
                Population = 2147585,
                InternetUsers = 148414,
                InternetPenetration = 0.07
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Nauru",
                Symbol = "NR",
                Size = 21,
                Population = 9322,
                InternetUsers = 340,
                InternetPenetration = 0.04
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Nepal",
                Symbol = "NP",
                Size = 147181,
                Population = 29391883,
                InternetUsers = 2031245,
                InternetPenetration = 0.07
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Netherlands",
                Symbol = "NL",
                Size = 41526,
                Population = 16847007,
                InternetUsers = 15071191,
                InternetPenetration = 0.90
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Netherlands Antilles",
                Symbol = "AN",
                Size = 800,
                Population = -1,
                InternetUsers = -1,
                InternetPenetration = -1
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "New Caledonia",
                Symbol = "NC",
                Size = 18736,
                Population = 256275,
                InternetUsers = 87420,
                InternetPenetration = 0.34
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "New Zealand",
                Symbol = "NZ",
                Size = 270534,
                Population = 4290347,
                InternetUsers = 3325553,
                InternetPenetration = 0.84
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Nicaragua",
                Symbol = "NI",
                Size = 129454,
                Population = 5666301,
                InternetUsers = 663500,
                InternetPenetration = 0.12
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Niger",
                Symbol = "NE",
                Size = 1186408,
                Population = 16468886,
                InternetUsers = 128749,
                InternetPenetration = 0.01
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Nigeria",
                Symbol = "NG",
                Size = 923768,
                Population = 170123740,
                InternetUsers = 45039711,
                InternetPenetration = 0.27
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Niue",
                Symbol = "NU",
                Size = 259,
                Population = 1311,
                InternetUsers = 1100,
                InternetPenetration = 0.84
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Norfolk Island",
                Symbol = "NF",
                Size = 35,
                Population = 2169,
                InternetUsers = 700,
                InternetPenetration = 0.32
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Northern Mariana Islands",
                Symbol = "MP",
                Size = 477,
                Population = 46050,
                InternetUsers = 15980,
                InternetPenetration = 0.35
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Norway",
                Symbol = "NO",
                Size = 323759,
                Population = 4691849,
                InternetUsers = 4560572,
                InternetPenetration = 0.97
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Oman",
                Symbol = "OM",
                Size = 309500,
                Population = 3027959,
                InternetUsers = 1741804,
                InternetPenetration = 0.57
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Pakistan",
                Symbol = "PK",
                Size = 880254,
                Population = 187342721,
                InternetUsers = 29128970,
                InternetPenetration = 0.15
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Palau",
                Symbol = "PW",
                Size = 491,
                Population = 20956,
                InternetUsers = 5980,
                InternetPenetration = 0.28
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Palestinian Territory",
                Symbol = "PS",
                Size = 6242,
                Population = 2568555,
                InternetUsers = 1512273,
                InternetPenetration = 0.59
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Panama",
                Symbol = "PA",
                Size = 77082,
                Population = 3460462,
                InternetUsers = 1503441,
                InternetPenetration = 0.43
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Papua New Guinea",
                Symbol = "PG",
                Size = 462840,
                Population = 6187591,
                InternetUsers = 125000,
                InternetPenetration = 0.02
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Paraguay",
                Symbol = "PY",
                Size = 406752,
                Population = 6459058,
                InternetUsers = 1523273,
                InternetPenetration = 0.26
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Peru",
                Symbol = "PE",
                Size = 1285216,
                Population = 29248943,
                InternetUsers = 9973244,
                InternetPenetration = 0.34
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Philippines",
                Symbol = "PH",
                Size = 300000,
                Population = 101833938,
                InternetUsers = 33600000,
                InternetPenetration = 0.33
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Pitcairn Island",
                Symbol = "PN",
                Size = -1,
                Population = 48,
                InternetUsers = -1,
                InternetPenetration = -1
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Poland",
                Symbol = "PL",
                Size = 312685,
                Population = 38441588,
                InternetUsers = 23852486,
                InternetPenetration = 0.62
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Portugal",
                Symbol = "PT",
                Size = 92391,
                Population = 10760305,
                InternetUsers = 5455217,
                InternetPenetration = 0.51
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Puerto Rico",
                Symbol = "PR",
                Size = 9104,
                Population = 3989133,
                InternetUsers = 1698301,
                InternetPenetration = 0.43
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Qatar",
                Symbol = "QA",
                Size = 11521,
                Population = 848016,
                InternetUsers = 563800,
                InternetPenetration = 0.67
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Reunion (FR)",
                Symbol = "RE",
                Size = 2547,
                Population = 834261,
                InternetUsers = 300000,
                InternetPenetration = 0.36
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Romania",
                Symbol = "RO",
                Size = 238391,
                Population = 21904551,
                InternetUsers = 8578484,
                InternetPenetration = 0.39
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Russia (Russian Fed.)",
                Symbol = "RU",
                Size = 16894741,
                Population = 138739892,
                InternetUsers = 61472011,
                InternetPenetration = 0.44
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Rwanda",
                Symbol = "RW",
                Size = 26338,
                Population = 11370425,
                InternetUsers = 818048,
                InternetPenetration = 0.07
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Sahara, Western",
                Symbol = "EH",
                Size = 266000,
                Population = 491519,
                InternetUsers = -1,
                InternetPenetration = -1
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Saint Barthelemy (FR)",
                Symbol = "BL",
                Size = 21,
                Population = 7367,
                InternetUsers = -1,
                InternetPenetration = -1
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Saint Helena (UK)",
                Symbol = "SH",
                Size = 410,
                Population = 7700,
                InternetUsers = 900,
                InternetPenetration = 0.12
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Saint Kitts and Nevis",
                Symbol = "KN",
                Size = 267,
                Population = 50314,
                InternetUsers = 22340,
                InternetPenetration = 0.44
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Saint Lucia",
                Symbol = "LC",
                Size = 616,
                Population = 161557,
                InternetUsers = 142900,
                InternetPenetration = 0.89
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Saint Martin (FR)",
                Symbol = "MF",
                Size = 37,
                Population = 30615,
                InternetUsers = -1,
                InternetPenetration = -1
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "S Pierre & Miquelon(FR)",
                Symbol = "PM",
                Size = 242,
                Population = 5943,
                InternetUsers = -1,
                InternetPenetration = -1
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "S Vincent & Grenadines",
                Symbol = "VC",
                Size = 392,
                Population = 103869,
                InternetUsers = 76000,
                InternetPenetration = 0.73
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Samoa",
                Symbol = "WS",
                Size = 2785,
                Population = 193161,
                InternetUsers = 12816,
                InternetPenetration = 0.07
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "San Marino",
                Symbol = "SM",
                Size = 61,
                Population = 31817,
                InternetUsers = 17000,
                InternetPenetration = 0.53
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Sao Tome and Principe",
                Symbol = "ST",
                Size = 1001,
                Population = 179506,
                InternetUsers = 31012,
                InternetPenetration = 0.17
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Saudi Arabia",
                Symbol = "SA",
                Size = 2149690,
                Population = 26131703,
                InternetUsers = 13000000,
                InternetPenetration = 0.50
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Senegal",
                Symbol = "SN",
                Size = 196722,
                Population = 12643799,
                InternetUsers = 1989396,
                InternetPenetration = 0.16
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Serbia",
                Symbol = "RS",
                Size = 77474,
                Population = 7310555,
                InternetUsers = 4107000,
                InternetPenetration = 0.56
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Seychelles",
                Symbol = "SC",
                Size = 455,
                Population = 89188,
                InternetUsers = 33900,
                InternetPenetration = 0.38
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Sierra Leone",
                Symbol = "SL",
                Size = 71740,
                Population = 5363669,
                InternetUsers = 48520,
                InternetPenetration = 0.01
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Singapore",
                Symbol = "SG",
                Size = 683,
                Population = 4740737,
                InternetUsers = 3658400,
                InternetPenetration = 0.77
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Slovakia",
                Symbol = "SK",
                Size = 49034,
                Population = 5477038,
                InternetUsers = 4337868,
                InternetPenetration = 0.79
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Slovenia",
                Symbol = "SI",
                Size = 20273,
                Population = 2000092,
                InternetUsers = 1420776,
                InternetPenetration = 0.71
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Solomon Islands",
                Symbol = "SB",
                Size = 28400,
                Population = 571890,
                InternetUsers = 26907,
                InternetPenetration = 0.05
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Somalia",
                Symbol = "SO",
                Size = 637657,
                Population = 9925640,
                InternetUsers = 106000,
                InternetPenetration = 0.01
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "South Africa",
                Symbol = "ZA",
                Size = 1219090,
                Population = 49004031,
                InternetUsers = 6800000,
                InternetPenetration = 0.14
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "S.George & S.Sandwich",
                Symbol = "GS",
                Size = 3903,
                Population = -1,
                InternetUsers = -1,
                InternetPenetration = -1
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "South Sudan",
                Symbol = "SS",
                Size = 619745,
                Population = 8260490,
                InternetUsers = -1,
                InternetPenetration = -1
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Spain",
                Symbol = "ES",
                Size = 504842,
                Population = 46754784,
                InternetUsers = 30654678,
                InternetPenetration = 0.66
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Sri Lanka (ex-Ceilan)",
                Symbol = "LK",
                Size = 65610,
                Population = 21283913,
                InternetUsers = 2503194,
                InternetPenetration = 0.12
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Sudan",
                Symbol = "SD",
                Size = 2505810,
                Population = 45047502,
                InternetUsers = 4200000,
                InternetPenetration = 0.09
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Suriname",
                Symbol = "SR",
                Size = 163820,
                Population = 491989,
                InternetUsers = 165733,
                InternetPenetration = 0.34
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Svalbard & Jan Mayen Is.",
                Symbol = "SJ",
                Size = 61606,
                Population = 2481,
                InternetUsers = -1,
                InternetPenetration = -1
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Swaziland",
                Symbol = "SZ",
                Size = 17363,
                Population = 1370424,
                InternetUsers = 95122,
                InternetPenetration = 0.07
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Sweden",
                Symbol = "SE",
                Size = 449965,
                Population = 9088728,
                InternetUsers = 8441718,
                InternetPenetration = 0.93
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Switzerland",
                Symbol = "CH",
                Size = 41285,
                Population = 7639961,
                InternetUsers = 6430363,
                InternetPenetration = 0.84
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Syrian Arab Republic",
                Symbol = "SY",
                Size = 185180,
                Population = 22530746,
                InternetUsers = 5069418,
                InternetPenetration = 0.23
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Taiwan",
                Symbol = "TW",
                Size = 36175,
                Population = 23071779,
                InternetUsers = 16147000,
                InternetPenetration = 0.70
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Tajikistan",
                Symbol = "TJ",
                Size = 143100,
                Population = 7627200,
                InternetUsers = 794483,
                InternetPenetration = 0.10
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Tanzania, United Rep. of",
                Symbol = "TZ",
                Size = 945088,
                Population = 42746620,
                InternetUsers = 4932535,
                InternetPenetration = 0.12
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Thailand",
                Symbol = "TH",
                Size = 513115,
                Population = 66720153,
                InternetUsers = 18310000,
                InternetPenetration = 0.27
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Timor-Leste (East Timor)",
                Symbol = "TL",
                Size = 14604,
                Population = 1177834,
                InternetUsers = 2361,
                InternetPenetration = 0.00
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Togo",
                Symbol = "TG",
                Size = 56785,
                Population = 6771993,
                InternetUsers = 356300,
                InternetPenetration = 0.05
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Tokelau",
                Symbol = "TK",
                Size = 10,
                Population = 1384,
                InternetUsers = 800,
                InternetPenetration = 0.58
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Tonga",
                Symbol = "TO",
                Size = 651,
                Population = 105916,
                InternetUsers = 12487,
                InternetPenetration = 0.12
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Trinidad & Tobago",
                Symbol = "TT",
                Size = 5128,
                Population = 1222505,
                InternetUsers = 650611,
                InternetPenetration = 0.53
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Tunisia",
                Symbol = "TN",
                Size = 163610,
                Population = 10629186,
                InternetUsers = 3856984,
                InternetPenetration = 0.36
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Turkey",
                Symbol = "TR",
                Size = 773473,
                Population = 78785548,
                InternetUsers = 36455000,
                InternetPenetration = 0.46
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Turkmenistan",
                Symbol = "TM",
                Size = 488100,
                Population = 4997503,
                InternetUsers = 110924,
                InternetPenetration = 0.02
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Turks and Caicos Is.",
                Symbol = "TC",
                Size = 497,
                Population = 44819,
                InternetUsers = 14760,
                InternetPenetration = 0.33
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Tuvalu",
                Symbol = "TV",
                Size = 26,
                Population = 10544,
                InternetUsers = 4300,
                InternetPenetration = 0.41
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Uganda",
                Symbol = "UG",
                Size = 242554,
                Population = 34612250,
                InternetUsers = 4178085,
                InternetPenetration = 0.12
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Ukraine",
                Symbol = "UA",
                Size = 603628,
                Population = 45134707,
                InternetUsers = 15300000,
                InternetPenetration = 0.34
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "United Arab Emirates",
                Symbol = "AE",
                Size = 77700,
                Population = 8264070,
                InternetUsers = 5859118,
                InternetPenetration = 0.71
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "United Kingdom",
                Symbol = "UK",
                Size = 244140,
                Population = 62698362,
                InternetUsers = 52731209,
                InternetPenetration = 0.84
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "United States",
                Symbol = "US",
                Size = 9629047,
                Population = 313232044,
                InternetUsers = 245203319,
                InternetPenetration = 0.78
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "US Minor Outlying Isl.",
                Symbol = "UM",
                Size = -1,
                Population = -1,
                InternetUsers = -1,
                InternetPenetration = -1
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Uruguay",
                Symbol = "UY",
                Size = 175016,
                Population = 3308535,
                InternetUsers = 1855000,
                InternetPenetration = 0.56
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Uzbekistan",
                Symbol = "UZ",
                Size = 447400,
                Population = 28128600,
                InternetUsers = 7550000,
                InternetPenetration = 0.27
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Vanuatu",
                Symbol = "VU",
                Size = 12190,
                Population = 224564,
                InternetUsers = 19172,
                InternetPenetration = 0.09
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Vatican (Holy See)",
                Symbol = "VA",
                Size = 1,
                Population = 832,
                InternetUsers = 480,
                InternetPenetration = 0.58
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Venezuela",
                Symbol = "VE",
                Size = 916445,
                Population = 27635743,
                InternetUsers = 10976342,
                InternetPenetration = 0.40
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Viet Nam",
                Symbol = "VN",
                Size = 332378,
                Population = 90549390,
                InternetUsers = 30858742,
                InternetPenetration = 0.34
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Virgin Islands, British",
                Symbol = "VG",
                Size = 151,
                Population = 25383,
                InternetUsers = 14620,
                InternetPenetration = 0.58
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Virgin Islands, U.S.",
                Symbol = "VI",
                Size = 352,
                Population = 109666,
                InternetUsers = 30000,
                InternetPenetration = 0.27
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Wallis and Futuna",
                Symbol = "WF",
                Size = 274,
                Population = 15398,
                InternetUsers = 1300,
                InternetPenetration = 0.08
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Western Sahara",
                Symbol = "EH",
                Size = 266000,
                Population = 491519,
                InternetUsers = -1,
                InternetPenetration = -1
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Yemen",
                Symbol = "YE",
                Size = 528076,
                Population = 24771809,
                InternetUsers = 3691000,
                InternetPenetration = 0.15
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Zambia",
                Symbol = "ZM",
                Size = 752614,
                Population = 13881336,
                InternetUsers = 882170,
                InternetPenetration = 0.06
            };
            dataList.Add(country); 

            country = new Country
            {
                Region = "Zimbabwe",
                Symbol = "ZW",
                Size = 390784,
                Population = 12084304,
                InternetUsers = 1445717,
                InternetPenetration = 0.12
            };
            dataList.Add(country); 

            return dataList;
        }
    }
}
