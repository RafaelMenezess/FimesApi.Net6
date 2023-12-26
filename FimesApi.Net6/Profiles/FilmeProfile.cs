using AutoMapper;
using FimesApi.Net6.Data.Dtos;
using FimesApi.Net6.Models;

namespace FimesApi.Net6.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
    }
}
