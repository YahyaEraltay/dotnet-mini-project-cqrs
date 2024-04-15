namespace Application.Users.Commands.Update
{
    public class UpdateResponse
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string DepartmentName { get; set; }
    }
}
