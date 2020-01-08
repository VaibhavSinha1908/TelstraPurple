using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;
using TelstraPurpleCodeChallenge_v1.Controllers;

namespace TelstraPurpleCodeChallenge_v1.Tests.Controllers
{
    [TestClass]
    public class CodeChallengeTest
    {
        CodeChallengeController controller;
        public CodeChallengeTest()
        {
            // Arrange
            controller = new CodeChallengeController();
        }

        [TestCategory("Fibonacci")]
        [TestMethod]
        public void Fibonacci_ExpectedResult_Success()
        {

            // Act
            IHttpActionResult result = controller.Fibonacci("20") as IHttpActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(((System.Web.Http.Results.OkNegotiatedContentResult<long>)result).Content, 6765);

        }

        [TestCategory("Fibonacci")]
        [TestMethod]
        public void Fibonacci_BadParameter()
        {

            // Act
            IHttpActionResult result = controller.Fibonacci("10abc") as IHttpActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(((System.Web.Http.Results.BadRequestErrorMessageResult)result).Message, "The request is invalid.");

        }

        [TestCategory("Fibonacci")]
        [TestMethod]
        public void Fibonacci_ResultOverFlow()
        {

            // Act
            IHttpActionResult result = controller.Fibonacci("100") as IHttpActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(((System.Web.Http.Results.BadRequestErrorMessageResult)result).Message, "no content");

        }



        [TestCategory("ReverseWords")]
        [TestMethod]
        public void ReverseWords_ExpectedResult()
        {
            // Act
            IHttpActionResult result = controller.ReverseWords("This is a test") as IHttpActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(((System.Web.Http.Results.OkNegotiatedContentResult<string>)result).Content, "sihT si a tset");
        }


        [TestCategory("ReverseWords")]
        [TestMethod]
        public void ReverseWords_BadParam_EmptyString()
        {
            // Act
            IHttpActionResult result = controller.ReverseWords("") as IHttpActionResult;

            // Assert
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(((System.Web.Http.Results.OkNegotiatedContentResult<string>)result).Content, string.Empty);

        }


        [TestCategory("TriangleType")]
        [TestMethod]
        public void TriangleType_ExpectedResult_Scalene()
        {
            // Act
            IHttpActionResult result = controller.TriangleType("3", "4", "5") as IHttpActionResult;

            // Assert
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(((System.Web.Http.Results.OkNegotiatedContentResult<string>)result).Content, "Scalene");

        }

        [TestMethod]
        public void TriangleType_ExpectedResult_Isosceles()
        {
            // Act
            IHttpActionResult result = controller.TriangleType("3", "3", "5") as IHttpActionResult;

            // Assert
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(((System.Web.Http.Results.OkNegotiatedContentResult<string>)result).Content, "Isosceles");

        }

        [TestMethod]
        public void TriangleType_ExpectedResult_Equilateral()
        {
            // Act
            IHttpActionResult result = controller.TriangleType("3", "3", "3") as IHttpActionResult;

            // Assert
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(((System.Web.Http.Results.OkNegotiatedContentResult<string>)result).Content, "Equilateral");

        }

        [TestMethod]
        public void TriangleType_BadTriangle()
        {
            // Act
            IHttpActionResult result = controller.TriangleType("3", "1", "1") as IHttpActionResult;

            // Assert
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(((System.Web.Http.Results.OkNegotiatedContentResult<string>)result).Content, "Error");

        }



        [TestMethod]
        public void TriangleType_BadParams()
        {
            // Act
            IHttpActionResult result = controller.TriangleType("3", "1a", "1b") as IHttpActionResult;


            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(((System.Web.Http.Results.BadRequestErrorMessageResult)result).Message, "The request is invalid.");
        }







    }
}
