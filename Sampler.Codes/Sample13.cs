using System;

// I
namespace Sampler.Codes
{
    public class Employee 
    {
        public int Id { get; set; }

        public string EmployeeName { get; set; }

        public int UserCreated { get; set; }

        public DateTime? DateCreated { get; set; }

        public int UserModified { get; set; }

        public DateTime? DateModified { get; set; }

        public bool IsActive { get; set; }
    }

    public class Client
    {
        public int Id { get; set; }

        public string ClientName { get; set; }

        public int UserCreated { get; set; }

        public DateTime? DateCreated { get; set; }

        public int UserModified { get; set; }

        public DateTime? DateModified { get; set; }

        public bool IsActive { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }

        public string DepartmentName { get; set; }

        public int UserCreated { get; set; }

        public DateTime? DateCreated { get; set; }

        public int UserModified { get; set; }

        public DateTime? DateModified { get; set; }
    }


    public class Sample13
    {

        public void ActivateClient(Client client)
        {
            client.IsActive = true;
        }

        public void ActivateEmployee(Employee employee)
        {
            employee.IsActive = true;
        }

        public void Audit(Client client, int userId)
        {
            if (client.Id == 0)
            {
                client.UserCreated = userId;
                client.DateCreated = DateTime.UtcNow;
            } 
            else
            {
                client.UserModified = userId;
                client.DateModified = DateTime.UtcNow;
            }
           
        }

        public void Audit(Employee employee, int userId)
        {
            if (employee.Id == 0)
            {
                employee.UserCreated = userId;
                employee.DateCreated = DateTime.UtcNow;
            }
            else
            {
                employee.UserModified = userId;
                employee.DateModified = DateTime.UtcNow;
            }
        }

        public void Audit(Department department, int userId)
        {
            if (department.Id == 0)
            {
                department.UserCreated = userId;
                department.DateCreated = DateTime.UtcNow;
            }
            else
            {
                department.UserModified = userId;
                department.DateModified = DateTime.UtcNow;
            }
        }

        public void Activate(Employee employee)
        {
            employee.IsActive = true;
        }

        public void Activate(Client client)
        {
            client.IsActive = true;
        }
    }
}
