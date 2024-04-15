namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }

        public Department Department { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
