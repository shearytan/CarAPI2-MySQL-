using Microsoft.AspNetCore.Mvc;
using CarAPI.Services;
using CarAPI.Entities;

namespace CarAPI.Controllers
{
    [Route("/api/v1/911_R8/waitlist")]
    [ApiController]
    public class CarsController : Controller
    {
        private CarsDBContext _context;
        public CarsController(CarsDBContext context)
        {
            _context = context;
        }
        
        // GET REQUEST
        public IActionResult GetCars()
        {
            return Ok(_context.Cars);
        }
    }
}