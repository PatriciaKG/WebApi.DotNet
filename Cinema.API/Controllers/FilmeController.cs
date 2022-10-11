using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cinema.Data.Repository;
using Cinema.Data.Interface;
using Cinema.Model;

namespace Cinema.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private readonly IFilme _filmeRepository;

        public FilmeController(IFilme filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var filme = _filmeRepository.Get();
            return Ok(fime);
        }
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var filme = _filmeRepository.Get(id);
            if (filme == null)
                return NotFound();
            return Ok(filme);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Model.Filme NovoFilme)
        {
            var addFilme = new Cinema.Model.Filme(
                NovoFilme.Nome, 
                NovoFilme.Sinopse, 
                NovoFilme.AnoEstreia,
                NovoFilme.IdDiretor,
                NovoFilme.IdAtor,
                NovoFilme.PretoBranco,
                NovoFilme.Categoria
            );
            if(_filmeRepository.Add(addFilme))
            {
                return Created("", addFilme);
            }
            else
            {
                return NotFound();
            }
            
        }
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] Model.Filme AlteracaoFilme)
        {
            var putFilme = _filmeRepository.Get(id);

            if (putFilme == null)
                return NotFound();

            putFilme.AlteraFilme(
                AlteracaoFilme.Nome, 
                AlteracaoFilme.Sinopse, 
                AlteracaoFilme.AnoEstreia,
                AlteracaoFilme.IdDiretor,
                AlteracaoFilme.IdAtor,
                AlteracaoFilme.PretoBranco,
                AlteracaoFilme.Categoria);

            _filmeRepository.Update(id, putFilme);

            return Ok(putFilme);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var filme = _filmeRepository.Get(id);

            if (filme == null)
                return NotFound();

            _filmeRepository.Delete(id);
            
            return NoContent();
        }



        
    }

}
