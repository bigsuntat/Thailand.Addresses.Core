using Newtonsoft.Json;
using System.Collections.Generic;
using Thailand.Addresses.Core.Data;
using Thailand.Addresses.Core.Models;
using Thailand.Addresses.Core.Services;

namespace Thailand.Addresses.Core
{
    public class ThailandAddresses
    {
        private readonly Region _region = new Region();
        private readonly Province _province = new Province();
        private readonly Postcode _postcode = new Postcode();
        private readonly District _district = new District();
        private readonly SubDistrict _subdistrict = new SubDistrict();
        private readonly FindAddress _findAddress = new FindAddress();

        /// <summary>
        /// Get all region
        /// </summary>
        /// <returns>Json format</returns>
        public string GetRegionToJson()
        {    
            return JsonConvert.SerializeObject(_region.RegionData());
        }

        /// <summary>
        /// Get all province
        /// </summary>
        /// <returns>Json format</returns>
        public string GetProvinceToJson()
        {
            return JsonConvert.SerializeObject(_province.ProvinceData());
        }

        /// <summary>
        /// Get all postcode
        /// </summary>
        /// <returns>Json format</returns>
        public string GetPostcodeToJson()
        {
            return JsonConvert.SerializeObject(_postcode.PostcodeData());
        }

        /// <summary>
        /// Get all district
        /// </summary>
        /// <returns>Json format</returns>
        public string GetDistrictToJson()
        {
            return JsonConvert.SerializeObject(_district.DistrictData());
        }

        /// <summary>
        /// Get all subdistrict
        /// </summary>
        /// <returns>Json format</returns>
        public string GetSubDistrictToJson()
        {
            return JsonConvert.SerializeObject(_subdistrict.SubDistrictData());
        }

        /// <summary>
        /// Find address by text
        /// </summary>
        /// <param name="text">finding word</param>
        /// <returns>Json format</returns>
        public string FindAddressByTextToJson(string text)
        {
            return _findAddress.FindByTextToJson(text);
        }

        public List<AddressViewModel> FindAddressByTextToList(string text)
        {
            return _findAddress.FindByTextToList(text);
        }
    }
}
