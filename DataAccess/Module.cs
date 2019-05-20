using Autofac;
using FinanceApp.DataAccess.Repository;

namespace FinanceApp.DataAccess
{
  public class DataAccessModule : Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<TypeRepository>();
      builder.RegisterType<InputTemplateRepository>();
    }
  }
}