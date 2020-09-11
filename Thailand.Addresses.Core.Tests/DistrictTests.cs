using Thailand.Addresses.Core.Data;
using Xunit;

namespace Thailand.Addresses.Core.Tests
{
    public class DistrictTests
    {
        private readonly District _district;

        public DistrictTests()
        {
            _district = new District();
        }

        [Fact]
        public void DistrictDataIsNotNull()
        {
            Assert.NotNull(_district.DistrictData());
        }

        [Theory]
        [InlineData("เขตพระนคร")]
        [InlineData("เขตดุสิต")]
        public void FindDistrictByNameTh(string name)
        {
            Assert.NotNull(_district.DistrictData().Find(x => x.DistrictNameTh == name));
        }
    }
}
