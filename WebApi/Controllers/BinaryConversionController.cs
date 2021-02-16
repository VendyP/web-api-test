using System;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BinaryConversionController : ControllerBase
    {
        [HttpGet(template: "binary-to-decimal")]
        public int Get([FromQuery] string input)
        {
            return BinaryConversionHelper.BinaryToDecimal(input);
        }

        [HttpGet(template: "decimal-to-binary")]
        public string Get([FromQuery] int input)
        {
            return BinaryConversionHelper.DecimalToBinary(input);
        }

        /// <summary>
        /// to validate
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [NonAction]
        [HttpGet(template: "test-binary-to-decimal")]
        public int Test([FromQuery] string input)
        {
            return Convert.ToInt32(input, 2);
        }

        /// <summary>
        /// to validate
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [NonAction]
        [HttpGet(template: "test-decimal-to-binary")]
        public string Test2([FromQuery] int input)
        {
            return Convert.ToString(input, 2);
        }
    }
}