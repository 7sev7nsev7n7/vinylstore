using Microsoft.AspNetCore.Mvc;

namespace RecordStoreWebApi.Controllers
{
  [ApiController]
  [Route("")]
  public class Index : ControllerBase
  {
    [HttpGet]
    public string Get()
    {
      return "Hola, Mundo!";
    }
  }
}
