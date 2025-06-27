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
      List<Vinyl> vinyls = new List<Vinyl>();
      vinyls.Add(new Vinyl { ID = 1, Name = "Yellow Submarine" });
      vinyls.Add(new Vinyl { ID = 2, Name = "WITH_TEETH" });

      return vinyls;
    }
  }
}
