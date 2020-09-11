using System;

namespace Thailand.Addresses.Core.Models
{
    public class SubDistrictModel
    {
        public int SubDistrictId { get; set; }
        public string SubDistrictCode { get; set; }
        public string SubDistrictNameTh { get; set; }
        public string SubDistrictNameEn { get; set; }
        public int RegionId { get; set; }
        public int ProvinceId { get; set; }
        public int DistrictId { get; set; }
    }
}
