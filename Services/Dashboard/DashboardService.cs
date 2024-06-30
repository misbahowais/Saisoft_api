using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dashboard
{
    public class DashboardService: IDashboardService
    {
        private readonly EmployeeDbContext db;
        public DashboardService(EmployeeDbContext _db)
        {
            db = _db;
        }

        public int TotalEmp()
        {
            return db.EmployeeModels.Count();


        }
        public int ActiveTotalEmp()

        {
            return db.EmployeeModels.Where(m => m.Status == true).Count();
        }
    }
}
