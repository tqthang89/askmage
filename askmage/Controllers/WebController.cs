using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace askmage.Controllers
{
    //[ApiController]
    [Route("api/[controller]")]
    public class WebController : ControllerBase
    {
        private IUMTProvider _webHomeProvider;
        public WebController(IUMTProvider webHomeProvider)
        {
            this._webHomeProvider = webHomeProvider;
        }
        [HttpPost("[action]")]
        public IActionResult EmployeeDevices_Create([FromBody] DataTable data)
        {
            try
            {
                string IP = "", Province = "", Country = "", UserAgent = "";
                if (data != null && data.Rows.Count > 0)
                {
                    IP = data.Rows[0]["IP"].ToString();
                    Province = data.Rows[0]["Province"].ToString();
                    Country = data.Rows[0]["Country"].ToString();
                    UserAgent = data.Rows[0]["ISP"].ToString();
                }

                DataSet ds =  this._webHomeProvider.EmployeeDevices_Create(IP, Province, Country, UserAgent);
                return Ok(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("[action]")]
        public IActionResult EmmployeeAccess_UpdateTime([FromBody] DataTable data)
        {
            try
            {
                int EmployeeId = 0, EAId = 0;
                if (data != null && data.Rows.Count > 0)
                {
                    EmployeeId = Convert.ToInt32(data.Rows[0]["EmployeeId"].ToString());
                    EAId = Convert.ToInt32(data.Rows[0]["EAId"].ToString());
                }

                DataSet ds = this._webHomeProvider.EmmployeeAccess_UpdateTime(EmployeeId, EAId);
                return Ok(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}