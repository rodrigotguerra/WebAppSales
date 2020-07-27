using System;
using System.Collections.Generic;
using System.Linq;
using WebAppSales.Data;
using WebAppSales.Models;

namespace WebAppSales.Services
{
    public class DepartmentService
    {
        private readonly WebAppSalesContext _context;

        public DepartmentService(WebAppSalesContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
