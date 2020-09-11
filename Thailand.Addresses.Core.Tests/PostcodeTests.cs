using Thailand.Addresses.Core.Data;
using Xunit;

namespace Thailand.Addresses.Core.Tests
{
    public class PostcodeTests
    {
        private readonly Postcode _postcode;

        public PostcodeTests()
        {
            _postcode = new Postcode();
        }

        [Fact]
        public void PostcodeDataIsNotNull()
        {
            Assert.NotNull(_postcode.PostcodeData());
        }

        [Theory]
        [InlineData("10200")]
        [InlineData("10300")]
        public void FindPostcodeByCode(string code)
        {
            Assert.NotNull(_postcode.PostcodeData().Find(x => x.Postcode == code));
        }
    }
}
