using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class AlunoController : ControllerBase
    {

        public AlunoController(SmartContext context)
        {
            _context = context;
        }
        
        private readonly SmartContext _context;

        // GET: api/<AlunoController>

           
        // api/aluno/1
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var aluno = _context.Alunos.FirstOrDefault(aluno => aluno.Id == id);
            if (aluno == null) return BadRequest("O Aluno não foi encontrado");
            return Ok(aluno);
        }
        
        //api/aluno/nome
        [HttpGet("{nome}")]
        public IActionResult GetByName(string nome)
        {
            var aluno = _context.Alunos.FirstOrDefault(aluno => aluno.Nome.Contains(nome));
            if (aluno == null) return BadRequest("O Aluno não foi encontrado");
            return Ok(aluno);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Alunos);
        }

        //api/aluno
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        // api/aluno
        [HttpPatch("{id}")]
        public IActionResult Patch(int Id, Aluno aluno)
        {
            return Ok(aluno);
        }

        // api/aluno
        [HttpPut("{id}")]
        public IActionResult Put(int Id, Aluno aluno)
        {
            return Ok(aluno);
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
