namespace Taskio.Domain.Entities
{
    public class AuditableEntity
    {
        public DateTime CreatedDate { get; private set; }
        public DateTime UpdatedDate { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime DeletedDate { get; private set; }

        public void Create()
        {
            CreatedDate = DateTime.UtcNow;
        }

        public void Update()
        {
            UpdatedDate = DateTime.UtcNow;
        }

        public void Delete()
        {
            DeletedDate = DateTime.UtcNow;
            IsDeleted = true;
        }
    }
}
