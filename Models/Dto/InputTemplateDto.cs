namespace FinanceApp.Models.Dto
{
  public class InputTemplateDto
  {
    public int Id { get; set; }
    public string Label { get; set; }
    public double Amount { get; set; }
    public string Description { get; set; }
    public int TypeId { get; set; }
    public string TypeDescription { get; set; }
  }
}