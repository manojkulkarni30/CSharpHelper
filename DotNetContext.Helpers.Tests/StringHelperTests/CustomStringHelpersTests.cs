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

        [TestCase]
        public void LastCharacterShouldBeRemovedWhenStringIsPass()
        {
            var testValue = "Web Development";

            var result = testValue.RemoveLastCharacter();

            Assert.AreEqual("Web Developmen", result);
        }

        [TestCase]
        public void FirstCharacterShouldBeRemovedWhenStringIsPass()
        {
            var testValue = "Web Development";

            var result = testValue.RemoveFirstCharacter();

            Assert.AreEqual("eb Development", result);
        }


        [TestCase]
        public void ResultShouldBeStringWhenStringArrayIsPassedWithSeperator()
        {
            var testValue = new string[] { "Web Development      ", "Azure Functions", "App Service" };

            var result = testValue.ToString(",", trim: true);

            var expectedResult = "Web Development,Azure Functions,App Service";
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase]
        public void IsMD5HashOfStringIsCorrect()
        {
            var testValue = "Web Development";

            var result = testValue.CreateMd5Hash();

            var expectedResult = "e9f65fa4000d038efa0cdff8bb824632";
            Assert.AreEqual(expectedResult, result);
        }
    }
}
