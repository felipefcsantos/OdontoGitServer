using AutoMapper;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Profiles;

public class FormaPgtoProfile : Profile
{
    public FormaPgtoProfile() 
    {
        CreateMap<CreateFormaPgtoDto, FormaPgto>();
        CreateMap<UpdateFormaPgtoDto, FormaPgto>();
        CreateMap<FormaPgto, UpdateFormaPgtoDto>();
        CreateMap<FormaPgto, ReadFormaPgtoDto>().ForMember(formaPgtoDto => formaPgtoDto.Pagamentos, opt => opt.MapFrom(formapgto => formapgto.Pagamentos));
    }
}
