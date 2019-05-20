using AutoMapper;
using FinanceApp.Models.Dto;
using FinanceApp.Models.Entities;

namespace FinanceApp.Models.MappingProfiles
{
  public class InputProfile : Profile
  {
    public InputProfile()
    {
      CreateMap<InputEntity, InputDto>()
        .ForMember(x => x.InputTemplateLabel, opts => opts.MapFrom(x => x.InputTemplate.Label))
        .ForMember(x => x.InputTemplateAmount, opts => opts.MapFrom(x => x.InputTemplate.Amount))
        .ForMember(x => x.InputTemplateDescription, opts => opts.MapFrom(x => x.InputTemplate.Description))
        .ForMember(x => x.TypeId, opts => opts.MapFrom(x => x.InputTemplate.TypeId))
        .ForMember(x => x.TypeDescription, opts => opts.MapFrom(x => x.InputTemplate.Type.Description));
    }
  }
}