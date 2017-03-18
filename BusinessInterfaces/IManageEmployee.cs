using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace BusinessInterfaces
{
    public interface IManageEmployee
    {
        void Create(Employee employee);
        List<Employee> Read(int id);
        void Update(Employee employee);
        void Delete(int id);
        List<Employee> ReadById(int id);
    }
}
