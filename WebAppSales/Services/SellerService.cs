using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppSales.Data;
using WebAppSales.Models;

namespace WebAppSales.Services
{
    public class SellerService
    {
        private readonly WebAppSalesContext _context;

        public SellerService (WebAppSalesContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
