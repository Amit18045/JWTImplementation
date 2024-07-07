using JWTImplementation.Models;

namespace JWTImplementation.Interfaces
{
    public interface IEmployeeServices
    {
        List<Employee> GetEmployeeDetails();
        Employee GetEmployeeDetailsBYID(int ID);
        Employee AddEmployee(Employee Employee);
        Employee UpdateEmployee(Employee Employee);
        bool DeleteEmployee(int ID);
    }
}
