using System;

namespace Thailand.Addresses.Core.Models
{
    public class AddressViewModel
    {
        public int RegionId { get; set; }
        public string RegionNameTh { get; set; }
        public string RegionNameEn { get; set; }
        public int ProvinceId { get; set; }
        public string ProvinceCode { get; set; }
        public string ProvinceNameTh { get; set; }
        public string ProvinceNameEn { get; set; }
        public int PostcodeId { get; set; }
        public string SubDistrictCode { get; set; }
        public int DistrictId { get; set; }
        public int SubDistrictId { get; set; }
        public string Postcode { get; set; }
        public string DistrictCode { get; set; }
        public string DistrictNameTh { get; set; }
        public string DistrictNameEn { get; set; }
        public string SubDistrictNameTh { get; set; }
        public string SubDistrictNameEn { get; set; }
        public string FullText { get; set; }
    }
}
