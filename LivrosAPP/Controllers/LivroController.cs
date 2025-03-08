using AutoMapper;
using LivrosAPP.Model;
using LivrosAPP.Service.Dtos;
using LivrosAPP.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LivrosAPP.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : Controller
    {
        private readonly ILivroRepository _livroRepository;
        private readonly IMapper _mapper;

        public LivroController(ILivroRepository livroRepository, IMapper mapper)
        {
            _livroRepository = livroRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// cadastrar livro
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(LivroGetDto),201)]
        public IActionResult Post([FromBody] LivroPostDto model)
        {
            try
            {
                var livro = _mapper?.Map<Livro>(model);
                _livroRepository?.Insert(livro);

                var response = _mapper?.Map<LivroGetDto>(livro);
                return StatusCode(201, model);
            }
            catch (ApplicationException e)
            {
                return StatusCode(400, new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
            
        }

        [HttpPut]
        [ProducesResponseType(typeof(LivroGetDto),200)]
        public IActionResult Put([FromBody] LivroPutDto model)
        {
            try
            {
                var livro = _livroRepository?.GetById(model.Id);

                if(livro == null)
                {
                    return NoContent();
                }

                livro = _mapper?.Map<Livro>(model);
                _livroRepository?.Update(livro);

                var response = _mapper?.Map<LivroGetDto>(livro);

                return StatusCode(200, response);

            }
            catch (ApplicationException e)
            {

                return StatusCode(400, new { e.Message });
            }
            catch (Exception e)
            {

                return StatusCode(500, new { e.Message });
            }
        }

        /// <summary>
        /// deletar livro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [ProducesResponseType(typeof(LivroGetDto),200)]
        public IActionResult Delete(int id)
        {
            try
            {
                var livro = _livroRepository?.GetById(id);

                if(livro == null)
                {
                    return NoContent();
                }

                _livroRepository?.Delete(livro);

                var response = _mapper?.Map<LivroGetDto>(livro);

                return StatusCode(200, response);
            }
            catch (ApplicationException e)
            {

                return StatusCode(400, new {e.Message});
            }
            catch (Exception e)
            {

                return StatusCode(500, new { e.Message });
            }
        }


        /// <summary>
        /// consultar todos os livros
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(LivroGetDto),200)]
        public IActionResult GetAll()
        {
            try
            {
                var livros = _livroRepository.GetAll();

                if(livros == null)
                {
                    return NoContent();
                }

                var response = _mapper?.Map<List<LivroGetDto>>(livros);

                return StatusCode(200, response);

            }
            catch (ApplicationException e)
            {

                return StatusCode(400, new { e.Message });
            }
            catch (Exception e)
            {

                return StatusCode(500, new { e.Message });
            }
        }

        /// <summary>
        /// consultar um livro
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        [ProducesResponseType(typeof(LivroGetDto), 200)]
        public IActionResult GetById(int id)
        {
            try
            {
                var livro = _livroRepository.GetById(id);

                if (livro == null)
                {
                    return NoContent();
                }

                var response = _mapper?.Map<LivroGetDto>(livro);

                return StatusCode(200, response);

            }
            catch (ApplicationException e)
            {

                return StatusCode(400, new { e.Message });
            }
            catch (Exception e)
            {

                return StatusCode(500, new { e.Message });
            }
        }

    }
}
