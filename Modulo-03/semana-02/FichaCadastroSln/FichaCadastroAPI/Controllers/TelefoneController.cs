using System.Net;
using AutoMapper;
using FichaCadastroAPI.Context;
using FichaCadastroAPI.DTOs;
using FichaCadastroAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace FichaCadastroAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TelefoneController : ControllerBase
    {   
        private readonly ILogger _logger;
        private readonly FichaCadastroDbContext _fichaCadastroDbContext;
        private readonly IMapper _mapper;
        public TelefoneController(ILogger logger, FichaCadastroDbContext fichaCadastroDbContext, IMapper mapper)
        {
            _logger = logger;
            _fichaCadastroDbContext = fichaCadastroDbContext;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GetTelefoneDTO> Post([FromBody] PostTelefoneDTO postTelefoneDTO)
        {
            try
            {
                
                if(_fichaCadastroDbContext.Telefones.ToList().Exists(e => e.DDD == postTelefoneDTO.DDD && e.Numero == postTelefoneDTO.Numero))
                {
                    return Conflict("Número já cadastrado."); 
                }

                var novoTelefone = _mapper.Map<TelefoneModel>(postTelefoneDTO);

                _fichaCadastroDbContext.Telefones.Add(novoTelefone);
                _fichaCadastroDbContext.SaveChanges();

                var getTelefone = _mapper.Map<GetTelefoneDTO>(novoTelefone);

                return StatusCode(HttpStatusCode.Created.GetHashCode(), getTelefone);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);       
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GetTelefoneDTO> Put(int id, [FromBody] PutTelefoneDTO putTelefoneDTO)
        {
            try
            {
                var telefoneModel = _fichaCadastroDbContext.Telefones.Where(w => w.Id == id).FirstOrDefault();

                if(telefoneModel == null)
                {
                    return NotFound(new {erro = "Id não encontrado."});
                }

                telefoneModel = _mapper.Map(putTelefoneDTO, telefoneModel);

                _fichaCadastroDbContext.Telefones.Update(telefoneModel);
                _fichaCadastroDbContext.SaveChanges();

                var getTelefone = _mapper.Map<GetTelefoneDTO>(telefoneModel);

                return Ok(getTelefone);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Delete(int id)
        {
            try
            {
                var telefoneModel = _fichaCadastroDbContext.Telefones.Where(w => w.Id == id).FirstOrDefault();

                if(telefoneModel == null)
                {
                    return NotFound(new {erro = "Id não encontrado."});
                }

                _fichaCadastroDbContext.Telefones.Remove(telefoneModel);
                _fichaCadastroDbContext.SaveChanges();

                return Ok(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }           
        }

         // Read com filtro (query string) e sem filtro
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult <GetFichaDTO> GetAllOrByDDD([FromQuery] string? DDD)
        {
            try
            {
                List<TelefoneModel> listaTelefones;

                if(DDD.IsNullOrEmpty())
                {
                    listaTelefones = _fichaCadastroDbContext.Telefones.Include(item => item.Ficha).ToList();
                }
                else
                {
                    listaTelefones = _fichaCadastroDbContext.Telefones.Where(items => items.DDD.Equals(DDD)).Include(item => item.Ficha).ToList();
                }

                if(listaTelefones.Count() == 0)
                {
                    return NotFound("Nenhum registro encontrado.");
                }

                var getListaTelefones = _mapper.Map<List<GetTelefoneDTO>>(listaTelefones);

                return Ok(getListaTelefones);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        public ActionResult <GetTelefoneDTO> GetById(int id)
        {
            try
            {
                var telefoneModel = _fichaCadastroDbContext.Telefones.Where(w => w.Id == id).FirstOrDefault();

                if(telefoneModel == null)
                {
                    return NotFound("Nenhum registro encontrado.");
                }

                var getTelefone = _mapper.Map<GetTelefoneDTO>(telefoneModel);
                
                return Ok(getTelefone);
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}