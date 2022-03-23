using EmployeeCrudMvc.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCrudMvc.Service
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeViewModel AddEmployee(EmployeeViewModel employeeViewModel)
        {
            ISession session = OpenNHibertnateSession.OpenSession();
            ITransaction transaction = session.BeginTransaction();
                session.Save(employeeViewModel);
                transaction.Commit();
            return employeeViewModel;
                
            
        }

        public void Delete(int Id, EmployeeViewModel employeeViewModel)
        {
            using (ISession session = OpenNHibertnateSession.OpenSession())
            {
                var employee = session.Get<EmployeeViewModel>(Id);
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(employee);
                    transaction.Commit();
                }
            }
        }

        public EmployeeViewModel Edit(int Id, EmployeeViewModel employeeViewModel)
        {
            using (ISession session = OpenNHibertnateSession.OpenSession())
            {
                var employee = session.Get<EmployeeViewModel>(Id);
                employee.FirstName = employeeViewModel.FirstName;
                employee.LastName = employeeViewModel.LastName;
                employee.Gender = employeeViewModel.Gender;
                employee.Age = employeeViewModel.Age;
                employee.MeritalStatus = employeeViewModel.MeritalStatus;
                employee.Department = employeeViewModel.Department;



                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(employee);
                    transaction.Commit();
                }
                return employee;
            }
        }

        public List<EmployeeViewModel> GetEmployeeViewModels()
        {
            using (ISession session = OpenNHibertnateSession.OpenSession())
            {
                var employees = session.Query<EmployeeViewModel>().OrderByDescending(x => x.EmployeeId).ToList();
                return employees;
            }
        }

        public EmployeeViewModel GetEmployeeViewModels(int Id)
        {
            using (ISession session = OpenNHibertnateSession.OpenSession())
            {
                var employee = session.Get<EmployeeViewModel>(Id);
                return employee;
            }
        }
    }
}
