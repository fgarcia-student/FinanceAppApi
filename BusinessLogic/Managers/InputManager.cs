using System;
using System.Collections.Generic;
using FinanceApp.DataAccess.Repository;
using FinanceApp.Models.Dto;

namespace FinanceApp.BusinessLogic.Managers
{
  public class InputManager
  {
    private readonly InputRepository _inputRepo;
    public InputManager(
      InputRepository inputRepo
    )
    {
      _inputRepo = inputRepo;
    }

    public List<InputDto> GetAllInputs()
    {
      try
      {
        return _inputRepo.GetAllInputs();
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}