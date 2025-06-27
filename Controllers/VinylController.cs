using Microsoft.AspNetCore.Mvc;
using RecordStoreWebApi.Entities;
using RecordStoreWebApi.Data;

namespace RecordStoreWebApi.Controllers
{
  [ApiController]
  [Route("/vinyls")]
  public class VinylControllers : ControllerBase
  {
    public ApplicationDbContext Context;
    public VinylControllers(ApplicationDbContext context)
    {
      Context = context;
    }
    [HttpPost]
    public async Task<ActionResult> Post(Vinyl vinyl)
    {
      Context.Add(vinyl);
      await Context.SaveChangesAsync();
      return Ok("Saved");
    }

    [HttpGet]
    public IEnumerable<Vinyl> Get()
    {
      return Context.vinyls;
    }
  }
}
