using CoreBusiness;
using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Employee
{
    public class EmployeeService: IEmployeeService
    {
        private readonly EmployeeDbContext db;
        public EmployeeService(EmployeeDbContext _db)
        {
            db = _db;
        }
        public Response Create(EmployeeModel model)
        {
            var resp = new Response();
            try
            {
                model.Status = true;
                db.Add(model);
                db.SaveChanges();
                resp.IsSuccess = true;
                resp.StatusCode = 200;
            }catch(Exception ex)
            {
                resp.Message = ex.Message;
                resp.StatusCode = 500;
            }
            return resp;
        }
        public Response Update(EmployeeModel model)
        {
            var resp = new Response();
            var data = db.EmployeeModels.Where(m => m.Id == model.Id).FirstOrDefault();
            if (data != null)
            {
                try
                {
                    data.Name = model.Name;
                    data.Email = model.Email;
                    data.Salary = model.Salary;
                    data.Designation = model.Designation;
                    data.Dob = model.Dob;
                    data.Status = model.Status;
                    db.SaveChanges();
                    resp.IsSuccess = true;
                    resp.StatusCode = 200;
                }
                catch (Exception ex)
                {
                    resp.Message = ex.Message;
                    resp.StatusCode = 500;
                }
            }
            return resp;
        }
        public Response Delete(int Id)
        {
            var resp = new Response();
            var data = db.EmployeeModels.Where(m => m.Id == Id).FirstOrDefault();
            if (data != null)
            {
                try
                {
                    db.Remove(data);
                    db.SaveChanges();
                    resp.IsSuccess = true;
                    resp.StatusCode = 200;
                }
                catch (Exception ex)
                {
                    resp.Message = ex.Message;
                    resp.StatusCode = 500;
                }
            }
            return resp;
        }

        public IEnumerable<EmployeeModel> GetAll()
        {
            return db.EmployeeModels;
        }
        public EmployeeModel? GetById(int ind)
        {
            var emp = db.EmployeeModels.Where(m => m.Id == ind).FirstOrDefault();
            return emp;
        }
    }
}
