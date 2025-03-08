using AutoMapper;
using LivrosAPP.Model;
using LivrosAPP.Service.Dto;
using LivrosAPP.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LivrosAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : Controller
    {
        private readonly IAutorRepository? _autorRepository;
        private readonly IMapper _mapper;

        public AutorController(IAutorRepository? autorRepository, IMapper mapper)
        {
            _autorRepository = autorRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// cadastrar autor
        /// </summary>
        /// <param name="autor"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(AutorGetDto),201)]
        public IActionResult Post([FromBody] AutorPostDto model)
        {
            try 
            { 
                var autor = _mapper?.Map<Autor>(model);
                _autorRepository?.Insert(autor);

                var response = _mapper?.Map<AutorGetDto>(autor);
                return StatusCode(201, response);

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
        /// atualizar autor
        /// </summary>
        /// <param name="autor"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(typeof(AutorGetDto), 201)]
        public IActionResult Put([FromBody] AutorPutDto model)
        {
            try
            {
                var autor = _autorRepository?.GetById(model.Id);

                if(autor == null)
                {
                    return NoContent();

                }
                
                autor = _mapper?.Map<Autor>(model);
                _autorRepository?.Update(autor);

                var response = _mapper?.Map<AutorGetDto>(autor);

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
        /// deletar autor
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpDelete]
        [ProducesResponseType(typeof(AutorGetDto),200)]
        public IActionResult Delete(int id)
        {
            try
            {
                var autor = _autorRepository?.GetById(id);

                if(autor == null)
                {
                    return NoContent();
                }

                _autorRepository?.Delete(autor);

                var response = _mapper?.Map<AutorGetDto>(autor);
                
                return StatusCode(200,response); 
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
        /// consultar todos os autores
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        [ProducesResponseType(typeof(List<AutorGetDto>),200)]
        public IActionResult GetAll()
        {
            try
            {
                var autores = _autorRepository?.GetAll();

                var response = _mapper?.Map<List<AutorGetDto>>(autores);

                return StatusCode(200,response);

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
        /// consultar um autor
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet("GetById/{id}")]
        [ProducesResponseType(typeof(AutorGetDto),200)]
        public IActionResult GetById(int id)
        {
            try
            {
                var autor = _autorRepository?.GetById(id);

                if(autor == null)
                {
                    return NoContent();
                }

                var response = _mapper?.Map<AutorGetDto>(autor);

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
