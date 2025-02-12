using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using AnyReservationTemp.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnyReservationTemp.Controllers
{

    public class RestaurantController : ControllerBase
    {
        public class RestaurantsController : ControllerBase
        {
            private readonly AnyReservationTempContext _context;
            public RestaurantsController(AnyReservationTempContext context)
            {
                _context = context;
            }
            // GET: api/<RestaurantController>
            [HttpGet]
            public IEnumerable<string> Get()
            {
                return new string[] { "value1", "value2" };
            }



            // POST api/<RestaurantController>
            [HttpPost("upload-image")]
            public async Task<IActionResult> UploadImage(IFormFile file)
            {
                var filePath = Path.Combine("wwwroot/UI photos", file.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                var restaurantId = 1; // Change this to the correct restaurant ID
                var restaurant = await _context.Restaurant.FindAsync(restaurantId);
                if (restaurant == null)
                {
                    return NotFound("Restaurant not found.");
                }

                restaurant.ImagePath = filePath;
                await _context.SaveChangesAsync();

                return Ok(new { imagePath = filePath }); // Or return the image path or other data
            }
        

        // PUT api/<RestaurantController>/5
        [HttpPut("{id}")]
            public void Put(int id, [FromBody] string value)
            {
            }

            // DELETE api/<RestaurantController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            }
        }
    }
}
