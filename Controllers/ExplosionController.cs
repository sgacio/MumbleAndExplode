using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace MumbleAndExplode.Controllers
{

  [Route("api/[controller]")]
  [ApiController]
  public class ExplosionController : ControllerBase
  {
    [HttpGet("{s}")]
    public ActionResult<string> QuickMaths(string s)
    {
      return String.Join("", s.Select((letter, index) => String.Join("", Enumerable.Repeat(letter, (int)Char.GetNumericValue(letter)))));
    }
  }
}