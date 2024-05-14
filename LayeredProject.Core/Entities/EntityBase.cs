namespace LayeredProject.Core.Entities;

public abstract class EntityBase
{
    public Guid Id { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? ModifiedBy { get; set; }
}