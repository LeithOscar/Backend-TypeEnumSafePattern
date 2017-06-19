
namespace EnumTypeSafePattern.Tests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TypeEnumSavePattern;

    [TestClass]
    public class ForoTests
    {
        [TestMethod]
        public void Be_Open_whenCreate()
        {
            var foro = new Foro(".Pattern Enum example");
            foro.StateEnum.Should().Be(ForoState.Open);
        }


        [TestMethod]
        public void Alllow_ChangeState_usingEnum()
        {
            var foro = new Foro(".Pattern Enum example");
            //Compiling does not give error and allows us to introduce invalid characters
            foro.ChangeState((ForoState)3);
            foro.StateEnum.Should().Be(3);
        }

        [TestMethod]
        public void Alllow_ChangeState_usingSealed()
        {
            var foro = new Foro(".Pattern Enum example");
            // The Compiling does a give error and  not allows us to introduce invalid characters
            //foro.ChangeState((State)3);
            foro.ChangeState(State.Closed);

            foro.StateSealead.Should().Be(State.Closed);
        }
    }
}

