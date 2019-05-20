using AutoMapper;
using FinanceApp.Models.Dto;
using FinanceApp.Models.Entities;

namespace FinanceApp.Models.MappingProfiles
{
  public class InputTemplateProfile : Profile
  {
    public InputTemplateProfile()
    {
      CreateMap<InputTemplateEntity, InputTemplateDto>()
        .ForMember(x => x.TypeDescription, opts => opts.MapFrom(x => x.Type.Description));
    }
  }
}