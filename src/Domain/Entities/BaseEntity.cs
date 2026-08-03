namespace Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; } = true;
        public Guid CreationUserId { get; set; }
        public DateTime CreationDate { get; set; } 
        public Guid? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? DeactivatedUserId { get; set; }
        public DateTime? DeactivatedDate { get; set; }
    }
}

