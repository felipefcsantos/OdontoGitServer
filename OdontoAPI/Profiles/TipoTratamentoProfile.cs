using AutoMapper;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Profiles;

public class TipoTratamentoProfile : Profile
{
    public TipoTratamentoProfile() 
    {
        CreateMap<CreateTipoTratamentoDto, TipoTratamento>();
        CreateMap<UpdateTipoTratamentoDto, TipoTratamento>();
        CreateMap<TipoTratamento, UpdateTipoTratamentoDto>();
        CreateMap<TipoTratamento, ReadTipoTratamentoDto>();
    }
}
