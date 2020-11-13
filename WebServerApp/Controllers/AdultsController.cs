using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebServerApp.Data.Model;
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

        /// <summary>
        /// Returns a list of all adults.
        /// </summary>
        /// <returns>An IList of Adults, embedded within a Task, with ActionResult subtype</returns>
        /// <response code="200">Returns the item with an OK HTTP response code.</response>
        /// <response code="500">Returns a status code 500, Internal Server Error.</response>
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
