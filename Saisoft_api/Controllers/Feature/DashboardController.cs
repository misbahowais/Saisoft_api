using CoreBusiness.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Dashboard;
using Services.Employee;

namespace Saisoft_api.Controllers.Feature
{
    public class DashboardController : BaseController
    {
        private readonly IDashboardService service;

        public DashboardController(IDashboardService _service)
        {
            service = _service;
        }

        [HttpGet]
        [Route("TotalEmp")]
        public int TotalEmp()
        {
            return service.TotalEmp();
        }

        [HttpGet]
        [Route("ActiveTotalEmp")]
        public int ActiveTotalEmp()
        {
            return service.ActiveTotalEmp();
        }
    }
}
