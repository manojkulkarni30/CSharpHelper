using CSharpHelpers.StringHelpers;
using NUnit.Framework;

namespace DotNetContext.Helpers.Tests.StringHelperTests
{
    [TestFixture]
    public class CustomStringHelpersTests
    {
        [TestCase]
        public void RemoveSpaceWhenStringWithSpaceIsPass()
        {
            var testValue = "Web Development";

            var result = testValue.RemoveSpace();

            Assert.AreEqual("WebDevelopment", result);
        }

        [TestCase]
        public void ResultShouldBeSameWithStringWithOutSpaceIsPass()
        {
            var testValue = "WebDevelopment";

            var result = testValue.RemoveSpace();

            Assert.AreEqual("WebDevelopment", result);
        }
    }
}
