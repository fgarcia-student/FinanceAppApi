namespace FinanceApp.Models.Entities
{
  public class InputTemplateEntity : BaseEntity
  {
    public string Label { get; set; }
    public double Amount { get; set; }
    public string Description { get; set; }
    public int TypeId { get; set; }
    public TypeEntity Type { get; set; }
  }
}