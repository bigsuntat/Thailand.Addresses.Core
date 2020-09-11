using System;

namespace Thailand.Addresses.Core.Models
{
    public class PostcodeModel
    {
        public int PostcodeId { get; set; }
        public string SubDistrictCode { get; set; }
        public int ProvinceId { get; set; }
        public int DistrictId { get; set; }
        public int SubDistrictId { get; set; }
        public string Postcode { get; set; }
    }
}
