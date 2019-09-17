using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace MumbleAndExplode.Controllers
{

  [Route("api/[controller]")]
  [ApiController]

  public class MumbleController : ControllerBase
  {
    [HttpGet("{s}")]
    public ActionResult<string> GetMyMath(string s)
    {
      return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
    }
  }
}