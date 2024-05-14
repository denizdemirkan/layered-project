namespace LayeredProject.Core.Entities;

public abstract class SoftDeleteEntityBase : EntityBase
{
    public bool IsDeleted { get; set; }
    public Guid? DeletedBy { get; set; }
    public Guid? UnDeletedBy { get; set; }
    public DateTime? DeletedDate { get; set; }
    public DateTime? UnDeletedDate { get; set; }
}