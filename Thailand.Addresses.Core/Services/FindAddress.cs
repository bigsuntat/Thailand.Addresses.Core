using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Thailand.Addresses.Core.Data;
using Thailand.Addresses.Core.Models;

namespace Thailand.Addresses.Core.Services
{
    public class FindAddress
    {
        private readonly Region _region = new Region();
        private readonly Province _province = new Province();
        private readonly Postcode _postcode = new Postcode();
        private readonly District _district = new District();
        private readonly SubDistrict _subdistrict = new SubDistrict();

        public string FindByTextToJson(string text)
        {
            var merge = (from subdist in _subdistrict.SubDistrictData()
                         join dist in _district.DistrictData() on subdist.DistrictId equals dist.DistrictId
                         join pro in _province.ProvinceData() on dist.ProvinceId equals pro.ProvinceId
                         join pos in _postcode.PostcodeData() on dist.DistrictId equals pos.DistrictId
                         join reg in _region.RegionData() on pro.RegionId equals reg.RegionId
                         where subdist.SubDistrictNameTh.Contains(text) || subdist.SubDistrictNameEn.Contains(text) ||
                         dist.DistrictNameTh.Contains(text) || dist.DistrictNameEn.Contains(text) ||
                         pro.ProvinceNameTh.Contains(text) || pro.ProvinceNameEn.Contains(text) ||
                         pos.Postcode.Contains(text)
                         select new { subdist, dist, pro, pos, reg });
            var result = merge.GroupBy(x => x.dist.DistrictId).Select(g => g.First());

            return JsonConvert.SerializeObject(result);
        }

        public List<AddressViewModel> FindByTextToList(string text)
        {
            List<AddressViewModel> result = new List<AddressViewModel>();
            var merge = (from subdist in _subdistrict.SubDistrictData()
                         join dist in _district.DistrictData() on subdist.DistrictId equals dist.DistrictId
                         join pro in _province.ProvinceData() on dist.ProvinceId equals pro.ProvinceId
                         join pos in _postcode.PostcodeData() on dist.DistrictId equals pos.DistrictId
                         join reg in _region.RegionData() on pro.RegionId equals reg.RegionId
                         where subdist.SubDistrictNameTh.Contains(text) || subdist.SubDistrictNameEn.Contains(text) ||
                         dist.DistrictNameTh.Contains(text) || dist.DistrictNameEn.Contains(text) ||
                         pro.ProvinceNameTh.Contains(text) || pro.ProvinceNameEn.Contains(text) ||
                         pos.Postcode.Contains(text)
                         select new { subdist, dist, pro, pos, reg });
            foreach (var item in merge)
            {
                result.Add(new AddressViewModel
                {
                    SubDistrictNameTh = item.subdist.SubDistrictNameTh,
                    DistrictNameTh = item.dist.DistrictNameTh,
                    ProvinceNameTh = item.pro.ProvinceNameTh,
                    Postcode = item.pos.Postcode,
                    FullText = item.subdist.SubDistrictNameTh + " > " + item.dist.DistrictNameTh + " > " + item.pro.ProvinceNameTh + " > " + item.pos.Postcode
                });
            }
            return result;
        }
    }
}
