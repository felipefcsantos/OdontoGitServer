using AutoMapper;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Profiles;

public class PagamentoProfile : Profile
{
    public PagamentoProfile() 
    {
        CreateMap<CreatePagamentoDto, Pagamento>();
        CreateMap<UpdatePagamentoDto, Pagamento>();
        CreateMap<Pagamento, UpdatePagamentoDto>();
        CreateMap<Pagamento, ReadPagamentoDto>();
    }
}
