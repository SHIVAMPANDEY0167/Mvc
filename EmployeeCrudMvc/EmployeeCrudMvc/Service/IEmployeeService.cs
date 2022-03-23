using EmployeeCrudMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCrudMvc.Service
{
    public interface IEmployeeService
    {
        List<EmployeeViewModel> GetEmployeeViewModels();
        EmployeeViewModel GetEmployeeViewModels(int Id);
        EmployeeViewModel AddEmployee(EmployeeViewModel employeeViewModel);
        EmployeeViewModel Edit(int Id,EmployeeViewModel employeeViewModel);
        void Delete(int Id, EmployeeViewModel employeeViewModel);
    }
}
