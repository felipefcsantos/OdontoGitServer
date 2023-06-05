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
    }
}
