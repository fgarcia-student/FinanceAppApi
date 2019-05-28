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
  public class TypesController : ControllerBase
  {
    private readonly TypeManager _typeManager;

    public TypesController(
      TypeManager typeManager
    )
    {
      _typeManager = typeManager;
    }

    [HttpGet]
    public ActionResult GetAllTypes()
    {
      return Ok(_typeManager.GetAllTypes());
    }
  }
}
