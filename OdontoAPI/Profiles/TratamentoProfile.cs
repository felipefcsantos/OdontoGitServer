using AutoMapper;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Profiles;

public class TratamentoProfile : Profile
{
    public TratamentoProfile() 
    {
        CreateMap<CreateTratamentoDto, Tratamento>();
        CreateMap<UpdateTratamentoDto, Tratamento>();
        CreateMap<Tratamento, UpdateTratamentoDto>();
        CreateMap<Tratamento, ReadTratamentoDto>().ForMember(tratamentoDto => tratamentoDto.TipoTratamento, opt => opt.MapFrom(tratamento => tratamento.TipoTratamento));
    }
}
