using System;
using SalesWebMvc0.Data;
using SalesWebMvc0.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc0.Services
{
    public class SellerService
    {

        private readonly SalesWebMvc0Context _context;

        public SellerService(SalesWebMvc0Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
