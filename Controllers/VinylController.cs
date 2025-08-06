using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
      this.Context = context;
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

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, Vinyl vinyl)
    {
      if (id != vinyl.ID)
      {
        return BadRequest("Identifier does not exist");
      }
      Context.Update(vinyl);
      await Context.SaveChangesAsync();
      return Ok("Updated registry");
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
      var deletedEntry = await Context.vinyls.Where(r=>r.ID==id).ExecuteDeleteAsync();
      if (deletedEntry==0) {
        return NotFound();
      }
      return Ok("Deleted entry");
    }
  }
}
