using AutoMapper;
using FinanceApp.Models.Dto;
using FinanceApp.Models.Entities;

namespace FinanceApp.Models.MappingProfiles
{
  public class TypeProfile : Profile
  {
    public TypeProfile()
    {
      CreateMap<TypeEntity, TypeDto>();
    }
  }
}