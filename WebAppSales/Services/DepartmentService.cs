using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
