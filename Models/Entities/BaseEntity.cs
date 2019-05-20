using System;

namespace FinanceApp.Models.Entities
{
  public class BaseEntity
  {
    public int Id { get; set; }
    public int CreatorId { get; set; }
    public DateTime DateCreated { get; set; }
    public int? ModifierId { get; set; }
    public DateTime? DateModified { get; set; }
    public bool IsDeleted { get; set; }
  }
}