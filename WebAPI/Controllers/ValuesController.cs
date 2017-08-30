using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        //IConfiguration _iConfiguration;
        //public ValuesController(IConfiguration iConfiguration) {
        //    _iConfiguration = iConfiguration;
        //}

        private readonly CustomAppSetting config;

        public ValuesController(IOptions<CustomAppSetting> iConfiguration)
        {
            config = iConfiguration.Value;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string value1 = config.TokenEndPoint;   
            return new string[] { value1, "value2 updated with status check" };                      
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
