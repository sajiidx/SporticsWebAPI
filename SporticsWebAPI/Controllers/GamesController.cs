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
    public class GamesController : ControllerBase
    {
        private readonly IGamesRepository _repository;
        public GamesController(IGamesRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IEnumerable<Games>> Get()
        {
            return await _repository.Get();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Games>> Get(int id)
        {
            return await _repository.Get(id);
        }
        [HttpPost]
        public async Task<ActionResult<Games>> Post([FromBody] Games obj)
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
        public async Task<ActionResult<Games>> Put(int id, [FromBody] Games obj)
        {
            try
            {
                if (id != obj.Id)
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
        public async Task<ActionResult> Delete(int id)
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
