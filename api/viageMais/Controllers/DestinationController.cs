using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using viageMais.Data;
using viageMais.Models;

namespace viageMais.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class DestinationController : ControllerBase
  {

    private readonly DataContext _dataContext;

    public DestinationController(DataContext _dataContext)
    {
      this._dataContext = _dataContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Destination>>> GetDestinations()
    {

      //   List<Destination> destinations = new List<Destination>
      // {
      //   new Destination()
      // };


      return await _dataContext.Destination.ToListAsync();
    }


    [HttpGet("{id:int}", Name = "getDestinationById")]
    public async Task<ActionResult<Destination>> getDestinationById(int id)
    {
      var destination = await _dataContext.Destination.FindAsync(id);

      if (destination is null)
      {
        return NotFound("not found item with id: " + id);
      }

      return Ok(destination);
    }


    [HttpGet("{city}", Name = "getDestinationByCity")]
    public async Task<ActionResult<Destination>> getDestinationByCity(string city)
    {
      var destination = await _dataContext.Destination.FirstOrDefaultAsync(d => d.City == city);

      if (destination is null)
      {
        return NotFound($"Destination in {city} not found");
      }

      return Ok(destination);
    }


  }
}