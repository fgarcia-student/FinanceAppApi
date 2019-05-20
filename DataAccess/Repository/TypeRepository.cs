using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FinanceApp.DataAccess.Utility;
using FinanceApp.Models.Dto;

namespace FinanceApp.DataAccess.Repository
{
  public class TypeRepository
  {
    private readonly FinanceAppContext _dbContext;
    private readonly IMapper _mapper;

    public TypeRepository(
      FinanceAppContext dbContext,
      IMapper mapper
    )
    {
      _dbContext = dbContext;
      _mapper = mapper;
    }

    public List<TypeDto> GetAllTypes()
    {
      try
      {
        var entities = _dbContext.Types.ToList();

        return _mapper.Map<List<TypeDto>>(entities);
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}