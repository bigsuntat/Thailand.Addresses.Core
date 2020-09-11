using Thailand.Addresses.Core.Data;
using Xunit;

namespace Thailand.Addresses.Core.Tests
{
    public class ProvinceTests
    {
        private readonly Province _province;

        public ProvinceTests()
        {
            _province = new Province();
        }

        [Fact]
        public void ProvinceDataIsNotNull()
        {
            Assert.NotNull(_province.ProvinceData());
        }

        [Theory]
        [InlineData("กรุงเทพมหานคร")]
        public void FindProvinceByNameTh(string name)
        {
            Assert.NotNull(_province.ProvinceData().Find(x => x.ProvinceNameTh == name));
        }
    }
}
