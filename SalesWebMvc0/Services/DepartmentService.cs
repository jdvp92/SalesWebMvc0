using SalesWebMvc0.Data;
using SalesWebMvc0.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc0.Services
{
    public class DepartmentService
    {

        private readonly SalesWebMvc0Context _context;

        public DepartmentService(SalesWebMvc0Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
