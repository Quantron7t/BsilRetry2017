using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessInterfaces;
using BusinessObjects;

namespace AdoRepo
{
    public class AdoDataOperations:IManageEmployee
    {
        List<Employee> listEmployee = new List<Employee>();

        void IManageEmployee.Create(Employee employee)
        {

        }

        List<Employee> IManageEmployee.Read(int id)
        {
            listEmployee.Add(new Employee { Id=2,Name="Martin",Location="New York",Salary=50000,Grade='A'});
            return listEmployee;
        }

        void IManageEmployee.Update(Employee employee)
        {

        }

        void IManageEmployee.Delete(int id) { }

        List<Employee> IManageEmployee.ReadById(int id) { return listEmployee; }
    }
}
