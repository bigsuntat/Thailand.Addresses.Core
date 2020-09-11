using System;

namespace Thailand.Addresses.Core.Models
{
    public class DistrictModel
    {
        public int DistrictId { get; set; }
        public string DistrictCode { get; set; }
        public string DistrictNameTh { get; set; }
        public string DistrictNameEn { get; set; }
        public int RegionId { get; set; }
        public int ProvinceId { get; set; }
    }
}
