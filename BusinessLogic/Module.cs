using Autofac;
using FinanceApp.BusinessLogic.Managers;

namespace FinanceApp.BusinessLogic
{
  public class BusinessLogicModule : Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<TypeManager>();
      builder.RegisterType<InputTemplateManager>();
      builder.RegisterType<InputManager>();
    }
  }
}