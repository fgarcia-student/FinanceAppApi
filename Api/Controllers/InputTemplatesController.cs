using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.BusinessLogic.Managers;
using FinanceApp.DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class InputTemplatesController : ControllerBase
  {
    private readonly InputTemplateManager _inputTemplateManager;

    public InputTemplatesController(
      InputTemplateManager inputTemplateManager
    )
    {
      _inputTemplateManager = inputTemplateManager;
    }

    [HttpGet]
    public ActionResult GetAllInputTemplates()
    {
      return Ok(_inputTemplateManager.GetAllTemplates());
    }
  }
}
