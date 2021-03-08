using Microsoft.AspNetCore.Mvc;
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
        public List<Aluno> Alunos = new List<Aluno>() {
         new Aluno() {
             Id = 1,
             Nome = "Marcos Almeida",
             Sobrenome = "Silva",
             Telefone = "123"
         },
         new Aluno() {
             Id = 2,
             Nome = "Carlos",
             Sobrenome = "Emanoel",
             Telefone = "1234"
         },
         new Aluno() {
             Id = 3,
             Nome = "Julia",
             Sobrenome = "Maria",
             Telefone = "12345"
         },
         new Aluno() {
             Id = 4,
             Nome = "Roberto",
             Sobrenome = "God",
             Telefone = "123456"
         }
        }; 
        // GET: api/<AlunoController>

        public AlunoController() { }
           
        // api/aluno/1
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(aluno => aluno.Id == id);
            if (aluno == null) return BadRequest("O Aluno não foi encontrado");
            return Ok(aluno);
        }
        
        //api/aluno/nome
        [HttpGet("{nome}")]
        public IActionResult GetByName(string nome)
        {
            var aluno = Alunos.FirstOrDefault(aluno => aluno.Nome.Contains(nome));
            if (aluno == null) return BadRequest("O Aluno não foi encontrado");
            return Ok(aluno);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
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
