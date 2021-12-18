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
    public class NewsController : ControllerBase
    {
        private readonly INewsRepository _repository;
        public NewsController(INewsRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IEnumerable<News>> Get()
        {
            return await _repository.Get();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<News>> Get(int id)
        {
            return await _repository.Get(id);
        }
        [HttpPost]
        public async Task<ActionResult<News>> Post([FromBody] News obj)
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
        public async Task<ActionResult<News>> Put(int id, [FromBody] News obj)
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
