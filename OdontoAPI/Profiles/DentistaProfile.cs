using AutoMapper;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Profiles;

public class DentistaProfile : Profile
{
    public DentistaProfile() 
    {
        CreateMap<CreateDentistaDto, Dentista>();
        CreateMap<UpdateDentistaDto, Dentista>();
        CreateMap<Dentista, UpdateDentistaDto>();
        CreateMap<Dentista, ReadDentistaDto>();
    }
}
