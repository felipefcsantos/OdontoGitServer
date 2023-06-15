using AutoMapper;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Profiles;

public class SalaProfile : Profile
{
    public SalaProfile() 
    {
        CreateMap<CreateSalaDto, Sala>();
        CreateMap<UpdateSalaDto, Sala>();
        CreateMap<Sala, UpdateSalaDto>();
        CreateMap<Sala, ReadSalaDto>().ForMember(salaDto => salaDto.TipoSala, opt => opt.MapFrom(sala => sala.TipoSala));
    }
}
