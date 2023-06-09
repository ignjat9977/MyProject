﻿using Application;
using Application.Commands;
using Application.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectNetworkMediaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {

        private readonly IApplicationActor _actor;
        private readonly UseCaseExecutor _executor;

        public CommentsController(IApplicationActor actor, UseCaseExecutor executor)
        {
            _actor = actor;
            _executor = executor;
        }

        // GET: api/<CommentsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CommentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CommentsController>
        [HttpPost]
        public IActionResult Post([FromBody] CommentInsertDto dto, 
            [FromServices] ICreateCommentCommand command)
        {
            _executor.ExecuteCommand(command, dto);
            return StatusCode(201);
        }

        // PUT api/<CommentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CommentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
