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
  public class InputsController : ControllerBase
  {
    private readonly InputManager _inputManager;

    public InputsController(
      InputManager inputManager
    )
    {
      _inputManager = inputManager;
    }

    [HttpGet]
    public ActionResult GetAllInputs()
    {
      return Ok(_inputManager.GetAllInputs());
    }
  }
}
