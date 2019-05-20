using System;

namespace FinanceApp.Models.Entities
{
  public class InputEntity : BaseEntity
  {
    public int InputTemplateId { get; set; }
    public InputTemplateEntity InputTemplate { get; set; }
    public bool IsComplete { get; set; }
    public DateTime? CompleteDate { get; set; }
    public string Notes { get; set; }
  }
}