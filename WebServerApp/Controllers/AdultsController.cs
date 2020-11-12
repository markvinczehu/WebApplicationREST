using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Data.Model;
using WebServerApp.Services;

namespace WebServerApp
{
    [ApiController]
    [Route("[controller]")]
    
    public class AdultsController : ControllerBase
    {
        IAdultService adultService;

        public AdultsController()
        {
            adultService = new AdultService();
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdultsAsync()
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("Controller");
                IList<Adult> list = new List<Adult>();
                list = adultService.GetAllAdults();
                return Ok(list);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.StackTrace);
                return StatusCode(500, e.StackTrace);
            }
        }
    }
}
