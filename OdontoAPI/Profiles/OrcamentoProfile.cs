using AutoMapper;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Profiles;

public class OrcamentoProfile : Profile
{
    public OrcamentoProfile() 
    {
        CreateMap<CreateOrcamentoDto, Orcamento>();
        CreateMap<UpdateOrcamentoDto, Orcamento>();
        CreateMap<Orcamento, UpdateOrcamentoDto>();
        CreateMap<Orcamento, ReadOrcamentoDto>();
    }
}
