

namespace EnumTypeSafePattern.Tests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;


    [TestClass]
    public class StateTests
    {
        [TestMethod]
        public void FindById_return_validState()
        {

            var state = State.FindbyId(State.Open.Id);

            state.Should().Be(State.Open);
        }

        [TestMethod]
        public void GetAll()
        {

            var state = State.GetAll();

            state.Should().HaveCount(2);
        }

        [TestMethod]
        public void FindById_notFound_invalidParameter()
        {

            var state = State.FindbyId(3);
            state.Should().Be(null);
        }

    }
}
