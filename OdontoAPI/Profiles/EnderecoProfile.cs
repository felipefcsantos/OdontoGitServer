using AutoMapper;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Profiles;

public class EnderecoProfile : Profile
{
    public EnderecoProfile() 
    {
        CreateMap<CreateEnderecoDto, Endereco>();
        CreateMap<UpdateEnderecoDto, Endereco>();
        CreateMap<Endereco, UpdateEnderecoDto>();
        CreateMap<Endereco, ReadEnderecoDto>();
    }
}
