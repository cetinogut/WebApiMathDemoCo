using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiMathDemoCo.Controllers
{
    public class MathController : ApiController
    {

        // Since we have multiple GET methods, we need to add the necessary routing instructions under the App_Start/WebApiConfig.cs file. Add the below code in WebApiConfig.cs->Register() routine for multiple GET method support.

        [HttpGet]
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        [HttpGet]
        public int Substract(int value1, int value2)
        {
            return value1 - value2;
        }

        [HttpGet]
        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        [HttpGet]
        public int Divide(int value1, int value2)
        {
            return value1 / value2;
        }

        [HttpGet]
        public string Get()
        {
            return "default";
        }
    }
}
