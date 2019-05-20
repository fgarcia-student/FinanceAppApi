using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FinanceApp.DataAccess.Utility;
using FinanceApp.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.DataAccess.Repository
{
  public class InputTemplateRepository
  {
    private readonly FinanceAppContext _dbContext;
    private readonly IMapper _mapper;

    public InputTemplateRepository(
      FinanceAppContext dbContext,
      IMapper mapper
    )
    {
      _dbContext = dbContext;
      _mapper = mapper;
    }

    public List<InputTemplateDto> GetAllTemplates()
    {
      try
      {
        var entities = _dbContext.InputTemplates
          .Include(x => x.Type)
          .ToList();

        return _mapper.Map<List<InputTemplateDto>>(entities);
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}