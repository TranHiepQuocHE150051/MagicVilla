using AutoMapper;
using MagicVilla.Models;
using MagicVilla.Models.DTO;

namespace RestfulAPICRUDExample
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, CreateVillaDTO>().ReverseMap();
            CreateMap<Villa, UpdateVillaDTO>().ReverseMap();
        }
    }
}
