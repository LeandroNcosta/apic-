using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using viageMais.Data;
using viageMais.Models;

namespace viageMais.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class HotelController : ControllerBase
  {

    private readonly DataContext _dataContext;

    public HotelController(DataContext _dataContext)
    {
      this._dataContext = _dataContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Hotel>>> getHotels()
    {
      var hotels = await this._dataContext.Hotel.ToArrayAsync();

      return hotels;
    }
    [HttpGet("{id:int}", Name = "getHotelById")]
    public async Task<ActionResult<Hotel>> getHotelById(int id)
    {
      var hotel = await this._dataContext.Hotel.FindAsync(id);

      if (hotel is null)
      {
        return NotFound("not found item with id: " + id);
      }

      return Ok(hotel);
    }

    [HttpGet("{name}", Name = "getHotelByName")]
    public async Task<ActionResult<Hotel>> getHotelByName(string name)
    {
      var hotel = await this._dataContext.Hotel.FirstOrDefaultAsync(h => h.Name == name);

      if (hotel is null)
      {
        return NotFound($"hotel in {name} not found");
      }

      return Ok(hotel);
    }
  }
}