using AutoMapper;
using FichaCadastroAPI.DTOs;
using FichaCadastroAPI.Model;

namespace FichaCadastroAPI.AutoMapper
{
    public class ConfigurationMapper : Profile
    {
        public ConfigurationMapper()
        {
            CreateMap<FichaModel, GetFichaDTO>();

            CreateMap<PostFichaDTO, FichaModel>();

            CreateMap<PutFichaDTO, FichaModel>();

            CreateMap<TelefoneModel, GetTelefoneDTO>()
                    .ForMember(destino => destino.Contato, origem => origem.MapFrom(origem => origem.DDD + origem.Numero));
        }
    }
}