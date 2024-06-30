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
            return 0;

        }
        public int ActiveTotalEmp()
        {
            return 0;
        }
    }
}
