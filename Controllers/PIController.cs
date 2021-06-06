using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OSIsoft.AF.PI;
using OSIsoft.AF.Time;
using System.Web.Http.Cors;

namespace Backend.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PIController : ApiController
    {
        private PIServer _piServer;
        private string _piserverIP = "202.44.12.146";
        private readonly NetworkCredential cred = new NetworkCredential("group4", "inc.382");
       
        // https://localhost:xxx/api/pi/value
        [HttpGet]
        [ActionName("value")]
        public IHttpActionResult GetValueFromPITag()
        {
            //connection PI server
            var cn = piConnect();
            if(cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "G004-4007-O1-ST002");
                var timeRange = new AFTimeRange("*-4y","*");
                var value = point.RecordedValues(timeRange,0,"",true,0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach(var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }

                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connnect to pi server" }); 
            }
        }

        [HttpGet]
        [ActionName("value")]
        public IHttpActionResult GetValueFromPITagByTagname(string id)
        {
            //connection PI server
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, id);
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }

                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connnect to pi server" });
            }
        }


        private PIServer piConnect()
        {
            //connect to PI server
            _piServer = new PIServers()[_piserverIP];
            _piServer.Connect(cred);

            return _piServer;
        }

    }
}
