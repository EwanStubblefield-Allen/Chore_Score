using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Chore_Score.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ChoresController : ControllerBase
  {
    private readonly ChoresService _choresService;
    public ChoresController(ChoresService choresService)
    {
      _choresService = choresService;
    }

    [HttpGet]
    public ActionResult<List<Chore>> GetChores()
    {
      try
      {
        List<Chore> chores = _choresService.GetChores();
        return Ok(chores);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{choreId}")]
    public ActionResult<Chore> GetChoreById(Guid choreId)
    {
      try
      {
        Chore chore = _choresService.GetChoreById(choreId);
        return Ok(chore);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
    {
      try
      {
        Chore chore = _choresService.CreateChore(choreData);
        return Ok(chore);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{choreId}")]
    public ActionResult<Chore> UpdateChore([FromBody] Chore choreData, Guid choreId)
    {
      try
      {
        choreData.Id = choreId;
        Chore chore = _choresService.UpdateChore(choreData);
        return chore;
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{choreId}")]
    public ActionResult<Chore> RemoveChore(Guid choreId)
    {
      try
      {
        Chore chore = _choresService.RemoveChore(choreId);
        return Ok(chore);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}