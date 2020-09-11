using Thailand.Addresses.Core.Data;
using Xunit;

namespace Thailand.Addresses.Core.Tests
{
    public class RegionTests
    {
        private readonly Region _region;

        public RegionTests()
        {
            _region = new Region();
        }

        [Fact]
        public void RegionDataIsNotNull()
        {
            Assert.NotNull(_region.RegionData());
        }

        [Theory]
        [InlineData("ภาคเหนือ")]
        [InlineData("ภาคกลาง")]
        [InlineData("ภาคตะวันออกเฉียงเหนือ")]
        [InlineData("ภาคตะวันตก")]
        [InlineData("ภาคตะวันออก")]
        [InlineData("ภาคใต้")]
        public void FindRegionByNameTh(string name)
        {
            Assert.NotNull(_region.RegionData().Find(x => x.RegionNameTh == name));
        }
    }
}
