using System.Text;
using aula02.Dtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace aula02.Controllers;

[ApiController]
[Route("[controller]")]
public class EnderecoController : ControllerBase
{   // -->> CONSUMO DE API <<--

    // Substituindo o valor 0 do appsetings pelo parâmetro desejado(parte1). Liberando os métodos do IConfiguration para puxar a variável de ambiente.
    private readonly IConfiguration _config;
    public EnderecoController(IConfiguration config)
    {
        _config = config;
    }

    [HttpGet]
    [Route("cep")]
    public async Task<IActionResult> ObterEndereco(int cep)
    {   // Substituindo o valor 0 da url da variável de ambiente pelo parâmetro desejado(parte2)
        var urlCep = _config.GetValue<string>("APIsExternas:CEP");
        StringBuilder sb = new StringBuilder(urlCep);
        sb.Replace("{0}",cep.ToString());
        

        using (var httpClient = new HttpClient())
        {
            using (var response = await httpClient.GetAsync(sb.ToString()))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                // -->> Tratamento da requisição: Filtrando o resultado para apenas os dados desejados (CepDto com apenas os atributos desejados).
                var cepDto = JsonConvert.DeserializeObject<CepDto>(apiResponse);
                // Tratamento dos dados: Transformando o JSON em texto!!
                var frase = $"{cepDto.Logradouro}, bairro {cepDto.Bairro}, cidade {cepDto.Localidade}, UF {cepDto.UF}.";
                return Ok(frase);
            }
        }
    }
}