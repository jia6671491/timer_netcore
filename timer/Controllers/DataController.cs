using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using timer.Models;

namespace timer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        public DataController()
        {

        }

        [Route("data")]
        [HttpGet]
        public async Task<ActionResult> getData()
        {
            XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(Inventory));

            using StreamReader sr = new StreamReader("xmlData.xml");

            return Ok(new {
                errCode = 0,
                errMsg = "",
                data = (Inventory)ser.Deserialize(sr)
            });
        }

        [Route("notify")]
        [HttpGet]
        public async Task<ActionResult> notify()
        {
            return Ok(new
            {
                errCode = 0,
                errMsg = "Acknowledgement about End of Counting from server!",
                data = new {}
            });
        }
    }
}
