using JWTImplementation.DataContext;
using JWTImplementation.Interfaces;
using JWTImplementation.Models;

namespace JWTImplementation.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private JwtContext _jwtContext;
        public EmployeeServices(JwtContext jwtContext)
        {
            _jwtContext = jwtContext;
        }

        public Employee AddEmployee(Employee Employee)
        {
            var emp = _jwtContext.Employees.Add(Employee);

            _jwtContext.SaveChanges();
            return emp.Entity;
        }

        public bool DeleteEmployee(int ID)
        {
            try
            {
                var emp = _jwtContext.Employees.SingleOrDefault(x => x.Id == ID);
                if (emp != null)
                {
                    throw new Exception("User not found");
                }
                else
                {
                    _jwtContext.Employees.Remove(emp);
                    _jwtContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }         
        }

        public List<Employee> GetEmployeeDetails()
        {
            var emp = _jwtContext.Employees.ToList();
            return emp;
        }

        public Employee GetEmployeeDetailsBYID(int ID)
        {
            var emp = _jwtContext.Employees.SingleOrDefault(x => x.Id == ID);
            return emp;
        }

        public Employee UpdateEmployee(Employee Employee)
        {
         var emp= _jwtContext.Employees.Update(Employee);
            _jwtContext.SaveChanges();
            return emp.Entity;
        }
    }
}
