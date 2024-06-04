using Api.Autor.Estrategy.Modelo;
using AutoMapper;

namespace Api.Autor.Estrategy.Aplicacion
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AutorLibro, AutorDto>();
        }
    }
}
