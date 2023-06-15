using AutoMapper;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Profiles;

public class TipoSalaProfile : Profile
{
    public TipoSalaProfile() 
    {
        CreateMap<CreateTipoSalaDto, TipoSala>();
        CreateMap<UpdateTipoSalaDto, TipoSala>();
        CreateMap<TipoSala, UpdateTipoSalaDto>();
        CreateMap<TipoSala, ReadTipoSalaDto>().ForMember(tipoSalaDto => tipoSalaDto.Salas, opt => opt.MapFrom(tipoSala => tipoSala.Salas));
    }
}
