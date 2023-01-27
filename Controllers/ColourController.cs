using ColourAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ColourAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColourController : ControllerBase
    {
        private readonly ColourContext _context;

        public ColourController(ColourContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Colour>> Get()
        {
            return _context.ColoursItems;
        }


    }
}
