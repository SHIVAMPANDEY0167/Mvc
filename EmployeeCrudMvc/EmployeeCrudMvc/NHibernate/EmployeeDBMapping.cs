using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeCrudMvc.Models;
using FluentNHibernate.Mapping;

namespace EmployeeCrudMvc.NHibernate
{
    public class EmployeeDBMapping : ClassMap<EmployeeViewModel>
    {
        public EmployeeDBMapping()
        {
            Id(x => x.EmployeeId);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Age);
            Map(x => x.Gender);
            Map(x => x.MeritalStatus);
            Map(x => x.Department);
            Table("EmployeeDetails");
        }
    }
}
