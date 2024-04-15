namespace Application.Users.Commands.Create
{
    public class CreateResponse
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
