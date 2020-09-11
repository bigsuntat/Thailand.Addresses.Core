using Thailand.Addresses.Core.Data;
using Thailand.Addresses.Core.Services;
using Xunit;

namespace Thailand.Addresses.Core.Tests
{
    public class ServicesTests
    {
        private readonly FindAddress _findAddress;

        public ServicesTests()
        {
            _findAddress = new FindAddress();
        }

        [Theory]
        [InlineData("พระนคร")]
        [InlineData("รัชดา")]
        public void FindAddressByText(string text)
        {
            Assert.NotNull(_findAddress.FindByTextToJson(text));
        }
    }
}
