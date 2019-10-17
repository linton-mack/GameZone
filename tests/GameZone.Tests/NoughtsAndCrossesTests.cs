using GameZone;
using Xunit;

namespace GameZone.Tests
{
    public class NoughtsAndCrossesTests
    {
        [Fact]
        public void CreateInstanceOfNoughtsAndCrosses()
        {
            NoughtsAndCrosses noughtsAndCrosses = new NoughtsAndCrosses();
            Assert.IsType<NoughtsAndCrosses>(noughtsAndCrosses);
        }
    }
}