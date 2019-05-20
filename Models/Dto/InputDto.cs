using System;

namespace FinanceApp.Models.Dto
{
  public class InputDto
  {
    public int Id { get; set; }
    public int InputTemplateId { get; set; }
    public string InputTemplateLabel { get; set; }
    public double InputTemplateAmount { get; set; }
    public string InputTemplateDescription { get; set; }
    public int TypeId { get; set; }
    public string TypeDescription { get; set; }
    public bool IsComplete { get; set; }
    public DateTime? CompleteDate { get; set; }
    public string Notes { get; set; }
  }
}