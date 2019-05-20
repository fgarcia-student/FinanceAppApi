using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FinanceApp.DataAccess.Utility;
using FinanceApp.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.DataAccess.Repository
{
  public class InputRepository
  {
    private readonly FinanceAppContext _dbContext;
    private readonly IMapper _mapper;
    public InputRepository(
      FinanceAppContext dbContext,
      IMapper mapper
    )
    {
      _dbContext = dbContext;
      _mapper = mapper;
    }

    public List<InputDto> GetAllInputs()
    {
      try
      {
        var entities = _dbContext.Inputs
          .Include(x => x.InputTemplate)
          .ThenInclude(x => x.Type)
          .ToList();

        return _mapper.Map<List<InputDto>>(entities);
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}