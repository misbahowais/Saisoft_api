using CoreBusiness;
using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Employee
{
    public interface IEmployeeService
    {
        Response Create(EmployeeModel model);
        Response Update(EmployeeModel model);
        Response Delete(int Id);

        IEnumerable<EmployeeModel> GetAll();
        EmployeeModel GetById(int ind);
    }
}
