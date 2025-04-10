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
            CreatedDate = DateTime.Now;
        }

        public void Update()
        {
            UpdatedDate = DateTime.Now;
        }

        public void Delete()
        {
            DeletedDate = DateTime.Now;
            IsDeleted = true;
        }
    }
}
