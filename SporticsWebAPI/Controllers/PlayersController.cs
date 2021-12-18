using Microsoft.AspNetCore.Mvc;
using SporticsWebAPI.Models;
using SporticsWebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayersRepository _repository;
        public PlayersController(IPlayersRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IEnumerable<Players>> Get()
        {
            return await _repository.Get();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Players>> Get(string id)
        {
            return await _repository.Get(id);
        }
        [HttpPost]
        public async Task<ActionResult<Players>> Post([FromBody] Players obj)
        {
            try
            {
                var newEntity = await _repository.Create(obj);
                return CreatedAtAction(nameof(Get), new { id = newEntity.Id }, newEntity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<ActionResult<Players>> Put(string id, [FromBody] Players obj)
        {
            try
            {
                if (!id.Equals(obj.Id))
                {
                    return BadRequest();
                }
                await _repository.Update(obj);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            try
            {
                var toBeDeleted = await _repository.Get(id);
                if (toBeDeleted == null)
                {
                    return NotFound();
                }
                await _repository.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
