using System;
using System.Web.Http;
using TelstraPurpleCodeChallenge_v1.Helper;

namespace TelstraPurpleCodeChallenge_v1.Controllers
{
    [AllowAnonymous]
    public class CodeChallengeController : ApiController
    {
        ApiHelpers helpers;
        public CodeChallengeController()
        {
            helpers = new ApiHelpers();
        }


        [HttpGet]
        [Route("api/Fibonacci")]
        public IHttpActionResult Fibonacci(string n)
        {
            try
            {
                if (!long.TryParse(n, out long param))
                {
                    return BadRequest("The request is invalid.");
                }
                else
                {
                    //Generate the Fibonacci sequence.
                    long value = checked(helpers.Fibonacci(param));
                    return Ok(value);
                }
            }
            catch (System.OverflowException ex)
            {
                return BadRequest("no content");
            }
            catch (Exception ex)
            {
                return BadRequest("Error");
            }
        }




        [HttpGet]
        [Route("api/ReverseWords")]
        public IHttpActionResult ReverseWords(string n)
        {
            try
            {
                if (string.IsNullOrEmpty(n))
                {
                    return Ok(string.Empty);
                }
                else
                {
                    return Ok(helpers.ReverseWords(n));
                }
            }
            catch (System.Exception)
            {

                return BadRequest("Error");
            }

        }

        [HttpGet]
        [Route("api/Token")]
        public IHttpActionResult Token()
        {
            return Ok("11942d58-67dc-4b9b-8373-676be8c6fe2a");
        }


        [HttpGet]
        [Route("api/TriangleType")]
        public IHttpActionResult TriangleType(string a, string b, string c)
        {
            try
            {
                if (int.TryParse(a, out int side1) && int.TryParse(b, out int side2) && int.TryParse(c, out int side3))
                {
                    return Ok(helpers.TriangleType(side1, side2, side3));
                }
                else
                {
                    return BadRequest("The request is invalid.");
                }
            }
            catch (System.Exception)
            {

                return BadRequest("The request is invalid.");
            }

        }


    }
}
