using System.Net;
using AutoMapper;
using FichaCadastroAPI.Context;
using FichaCadastroAPI.DTOs;
using FichaCadastroAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace FichaCadastroAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FichaController : ControllerBase
    {
        private readonly ILogger<FichaController> _logger;
        private readonly FichaCadastroDbContext _fichaCadastroDbContext;
        private readonly IMapper _mapper;

        public FichaController(ILogger<FichaController> logger, FichaCadastroDbContext fichaCadastroDbContext, IMapper mapper)
        {
            _logger = logger;
            _fichaCadastroDbContext = fichaCadastroDbContext;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GetFichaDTO> Post([FromBody] PostFichaDTO postFichaDTO)
        {   
            try
            {
                var fichaModel = _mapper.Map<FichaModel>(postFichaDTO);

                if (_fichaCadastroDbContext.Fichas.ToList().Exists(e => e.Email == postFichaDTO.Email))
                {
                    return Conflict(new { erro = "E-mail já cadastrado." });
                }

                 var getFichaDTO = _mapper.Map<GetFichaDTO>(fichaModel);

                _fichaCadastroDbContext.Fichas.Add(fichaModel);
                _fichaCadastroDbContext.SaveChanges();

                return StatusCode(HttpStatusCode.Created.GetHashCode(), getFichaDTO);

            }
            catch (Exception ex)
            {
                return StatusCode(HttpStatusCode.InternalServerError.GetHashCode(), ex);
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GetFichaDTO> Put(int id, [FromBody] PutFichaDTO putFichaDTO)
        {
            try 
            {
                var fichaModel = _fichaCadastroDbContext.Fichas.Where(w => w.Id == id).FirstOrDefault();

                if (fichaModel == null)
                {
                    return NotFound(new { erro = "Registro não encontrado."});
                }

                fichaModel = _mapper.Map(putFichaDTO, fichaModel);

                _fichaCadastroDbContext.Fichas.Update(fichaModel);
                _fichaCadastroDbContext.SaveChanges();

                var getFichaDTO = _mapper.Map<GetFichaDTO>(fichaModel);

                return Ok(getFichaDTO);
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
                var fichaModel = _fichaCadastroDbContext.Fichas.Where(w => w.Id == id).FirstOrDefault();

                if (fichaModel == null)
                {
                    return NotFound(new { erro = "Registro não encontrado."});
                }

                if (fichaModel.Detalhes != null && fichaModel.Detalhes!.Count > 0)
                {
                    return NotFound(new { erro = "Existem detalhes relacionados com a ficha."});
                }

                _fichaCadastroDbContext.Fichas.Remove(fichaModel);
                _fichaCadastroDbContext.SaveChanges();

                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        // Read com filtro (query string) e sem filtro
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<GetFichaDTO>> Get([FromQuery] string? email)
        {
            try
            {
                List<FichaModel> fichaModels;

                if (email.IsNullOrEmpty())
                {
                    fichaModels = _fichaCadastroDbContext.Fichas.ToList();
                }
                else
                {
                    fichaModels = _fichaCadastroDbContext.Fichas.Where(w => w.Email.Equals(email!)).ToList();
                }

                var getFichaDTO = _mapper.Map<List<GetFichaDTO>>(fichaModels);

                return Ok(getFichaDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GetFichaDTO> Get(int id)
        {
            try
            {
                var fichaModel = _fichaCadastroDbContext.Fichas.Find(id);

                if (fichaModel == null)
                {
                    return NotFound(new { erro = "Ficha não encontrada." });
                }

                var getFichaDTO = _mapper.Map<GetFichaDTO>(fichaModel);

                return Ok(getFichaDTO);
            }
            catch (Exception ex) 
            {
                return StatusCode(HttpStatusCode.InternalServerError.GetHashCode(), ex);
            }
        }

    }
}