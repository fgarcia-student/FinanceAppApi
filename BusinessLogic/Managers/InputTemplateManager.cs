using System;
using System.Collections.Generic;
using FinanceApp.DataAccess.Repository;
using FinanceApp.Models.Dto;

namespace FinanceApp.BusinessLogic.Managers
{
  public class InputTemplateManager
  {
    private readonly InputTemplateRepository _inputTemplateRepo;
    public InputTemplateManager(
      InputTemplateRepository inputTemplateRepo
    )
    {
      _inputTemplateRepo = inputTemplateRepo;
    }

    public List<InputTemplateDto> GetAllTemplates()
    {
      try
      {
        return _inputTemplateRepo.GetAllTemplates();
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}