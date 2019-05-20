using System.ComponentModel;

namespace FinanceApp.Models.Enums
{
  public enum TypeEnum
  {
    [Description("Income")]
    Income = 1,
    [Description("Expense")]
    Expense = 2,
    [Description("Saving")]
    Saving = 3
  }
}