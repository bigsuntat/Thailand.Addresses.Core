using System.Collections.Generic;

using Thailand.Addresses.Core.Models;

namespace Thailand.Addresses.Core.Data {
    public class Region {
        public List<RegionModel> RegionData() {
            return new List<RegionModel> {
                new RegionModel { RegionId = 1, RegionNameTh = "ภาคเหนือ", RegionNameEn = "North" },
                new RegionModel { RegionId = 2, RegionNameTh = "ภาคกลาง", RegionNameEn = "Central" },
                new RegionModel { RegionId = 3, RegionNameTh = "ภาคตะวันออกเฉียงเหนือ", RegionNameEn = "North East" },
                new RegionModel { RegionId = 4, RegionNameTh = "ภาคตะวันตก", RegionNameEn = "West" },
                new RegionModel { RegionId = 5, RegionNameTh = "ภาคตะวันออก", RegionNameEn = "East" },
                new RegionModel { RegionId = 6, RegionNameTh = "ภาคใต้", RegionNameEn = "South" }
            };
        }
    }
}
