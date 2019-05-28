using System;
using System.Collections.Generic;
using FinanceApp.DataAccess.Repository;
using FinanceApp.Models.Dto;

namespace FinanceApp.BusinessLogic.Managers
{
  public class TypeManager
  {
    private readonly TypeRepository _typeRepo;
    public TypeManager(
      TypeRepository typeRepo
    )
    {
      _typeRepo = typeRepo;
    }

    public List<TypeDto> GetAllTypes()
    {
      try
      {
        return _typeRepo.GetAllTypes();
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}