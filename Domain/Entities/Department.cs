﻿namespace Domain.Entities
{
    public class Department
    {
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }

        public List<User> Users { get; set; }
    }
}
