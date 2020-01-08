using System;
using System.Linq;
using System.Text;
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
                checked
                {
                    if (!long.TryParse(n, out long param))
                    {
                        return BadRequest("The request is invalid.");
                    }
                    else
                    {
                        //Generate the Fibonacci sequence.
                        var value = helpers.Fibonacci(param);
                        return Ok(value);
                    }
                }
            }
            catch (OverflowException ex)
            {
                return BadRequest("The request is invalid.");
            }
            catch (Exception ex)
            {
                return BadRequest("Error");
            }
        }




        [HttpGet]
        [Route("api/ReverseWords")]
        public IHttpActionResult ReverseWords(string sentence)
        {
            try
            {
                if (string.IsNullOrEmpty(sentence))
                {
                    return Ok(string.Empty);
                }
                else
                {
                    return Ok(helpers.ReverseWords(sentence));
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
            return Ok(new Guid("11942d58-67dc-4b9b-8373-676be8c6fe2a"));
        }


        [HttpGet]
        [Route("api/TriangleType")]
        public IHttpActionResult TriangleType(string a, string b, string c)
        {
            try
            {
                checked
                {
                    a = a.TrimEnd('\r', '\n');
                    char[] chArrSideA = a.ToArray();
                    StringBuilder builderA = new StringBuilder();


                    foreach (var ch in chArrSideA)
                    {
                        builderA.Append(ch);
                    }


                    b = b.TrimEnd('\r', '\n');
                    char[] chArrSideB = b.ToArray();

                    StringBuilder builderB = new StringBuilder();


                    foreach (var ch in chArrSideB)
                    {
                        builderB.Append(ch);
                    }


                    c = c.TrimEnd('\r', '\n');
                    char[] chArrSideC = c.ToArray();
                    StringBuilder builderC = new StringBuilder();


                    foreach (var ch in chArrSideC)
                    {
                        builderC.Append(ch);
                    }


                    if (int.TryParse(builderA.ToString(), out int side1) && int.TryParse(builderB.ToString(), out int side2) && int.TryParse(builderC.ToString(), out int side3))
                    {
                        return Ok(helpers.TriangleType(side1, side2, side3));
                    }
                    else
                    {
                        return BadRequest("The request is invalid.");
                    }
                }
            }
            catch (System.Exception)
            {

                return BadRequest("The request is invalid.");
            }

        }


    }
}
