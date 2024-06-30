using CoreBusiness;
using CoreBusiness.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Employee;

namespace Saisoft_api.Controllers.Feature
{
    public class EmployeeController : BaseController
    {
        private readonly IEmployeeService service;

        public EmployeeController (IEmployeeService _service)
        {
            service = _service;
        }

        [HttpPost]
        [Route("Create")]
        public Response Create(EmployeeModel model)
        {
            return service.Create(model);
        }

        [HttpPut]
        [Route("Update")]
        public Response Update(EmployeeModel model)
        {
            return service.Update(model);
        }

        [HttpDelete]
        [Route("Delete")]
        public Response Delete(int id)
        {
            return service.Delete(id);
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<EmployeeModel> GetAll()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("GetById")]
        public EmployeeModel GetById(int id)
        {
            return service.GetById(id);
        }
    }
}
